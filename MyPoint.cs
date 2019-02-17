using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecthadash
{
    internal class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        internal int getx()
        {
            return _x;
        }
        internal int gety()
        {
            return _y;
        }
        internal void setx(int x)
        {
            if (x >= 0 && x <= Mycanvas.Max_Width)
            {
                _x = x;
            }
            else
            {
                Console.WriteLine("$x value of {X} is invalid!");
            }

        }

         internal void sety(int y)
        {
            if (y >= 0 && y <= Mycanvas.Max_Height)
            {
                _y = y;
            }

            else
            {
                Console.WriteLine("$y value of {y} is invalid!");
            }
        }
            

                public override string ToString()
         {
            return $" Point ( { this._x } , { this._y } )";
        }

       
    }
}
