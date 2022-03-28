using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fogoly
{
    class Szimulacio
    {
        static public List<Alany> Alanylista = new List<Alany>();
        int mennyiseg;
        Random rnd = new Random();



        public int setChance;

        public List<int> getYears(int i)
        {
            return Alanylista[i].Years;
        }


        public void Initialize(int k)
        {
            Alanylista.Clear();
            this.mennyiseg = k;
            int id = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < mennyiseg; j++)
                {
                    Alany a = new Alany(i, id);
                    a.chance = setChance;
                    Alanylista.Add(a);
                    id += 1;
                }
            }

        }
        public void Szimulal(Alany elso, Alany masodik)
        {
            bool ElsoAlany = elso.Decision();
            bool MasodikAlany = masodik.Decision();

            Alanylista[elso.Id].Cases++;
            Alanylista[masodik.Id].Cases++;

            switch (ElsoAlany)
            {
                case true when MasodikAlany == false:
                    Alanylista[elso.Id].Years.Add(3);
                    Alanylista[masodik.Id].Years.Add(0);
                    break;

                case true when MasodikAlany == true:
                    Alanylista[elso.Id].Years.Add(1);
                    Alanylista[masodik.Id].Years.Add(1);
                    break;

                case false when MasodikAlany == true:
                    Alanylista[elso.Id].Years.Add(0);
                    Alanylista[masodik.Id].Years.Add(3);
                    break;

                case false when MasodikAlany == false:
                    Alanylista[elso.Id].Years.Add(2);
                    Alanylista[masodik.Id].Years.Add(2);
                    break;
            }
            
        }
        public void Start(int Rounds)
        {
            for (int i = 0; i < Rounds; i++)
            {                
                List<Alany> tempList = new List<Alany>(Alanylista);    
                while(tempList.Count>0)
                {
                    int v = rnd.Next(0, tempList.Count - 1);
                    Alany tempElso = tempList[v];
                    tempList.RemoveAt(v);

                    v = rnd.Next(0, tempList.Count - 1);
                    Alany tempMasodik = tempList[v];
                    tempList.RemoveAt(v);

                    Szimulal(tempElso, tempMasodik);
                }               
            }
            Alanylista = Alanylista.OrderBy(a => a.Average()).ToList();
        }

        public string Result(int i)
        {
            
            var res = Alanylista[i];

            return "id: " + res.Id + " strategy: " + res.Strategy + ", átlag: " + res.Average();
        }

        public List<Tuple<int,int>> Positions()
        {
            List<Tuple<int, int>> x = new List<Tuple<int, int>>();

            for(int i = 0; i < Alanylista.Count; i++)
            {
                Tuple<int, int> t = new Tuple<int, int>(i, Alanylista[i].Id);
                x.Add(t);
            }
            return x;
            
        }
    }
}
