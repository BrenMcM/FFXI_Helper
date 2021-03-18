using EliteMMO.API;
using FFXI.MainUI.Controllers;
using System.Windows.Forms;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.UserControls
{
    public partial class SpellDetailsView : UserControl
    {
        public SpellDetailsView()
        {
            InitializeComponent();
        }

        public void UpdateSpellInfo(ISpell spell)
        {            
            txtSpellDescription.Text = spell.Description[0];
            txtSpellElement.Text = ((ElementType) spell.Element).ToString();
            txtCastTime.Text = ApiController.GetSpellRecastTimer(spell.Index).ToString();
            txtMpCost.Text = spell.MPCost.ToString();
            txtMagicType.Text = ((MagicType)spell.MagicType).ToString();
        }
    }
}
