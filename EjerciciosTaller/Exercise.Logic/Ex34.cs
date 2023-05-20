using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Logic
{
    public class Ex34
    {
        private int[,] _watch; 

        public int N { get; }
        
        public Ex34(int _n)
        {
            N = _n;
            _watch = new int[_n, _n];
            
        }

        public void Fill()
        {            
            
            var count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _watch[i, j] = count;
                    count++;
                }
                count -= 9;         
            }

        }
        public string Hourglass()
        {
            var _n = N;
            var output = string.Empty;
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (i <= _n / 2)
                    {
                        if (j >= i && j < _n - i)
                        {
                            output += $"{_watch[i, j]}\t";

                        }
                        else
                        {
                            output += "\t";
                        }

                    }
                    else
                    {
                        if (j >= _n - i - 1 && j <= i)
                        {
                            output += $"{_watch[i, j]}\t";
                        }
                        else
                        {
                            output += "\t";
                        }

                    }
                }
                output += "\n";
            }
            return output;

        }
        public override string ToString()
        {
            var outputA = string.Empty;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    outputA += $"{_watch[i, j]}\t";
                }
                outputA += "\n";

            }

            return $"{outputA}";
        }

    }
}
