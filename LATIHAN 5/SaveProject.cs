using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LATIHAN_5
{
    public abstract class SaveProject
    {
        protected TextBox TextBox { get; }
        protected string Filename { get; }

        protected SaveProject(TextBox textBox, string filename)
        {
            TextBox = textBox;
            Filename = filename;
        }

        public abstract void ExecuteSave();
    }
}
