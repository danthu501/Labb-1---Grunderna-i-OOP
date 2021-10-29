using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Grunderna_i_OOP_ny
{
    class Triangel
    {
        public float _Width;
        public float _Height;

        public Triangel(float Width, float Height)
        {
            this._Width = Width;
            this._Height = Height;
        }
        public float AreaTriangel()
        {
            return _Width * _Height / 2;
        }
    }
}
