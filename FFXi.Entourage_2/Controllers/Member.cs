using EliteMMO.API;
using FFXi.Entourage_2.Entities;
using FFXi.Entourage_2.Enums;
using FFXi.Entourage_2.MapAI;
using FFXI.Entourage_2.Entities;
using FFXI.Entourage_2.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;
using @threading = System.Threading;
using @worker = System.ComponentModel;

namespace FFXI.Entourage_2.Controllers
{
    public class Member
    {

        private worker.BackgroundWorker _SpellCastProtection;
        #region public worker.BackgroundWorker SpellCastProtection
        public worker.BackgroundWorker SpellCastProtection
        {
            get
            {
                if (_SpellCastProtection == null)
                {
                    _SpellCastProtection = new worker.BackgroundWorker();
                    _SpellCastProtection.DoWork += CastSpellProtectionWorker;
                }

                return _SpellCastProtection;
            }
        }
        #endregion

        // Records the current status of the Player
        private int _currentPlayerStatus = -1;

        // Event Handler for updating UI components each timer the players status changes
        public event EventHandler PlayerStatusChangedHandler;
        public event EventHandler PluginTimerEventHandler;
        public Timer _Timer;
        public bool IsCasting = false;
        private int ProcessId;
        private EliteAPI _Api;
        #region public EliteAPI Api
        public EliteAPI Api
        {
            private get
            {
                return _Api;
            }
            set
            {
                _Api = value;
                if (_Api != null)
                {
                    _Timer = new Timer();
                    _Timer.Interval = (1 * 500);
                    _Timer.Tick += new EventHandler(CheckPlayerSate);
                    _Timer.Tick += new EventHandler(InvokePluginTimerEventHandler);
                    _Timer.Start();
                }
            }
        }
        #endregion
        
        public short[] PlayerStatusEffects
        {
            get
            {
                return Api.Player.Buffs;
            }
        }

        // Basic Player Details
        #region public string Name
        public string Name
        {
            get { return _Api.Player.Name; }
        }
        #endregion        
        public int PlayerHP
        {
            get { return (int) Api.Player.HP; }
        }

        public int PlayerHPP
        {
            get { return (int)Api.Player.HPP; }
        }

        public int PlayerMP
        {
            get { return (int)Api.Player.MP; }
        }

        public int PlayerMPP
        {
            get { return (int)Api.Player.MPP; }
        }

        #region public string Nation
        public string Nation
        {
            get { return ((Nations)_Api.Player.Nation).ToString(); }
        }
        #endregion
        #region public string GoldAmount 
        public string PlayerGold
        {
            get { return Api.Inventory.GetContainerItem(0, 0).Count.ToString("C"); }
        }
        #endregion
        
        public string PlayerZoneName
        {
            get
            {
                var zone = (ZoneNames)Api.Player.ZoneId;
                return zone.ToString().Replace('_', ' ');
            }
        }

        public string PlayerState
        {
            get
            {
                return ((PlayerState)Api.Player.Status).ToString();
            }
        }

        public Coordinate PlayerCoordinates
        {
            get
            {
                return new Coordinate()
                {
                    X = Api.Player.X,
                    Y = Api.Player.Y,
                    Z = Api.Player.Z
                };
            }
        }

        public void setzone() { }

