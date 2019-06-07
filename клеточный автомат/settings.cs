using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace клеточный_автомат
{
    public partial class settings : Form
    {
        TGOL f;
        CheckBox[] survives;
        CheckBox[] comeAts;
        Color cell;
        Color space;

        private void FillPictureBox(Color c, PictureBox p)
        {
            Bitmap b = new Bitmap(p.Width, p.Height);
            Graphics g = Graphics.FromImage(b);

            g.Clear(c);
            p.Image = b;
        }

        public settings(TGOL form)
        {
            InitializeComponent();
            f = form;
            CheckBox[] survives = { survive0, survive1, survive2, survive3, survive4, survive5, survive6, survive7, survive8 };
            this.survives = survives;
            CheckBox[] comeAts = { come0, come1, come2, come3, come4, come5, come6, come7, come8 };
            this.comeAts = comeAts;
            for(int i = 0; i < survives.Length; i++)
            {
                survives[i].Checked = f.survive[i];
                comeAts[i].Checked = f.come[i];
            }
            cycle.Checked = f.cycleSpase;
            cell = f.cell;
            space = f.space;
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            FillPictureBox(cell, ColorLife);
            FillPictureBox(space, ColorSpase);
        }
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < survives.Length; i++)
            {
                f.survive[i] = survives[i].Checked;
                f.come[i] = comeAts[i].Checked;
            }
            f.cell = cell;
            f.space = space;
            f.cycleSpase = cycle.Checked;
        }
        private void ColorLife_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK) cell = colorDialog1.Color;
            FillPictureBox(cell, ColorLife);
        }
        private void ColorSpase_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK) space = colorDialog1.Color;
            FillPictureBox(space, ColorSpase);
        }
    }
}
