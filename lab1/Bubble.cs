using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Chernyshenko.lab1
{
    public class Bubble : Container
    {
        public Bubble(int size) : base(size){}

        public override string Foreach()
        {
            string res = String.Empty;
            for (int i=0;i<Mas.Length;i++)
            {
                res+= Math.Sqrt(Mas[i])+" ";
            }
            return res;
        }

        public override string Sort(Container mas)
        {
            int temp;
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas.Length; j++)
                {
                    if (Mas[i] > Mas[j])
                    {
                        temp = Mas[i];
                        Mas[i] = Mas[j];
                        Mas[j] = temp;
                    }
                }
            }
            string res = String.Empty;
            for (int i = 0; i < Mas.Length; i++)
            {
                res += Mas[i] + " ";
            }
            return res;      
        }
    }
}
