using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LATIHAN_5
{
    public abstract class File_Manager
    {
        public TextBox MyTextBox { get; set; }
        public string MyFilename { get; set; }
        public static string LastFilename { get; set; } // Menyimpan lokasi file terakhir

        protected File_Manager(TextBox textBox, string filename)
        {
            MyTextBox = textBox;
            MyFilename = filename;
        }

        public abstract void WriteFile();
        public abstract void ReadFile();

        protected string GetLastFilename()
        {
            return LastFilename;
        }

        // Menyimpan lokasi file terakhir
        protected void SetLastFilename(string filename)
        {
            LastFilename = filename;
        }
    }
}
