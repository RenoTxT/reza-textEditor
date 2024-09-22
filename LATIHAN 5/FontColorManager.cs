using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using LATIHAN_5;

namespace LATIHAN_5
{
    public class FontColorManager : TextStyleManager
    {
        private Color _color;

        public FontColorManager(TextBox textBox, Color color) : base(textBox)
        {
            _color = color;
        }

        public override void ApplyStyle()
        {
            TextBox.ForeColor = _color;
        }
    }
}
