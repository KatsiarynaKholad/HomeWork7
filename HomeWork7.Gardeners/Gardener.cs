using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7.Gardeners
{
    public class Gardener
    {
        private int[,] Field { get; set; }

        public Gardener(int[,] array)
        {
            Field = array;     
        }

        private void DoGardener()
        {
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    if (Field[i, j] == 0)
                    {
                        Field[i, j] = 1;
                        Thread.Sleep(10);
                    }
                }
            }
        }

        private void DoSecondGardener()
        {
            for (int i = Field.GetLength(1)-1; i> 0 ; i--)
            {
                for (int j = Field.GetLength(0)-1; j > 0 ; j--)
                {
                    if (Field[j,i] == 0)
                    {
                        Field[j,i] = 2;
                        Thread.Sleep(10);
                    }
                }
            }
        }

        public void CreateThreads()
        {
            Thread th1 = new Thread(DoGardener);
            Thread th2 = new Thread(DoSecondGardener);
            
            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();
        }
    }
}