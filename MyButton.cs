using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecthadash
{
    internal class MyButton
    {
        protected Point _topleft;
        protected Point _bottomright;

        private int _width;
        private int _height;



        internal MyButton(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
        }
        internal int Getwidth()
        {
            return _width;
        }
        internal int gethight()
        {
            return _width;
        }
        internal Point getbottoright()
        {
            return _bottomright;
        }
        private void updatewidthandheight()
        {
            this._width = _bottomright.getx() - _topleft.getx();
            this._height = _bottomright.gety() - _topleft.gety();
        }

        internal bool setbottomright(Point br)
        {
            if (br.getx() < this._topleft.getx() || br.gety() < this._topleft.gety())
            {
                return false;
            }
            this._bottomright = br;
            this.updatewidthandheight();
            return true;
        }

        internal bool settopleft (Point tl)
        {
            if (tl.getx() > this._bottomright.getx() || tl.gety() > this._bottomright.gety())
            {
                return false;
            }
            this._topleft = tl;
            this.updatewidthandheight();
            return true;
        }
        public override string ToString()
        {
            return $"button topleft : {this._topleft}, bottomright : { this._bottomright } , width : {this._width}, height: {this._height}";


        }

    }
}
