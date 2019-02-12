using System;
using System.Drawing;

namespace Zmeya
{
    class Zmeya //создание змейки
    {
        public static int Score = 0;
        public static bool moving;  //движется или стоит
        public Rectangle RecZmeya;  //координаты и размеры змейки
        public static int dv;       //скорость движения
        public char _turn;          //направление движения

        public Zmeya(int k)
        {
            moving = true;
            _turn = 'R';
            RecZmeya = new Rectangle(105 - k * 8, 105, 15, 15);
            dv = 8;
        }

    }
}
