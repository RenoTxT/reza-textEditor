using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LATIHAN_5
{
    public class SaveAs : SaveProject
    {
        public SaveAs(TextBox textBox, string filename) : base(textBox, filename)
        {
        }

        public override void ExecuteSave()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml";
                saveFileDialog.Title = "Save File As";
                saveFileDialog.FileName = Filename;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Update the filename and save
                    var saveProject = new Save(TextBox, saveFileDialog.FileName);
                    saveProject.ExecuteSave();
                    File_Manager.LastFilename = saveFileDialog.FileName; // Menyimpan lokasi file terakhir
                }
            }
        }
    }
}
