using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LATIHAN_5
{
    public class BackColorManager : TextStyleManager
    {
        private Color _color;

        public BackColorManager(TextBox textBox, Color color) : base(textBox)
        {
            _color = color;
        }

        public override void ApplyStyle()
        {
            TextBox.BackColor = _color;
        }
    }
}
