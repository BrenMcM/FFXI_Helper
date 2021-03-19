using EliteMMO.API;
using System;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.Controllers
{
    public static class ApiController
    {
        private static EliteAPI _Api;
        #region public static EliteAPI Api
        public static EliteAPI Api
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
                    _Timer.Interval = (1 * 1000);
                    _Timer.Tick += new EventHandler(CheckPlyerSate);
                    _Timer.Start();
                }
            }
        }
        #endregion

        // Records the current status of the Player
        private static int _currentPlayerStatus = -1;        
        
        // Event Handler for updating UI components each timer the players status changes
        public static event EventHandler PlayerStatusChangedHandler;
        public static Timer _Timer;

        // Basic Player Details
        #region public static string PlayerName
        public static string PlayerName 
        {
            get { return _Api.Player.Name; }
        }
        #endregion
        #region public static string PlayerNation
        public static string PlayerNation
        {
            get { return ((Nations)_Api.Player.Nation).ToString(); }
        }
        #endregion
        #region public static string PlayerGold 
        public static string PlayerGold 
        {
            get { return _Api.Inventory.GetContainerItem(0, 0).Count.ToString("C"); }
        }
        #endregion
        // Basic Combat Details
        #region public static int PlayerTP
        public static int PlayerTP
        {
            get { return (int)_Api.Player.TP; }
        }
        #endregion
        #region public static string PlayerMaxHP 
        public static string PlayerMaxHP 
        {
            get { return _Api.Player.HPMax.ToString(); }
        }
        #endregion
        #region public static string PlayerMaxMP 
        public static string PlayerMaxMP 
        {
            get { return _Api.Player.MPMax.ToString(); }
        }
        #endregion        
        #region public static int PlayerAttack 
        public static int PlayerAttack 
        {
            get { return _Api.Player.Attack; }
        }
        #endregion
        #region public static int PlayerDeffense
        public static int PlayerDefense
        {
            get { return _Api.Player.Defense; }
        }
        #endregion
        // Basic Job details
        #region public static byte PlayerMainJob
        public static byte PlayerMainJob
        {
            get { return _Api.Player.MainJob; }
        }
        #endregion
        #region public static byte PlayerSubJob
        public static byte PlayerSubJob
        {
            get { return _Api.Player.SubJob; }
        }
        #endregion
        #region public static int PlayerMainJobLevel
        public static int PlayerMainJobLevel
        {
            get { return _Api.Player.MainJobLevel; }
        }
        #endregion
        #region public static int PlayerSubJobLevel
        public static int PlayerSubJobLevel
        {
            get { return _Api.Player.SubJobLevel; }
        }
        #endregion
        #region public static string PlayerMainJobLevelStr
        public static string PlayerMainJobLevelStr
        {
            get
            {
                string jobName = ((JobType)_Api.Player.MainJob).ToString();
                return $"{jobName} ({_Api.Player.MainJobLevel})";
            }
        }
        #endregion
        #region public static string PlayerSubJobLevelStr
        public static string PlayerSubJobLevelStr
        {
            get
            {
                string jobName = ((JobType)_Api.Player.SubJob).ToString();
                return $"{jobName} ({_Api.Player.SubJobLevel})";
            }
        }
        #endregion
        // Player BASE stats
        #region public static int PlayerAgility
        public static int PlayerAgility
        {
            get { return _Api.Player.Stats.Agility; }
        }
        #endregion
        #region public static int PlayerCharisma
        public static int PlayerCharisma
        {
            get { return _Api.Player.Stats.Charisma; }
        }
        #endregion
        #region public static int PlayerDexterity
        public static int PlayerDexterity
        {
            get { return _Api.Player.Stats.Dexterity; }
        }
        #endregion
        #region public static int PlayerIntelligence
        public static int PlayerIntelligence
        {
            get { return _Api.Player.Stats.Intelligence; }
        }
        #endregion
        #region public static int PlayerMind
        public static int PlayerMind
        {
            get { return _Api.Player.Stats.Mind; }
        }
        #endregion
        #region public static int PlayerStrength
        public static int PlayerStrength
        {
            get { return _Api.Player.Stats.Strength; }
        }
        #endregion
        #region public static int PlayerVitality
        public static int PlayerVitality
        {
            get { return _Api.Player.Stats.Vitality; }
        }
        #endregion
        // Player Base Magic Skills
        #region public static PlayerCombatSkill PlayerBlueMagicSkill
        public static PlayerCombatSkill PlayerBlueMagicSkill
        {
            get { return _Api.Player.CombatSkills.BlueMagic; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerDarkMagicSkill
        public static PlayerCombatSkill PlayerDarkMagicSkill
        {
            get { return _Api.Player.CombatSkills.Dark; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerDivineMagicSkill
        public static PlayerCombatSkill PlayerDivineMagicSkill
        {
            get { return _Api.Player.CombatSkills.Divine; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerElementalMagicSkill
        public static PlayerCombatSkill PlayerElementalMagicSkill
        {
            get { return _Api.Player.CombatSkills.Elemental; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerEnhancingMagicSkill
        public static PlayerCombatSkill PlayerEnhancingMagicSkill
        {
            get { return _Api.Player.CombatSkills.Enhancing; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerHealingSkill
        public static PlayerCombatSkill PlayerHealingSkill
        {
            get { return _Api.Player.CombatSkills.Healing; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerNinjitsuSkill
        public static PlayerCombatSkill PlayerNinjitsuSkill
        {
            get { return _Api.Player.CombatSkills.Ninjitsu; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerSingingSkill
        public static PlayerCombatSkill PlayerSingingSkill
        {
            get { return _Api.Player.CombatSkills.Singing; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerStringSkill
        public static PlayerCombatSkill PlayerStringSkill
        {
            get { return _Api.Player.CombatSkills.String; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerWindSkill
        public static PlayerCombatSkill PlayerWindSkill
        {
            get { return _Api.Player.CombatSkills.Wind; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerSummoningSkill
        public static PlayerCombatSkill PlayerSummoningSkill
        {
            get { return _Api.Player.CombatSkills.Summon; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerEnfeeblingSkill
        public static PlayerCombatSkill PlayerEnfeeblingSkill
        {
            get { return _Api.Player.CombatSkills.Enfeebling; }
        }
        #endregion
        // Player Base Combat Skills
        #region public static PlayerCombatSkill PlayerHandToHandSkill        
        public static PlayerCombatSkill PlayerHandToHandSkill
        {
            get { return _Api.Player.CombatSkills.HandToHand; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerDaggerSkill
        public static PlayerCombatSkill PlayerDaggerSkill
        {
            get { return _Api.Player.CombatSkills.Dagger; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerSwordSkill
        public static PlayerCombatSkill PlayerSwordSkill
        {
            get { return _Api.Player.CombatSkills.Sword; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerGreatSwordSkill
        public static PlayerCombatSkill PlayerGreatSwordSkill
        {
            get { return _Api.Player.CombatSkills.GreatSword; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerAxeSkill
        public static PlayerCombatSkill PlayerAxeSkill
        {
            get { return _Api.Player.CombatSkills.Axe; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerGreatAxeSkill
        public static PlayerCombatSkill PlayerGreatAxeSkill
        {
            get { return _Api.Player.CombatSkills.GreatAxe; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerScytheSkill
        public static PlayerCombatSkill PlayerScytheSkill
        {
            get { return _Api.Player.CombatSkills.Scythe; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerPolearmSkill
        public static PlayerCombatSkill PlayerPolearmSkill
        {
            get { return _Api.Player.CombatSkills.Polearm; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerKatanaSkill
        public static PlayerCombatSkill PlayerKatanaSkill
        {
            get { return _Api.Player.CombatSkills.Katana; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerGreatKatanaSkill
        public static PlayerCombatSkill PlayerGreatKatanaSkill
        {
            get { return _Api.Player.CombatSkills.GreatKatana; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerClubSkill
        public static PlayerCombatSkill PlayerClubSkill
        {
            get { return _Api.Player.CombatSkills.Club; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerStaffSkill
        public static PlayerCombatSkill PlayerStaffSkill
        {
            get { return _Api.Player.CombatSkills.Staff; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerArcherySkill
        public static PlayerCombatSkill PlayerArcherySkill
        {
            get { return _Api.Player.CombatSkills.Archery; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerMarksmanshipSkill
        public static PlayerCombatSkill PlayerMarksmanshipSkill
        {
            get { return _Api.Player.CombatSkills.Marksmanship; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerThrowingSkill
        public static PlayerCombatSkill PlayerThrowingSkill
        {
            get { return _Api.Player.CombatSkills.Throwing; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerGuardingSkill
        public static PlayerCombatSkill PlayerGuardingSkill
        {
            get { return _Api.Player.CombatSkills.Guarding; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerEvasionSkill
        public static PlayerCombatSkill PlayerEvasionSkill
        {
            get { return _Api.Player.CombatSkills.Evasion; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerShieldSkill
        public static PlayerCombatSkill PlayerShieldSkill
        {
            get { return _Api.Player.CombatSkills.Shield; }
        }
        #endregion
        #region public static PlayerCombatSkill PlayerParryingSkill
        public static PlayerCombatSkill PlayerParryingSkill
        {
            get { return _Api.Player.CombatSkills.Parrying; }
        }
        #endregion

        // Checks the players current status for changes
        // if a change is detected, the PlayerStatusChangedHandler is invoked
        #region private static void CheckPlyerSate(object sender, EventArgs args)
        private static void CheckPlyerSate(object sender, EventArgs args)
        {
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

        // Converts the Equipment Description into a readable/parseable format
        #region public static string FixEquipmentDescription(string str)
        public static string FixEquipmentDescription(string str)
        {
            // Sanitize first
            str = str.Replace("\u001f", "Fire");
            str = str.Replace("$", "Water");
            str = str.Replace("� ", "Ice");
            str = str.Replace("�!", "Wind");
            str = str.Replace("#", "Earth");
            str = str.Replace("�", "");
            str = str.Replace("\"", "");

            string temp = string.Empty;
            string line = string.Empty;
            bool slicer = false;
            foreach(char c in str) 
            {
                if(Char.IsNumber(c) || c == '`')
                {
                    line += c;
                    line = line.Replace("`", "~");
                    slicer = true;
                } else if (c == '%')
                {
                    line += c;
                    // line += Environment.NewLine;
                    temp += Environment.NewLine + line.Trim();
                    //FindAddedStats(line);
                    line = "";

                    slicer = false;
                } else
                {
                    if (slicer)
                    {
                        temp += Environment.NewLine + line.Trim();
                        //FindAddedStats(line);
                        line = "";

                        line += c;
                        slicer = false;
                    } else
                    {
                        line += c;
                    }
                }
            }
            var actual = str;
            return temp + Environment.NewLine + line.Trim();
        }
        #endregion

        // Get the details for a specific spell
        #region public static ISpell GetSpellInfo(int spellId)
        public static ISpell GetSpellInfo(int spellId)
        {
            return _Api.Resources.GetSpell((uint) spellId);
        }
        #endregion
        #region public static ISpell GetSpellInfo(uint spellId)
        public static ISpell GetSpellInfo(uint spellId)
        {
            return _Api.Resources.GetSpell(spellId);
        }
        #endregion
        // Get the current recast time for a specific Spell
        #region public static int GetSpellRecastTimer(ushort index)
        public static int GetSpellRecastTimer(ushort index)
        {
            return _Api.Recast.GetSpellRecast(index);
        }
        #endregion

        // Check if the player has a specific spell
        #region public static bool PlayerHasSpell(uint spellId)
        public static bool PlayerHasSpell(int spellId)
        {
            return _Api.Player.HasSpell((uint)spellId);
        }
        #endregion
        #region public static bool PlayerHasSpell(uint spellId)
        public static bool PlayerHasSpell(uint spellId)
        {
            return _Api.Player.HasSpell(spellId);
        }
        #endregion

        // Get Details for a specific Item
        #region public static IItem GetItemInfo(int itemId)
        public static IItem GetItemInfo(int itemId)
        {
            return _Api.Resources.GetItem((uint)itemId);
        }
        #endregion
        #region public static IItem GetItemInfo(uint itemId)
        public static IItem GetItemInfo(uint itemId)
        {
            return _Api.Resources.GetItem(itemId);
        }
        #endregion

        // Get Inventory Item
        #region public static InventoryItem GetEquippedItem(EquipmentSlot slot)
        public static InventoryItem GetEquippedItem(EquipmentSlot slot)
        {
            return _Api.Inventory.GetEquippedItem((int)slot);
        }
        #endregion

        // Count Items in a specific Item container
        #region public static int GetContainerCount(int containerId)
        public static int GetContainerCount(int containerId)
        {
            return _Api.Inventory.GetContainerCount(containerId);
        }
        #endregion
        // Get Item at specified index from the specified container
        #region public static InventoryItem GetContainerItem(int containerId, int index)
        public static InventoryItem GetContainerItem(int containerId, int index)
        {
            return _Api.Inventory.GetContainerItem(containerId, index);
        }
        #endregion

        public static string GetStatsAddWithEquipment(string key, bool isPercentageBased)
        {
            int addedStat = 0;
            foreach(EquipmentSlot slot in Enum.GetValues(typeof(EquipmentSlot)))
            {
                var item = GetEquippedItem(slot);
                var itemInfo = GetItemInfo(item.Id);
                if (itemInfo != null)
                {
                    var targetLine = GetTargetLine(
                        FixEquipmentDescription(itemInfo.Description[0]).Trim(),
                        key
                        );

                    var valueStr = targetLine.Replace(key, "").Trim();
                    if (isPercentageBased)
                    {
                        valueStr = valueStr.Replace("%", "");
                    }

                    if (!string.IsNullOrEmpty(valueStr))
                    {
                        if (valueStr.Contains("~"))
                            addedStat += GetRajasTildedValue();
                        else
                        {
                            var intValue = Convert.ToInt32(valueStr);
                            addedStat += intValue;
                        }                    
                    }
                }
            }

            if (isPercentageBased)
            {
                return addedStat + "%";
            } else
            {
                return addedStat.ToString();
            }
        }

        // FOR Raja's Ring - I need to review other tilded item specs
        private static int GetRajasTildedValue()
        {
            if (PlayerMainJobLevel >= 75) return 5;
            else if (PlayerMainJobLevel >= 60) return 4;
            else if (PlayerMainJobLevel >= 45) return 3;
            else if (PlayerMainJobLevel >= 30) return 2;
            else if (PlayerMainJobLevel >= 18) return 1;
            return 0;
        }

        private static string GetTargetLine(string description, string key)
        {
            foreach(var line in description.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                if (line.StartsWith(key)) return line;
            }
            return "";
        }

        // Check if the API is NULL
        #region public static bool IsNULL()
        public static bool IsNULL()
        {
            return Api == null;
        }
        #endregion
    }
}
