﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_6_B
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            List<string> vs = new List<string>();
            

            for(int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        vs.Add($"S {j + 1}");
                    }
                }
                else if (i == 1)
                {
                    for (int k = 0; k < 13; k++)
                    {
                        vs.Add($"H {k + 1}");
                    }
                }
                else if (i == 2)
                {
                    for (int l = 0; l < 13; l++)
                    {
                        vs.Add($"C {l + 1}");
                    }
                }
                else
                {
                    for (int m = 0; m < 13; m++)
                    {
                        vs.Add($"D {m + 1}");
                    }
                } 
            }

            for(int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

           List<string> results = new List<string> (vs.Except(list));

            for(int i = 0; i < results.Count;i++)
            {
                Console.WriteLine (results[i]);
            }

            
            
            


        }
    }
}