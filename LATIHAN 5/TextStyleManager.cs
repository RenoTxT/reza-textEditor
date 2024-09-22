using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LATIHAN_5
{
    public abstract class TextStyleManager
    {
        protected TextBox TextBox { get; }

        protected TextStyleManager(TextBox textBox)
        {
            TextBox = textBox;
        }

        public abstract void ApplyStyle();
    }
}
