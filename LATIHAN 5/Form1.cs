using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LATIHAN_5
{
    public partial class Form1 : Form
    {
        private bool isFileSaved = false;
        public string Content { get; set; }
        public string FilePath { get; set; }
        public string OpenFilePath { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveProject(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(File_Manager.LastFilename))
            {
                SaveFile();
            }
            else
            {
                var saveProject = new Save(textBox1, File_Manager.LastFilename);
                saveProject.ExecuteSave();
                isFileSaved = true; // Mark project as saved
            }
        }

        private void LoadProject(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text and XML Files (*.txt; *.xml)|*.txt;*.xml|Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
                openFileDialog.Title = "Open File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File_Manager fileManager = null;
                    string extension = System.IO.Path.GetExtension(openFileDialog.FileName).ToLower();

                    if (extension == ".xml")
                    {
                        fileManager = new XMLManager(textBox1, openFileDialog.FileName);
                    }
                    else if (extension == ".txt")
                    {
                        fileManager = new TxtManager(textBox1, openFileDialog.FileName);
                    }

                    if (fileManager != null)
                    {
                        fileManager.ReadFile();
                        File_Manager.LastFilename = openFileDialog.FileName; // Menyimpan lokasi file terakhir
                    }
                }
            }
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = textBox1.Font;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog.Font;
                }
            }
        }

        private void FONT_COLOUR_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = textBox1.ForeColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.ForeColor = colorDialog.Color;
                }
            }
        }

        private void ChangeBackgroundColour(object sender, EventArgs e)
        {

        }

        private void NewProject(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                if (MessageBox.Show("Do you want to discard unsaved changes and start a new project?", "New Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return; // User chose not to discard changes
                }
            }

            textBox1.Clear();
            textBox1.Font = new Font("Microsoft Sans Serif", 10); // Set default font
            textBox1.ForeColor = Color.Black; // Set default font color
            textBox1.BackColor = Color.White; // Set default background color
            File_Manager.LastFilename = null; // Reset file location
            isFileSaved = false; // Mark project as not saved
        }

        private void SaveAS(object sender, EventArgs e)
        {
            SaveFile(true);
        }
        private void SaveFile(bool saveAs = false)
        {
            if (saveAs)
            {
                var saveAsProject = new SaveAs(textBox1, File_Manager.LastFilename ?? "Untitled");
                saveAsProject.ExecuteSave();
                isFileSaved = true; // Mark project as saved
            }
            else
            {
                if (string.IsNullOrEmpty(File_Manager.LastFilename))
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml";
                        saveFileDialog.Title = "Save File";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var saveProject = new Save(textBox1, saveFileDialog.FileName);
                            saveProject.ExecuteSave();
                            File_Manager.LastFilename = saveFileDialog.FileName; // Menyimpan lokasi file terakhir
                            isFileSaved = true; // Mark project as saved
                        }
                    }
                }
                else
                {
                    var saveProject = new Save(textBox1, File_Manager.LastFilename);
                    saveProject.ExecuteSave();
                    isFileSaved = true; // Mark project as saved
                }
            }
        }

        private void exit(object sender, EventArgs e)
        {
            if (!isFileSaved)
            {
                if (MessageBox.Show("Do you want to discard unsaved changes and Exit project?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return; // User chose not to discard changes
                }
            }
            Application.Exit();
        }

        private void SAVEAS_Click(object sender, EventArgs e)
        {
            SaveAs saveAsFunction = new SaveAs(textBox1, File_Manager.LastFilename);
            saveAsFunction.ExecuteSave();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            Save saveFunction = new Save(textBox1, File_Manager.LastFilename);
            saveFunction.ExecuteSave();
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            //bisa dipindahkan ke class lain sesuai struktur yang dibuat
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFilePath = openFileDialog.FileName;
                string extension = Path.GetExtension(OpenFilePath).ToLower();
                if (extension == ".txt")
                {
                    Content = File.ReadAllText(OpenFilePath);
                }
                else if (extension == ".xml")
                {
                    Content = File.ReadAllText(OpenFilePath);
                }
            }

            textBox1.Text = Content;
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
