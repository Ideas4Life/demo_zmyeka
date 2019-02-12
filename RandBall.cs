using System;
using System.Drawing;

namespace Zmeya
{
    class RandBall //рандомная точка
    {
        public Rectangle rBl;
        public int Number;
        public Image img;

        public RandBall()   //создание рандомного фрукта в произвольном месте
        {
            var randomX = new Random();
            var randomY = new Random();
            var randomN = new Random();
            rBl.X = randomX.Next(30, 552);
            rBl.Y = randomY.Next(30, 435);
            rBl.Height = rBl.Width = 25;
            Number = randomN.Next(1, 4);
            switch (Number)
            {
                case 1:
                    img = Properties.Resources.apple;
                    break;
                case 2:
                    img = Properties.Resources.orange;
                    break;
                case 3:
                    img = Properties.Resources.pear;
                    break;
                case 4:
                    img = Properties.Resources.pineapple;
                    break;
                default: break;
            }
        }
    }
}