        // Basic Combat Details
        #region public  int PlayerTP
        public  int PlayerTP
        {
            get { return (int)_Api.Player.TP; }
        }
        #endregion
        #region public  string PlayerMaxHP 
        public  string PlayerMaxHP
        {
            get { return _Api.Player.HPMax.ToString(); }
        }
        #endregion
        #region public  string PlayerMaxMP 
        public  string PlayerMaxMP
        {
            get { return _Api.Player.MPMax.ToString(); }
        }
        #endregion        
        #region public  int PlayerAttack 
        public  int PlayerAttack
        {
            get { return _Api.Player.Attack; }
        }
        #endregion
        #region public  int PlayerDeffense
        public  int PlayerDefense
        {
            get { return _Api.Player.Defense; }
        }
        #endregion
        // Basic Job details
        #region public  byte PlayerMainJob
        public  byte PlayerMainJob
        {
            get { return _Api.Player.MainJob; }
        }
        #endregion
        #region public  byte PlayerSubJob
        public  byte PlayerSubJob
        {
            get { return _Api.Player.SubJob; }
        }
        #endregion
        #region public  int PlayerMainJobLevel
        public  int PlayerMainJobLevel
        {
            get { return _Api.Player.MainJobLevel; }
        }
        #endregion
        #region public  int PlayerSubJobLevel
        public  int PlayerSubJobLevel
        {
            get { return _Api.Player.SubJobLevel; }
        }
        #endregion
        #region public  string PlayerMainJobLevelStr
        public  string PlayerMainJobLevelStr
        {
            get
            {
                string jobName = ((JobType)_Api.Player.MainJob).ToString();
                return $"{jobName} ({_Api.Player.MainJobLevel})";
            }
        }
        #endregion
        #region public  string PlayerSubJobLevelStr
        public  string PlayerSubJobLevelStr
        {
            get
            {
                string jobName = ((JobType)_Api.Player.SubJob).ToString();
                return $"{jobName} ({_Api.Player.SubJobLevel})";
            }
        }
        #endregion
        // Player BASE stats
        #region public int PlayerAgility
        public int PlayerAgility
        {
            get { return Api.Player.Stats.Agility; }
        }
        #endregion
        #region public int PlayerCharisma
        public int PlayerCharisma
        {
            get { return Api.Player.Stats.Charisma; }
        }
        #endregion
        #region public int PlayerDexterity
        public  int PlayerDexterity
        {
            get { return Api.Player.Stats.Dexterity; }
        }
        #endregion
        #region public int PlayerIntelligence
        public int PlayerIntelligence
        {
            get { return Api.Player.Stats.Intelligence; }
        }
        #endregion
        #region public int PlayerMind
        public int PlayerMind
        {
            get { return Api.Player.Stats.Mind; }
        }
        #endregion
        #region public int PlayerStrength
        public int PlayerStrength
        {
            get { return Api.Player.Stats.Strength; }
        }
        #endregion
        #region public int PlayerVitality
        public int PlayerVitality
        {
            get { return Api.Player.Stats.Vitality; }
        }
        #endregion
        // Player Base Magic Skills
        #region public PlayerCombatSkill PlayerBlueMagicSkill
        public PlayerCombatSkill PlayerBlueMagicSkill
        {
            get { return Api.Player.CombatSkills.BlueMagic; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerDarkMagicSkill
        public PlayerCombatSkill PlayerDarkMagicSkill
        {
            get { return Api.Player.CombatSkills.Dark; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerDivineMagicSkill
        public PlayerCombatSkill PlayerDivineMagicSkill
        {
            get { return Api.Player.CombatSkills.Divine; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerElementalMagicSkill
        public PlayerCombatSkill PlayerElementalMagicSkill
        {
            get { return Api.Player.CombatSkills.Elemental; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerEnhancingMagicSkill
        public PlayerCombatSkill PlayerEnhancingMagicSkill
        {
            get { return Api.Player.CombatSkills.Enhancing; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerHealingSkill
        public PlayerCombatSkill PlayerHealingSkill
        {
            get { return Api.Player.CombatSkills.Healing; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerNinjitsuSkill
        public PlayerCombatSkill PlayerNinjitsuSkill
        {
            get { return Api.Player.CombatSkills.Ninjitsu; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerSingingSkill
        public PlayerCombatSkill PlayerSingingSkill
        {
            get { return Api.Player.CombatSkills.Singing; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerStringSkill
        public PlayerCombatSkill PlayerStringSkill
        {
            get { return Api.Player.CombatSkills.String; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerWindSkill
        public PlayerCombatSkill PlayerWindSkill
        {
            get { return Api.Player.CombatSkills.Wind; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerSummoningSkill
        public PlayerCombatSkill PlayerSummoningSkill
        {
            get { return Api.Player.CombatSkills.Summon; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerEnfeeblingSkill
        public PlayerCombatSkill PlayerEnfeeblingSkill
        {
            get { return Api.Player.CombatSkills.Enfeebling; }
        }
        #endregion
        // Player Base Combat Skills
        #region public PlayerCombatSkill PlayerHandToHandSkill        
        public PlayerCombatSkill PlayerHandToHandSkill
        {
            get { return Api.Player.CombatSkills.HandToHand; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerDaggerSkill
        public PlayerCombatSkill PlayerDaggerSkill
        {
            get { return Api.Player.CombatSkills.Dagger; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerSwordSkill
        public PlayerCombatSkill PlayerSwordSkill
        {
            get { return Api.Player.CombatSkills.Sword; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerGreatSwordSkill
        public  PlayerCombatSkill PlayerGreatSwordSkill
        {
            get { return _Api.Player.CombatSkills.GreatSword; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerAxeSkill
        public PlayerCombatSkill PlayerAxeSkill
        {
            get { return Api.Player.CombatSkills.Axe; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerGreatAxeSkill
        public PlayerCombatSkill PlayerGreatAxeSkill
        {
            get { return Api.Player.CombatSkills.GreatAxe; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerScytheSkill
        public PlayerCombatSkill PlayerScytheSkill
        {
            get { return Api.Player.CombatSkills.Scythe; }
        }
        #endregion
        #region public PlayerCombatSkill PlayerPolearmSkill
        public PlayerCombatSkill PlayerPolearmSkill
        {
            get { return _Api.Player.CombatSkills.Polearm; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerKatanaSkill
        public  PlayerCombatSkill PlayerKatanaSkill
        {
            get { return _Api.Player.CombatSkills.Katana; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerGreatKatanaSkill
        public  PlayerCombatSkill PlayerGreatKatanaSkill
        {
            get { return _Api.Player.CombatSkills.GreatKatana; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerClubSkill
        public  PlayerCombatSkill PlayerClubSkill
        {
            get { return _Api.Player.CombatSkills.Club; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerStaffSkill
        public  PlayerCombatSkill PlayerStaffSkill
        {
            get { return _Api.Player.CombatSkills.Staff; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerArcherySkill
        public  PlayerCombatSkill PlayerArcherySkill
        {
            get { return _Api.Player.CombatSkills.Archery; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerMarksmanshipSkill
        public  PlayerCombatSkill PlayerMarksmanshipSkill
        {
            get { return _Api.Player.CombatSkills.Marksmanship; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerThrowingSkill
        public  PlayerCombatSkill PlayerThrowingSkill
        {
            get { return _Api.Player.CombatSkills.Throwing; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerGuardingSkill
        public  PlayerCombatSkill PlayerGuardingSkill
        {
            get { return _Api.Player.CombatSkills.Guarding; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerEvasionSkill
        public  PlayerCombatSkill PlayerEvasionSkill
        {
            get { return _Api.Player.CombatSkills.Evasion; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerShieldSkill
        public  PlayerCombatSkill PlayerShieldSkill
        {
            get { return _Api.Player.CombatSkills.Shield; }
        }
        #endregion
        #region public  PlayerCombatSkill PlayerParryingSkill
        public  PlayerCombatSkill PlayerParryingSkill
        {
            get { return _Api.Player.CombatSkills.Parrying; }
        }
        #endregion

        public double GetTargetAngle(Point p2)
        {
            float xDiff = p2.X - Api.Player.X;
            float yDiff = p2.X - Api.Player.Y;
            return Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        }
        public uint GetPlayerOwnTargetIndex()
        {
            return Api.Party.GetPartyMember(0).TargetIndex;
        }

        public string GetTargetName()
        {
            var targetInfo = Api.Target.GetTargetInfo();
            return targetInfo.TargetName;
        }

        public string GetTargetDostance()
        {
            var targetInfo = Api.Target.GetTargetInfo();
            var entity = Api.Entity.GetEntity((int)targetInfo.TargetIndex);
            
            return Math.Sqrt(
            Math.Pow(entity.X - Api.Player.X, 2) +
            Math.Pow(entity.Y - Api.Player.Y, 2) +
            Math.Pow(entity.Z - Api.Player.Z, 2)
            ).ToString();
            
        }

        public string GetTargetRace()
        {
            var targetInfo = Api.Target.GetTargetInfo();
            var entity = Api.Entity.GetEntity((int)targetInfo.TargetIndex);
            var race = (EntityRace)entity.Race;
            return race.ToString();
        }

        public string TargetCoords()
        {
            var targetInfo = Api.Target.GetTargetInfo();
            var entity = Api.Entity.GetEntity((int)targetInfo.TargetIndex);
            return $"X: {entity.X.ToString("#.##")}, Y: {entity.Y.ToString("#.##")}, Z: {entity.Z.ToString("#.##")}";
        }

        public Member(int processId)
        {
            ProcessId = processId;
            Api = new EliteAPI(processId);            
        }


        public bool FaceTarget()
        {
            var targetInfo = Api.Target.GetTargetInfo();
            var entity = Api.Entity.GetEntity((int)targetInfo.TargetIndex);

            var angle = (byte)(Math.Atan((entity.Z - Api.Player.Z) / (entity.X - Api.Player.X)) * -(128.0f / Math.PI));
            if (Api.Player.X > entity.X) angle += 128;
            var radian = (((float)angle) / 255) * 2 * Math.PI;
            return Api.Entity.SetEntityHPosition(Api.Entity.LocalPlayerIndex, (float)radian);
        }


        #region public List<PlayerItem> GetContainerItems(int containerId)
        public List<PlayerItem> GetContainerItems(int containerId)
        {
            List<PlayerItem> items = new List<PlayerItem>();
            int containerCount = GetContainerCount(containerId);

            for (int i = 1; i <= containerCount; i++)
            {
                var item = GetContainerItem(containerId, i);

                var iItem = GetItemInfo(item.Id);

                if (iItem != null)
                {

                    var pItem = new PlayerItem()
                    {
                        ItemId = item.Id,
                        Name = iItem.Name[0],
                        ContainerIndex = i,
                        Count = (int)item.Count,
                        Container = (ItemContainerType)containerId
                    };

                    items.Add(pItem);
                }
            }

            return items;
        }
        #endregion

        // Get Item at specified index from the specified container
        #region public  InventoryItem GetContainerItem(int containerId, int index)
        public InventoryItem GetContainerItem(int containerId, int index)
        {
            return Api.Inventory.GetContainerItem(containerId, index);
        }
        #endregion

        // Get Details for a specific Item
        #region public  IItem GetItemInfo(int itemId)
        public IItem GetItemInfo(int itemId)
        {
            return Api.Resources.GetItem((uint)itemId);
        }
        #endregion

        // Count Items in a specific Item container
        #region public int GetContainerCount(int containerId)
        public int GetContainerCount(int containerId)
        {
            return Api.Inventory.GetContainerCount(containerId);
        }
        #endregion


        #region public void CastSpellProtectionWorker(object sender, DoWorkEventArgs args)
        public void CastSpellProtectionWorker(object sender, DoWorkEventArgs args)
        {
            threading.Thread.Sleep(TimeSpan.FromSeconds(1.0));
            int count = 0;
            float lastPercent = 0;
            float castPercent = _Api.CastBar.Percent;

            while (castPercent < 1)
            {
                if (lastPercent != castPercent)
                {
                    count = 0;
                    lastPercent = castPercent;
                }
                else if (count == 10)
                {
                    break;
                }
                else
                {
                    count++;
                    lastPercent = castPercent;
                }
            }

            threading.Thread.Sleep(TimeSpan.FromSeconds(2.0));
        }
        #endregion

        // Checks the players current status for changes
        // if a change is detected, the PlayerStatusChangedHandler is invoked
        #region private void CheckPlyerSate(object sender, EventArgs args)
        private void CheckPlayerSate(object sender, EventArgs args)
        {
            WorldMap.AddPointToMap(PlayerZoneName,
                (int)Api.Player.X, (int)Api.Player.Y, (int)Api.Player.Z);

            if (((int)Api.Player.Status) != _currentPlayerStatus)
            {
                _currentPlayerStatus = (int)Api.Player.Status;
                if (PlayerStatusChangedHandler != null)
                {
                    PlayerStatusChangedHandler.Invoke(sender, args);
                }
            }
        }
        #endregion

        private void InvokePluginTimerEventHandler(object sender, EventArgs args)
        {
            if (PluginTimerEventHandler != null)
            {
                PluginTimerEventHandler.Invoke(this, args);
            }
        }

        public void Dispose()
        {
            _Timer.Stop();
            _Timer.Dispose();
            Api = null;
            PlayerStatusChangedHandler = null;
            PluginTimerEventHandler = null;
        }
    }
}
