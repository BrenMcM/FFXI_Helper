using FFXI.MainUI.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class CombatSkillsView : UserControl
    {
        public CombatSkillsView()
        {
            InitializeComponent();
            ApiController.PlayerStatusChangedHandler += new EventHandler(UpdateValues);
        }

        public void UpdateValues(object sender, EventArgs args)
        {
            UpdateCombatSkill(
                txtHand2Hand,
                ApiController.PlayerHandToHandSkill
                );
            UpdateCombatSkill(
                txtDagger,
                ApiController.PlayerDaggerSkill
                );
            UpdateCombatSkill(
                txtSword,
                ApiController.PlayerSwordSkill
                );
            UpdateCombatSkill(
                txtGreatSword,
                ApiController.PlayerGreatSwordSkill
                );
            UpdateCombatSkill(
                txtAxe,
                ApiController.PlayerAxeSkill
                );
            UpdateCombatSkill(
                txtGreatAxe,
                ApiController.PlayerGreatAxeSkill
                );
            UpdateCombatSkill(
                txtScythe,
                ApiController.PlayerScytheSkill
                );
            UpdateCombatSkill(
                txtPolearm,
                ApiController.PlayerPolearmSkill
                );
            UpdateCombatSkill(
                txtKatana,
                ApiController.PlayerKatanaSkill
                );
            UpdateCombatSkill(
                txtGreatKatana,
                ApiController.PlayerGreatKatanaSkill
                );
            UpdateCombatSkill(
                txtClub,
                ApiController.PlayerClubSkill
                );
            UpdateCombatSkill(
                txtStaff,
                ApiController.PlayerStaffSkill
                );
            UpdateCombatSkill(
                txtArchery,
                ApiController.PlayerArcherySkill
                );
            UpdateCombatSkill(
                txtMarksmanship,
                ApiController.PlayerMarksmanshipSkill
                );
            UpdateCombatSkill(
                txtThrowing,
                ApiController.PlayerThrowingSkill
                );
            UpdateCombatSkill(
                txtGuarding,
                ApiController.PlayerGuardingSkill
                );
            UpdateCombatSkill(
                txtEvasion,
                ApiController.PlayerEvasionSkill
                );
            UpdateCombatSkill(
                txtShield,
                ApiController.PlayerShieldSkill
                );
            UpdateCombatSkill(
                txtParrying,
                ApiController.PlayerParryingSkill
                );
        }

        private void UpdateCombatSkill(TextBox tb, PlayerCombatSkill pcs)
        {
            tb.Text = pcs.Skill.ToString();
            if (pcs.Capped) tb.ForeColor = Color.Green;
        }
    }
}
