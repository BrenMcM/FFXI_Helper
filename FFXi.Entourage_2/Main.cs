using FFXi.Entourage_2;
using FFXi.Entourage_2.MapAI;
using FFXI.Entourage_2.Controllers;
using FFXI.Entourage_2.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace FFXI.Entourage_2
{
    public partial class Main : Form
    {     
        private event EventHandler<MemberUpdateEventArgs> _PlayerUpdateEvent;
        public event EventHandler<MemberUpdateEventArgs> PlayerUpdateEvent
        {
            add { _PlayerUpdateEvent += value; }
            remove { _PlayerUpdateEvent -= value; }
        }

        private MemberSelector MemberSelector;
        
        public Main()
        {
            InitializeComponent();
            MemberSelector = new MemberSelector();
            PlayerUpdateEvent += UcInventories.MemberAddedEventHandler;            
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (MemberSelector.ShowDialog(this) == DialogResult.OK)
            {
                var result = MemberController.AddMember(MemberSelector.SelectedProcess);
                if (result.ResultType == Enums.AddMemberResultType.MemberAlreadyExists)
                {
                    MessageBox.Show(this, "Member Is Already Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Set party member view
                    var ptm = new PartyMemberView(result.MemberName);
                    ptm.PartyMemberClosed += UcInventories.HandlePartyMemberClosedEvent;
                    ptm.PartyMemberClosed += WorldMap.MapViewer.MemberRemoved;
                 
                    WorldMap.MapViewer.NewMemberAdded(result.MemberName);

                    // Invoke event handlers
                    MemberUpdateEventArgs args = new MemberUpdateEventArgs();
                    args.MemberName = result.MemberName;
                    _PlayerUpdateEvent.Invoke(args.MemberName, args);

                    MemberController.AddMemberStatusEventHandler(args.MemberName, UcInventories.LoadContainerItemsForAll);
                    ptm.Dock = DockStyle.Top;
                    pnlMembersBoard.Controls.Add(ptm);
                }                
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMap_Click(object sender, EventArgs e)
        {
            WorldMap.MapViewer = new MapViewer();
            WorldMap.MapViewer.Show();
        }
    }
}
