using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LATIHAN_5
{
    public class XMLManager : File_Manager
    {
        public XMLManager(TextBox textBox, string filename) : base(textBox, filename)
        {
        }

        public override void WriteFile()
        {
            using (XmlTextWriter writer = new XmlTextWriter(MyFilename, System.Text.Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("text-editor");

                writer.WriteStartElement("font");
                writer.WriteStartElement("family");
                writer.WriteString(MyTextBox.Font.FontFamily.Name);
                writer.WriteEndElement();

                writer.WriteStartElement("style");
                writer.WriteString(MyTextBox.Font.Style.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("size");
                writer.WriteString(MyTextBox.Font.Size.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("color");
                Color fontColor = MyTextBox.ForeColor;
                writer.WriteElementString("r", fontColor.R.ToString());
                writer.WriteElementString("g", fontColor.G.ToString());
                writer.WriteElementString("b", fontColor.B.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteStartElement("background");
                Color backColor = MyTextBox.BackColor;
                writer.WriteElementString("r", backColor.R.ToString());
                writer.WriteElementString("g", backColor.G.ToString());
                writer.WriteElementString("b", backColor.B.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("text");
                writer.WriteString(MyTextBox.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public override void ReadFile()
        {
            using (XmlReader reader = XmlReader.Create(MyFilename))
            {
                int r = 0, g = 0, b = 0;
                FontStyle fontStyle = FontStyle.Regular;
                string fontFamily = "Microsoft Sans Serif";
                float fontSize = 12.0f; // Default font size

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "family":
                                if (reader.Read())
                                {
                                    fontFamily = reader.Value;
                                }
                                break;

                            case "style":
                                if (reader.Read())
                                {
                                    Enum.TryParse(reader.Value, out fontStyle);
                                }
                                break;

                            case "size":
                                if (reader.Read())
                                {
                                    float.TryParse(reader.Value, out fontSize);
                                }
                                break;

                            case "color":
                                if (reader.ReadToFollowing("r"))
                                {
                                    r = int.Parse(reader.ReadElementContentAsString());
                                }
                                if (reader.ReadToFollowing("g"))
                                {
                                    g = int.Parse(reader.ReadElementContentAsString());
                                }
                                if (reader.ReadToFollowing("b"))
                                {
                                    b = int.Parse(reader.ReadElementContentAsString());
                                }
                                MyTextBox.ForeColor = Color.FromArgb(r, g, b);
                                break;

                            case "background":
                                if (reader.ReadToFollowing("r"))
                                {
                                    r = int.Parse(reader.ReadElementContentAsString());
                                }
                                if (reader.ReadToFollowing("g"))
                                {
                                    g = int.Parse(reader.ReadElementContentAsString());
                                }
                                if (reader.ReadToFollowing("b"))
                                {
                                    b = int.Parse(reader.ReadElementContentAsString());
                                }
                                MyTextBox.BackColor = Color.FromArgb(r, g, b);
                                break;

                            case "text":
                                if (reader.Read())
                                {
                                    MyTextBox.Text = reader.Value;
                                }
                                break;
                        }
                    }
                }

                // Set font at the end of the reading process
                MyTextBox.Font = new Font(fontFamily, fontSize, fontStyle);
            }
        }
    }
}