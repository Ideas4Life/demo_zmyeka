using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zmeya
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.logo;
            this.BackgroundImage = Properties.Resources.fon5;
            this.Text = "Records";
            Invalidate();
        }

        private void Records_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            e.Graphics.DrawString("1 место: " + Convert.ToString(Properties.Settings.Default.Score1) +
                                  "\n2 место: " + Convert.ToString(Properties.Settings.Default.Score2) +
                                  "\n3 место: " + Convert.ToString(Properties.Settings.Default.Score3),
                new Font("Arial", 26, FontStyle.Regular), Brushes.White, new Point(10, 40));
        }
    }
}
