﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyFile file1 = new MyFile("picture.txt",
                @"C:\users\bwood\",
                Rights.READABLE,
                null);

            // Is file1 readable?

            Console.WriteLine(file1.FileRights);


        }
    }
}
