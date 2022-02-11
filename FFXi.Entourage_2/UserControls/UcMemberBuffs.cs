using FFXi.Entourage_2.CustomEventArgs;
using FFXi.Entourage_2.Properties;
using FFXI.Entourage_2.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FFXi.Entourage_2.UserControls
{
    public partial class UcMemberBuffs : UserControl
    {
        private Dictionary<short, UcBuff> Buffs;
        private string _member;
        public string MemberName 
        {
            get { return _member; }
            set {
                _member = value;
                 var member = MemberController.GetMember(_member);
                 if (member != null) {
                    member.PluginTimerEventHandler += UpdateBuffs;
                 }
            }
        }
        public UcMemberBuffs()
        {
            InitializeComponent();
            MemberName = "";
            Buffs = new Dictionary<short, UcBuff>();
        }

        public UcMemberBuffs(string memberName)
        {
            InitializeComponent();
            MemberName = memberName;
            Buffs = new Dictionary<short, UcBuff>();        

            MemberController.GetMember(MemberName).PluginTimerEventHandler += UpdateBuffs;            
        }

        public void LoadBuffs()
        {
            var rm = Resources.ResourceManager;
            var member = MemberController.GetMember(MemberName);
            foreach(var buff in member.PlayerStatusEffects)
            {
                if (buff > 0)
                {
                    UcBuff temp;
                    if (!Buffs.TryGetValue(buff, out temp))
                    {
                        var newBuff = new UcBuff(MemberName, buff);
                        newBuff.Size = new System.Drawing.Size(20, 20);
                        newBuff.BackgroundImage = (Bitmap)rm.GetObject(buff.ToString());
                        newBuff.BackgroundImageLayout = ImageLayout.Stretch;
                        newBuff.BuffRemovedEvent += BuffRemovedEventHangler;
                        Buffs.Add(buff, newBuff);
                        flpBuffs.Controls.Add(newBuff);
                    }
                }
            }
        }

        public void UpdateBuffs(object sender, EventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(MemberName))
            {
                LoadBuffs();
            }
        }

        public void BuffRemovedEventHangler(object sender, BuffRemovedEventArgs args)
        {
            UcBuff temp;
            if(Buffs.TryGetValue(args.BuffId, out temp))
            {
                flpBuffs.Controls.Remove(temp);
                temp.Dispose();

                Buffs.Remove(args.BuffId);
            }  
        }
    }
}
