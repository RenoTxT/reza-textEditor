using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LATIHAN_5
{
    public class Save : SaveProject
    {
        public Save(TextBox textBox, string filename) : base(textBox, filename)
        {
        }

        public override void ExecuteSave()
        {
            File_Manager fileManager = null;
            string extension = Path.GetExtension(Filename).ToLower();

            if (extension == ".xml")
            {
                fileManager = new XMLManager(TextBox, Filename);
            }
            else if (extension == ".txt")
            {
                fileManager = new TxtManager(TextBox, Filename);
            }

            fileManager?.WriteFile();
        }
    }
}
