using FFXi.Entourage_2.CustomEventArgs;
using FFXI.Entourage_2.Controllers;
using System;
using System.Windows.Forms;

namespace FFXi.Entourage_2.UserControls
{
    public partial class UcBuff : UserControl
    {
        private string MemberName { get; set; }
        public event EventHandler<BuffRemovedEventArgs> BuffRemovedEvent;
        private short BuffId { get; set; }
        public UcBuff()
        {
            InitializeComponent();
        }

        public UcBuff(string memberName, short buffId)
        {
            InitializeComponent();
            MemberName = memberName;
            BuffId = buffId;

            MemberController.GetMember(MemberName).PlayerStatusChangedHandler += CheckHasBuff;
        }


        public void CheckHasBuff(object sender, EventArgs args)
        {
            var member = MemberController.GetMember(MemberName);
            foreach (var buff in member.PlayerStatusEffects)
            {
                if (buff == BuffId) return;
            }

            BuffRemovedEvent.Invoke(this, new BuffRemovedEventArgs() { BuffId = BuffId });            
        }
    }
}
