using EliteMMO.API;
using FFXI.MainUI.Controllers;
using FFXI.MainUI.Enums;
using System;
using System.Windows.Forms;

namespace FFXI.MainUI.UserControls.Ninja
{
    public partial class ShadowCaster : UserControl
    {
        public ShadowCaster()
        {
            InitializeComponent();
            
        }

        private void UpdateShadowCaster(object sender, EventArgs args)
        {
            if (
                (!chkBattleOnly.Checked && ApiController.PlayerIsStanding()) || 
                (chkBattleOnly.Checked && ApiController.PlayerIsAttacking())
                )
            {
                CheckShadowsAndCastUtsusemi();
            }             
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ApiController._Timer.Tick += UpdateShadowCaster;

            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ApiController._Timer.Tick -= UpdateShadowCaster;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void CheckShadowsAndCastUtsusemi()
        {

            if(ApiController.PlayerHasBuff(StatusEffect.Utsusemi_1_Shadow_Left))
            {
                // san
                if (ApiController.PlayerCanCastSpellNow(MagicSpells.Utsusemi_san))
                {
                    ApiController.CastSpell(MagicSpells.Utsusemi_san, "<me>");
                }
                // ni
                else if (ApiController.PlayerHasSpell((int)MagicSpells.Utsusemi_ni))
                {
                    ApiController.CastSpell(MagicSpells.Utsusemi_ni, "<me>");
                }

            } else if (! (
                (ApiController.PlayerHasBuff(StatusEffect.Utsusemi_1_Shadow_Left)) ||
                (ApiController.PlayerHasBuff(StatusEffect.Utsusemi_2_Shadows_Left)) ||
                (ApiController.PlayerHasBuff(StatusEffect.Utsusemi_3_Shadows_Left)) ||
                (ApiController.PlayerHasBuff(StatusEffect.Utsusemi_4_Shadows_Left))
                ))
            {
                // san
                if (ApiController.PlayerCanCastSpellNow(MagicSpells.Utsusemi_san))
                {
                    ApiController.CastSpell(MagicSpells.Utsusemi_san, "<me>");
                }
                // ni
                else if (ApiController.PlayerHasSpell((int)MagicSpells.Utsusemi_ni))
                {
                    ApiController.CastSpell(MagicSpells.Utsusemi_ni, "<me>");
                }
                // ichi
                else if (ApiController.PlayerHasSpell((int)MagicSpells.Utsusemi_ichi))
                {
                    ApiController.CastSpell(MagicSpells.Utsusemi_ichi, "<me>");
                }
            }
        }
    }
}
 