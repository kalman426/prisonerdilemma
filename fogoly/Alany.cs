using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fogoly
{
    class Alany
    {
        public int Strategy, Id;
        public int Cases = 0;
        public int chance;
        public List<int> Years = new List<int>();
        public double Average()
        {
            
            return (double)Years.Sum() / Years.Count;
        }
        Random rnd = new Random();

        public bool Decision()
        {
            if (Strategy == 0)
                return true;
            else if (Strategy == 1)
                return false;
            else if (Strategy == 2)
            {
                int v = rnd.Next(1, 100);

                if (v > chance)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public Alany(int strategy, int id)
        {
            this.Strategy = strategy;
            this.Id = id;
        }
        
        
    }
}
