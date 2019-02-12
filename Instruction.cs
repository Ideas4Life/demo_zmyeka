using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zmeya
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void Instruction_Paint(object sender, PaintEventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            label1.Text = "d, → - поворот вправо\na, ← - поворот вправо" +
                               "\nw, ↑ - поворот вправо;" +
                               "\ns, ↓ - поворот вправо;" +
                               "\nпробел - пауза/продолжить игру";
            //e.Graphics.DrawString("d, → - поворот вправо;" +
            //                      "\na, ← - поворот вправо;" +
            //                      "\nw, ↑ - поворот вправо;" +
            //                      "\ns, ↓ - поворот вправо;" +
            //                      "\nпробел - пауза/продолжить игру",
            //    new Font("Arial", 16, FontStyle.Regular), Brushes.White, new Point(10, 40));
        }
    }
}
