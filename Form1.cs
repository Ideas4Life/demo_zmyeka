using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zmeya
{
    public partial class Form1 : Form
    {
        public static int NewBackColor;
        public static int NewBallColor;
        public static Image ColorImgBall;
        private Zmeya[] zm;
        private RandBall rBall;
        public int k;

        public Form1()
        {
            InitializeComponent();

            this.Icon=Properties.Resources.logo;
            zm = new Zmeya[5];
            for (int i = 0; i < zm.Length; i++)
            {
                zm[i] = new Zmeya(i);
            }
            rBall = new RandBall();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Zmeya.moving != false)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up: //вверх
                    {
                        if (zm[0]._turn != 'D')
                            zm[0]._turn = 'U';
                    }
                        break;
                    case Keys.W: //вверх
                    {
                        if (zm[0]._turn != 'D')
                            zm[0]._turn = 'U';
                    }
                        break;
                    case Keys.Down: //вниз
                    {
                        if (zm[0]._turn != 'U')
                            zm[0]._turn = 'D';
                    }
                        break;
                    case Keys.S: //вниз
                    {
                        if (zm[0]._turn != 'U')
                            zm[0]._turn = 'D';
                    }
                        break;
                    case Keys.Right: //вправо
                    {
                        if (zm[0]._turn != 'L')
                            zm[0]._turn = 'R';
                    }
                        break;
                    case Keys.D: //вправо
                    {
                        if (zm[0]._turn != 'L')
                            zm[0]._turn = 'R';
                    }
                        break;
                    case Keys.Left: //влево 
                    {
                        if (zm[0]._turn != 'R')
                            zm[0]._turn = 'L';
                    }
                        break;
                    case Keys.A: //влево 
                    {
                        if (zm[0]._turn != 'R')
                            zm[0]._turn = 'L';
                    }
                        break;
                    default: break;
                }
            }

            switch (e.KeyCode)
            {
                case Keys.Space: //пауза по пробелу 
                {
                    if (Zmeya.moving == true)
                    {
                        Zmeya.moving = false;
                        timer1.Stop();
                    }
                    else
                    {
                        Zmeya.moving = true;
                        timer1.Start();
                    }
                }
                    break;
                default: break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Zmeya zf in zm)
                e.Graphics.DrawImage(Form1.ColorImgBall, zf.RecZmeya);
            switch (Form1.NewBackColor)
            {
                case 1:
                {
                    greenMenu.Checked = true;
                    colorOfFonMenu.BackgroundImage= Properties.Resources.fon1;
                    colorOfBallMenu.BackgroundImage = Properties.Resources.fon1;
                    instructionMenu.BackgroundImage = Properties.Resources.fon1;
                        recordsMenu.BackgroundImage = Properties.Resources.fon1;
                    }
                    break;
                case 2:
                {
                    purpleMenu.Checked = true;
                    colorOfFonMenu.BackgroundImage = Properties.Resources.fon2;
                    colorOfBallMenu.BackgroundImage = Properties.Resources.fon2;
                    instructionMenu.BackgroundImage = Properties.Resources.fon2;
                        recordsMenu.BackgroundImage = Properties.Resources.fon2;
                    }
                    break;
                case 3:
                {
                    lilacMenu.Checked = true;
                    colorOfFonMenu.BackgroundImage = Properties.Resources.fon3;
                    colorOfBallMenu.BackgroundImage = Properties.Resources.fon3;
                    instructionMenu.BackgroundImage = Properties.Resources.fon3;
                        recordsMenu.BackgroundImage = Properties.Resources.fon3;
                    }
                    break;
                case 4:
                {
                    brownMenu.Checked = true;
                    colorOfFonMenu.BackgroundImage = Properties.Resources.fon4;
                    colorOfBallMenu.BackgroundImage = Properties.Resources.fon4;
                    instructionMenu.BackgroundImage = Properties.Resources.fon4;
                        recordsMenu.BackgroundImage = Properties.Resources.fon4;
                    }
                    break;
                case 5:
                {
                    turquoiseMenu.Checked = true;
                    colorOfFonMenu.BackgroundImage = Properties.Resources.fon5;
                    colorOfBallMenu.BackgroundImage = Properties.Resources.fon5;
                    instructionMenu.BackgroundImage = Properties.Resources.fon5;
                    recordsMenu.BackgroundImage = Properties.Resources.fon5;
                    }
                    break;
                default: break;
            }
            switch (Form1.NewBallColor)
            {
                case 1:
                    orangeMenuBall.Checked = true;
                    break;
                case 2:
                    greenMenuBall.Checked = true;
                    break;
                case 3:
                    darkRedMenuBall.Checked = true;
                    break;
                case 4:
                    blueMenuBall.Checked = true;
                    break;
                case 5:
                    brownMenuBall.Checked = true;
                    break;
                case 6:
                    redMenuBall.Checked = true;
                    break;
                default: break;
            }
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            Suicide();          //проверка на самопересечение
            Border(e.Graphics); //проверка на пересечение с краем формы
            Point(e.Graphics);  //ловля точки и увеличение змейки
        }


        public void Suicide()   //проверка на самопересечение
        {
            for (int i = 1; i < zm.Length; i++)
            {
                if (zm[0].RecZmeya.X == zm[i].RecZmeya.X && zm[0].RecZmeya.Y == zm[i].RecZmeya.Y)
                {
                    timer1.Enabled = false;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(" Желате сыграть ещё раз? ", " Вы проиграли ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Array.Resize<Zmeya>(ref zm, 5);
                        for (int j = 0; j < zm.Length; j++)
                        {
                            zm[j] = new Zmeya(j);
                        }
                        rBall = new RandBall();
                        timer1.Interval = 200;
                        scoreMenu.Text = "score: " + Convert.ToString(Zmeya.Score = 0);
                        timer1.Enabled = true;
                    }
                    else Application.Exit();
                }
            }
        }   

        public void Border(Graphics dc)     //проверка на пересечение с краем формы
        {
            Point pt1 = new Point(0, 30);
            Point pt2 = new Point(586, 30);
            Point pt3 = new Point(586, 452);
            Point pt4 = new Point(0, 452);
            Point[] ptMas = {pt1, pt2, pt3, pt4, pt1};
            dc.DrawLines(new Pen(Color.Black, 3), ptMas);
            Rectangle windows = new Rectangle(0, 24, 585, 421);
            if (!windows.Contains(zm[0].RecZmeya.X, zm[0].RecZmeya.Y))
            {
                timer1.Enabled = false;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(" Желате сыграть ещё раз? ", " Вы проиграли ", buttons);
                if (result == DialogResult.Yes)
                {
                    Array.Resize<Zmeya>(ref zm, 5);
                    for (int j = 0; j < zm.Length; j++)
                    {
                        zm[j] = new Zmeya(j);
                    }
                    rBall = new RandBall();
                    timer1.Interval = 200;
                    scoreMenu.Text = "score: " + Convert.ToString(Zmeya.Score = 0);
                    timer1.Enabled = true;
                }
                else Application.Exit();
            }
        }   

        public void Point(Graphics dc)  //ловля точки и увеличение змейки
        {
            if (rBall.rBl.IntersectsWith(zm[0].RecZmeya))
            {
                if (Zmeya.Score<50)
                {
                    Array.Resize<Zmeya>(ref zm, zm.Length + 1);
                    zm[zm.Length - 1] = new Zmeya(zm.Length);
                }
                rBall = new RandBall();
                dc.DrawImage(rBall.img, rBall.rBl);
                scoreMenu.Text = "score: " + Convert.ToString(++Zmeya.Score);
                if (timer1.Interval > 50)
                {
                    timer1.Interval -= 5;
                }

            }
            else dc.DrawImage(rBall.img, rBall.rBl);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = zm.Length - 1; i > 0; i--)
            {
                zm[i]._turn = zm[i - 1]._turn;
                zm[i].RecZmeya.X = zm[i - 1].RecZmeya.X;
                zm[i].RecZmeya.Y = zm[i - 1].RecZmeya.Y;
            }

            if (zm[0]._turn == 'R')
                zm[0].RecZmeya.X += Zmeya.dv;
            if (zm[0]._turn == 'L')
                zm[0].RecZmeya.X -= Zmeya.dv;
            if (zm[0]._turn == 'D')
                zm[0].RecZmeya.Y += Zmeya.dv;
            if (zm[0]._turn == 'U')
                zm[0].RecZmeya.Y -= Zmeya.dv;
            Invalidate();
        }

        private void MenuItemStart_Click(object sender, EventArgs e)    //кнопка старт
        {
            Zmeya.moving = true;
            timer1.Start();
        }

        private void MenuItemStop_Click(object sender, EventArgs e)     //кнопка стоп
        {
            Zmeya.moving = false;
            timer1.Stop();
        }

        private void newGameMenu_Paint(object sender, EventArgs e)      //кнопка новой игры
        {
            Form1_FormClosing(null,null);
            Form1_Load(null, null);
            Array.Resize (ref zm, 5);
            for (int j = 0; j < zm.Length; j++)
            {
                zm[j] = new Zmeya(j);
            }
            rBall = new RandBall();
            timer1.Interval = 200;
            scoreMenu.Text = "score: " + Convert.ToString(Zmeya.Score=0);
            timer1.Enabled = true;
            
        }

        //цвет шарика

        private void orangeMenuBall_Click(object sender, EventArgs e)
        {
            orangeMenuBall.Checked = true;
            switch (Form1.NewBallColor)
            {
                case 2:
                    greenMenuBall.Checked = false;
                    break;
                case 3:
                    darkRedMenuBall.Checked = false;
                    break;
                case 4:
                    blueMenuBall.Checked = false;
                    break;
                case 5:
                    brownMenuBall.Checked = false;
                    break;
                case 6:
                    redMenuBall.Checked = false;
                    break;
                default: break;
            }
            Form1.ColorImgBall = Properties.Resources.sharik1;
            Form1.NewBallColor = 1;
            Invalidate();
        }

        private void greenMenuIBall_Click(object sender, EventArgs e)       
        {
            greenMenuBall.Checked = true;
            switch (Form1.NewBallColor)
            {
                case 1:
                    orangeMenuBall.Checked = false;
                    break;
                case 3:
                    darkRedMenuBall.Checked = false;
                    break;
                case 4:
                    blueMenuBall.Checked = false;
                    break;
                case 5:
                    brownMenuBall.Checked = false;
                    break;
                case 6:
                    redMenuBall.Checked = false;
                    break;
                default: break;
            }
            Form1.ColorImgBall = Properties.Resources.sharik2;
            Form1.NewBallColor = 2;
            Invalidate();
        }

        private void darkRedMenuBall_Click(object sender, EventArgs e)
        {
            darkRedMenuBall.Checked = true;
            switch (Form1.NewBallColor)
            {
                case 1:
                    orangeMenuBall.Checked = false;
                    break;
                case 2:
                    greenMenuBall.Checked = false;
                    break;
                case 4:
                    blueMenuBall.Checked = false;
                    break;
                case 5:
                    brownMenuBall.Checked = false;
                    break;
                case 6:
                    redMenuBall.Checked = false;
                    break;
                default: break;
            }
            Form1.ColorImgBall = Properties.Resources.sharik3;
            Form1.NewBallColor = 3;
            Invalidate();
        }

        private void blueMenuBall_Click(object sender, EventArgs e)
        {
            blueMenuBall.Checked = true;
            switch (Form1.NewBallColor)
            {
                case 1:
                    orangeMenuBall.Checked = false;
                    break;
                case 2:
                    greenMenuBall.Checked = false;
                    break;
                case 3:
                    darkRedMenuBall.Checked = false;
                    break;
                case 5:
                    brownMenuBall.Checked = false;
                    break;
                case 6:
                    redMenuBall.Checked = false;
                    break;
                default: break;
            }
            Form1.ColorImgBall = Properties.Resources.sharik4;
            Form1.NewBallColor = 4;
            Invalidate();
        }

        private void brownMenuBall_Click(object sender, EventArgs e)
        {
            brownMenuBall.Checked = true;
            switch (Form1.NewBallColor)
            {
                case 1:
                    orangeMenuBall.Checked = false;
                    break;
                case 2:
                    greenMenuBall.Checked = false;
                    break;
                case 3:
                    darkRedMenuBall.Checked = false;
                    break;
                case 4:
                    blueMenuBall.Checked = false;
                    break;
                case 6:
                    redMenuBall.Checked = false;
                    break;
                default: break;
            }
            Form1.ColorImgBall = Properties.Resources.sharik5;
            Form1.NewBallColor = 5;
            Invalidate();
        }

        private void redMenuBall_Click(object sender, EventArgs e)
        {
            redMenuBall.Checked = true;
            switch (Form1.NewBallColor)
            {
                case 1:
                    orangeMenuBall.Checked = false;
                    break;
                case 2:
                    greenMenuBall.Checked = false;
                    break;
                case 3:
                    darkRedMenuBall.Checked = false;
                    break;
                case 4:
                    blueMenuBall.Checked = false;
                    break;
                case 5:
                    brownMenuBall.Checked = false;
                    break;
                default: break;
            }
            Form1.ColorImgBall = Properties.Resources.sharik6;
            Form1.NewBallColor = 6;
            Invalidate();
        }

        //изменение фона

        private void greenMenuFon_Click(object sender, EventArgs e)
        {
            greenMenu.Checked = true;
            switch (Form1.NewBackColor)
            {
                case 2: purpleMenu.Checked = false;
                    break;
                case 3: lilacMenu.Checked = false;
                    break;
                case 4: brownMenu.Checked = false;
                    break;
                case 5: turquoiseMenu.Checked = false;
                    break;
                default:break;
            }
            this.BackgroundImage = Properties.Resources.fon1;
            Form1.NewBackColor = 1;
        }

        private void purpleMenuFon_Click(object sender, EventArgs e)
        {
            purpleMenu.Checked = true;
            switch (Form1.NewBackColor)
            {
                case 1:
                    greenMenu.Checked = false;
                    break;
                case 3:
                    lilacMenu.Checked = false;
                    break;
                case 4:
                    brownMenu.Checked = false;
                    break;
                case 5:
                    turquoiseMenu.Checked = false;
                    break;
                default: break;
            }
            this.BackgroundImage = Properties.Resources.fon2;
            Form1.NewBackColor = 2;
        }

        private void lilacMenuFon_Click(object sender, EventArgs e)
        {
            lilacMenu.Checked = true;
            switch (Form1.NewBackColor)
            {
                case 1:
                    greenMenu.Checked = false;
                    break;
                case 2:
                    purpleMenu.Checked = false;
                    break;
                case 4:
                    brownMenu.Checked = false;
                    break;
                case 5:
                    turquoiseMenu.Checked = false;
                    break;
                default: break;
            }
            this.BackgroundImage = Properties.Resources.fon3;
            Form1.NewBackColor = 3;
        }

        private void brownMenuFon_Click(object sender, EventArgs e)
        {
            brownMenu.Checked = true;
            switch (Form1.NewBackColor)
            {
                case 1:
                    greenMenu.Checked = false;
                    break;
                case 2:
                    purpleMenu.Checked = false;
                    break;
                case 3:
                    lilacMenu.Checked = false;
                    break;
                case 5:
                    turquoiseMenu.Checked = false;
                    break;
                default: break;
            }
            this.BackgroundImage = Properties.Resources.fon4;
            Form1.NewBackColor = 4;
        }

        private void turquoiseMenuFon_Click(object sender, EventArgs e)
        {
            turquoiseMenu.Checked = true;
            switch (Form1.NewBackColor)
            {
                case 1:
                    greenMenu.Checked = false;
                    break;
                case 2:
                    purpleMenu.Checked = false;
                    break;
                case 3:
                    lilacMenu.Checked = false;
                    break;
                case 4:
                    brownMenu.Checked = false;
                    break;
                default: break;
            }
            this.BackgroundImage = Properties.Resources.fon5;
            Form1.NewBackColor = 5;
        }

        //закрытие формы

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.BackgrundColor = Form1.NewBackColor;
            Properties.Settings.Default.BallColor = Form1.NewBallColor;
            if (Zmeya.Score > Properties.Settings.Default.Score1)
            {
                Properties.Settings.Default.Score3 = Properties.Settings.Default.Score2;
                Properties.Settings.Default.Score2 = Properties.Settings.Default.Score1;
                Properties.Settings.Default.Score1 = Zmeya.Score;
            }
            if (Zmeya.Score < Properties.Settings.Default.Score1 && 
                    Zmeya.Score > Properties.Settings.Default.Score2)
            {
                Properties.Settings.Default.Score3 = Properties.Settings.Default.Score2;
                Properties.Settings.Default.Score2 = Zmeya.Score;
            }
            if (Zmeya.Score < Properties.Settings.Default.Score2 &&
                Zmeya.Score > Properties.Settings.Default.Score3)
                Properties.Settings.Default.Score3 = Zmeya.Score;
            Properties.Settings.Default.Save();
        }

        //загрузка сохраненных данных

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.NewBackColor = Properties.Settings.Default.BackgrundColor;
            switch (Form1.NewBackColor)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.fon1;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.fon2;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.fon3;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.fon4;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.fon5;
                    break;
                default: break;
            }
            Form1.NewBallColor = Properties.Settings.Default.BallColor;
            switch (Form1.NewBallColor)
            {
                case 1:
                    Form1.ColorImgBall = Properties.Resources.sharik1;
                    break;
                case 2:
                    Form1.ColorImgBall = Properties.Resources.sharik2;
                    break;
                case 3:
                    Form1.ColorImgBall = Properties.Resources.sharik3;
                    break;
                case 4:
                    Form1.ColorImgBall = Properties.Resources.sharik4;
                    break;
                case 5:
                    Form1.ColorImgBall = Properties.Resources.sharik5;
                    break;
                case 6:
                    Form1.ColorImgBall = Properties.Resources.sharik6;
                    break;
                default: break;
            }
            Properties.Settings.Default.Save();
        }

        private void recordsMenu_Click(object sender, EventArgs e)
        {
            Zmeya.moving = false;
            timer1.Stop();
            Records f2 = new Records();
            f2.ShowDialog();
            Zmeya.moving = true;
            timer1.Start();
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zmeya.moving = false;
            timer1.Stop();
            Records f2 = new Records();
            f2.ShowDialog();
            Zmeya.moving = true;
            timer1.Start();
        }

        private void instructionMenu_Click(object sender, EventArgs e)
        {
            Zmeya.moving = false;
            timer1.Stop();
            Instruction f2 = new Instruction();
            f2.ShowDialog();
            Zmeya.moving = true;
            timer1.Start();
        }
    }
}