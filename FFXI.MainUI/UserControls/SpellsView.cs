using EliteMMO.API;
using FFXI.MainUI.Controllers;
using FFXI.MainUI.Entities;
using FFXI.MainUI.Enums;
using FFXI.MainUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class SpellsView : UserControl
    {
        public SpellsView()
        {
            InitializeComponent();
            ApiController.PlayerStatusChangedHandler += new EventHandler(UpdateSpells);
        }

        public void UpdateSpells(object sender, EventArgs args)
        {
            List<ListItem> trustSpells = new List<ListItem>();
            List<ListItem> whiteMagicSpells = new List<ListItem>();
            List<ListItem> blackMagicSpells = new List<ListItem>();
            List<ListItem> summoningSpells = new List<ListItem>();
            List<ListItem> ninjitsuSpells = new List<ListItem>();
            List<ListItem> geomancySpells = new List<ListItem>();
            List<ListItem> bardSpells = new List<ListItem>();
            List<ListItem> blueSpells = new List<ListItem>();
            foreach (var spell in ((MagicSpells[]) Enum.GetValues(typeof(MagicSpells)))) 
            {
                if (ApiController.PlayerHasSpell((uint)spell))
                {
                    var iSpell = ApiController.GetSpellInfo((uint)spell);                    
                    if (CanCastSpell(iSpell))
                    {

                        var lItem = new ListItem()
                        {
                            Value = (int)iSpell.ID,
                            Label = iSpell.Name[0]
                        };

                        var magicType = (MagicType)iSpell.MagicType;

                        switch (magicType)
                        #region MagicType Options
                        {
                            case MagicType.WhiteMagic:
                                whiteMagicSpells.Add(lItem);
                                break;
                            case MagicType.BlackMagic:
                                blackMagicSpells.Add(lItem);
                                break;
                            case MagicType.BlueMagic:
                                blueSpells.Add(lItem);
                                break;
                            case MagicType.Ninjutsu:
                                ninjitsuSpells.Add(lItem);
                                break;
                            case MagicType.Summon:
                                summoningSpells.Add(lItem);
                                break;
                            case MagicType.Song:
                                bardSpells.Add(lItem);
                                break;
                            case MagicType.Trust:
                                trustSpells.Add(lItem);
                                break;
                            case MagicType.Geomancy:
                                geomancySpells.Add(lItem);
                                break;
                        }
                        #endregion
                    }
                }               
            }

            SetListBox(lsbHealingMagic, whiteMagicSpells);
            SetListBox(lsbBlackMagic, blackMagicSpells);
            SetListBox(lsbSummoningMagic, summoningSpells);
            SetListBox(lsbNinjitsu, ninjitsuSpells);
            SetListBox(lsbSongs, bardSpells);
            SetListBox(lsbBlueMagic, blueSpells);
            SetListBox(lsbGeomancy, geomancySpells);
            SetListBox(lsbTrustMagic, trustSpells);

            void SetListBox(ListBox lb, List<ListItem> items)
            {
                if (items.Count <= 0)
                {
                    lb.Parent.Hide();
                }
                else
                {
                    lb.DataSource = items;
                    lb.DisplayMember = "Label";
                    lb.ValueMember = "Value";
                    lb.Parent.Show();
                }
            }

            bool CanCastSpell(ISpell spell)
            {
                if (spell == null) return false;

                int mainJobRequired = spell
                    .LevelRequired[(ApiController.PlayerMainJob)];
                int subJobRequired = spell
                    .LevelRequired[(ApiController.PlayerSubJob)];

                if (mainJobRequired <= ApiController.PlayerMainJobLevel && mainJobRequired != -1)
                {
                    return true;
                }
                else if (subJobRequired <= ApiController.PlayerSubJobLevel && subJobRequired != -1)
                {
                    return true;
                }

                return false;
            }
        }

        private void lsbMagic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var spellId = (IListItem)listBox.SelectedItem;

            var spell = ApiController.GetSpellInfo(spellId.Value);

            if(spell != null)
            {
                vwSpellDetails.UpdateSpellInfo(spell);
            }
        }
    }
}
