
namespace Doodler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.yellow = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            this.white = new System.Windows.Forms.PictureBox();
            this.silver = new System.Windows.Forms.PictureBox();
            this.grey = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.PictureBox();
            this.ColourBox = new System.Windows.Forms.PictureBox();
            this.bin = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.colour_Picker = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colour_Picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.Maroon;
            this.DrawPanel.Controls.Add(this.yellow);
            this.DrawPanel.Controls.Add(this.green);
            this.DrawPanel.Controls.Add(this.blue);
            this.DrawPanel.Controls.Add(this.red);
            this.DrawPanel.Controls.Add(this.white);
            this.DrawPanel.Controls.Add(this.silver);
            this.DrawPanel.Controls.Add(this.grey);
            this.DrawPanel.Controls.Add(this.black);
            this.DrawPanel.Controls.Add(this.ColourBox);
            this.DrawPanel.Controls.Add(this.bin);
            this.DrawPanel.Controls.Add(this.Minimize);
            this.DrawPanel.Controls.Add(this.colour_Picker);
            this.DrawPanel.Controls.Add(this.close);
            this.DrawPanel.Location = new System.Drawing.Point(0, 0);
            this.DrawPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(764, 1000);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDrawing);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopDrawing);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(138, 117);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(35, 35);
            this.yellow.TabIndex = 13;
            this.yellow.TabStop = false;
            this.yellow.Click += new System.EventHandler(this.ChangeColour);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.Location = new System.Drawing.Point(97, 117);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(35, 35);
            this.green.TabIndex = 12;
            this.green.TabStop = false;
            this.green.Click += new System.EventHandler(this.ChangeColour);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(56, 117);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(35, 35);
            this.blue.TabIndex = 11;
            this.blue.TabStop = false;
            this.blue.Click += new System.EventHandler(this.ChangeColour);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(15, 117);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(35, 35);
            this.red.TabIndex = 10;
            this.red.TabStop = false;
            this.red.Click += new System.EventHandler(this.ChangeColour);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.white.Location = new System.Drawing.Point(138, 76);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(35, 35);
            this.white.TabIndex = 9;
            this.white.TabStop = false;
            this.white.Click += new System.EventHandler(this.ChangeColour);
            // 
            // silver
            // 
            this.silver.BackColor = System.Drawing.Color.LightGray;
            this.silver.Location = new System.Drawing.Point(97, 76);
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(35, 35);
            this.silver.TabIndex = 8;
            this.silver.TabStop = false;
            this.silver.Click += new System.EventHandler(this.ChangeColour);
            // 
            // grey
            // 
            this.grey.BackColor = System.Drawing.Color.DimGray;
            this.grey.Location = new System.Drawing.Point(56, 76);
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(35, 35);
            this.grey.TabIndex = 7;
            this.grey.TabStop = false;
            this.grey.Click += new System.EventHandler(this.ChangeColour);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(15, 76);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(35, 35);
            this.black.TabIndex = 6;
            this.black.TabStop = false;
            this.black.Click += new System.EventHandler(this.ChangeColour);
            // 
            // ColourBox
            // 
            this.ColourBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ColourBox.Location = new System.Drawing.Point(12, 74);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(165, 80);
            this.ColourBox.TabIndex = 5;
            this.ColourBox.TabStop = false;
            // 
            // bin
            // 
            this.bin.BackColor = System.Drawing.Color.Maroon;
            this.bin.Image = global::Doodler.Properties.Resources.Bin;
            this.bin.Location = new System.Drawing.Point(42, 42);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(24, 24);
            this.bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bin.TabIndex = 4;
            this.bin.TabStop = false;
            this.bin.Click += new System.EventHandler(this.Clear);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Maroon;
            this.Minimize.Image = global::Doodler.Properties.Resources.Minus;
            this.Minimize.Location = new System.Drawing.Point(42, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 3;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.MinimiseButton);
            // 
            // colour_Picker
            // 
            this.colour_Picker.BackColor = System.Drawing.Color.Black;
            this.colour_Picker.Location = new System.Drawing.Point(12, 42);
            this.colour_Picker.Name = "colour_Picker";
            this.colour_Picker.Size = new System.Drawing.Size(24, 24);
            this.colour_Picker.TabIndex = 1;
            this.colour_Picker.TabStop = false;
            this.colour_Picker.Click += new System.EventHandler(this.ColourPopup);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Maroon;
            this.close.Image = global::Doodler.Properties.Resources.Close;
            this.close.Location = new System.Drawing.Point(12, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.CloseGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.DrawPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.DrawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colour_Picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox colour_Picker;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox bin;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.PictureBox ColourBox;
        private System.Windows.Forms.PictureBox grey;
        private System.Windows.Forms.PictureBox silver;
        private System.Windows.Forms.PictureBox white;
        private System.Windows.Forms.PictureBox yellow;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox red;
    }
}

