using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doodler
{
    public partial class Form1 : Form
    {
        private List<List<Point>> lines;
        private List<Color> lineColours;

        private bool IsOpen = false;
        private KeyHandler ghk;
        private Graphics g;
        private bool isPainting;
        private Pen pen;
        int lastX, lastY;
        int loops;

        public static Form1 Doodler
        {
            get
            {
                if (_doodler == null)
                    _doodler = new Form1();
                return _doodler;
            }
        }
        private static Form1 _doodler;

        public Form1()
        {
            InitializeComponent();
            lines = new List<List<Point>>();
            lineColours = new List<Color>();

            _doodler = this;

            Size = new Size((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
            DrawPanel.Size = Size;
            TransparencyKey = BackColor;
            pen = new Pen(Color.FromArgb(200, Color.Black), 5);
            DrawPanel.BackColor = Color.Transparent;
            g = DrawPanel.CreateGraphics();
            ghk = new KeyHandler(Keys.Scroll, this);
            ghk.Register();

            //Hide on startup
            BeginInvoke(new MethodInvoker(delegate
            {
                Hide();
            }));
        }

        private void StartDrawing(object sender, MouseEventArgs e)
        {
            lines.Add(new List<Point>());
            lineColours.Add(pen.Color);
            lastX = e.X;
            lastY = e.Y;
            isPainting = true;
        }

        private void StopDrawing(object sender, MouseEventArgs e)
        {
            isPainting = false;
        }

        private void Draw(object sender, MouseEventArgs e)
        {
            if (!isPainting)
                return;

            loops++;

            if (loops % 10 != 0)
                return;

            loops = 0;
            g = DrawPanel.CreateGraphics();

            g.DrawLine(pen, new Point(lastX, lastY), new Point(e.X, e.Y));
            lines[lines.Count-1].Add(new Point(e.X, e.Y));

            lastX = e.X;
            lastY = e.Y;
        }

        private void HandleHotkey()
        {
            if (IsOpen)
                Doodler.Hide();
            else
            {
                Doodler.Show();
                Redraw();
            }

            IsOpen = !IsOpen;
        }

        private void Redraw()
        {
            Color originalColour = pen.Color;
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Count <= 1)
                    continue;

                pen.Color = lineColours[i];
                g.DrawLines(pen, lines[i].ToArray());
            }
            pen.Color = originalColour;
        }

        private void ColourPicker(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                colourPicker.BackColor = c.Color;
                pen.Color = c.Color;
            }
        }

        private void CloseGame(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimiseButton(object sender, EventArgs e)
        {
            HandleHotkey();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
    }

    public static class Constants
    {
        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }
}
