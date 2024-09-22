using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LATIHAN_5
{
    public class TxtManager : File_Manager
    {
        public TxtManager(TextBox textBox, string filename) : base(textBox, filename)
        {
            SetLastFilename(filename);
        }

        public override void WriteFile()
        {
            using (StreamWriter writer = new StreamWriter(MyFilename))
            {
                // Save only text content
                writer.Write(MyTextBox.Text);
            }
        }

        public override void ReadFile()
        {
            using (StreamReader reader = new StreamReader(MyFilename))
            {
                // Read text content only
                MyTextBox.Text = reader.ReadToEnd();
            }
        }

        // Optional: You can have separate methods to save/load the formatting if needed
        //public void SaveFormat(string formatFilename)
        //{
        //    using (StreamWriter writer = new StreamWriter(formatFilename))
        //    {
        //        // Save font information
        //        writer.WriteLine($"FontFamily:{MyTextBox.Font.FontFamily.Name}");
        //        writer.WriteLine($"FontSize:{MyTextBox.Font.Size}");
        //        writer.WriteLine($"FontStyle:{MyTextBox.Font.Style}");

        //        // Save font color information
        //        writer.WriteLine($"FontColor:{MyTextBox.ForeColor.R},{MyTextBox.ForeColor.G},{MyTextBox.ForeColor.B}");

        //        // Save background color information
        //        writer.WriteLine($"BackColor:{MyTextBox.BackColor.R},{MyTextBox.BackColor.G},{MyTextBox.BackColor.B}");
        //    }
        //}

        //public void LoadFormat(string formatFilename)
        //{
        //    using (StreamReader reader = new StreamReader(formatFilename))
        //    {
        //        // Read font information
        //        string line = reader.ReadLine();
        //        FontFamily fontFamily = new FontFamily(line.Split(':')[1]);

        //        line = reader.ReadLine();
        //        float fontSize = float.Parse(line.Split(':')[1]);

        //        line = reader.ReadLine();
        //        FontStyle fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), line.Split(':')[1]);

        //        MyTextBox.Font = new Font(fontFamily, fontSize, fontStyle);

        //        // Read font color information
        //        line = reader.ReadLine();
        //        string[] fontColorValues = line.Split(':')[1].Split(',');
        //        Color fontColor = Color.FromArgb(int.Parse(fontColorValues[0]), int.Parse(fontColorValues[1]), int.Parse(fontColorValues[2]));
        //        MyTextBox.ForeColor = fontColor;

        //        // Read background color information
        //        line = reader.ReadLine();
        //        string[] backColorValues = line.Split(':')[1].Split(',');
        //        Color backColor = Color.FromArgb(int.Parse(backColorValues[0]), int.Parse(backColorValues[1]), int.Parse(backColorValues[2]));
        //        MyTextBox.BackColor = backColor;
        //    }
        //}
    }
}
