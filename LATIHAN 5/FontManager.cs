using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LATIHAN_5
{
    public class FontManager : TextStyleManager
    {
        private Font _font;

        public FontManager(TextBox textBox, Font font) : base(textBox)
        {
            _font = font;
        }

        public override void ApplyStyle()
        {
            TextBox.Font = _font;
        }
    }
}
