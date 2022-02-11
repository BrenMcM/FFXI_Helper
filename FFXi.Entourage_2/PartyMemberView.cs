using FFXi.Entourage_2.Properties;
using FFXI.Entourage_2.Controllers;
using FFXI.Entourage_2.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace FFXI.Entourage_2
{
    public partial class PartyMemberView : UserControl
    {
        public event EventHandler<MemberUpdateEventArgs> PartyMemberClosed;

        private string MemberName { get; set; }
        public PartyMemberView()
        {
            InitializeComponent();
        }

        public PartyMemberView(string name)
        {
            InitializeComponent();
            MemberName = name;
            ucMemberBuffs.MemberName = name;
            MemberController.AddPluginTimerEventHandler(MemberName, MemberDataRefresh);
        }

        public void LoadMemberInfo()
        {
            var rm = Resources.ResourceManager;

            var Member = MemberController.GetMember(MemberName);
            lblName.Text = Member.Name;
            lblTP.Text = $"TP: {Member.PlayerTP} ({(((float)Member.PlayerTP)/1000)*100}%)";
            lblHP.Text = $"HP: {Member.PlayerHP} ({Member.PlayerHPP}%)";
            lblMP.Text = $"MP: {Member.PlayerMP} ({Member.PlayerMPP}%)";
            lblZone.Text = Member.PlayerZoneName;
            lblStatus.Text = Member.PlayerState;
            //lblTarget.Text = $"Target: {Member.GetTargetName() ?? "None"} : {Member.GetTargetRace() ?? ""} : {Member.TargetCoords() ?? ""}";
            lblCoords.Text = $"X:{Member.PlayerCoordinates.X}, Y:{Member.PlayerCoordinates.Y}, Z:{Member.PlayerCoordinates.Z}";
            
        }

        private void PartyMemberView_FormClosing(object sender, FormClosingEventArgs e)
        {
            PartyMemberClosed.Invoke(this, new MemberUpdateEventArgs() { MemberName = MemberName });
            MemberController.RemovePluginTimerEventHandler(MemberName, MemberDataRefresh);
            MemberController.RemoveMember(MemberName);
        }

        private void MemberDataRefresh(object sender, EventArgs args)
        {
            LoadMemberInfo();
        }
    }
}
