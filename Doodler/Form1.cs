using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


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
        static string filePosition;

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


        private Control[] colourObjects;

        public Form1()
        {
            InitializeComponent();
            colourObjects = new Control[]
            {
                black, grey, silver, white,
                red, blue, green, yellow,
            };

            lines = new List<List<Point>>();
            lineColours = new List<Color>();

            _doodler = this;

            Size = new Size((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight);
            DrawPanel.Size = Size;
            TransparencyKey = BackColor;
            pen = new Pen(ColourOf("black"), 2.5f);
            DrawPanel.BackColor = Color.Transparent;
            g = DrawPanel.CreateGraphics();
            ghk = new KeyHandler(Keys.Scroll, this);
            ghk.Register();

            //TopMost = true;

            filePosition = Environment.ExpandEnvironmentVariables(@"%appdata%\Doodler");

            if (!Directory.Exists(filePosition))
                Directory.CreateDirectory(filePosition);

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

            //if (loops % 10 != 0)
             //   return;

            loops = 0;
            g = DrawPanel.CreateGraphics();

            g.DrawLine(pen, new Point(lastX, lastY), new Point(e.X, e.Y));
            lines[lines.Count - 1].Add(new Point(e.X, e.Y));

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
                colour_Picker.BackColor = c.Color;
                pen.Color = c.Color;
            }
        }

        private void CloseGame(object sender, EventArgs e)
        {
            SaveCurrent(GetFilename());
            Close();
        }

        private void MinimiseButton(object sender, EventArgs e)
        {
            HandleHotkey();
        }

        private void Clear(object sender, EventArgs e)
        {
            SaveCurrent("");

            Invalidate();
            lines = new List<List<Point>>();
            lineColours = new List<Color>();
        }

        private void SaveCurrent(string position)
        {
            if (position == "")
                position = GetFilename();

            position = position.Replace(@"\\", @"\");

            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }

                string fullpath = position;

                bitmap.Save(fullpath, ImageFormat.Png);
            }

            //ScreenCapture sc = new ScreenCapture();

            //sc.CaptureWindowToFile(this.Handle, position, ImageFormat.Png);

            // Save the result.

            //SaveImage(bm, position == "" ? GetFilename() : position);
        }

        private string GetFilename()
        {
            return filePosition + @"\" + DateTime.Now.ToString("u").Replace(" ", ".").Replace(":", ".") + ".png";
        }

        public void SaveImage(Image image, string filename)
        {
            string extension = Path.GetExtension(filename);
            switch (extension.ToLower())
            {
                case ".bmp":
                    image.Save(filename, ImageFormat.Bmp);
                    break;
                case ".exif":
                    image.Save(filename, ImageFormat.Exif);
                    break;
                case ".gif":
                    image.Save(filename, ImageFormat.Gif);
                    break;
                case ".jpg":
                case ".jpeg":
                    image.Save(filename, ImageFormat.Jpeg);
                    break;
                case ".png":
                    image.Save(filename, ImageFormat.Png);
                    break;
                case ".tif":
                case ".tiff":
                    image.Save(filename, ImageFormat.Tiff);
                    break;
                default:
                    image.Save(filename + ".png", ImageFormat.Png);
                    break;
            }
        }

        private void ChangeColour(object sender, EventArgs e)
        {
            pen.Color = ColourOf(((Control)sender).Name);
            ColourBox.Hide();

            for (int i = 0; i < colourObjects.Length; i++)
            {
                colourObjects[i].Hide();
            }

            colour_Picker.BackColor = pen.Color;
        }

        private Color ColourOf(string colour)
        {
            switch (colour)
            {
                default:
                    return pen.Color;
                case "black":
                    return Color.FromArgb(100, Color.Black);
                case "grey":
                    return Color.FromArgb(200, Color.Gray);
                case "silver":
                    return Color.FromArgb(200, Color.LightGray);
                case "white":
                    return Color.FromArgb(200, Color.White);
                case "red":
                    return Color.FromArgb(200, Color.Red);
                case "blue":
                    return Color.FromArgb(200, Color.Blue);
                case "green":
                    return Color.FromArgb(200, Color.Green);
                case "yellow":
                    return Color.FromArgb(200, Color.Yellow);
            }
        }

        private void ColourPopup(object sender, EventArgs e)
        {
            ColourBox.Show();

            for (int i = 0; i < colourObjects.Length; i++)
            {
                colourObjects[i].Show();
            }
        }

        private void SaveButton(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                SaveCurrent(file.FileName);
            }
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
