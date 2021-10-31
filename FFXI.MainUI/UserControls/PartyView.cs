using FFXI.MainUI.Controllers;
using System;
using System.Windows.Forms;

namespace FFXI.MainUI.UserControls
{
    public partial class PartyView : UserControl
    {
        public PartyView()
        {
            InitializeComponent();

            ApiController.PlayerStatusChangedHandler += 
                new EventHandler(UpdatePartyDetails);
        }

        public void UpdatePartyDetails(object sender, EventArgs args)
        {
            partyMemberView1.loadPartyMember(ApiController.GetPartyMember(0));
            partyMemberView2.loadPartyMember(ApiController.GetPartyMember(1));
            partyMemberView3.loadPartyMember(ApiController.GetPartyMember(2));
            partyMemberView4.loadPartyMember(ApiController.GetPartyMember(3));
            partyMemberView5.loadPartyMember(ApiController.GetPartyMember(4));
            partyMemberView6.loadPartyMember(ApiController.GetPartyMember(5));

        }
    }
}
