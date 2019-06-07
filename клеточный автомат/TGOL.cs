using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace клеточный_автомат
{
    public partial class TGOL : Form
    {
        public bool[] survive = { false, false, true, true, false, false, false, false, false };
        public bool[] come = { false, false, false, true, false, false, false, false, false };
        public bool cycleSpase = true;
        private bool[,] field;
        private int Width = 10, Height = 10;
        private bool play = false;
        private Thread mainThread;
        public Color cell = Color.Black;
        public Color space = Color.White;

        private Bitmap Draw()
        {
            if (picture.Width > 0)
            {
                Bitmap bmp = new Bitmap(Width * 20, Height * 20);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(space);
                Brush b = new SolidBrush(cell);
                for (int j = 0; j < Height; j++)
                    for (int i = 0; i < Width; i++)
                        if (field[i, j]) g.FillRectangle(b, i * 20, j * 20, 20, 20);
                return bmp;
            }
            return null;
        }
        private void ShowImage(Bitmap bmp)
        {
            Invoke((Action)(() => picture.Image = bmp));
        }
        private void Simulation()
        {
            while (play)
            {
                bool[,] copy = new bool[Width, Height];
                for (int j = 0; j < Height; j++)
                    for (int i = 0; i < Width; i++)
                    {
                        int t = CountNeighboard(i, j);
                        if (field[i, j] && survive[t]) copy[i, j] = true;
                        else if (!field[i, j] && come[t]) copy[i, j] = true;
                        else copy[i, j] = false;
                    }
                field = copy;
                ShowImage(Draw());
                GC.Collect();
            }
            AbortThread(ref mainThread);
        }
        private int CountNeighboard(int x, int y)
        {
            int k = 0;
            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                    if (!(i == 0 && j == 0))
                        if (cycleSpase && field[(x + i + Width) % Width, (y + j + Height) % Height]) k++;
                        else if (!cycleSpase && i + x >= 0 && j + y >= 0 && i + x < Width && j + y < Height && field[x + i, y + j]) k++;
            return k;
        }
        private void AbortThread(ref Thread thread)
        {
            Thread t = thread;
            thread = null;
            if (t != null)
                t.Abort();
        }
        private void StartThread(ref Thread thread, ThreadStart func)
        {
            if (thread == null)
            {
                thread = new Thread(func);
                thread.Start();
            }
        }
        private void NewField()
        {
            if (field == null || field.GetLength(0) != Width || field.GetLength(1) != Height)
                field = new bool[Width, Height];
        }

        public TGOL()
        {
            InitializeComponent();
        }
        private void TrackBarY_Scroll(object sender, EventArgs e)
        {
            labelY.Text = (Height = trackBarY.Value).ToString();
        }
        private void TrackBarX_Scroll(object sender, EventArgs e)
        {
            labelX.Text = (Width = trackBarX.Value).ToString();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (play)
            {
                start.Text = "start";
                play = false;
                Thread.Sleep(50);
                random.Enabled = delete.Enabled = settings.Enabled = trackBarX.Enabled = trackBarY.Enabled = true;
            }
            else
            {
                start.Text = "stop";
                random.Enabled = delete.Enabled = settings.Enabled = trackBarX.Enabled = trackBarY.Enabled = false;
                NewField();
                play = true;
                StartThread(ref mainThread, Simulation);
            }
        }
        private void Random_Click(object sender, EventArgs e)
        {
            NewField();
            Random rand = new Random();
            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Width; i++)
                    if (rand.Next(8) == 0) field[i, j] = true;
                    else field[i, j] = false;
            picture.Image = Draw();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            NewField();
            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Width; i++)
                    field[i, j] = false;
            picture.Image = Draw();
        }
        private void TGOL_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortThread(ref mainThread);
        }
        private void settings_Click(object sender, EventArgs e)
        {
            settings s = new settings(this);
            s.ShowDialog();
        }
    }
}
