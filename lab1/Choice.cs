using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Chernyshenko.lab1
{
    public class Choice : Container
    {
        public Choice(int size) : base(size) {}

        public override string Foreach()
        {
            string res = string.Empty;
            foreach (var i in Mas)
            {
                res += Math.Log(i) + " ";
            }
            return res;
        }

        public override string Sort(Container mas)
        {
            for (int i = 0; i < Mas.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < Mas.Length; j++)
                {
                    if (Mas[j] < Mas[min])
                    {
                        min = j;
                    }
                }
                int temp = Mas[min];
                Mas[min] = Mas[i];
                Mas[i] = temp;
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
