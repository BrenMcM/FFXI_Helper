using EliteMMO.API;
using FFXI.MainUI.Controllers;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class PartyMemberView : UserControl
    {
        private PartyMember _member;
        
        public PartyMemberView()
        {
            InitializeComponent();
        }

        public void loadPartyMember(PartyMember member)
        {
            _member = member;
            grpMember.Text = _member.Name;
            prgbHP.Value = member.CurrentHPP;
            prgbMP.Value = member.CurrentMPP;
        }
    }
}
