using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace fogoly
{
    class Pont
    {
        public int X, Y;
        public int Id;
        public int Place;
        public Color szin;


        public Pont(Color sz, int id)
        {
            this.szin = sz;
            this.Id = id;
        }

    }
}
