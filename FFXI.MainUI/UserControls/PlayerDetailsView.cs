using FFXI.MainUI.Controllers;
using System;
using System.Windows.Forms;

namespace FFXI.MainUI.UserControls
{
    public partial class PlayerDetailsView : UserControl
    {
        public PlayerDetailsView()
        {
            InitializeComponent();
            ApiController.PlayerStatusChangedHandler += new EventHandler(UpdateValues);
        }

        public void UpdateValues(object sender, EventArgs args)
        {
            txtPlayerName.Text = ApiController.PlayerName;
            txtPlayerNation.Text = ApiController.PlayerNation;
            txtPlayerMainJob.Text = ApiController.PlayerMainJobLevelStr;
            txtPlayerSubJob.Text = ApiController.PlayerSubJobLevelStr;
            txtPlayerMaxHP.Text = ApiController.PlayerMaxHP;
            txtPlayerMaxMP.Text = ApiController.PlayerMaxMP;
            txtPlayerGil.Text = ApiController.PlayerGold;

            txtPlayerAgility.Text = ApiController.PlayerAgility.ToString();
            txtPlayerCharisma.Text = ApiController.PlayerCharisma.ToString();
            txtPlayerDexterity.Text = ApiController.PlayerDexterity.ToString();
            txtPlayerIntelligence.Text = ApiController.PlayerIntelligence.ToString();
            txtPlayerMind.Text = ApiController.PlayerMind.ToString();
            txtPlayerStrength.Text = ApiController.PlayerStrength.ToString();
            txtPlayerVitality.Text = ApiController.PlayerVitality.ToString();
            txtPlayerDefense.Text = ApiController.PlayerDefense.ToString();
            txtPlayerAttack.Text = ApiController.PlayerDefense.ToString();
        }        
    }
}
