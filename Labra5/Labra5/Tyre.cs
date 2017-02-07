﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        //Constans and variables
        //Const on määritelty määrä
        private const int maxTyres = 4;
        private int countTyres;
        //properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyre[] Tyres { get; }
        public List<Tyre> Renkaat { get; }
        //contructors
        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
            
        }

        //methods
        public void Addtyre(Tyre tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyres[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", tyre.ToString(), this.Brand);
            }
            else
            {
                Console.WriteLine("Ei sovi enempää renkaita, sorry");
            }
        }
        //metodi jolla lisätään  listaan uusi rengas
        public void AddtyreToList(Tyre tyre)
        {

        }
        public override string ToString()
        {
            string retval = "Ajoneuvo valmistaja: " + Brand + "malli: " + Model + "\nrenkaat: ";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null)
                    {
                    retval += "\n" + tyre.ToString();
                }
            }
            return retval;
        }
    }
}
public class Tyre
{
    public string Branch { get; set; }
    
public string Size { get; set; }
    public override string ToString()
    {
        // return "Valmistaja: " + Branch + "koko" + Size;
        //ylempi tai alempi tapa
        return String.Format("Valmistaja on {0} koko on {1}", Branch, Size);
    }
}

