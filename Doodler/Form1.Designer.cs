
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
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.colourPicker = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.Maroon;
            this.DrawPanel.Controls.Add(this.Minimize);
            this.DrawPanel.Controls.Add(this.colourPicker);
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
            // colourPicker
            // 
            this.colourPicker.BackColor = System.Drawing.Color.Black;
            this.colourPicker.Location = new System.Drawing.Point(12, 42);
            this.colourPicker.Name = "colourPicker";
            this.colourPicker.Size = new System.Drawing.Size(24, 24);
            this.colourPicker.TabIndex = 1;
            this.colourPicker.TabStop = false;
            this.colourPicker.Click += new System.EventHandler(this.ColourPicker);
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
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(826, 545);
            this.Controls.Add(this.DrawPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.DrawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colourPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox colourPicker;
        private System.Windows.Forms.PictureBox Minimize;
    }
}

