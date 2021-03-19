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

            txtPlayerAgility.Text = ApiController.PlayerAgility
                + " (" + ApiController.GetStatsAddWithEquipment("AGI", false) + ")";
            txtPlayerCharisma.Text = ApiController.PlayerCharisma
                + " (" + ApiController.GetStatsAddWithEquipment("CHR", false) + ")";
            txtPlayerDexterity.Text = ApiController.PlayerDexterity
                + " (" + ApiController.GetStatsAddWithEquipment("DEX", false) + ")";
            txtPlayerIntelligence.Text = ApiController.PlayerIntelligence
                + " (" + ApiController.GetStatsAddWithEquipment("INT", false) + ")";
            txtPlayerMind.Text = ApiController.PlayerMind
                + " (" + ApiController.GetStatsAddWithEquipment("MND", false) + ")";
            txtPlayerStrength.Text = ApiController.PlayerStrength 
                + " (" + ApiController.GetStatsAddWithEquipment("STR", false) + ")";
            txtPlayerVitality.Text = ApiController.PlayerVitality
                + " (" + ApiController.GetStatsAddWithEquipment("VIT", false) + ")";
            txtPlayerDefense.Text = ApiController.PlayerDefense.ToString();
            txtPlayerAttack.Text = ApiController.PlayerDefense.ToString();
        }        
    }
}
