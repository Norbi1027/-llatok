﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace állatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emlosok> emlosok = new List<Emlosok>();
            emlosok.Add(new Macska("cirmi",2.1,"kandúr"));
            emlosok.Add(new Kutya("Bodri", 5.2, "Kan"));
            emlosok.Add(new Macska("Szerénke",1.3,"nőstény"));

            foreach (var item in emlosok)
            {
                Console.WriteLine($"{item} - {item.faj}");
            }
            
            Console.ReadKey();
        }
    }
}
