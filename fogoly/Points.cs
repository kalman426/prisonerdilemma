using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace fogoly
{
    class Points
    {
        static List<Pont> PointList = new List<Pont>();

        

        public int GetX(int i)
        {
            return PointList[i].X;
        }

        public int GetY(int i)
        {
            return PointList[i].Y;
        }

        public Color GetColor(int i)
        {
            return PointList[i].szin;
        }

        public void Initialize(int count)
        {
            PointList.Clear();
            int id = 0;
            Color temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == 0)
                        temp = Color.Red;
                    else if (i == 1)
                        temp = Color.Blue;
                    else
                        temp = Color.Green;
                    Pont p = new Pont(temp, id);
                    PointList.Add(p);
                    id += 1;
                }
            }
            
        }

        public List<Tuple<int, int>> Positions = new List<Tuple<int, int>>();

        public void Fill()
        {
            for (int i = 0; i < PointList.Count; i++)
            {
                PointList[i].X = (PointList[i].Place % 30)*15;
                PointList[i].Y = (PointList[i].Place/30)*15;
            }
        }

        public void Refresh()
        {
            for (int i = 0; i < PointList.Count; i++)
            {
                for (int j = 0; j < Positions.Count; j++)
                {
                    if(PointList[i].Id == Positions[j].Item2)
                    {
                        PointList[i].Place = Positions[j].Item1;
                    }
                }
            }
        }
    }
}
