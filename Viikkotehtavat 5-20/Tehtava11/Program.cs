using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava11
{
    class Program
    {
        //Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
        //*
        //**
        //***
        //****
        //*****

        //Käyttäjä antaa syötteenä tähtirivien lukumäärän.Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Anna luku: ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out numero);
            if (result)
            {
                int tähti = 1;
                for (int i = 0; i < numero; i++)
                {
                    for (int k = 0; k < tähti; k++)
                    {
                        Console.Write("*");
                    }
                    tähti++;
                    Console.WriteLine();
                }
            }
            
            Console.ReadLine();
        }
    }
}
