using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Chernyshenko.lab1
{
    public abstract class Container
    {
        public int[] Mas { get; set; }
        public Container(int size)
        {
            Mas = new int[size];
            Random random = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = random.Next(10, 100);
            }
        }
        public String Print()
        {
            string res = String.Empty;
            foreach (int i in Mas)
            {
                res += i + " ";
            }
            return res;
        }
        public abstract string Sort(Container mas);
        public abstract string Foreach();
    }
}
