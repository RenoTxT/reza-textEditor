namespace LATIHAN_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.NEW = new System.Windows.Forms.ToolStripMenuItem();
            this.OPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.SAVE = new System.Windows.Forms.ToolStripMenuItem();
            this.SAVEAS = new System.Windows.Forms.ToolStripMenuItem();
            this.EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FONT_COLOUR = new System.Windows.Forms.ToolStripMenuItem();
            this.FONT_STYLE = new System.Windows.Forms.ToolStripMenuItem();
            this.BACKGROUND = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILE,
            this.fontToolStripMenuItem,
            this.BACKGROUND});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1187, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FILE
            // 
            this.FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NEW,
            this.OPEN,
            this.SAVE,
            this.SAVEAS,
            this.EXIT});
            this.FILE.Name = "FILE";
            this.FILE.Size = new System.Drawing.Size(46, 24);
            this.FILE.Text = "File";
            // 
            // NEW
            // 
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(224, 26);
            this.NEW.Text = "New";
            // 
            // OPEN
            // 
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(224, 26);
            this.OPEN.Text = "Open";
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // SAVE
            // 
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(224, 26);
            this.SAVE.Text = "Save";
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // SAVEAS
            // 
            this.SAVEAS.Name = "SAVEAS";
            this.SAVEAS.Size = new System.Drawing.Size(224, 26);
            this.SAVEAS.Text = "SaveAs";
            this.SAVEAS.Click += new System.EventHandler(this.SAVEAS_Click);
            // 
            // EXIT
            // 
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(224, 26);
            this.EXIT.Text = "Exit";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FONT_COLOUR,
            this.FONT_STYLE});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // FONT_COLOUR
            // 
            this.FONT_COLOUR.Name = "FONT_COLOUR";
            this.FONT_COLOUR.Size = new System.Drawing.Size(224, 26);
            this.FONT_COLOUR.Text = "Font Colour";
            this.FONT_COLOUR.Click += new System.EventHandler(this.FONT_COLOUR_Click);
            // 
            // FONT_STYLE
            // 
            this.FONT_STYLE.Name = "FONT_STYLE";
            this.FONT_STYLE.Size = new System.Drawing.Size(224, 26);
            this.FONT_STYLE.Text = "Font Style";
            this.FONT_STYLE.Click += new System.EventHandler(this.ChangeFont);
            // 
            // BACKGROUND
            // 
            this.BACKGROUND.Name = "BACKGROUND";
            this.BACKGROUND.Size = new System.Drawing.Size(150, 24);
            this.BACKGROUND.Text = "Background Colour";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1188, 606);
            this.textBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 638);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FILE;
        private System.Windows.Forms.ToolStripMenuItem NEW;
        private System.Windows.Forms.ToolStripMenuItem OPEN;
        private System.Windows.Forms.ToolStripMenuItem SAVE;
        private System.Windows.Forms.ToolStripMenuItem SAVEAS;
        private System.Windows.Forms.ToolStripMenuItem EXIT;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FONT_COLOUR;
        private System.Windows.Forms.ToolStripMenuItem FONT_STYLE;
        private System.Windows.Forms.ToolStripMenuItem BACKGROUND;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

