using FFXI.MainUI.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class MagicSkillsView : UserControl
    {
        public MagicSkillsView()
        {
            InitializeComponent();
            ApiController.PlayerStatusChangedHandler += new EventHandler(UpdateValues);
        }

        public void UpdateValues(object sender, EventArgs args)
        {
            UpdateCombatSkill(txtBlueSkill, ApiController.PlayerBlueMagicSkill);
            UpdateCombatSkill(txtDarkSkill, ApiController.PlayerDarkMagicSkill);
            UpdateCombatSkill(txtDivineSkill, ApiController.PlayerDivineMagicSkill);
            UpdateCombatSkill(txtElementalSkill, ApiController.PlayerElementalMagicSkill);
            UpdateCombatSkill(txtEnhancingSkill, ApiController.PlayerEnhancingMagicSkill);
            UpdateCombatSkill(txtEfeeblingSkill, ApiController.PlayerEnfeeblingSkill);
            //UpdateCombatSkill(txtGeomancySkill, _player.CombatSkills.G);
            //UpdateCombatSkill(txtHandbellSkill, _player.CombatSkills.Ha);
            UpdateCombatSkill(txtHealingSkill, ApiController.PlayerHealingSkill);
            UpdateCombatSkill(txtNinjitsuSkill, ApiController.PlayerNinjitsuSkill);
            UpdateCombatSkill(txtSingingSkill, ApiController.PlayerSingingSkill);
            UpdateCombatSkill(txtStringInstSkil, ApiController.PlayerStringSkill);
            UpdateCombatSkill(txtSummoningSkill, ApiController.PlayerSummoningSkill);
            UpdateCombatSkill(txtWindInstSkill, ApiController.PlayerWindSkill);
        }

        private void UpdateCombatSkill(TextBox tb, PlayerCombatSkill pcs)
        {
            tb.Text = pcs.Skill.ToString();
            if (pcs.Capped) tb.ForeColor = Color.Green;
        }
    }
}
