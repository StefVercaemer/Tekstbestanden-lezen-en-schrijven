﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    public enum Geslacht { M, V }

    public class Persoon
    {
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        public string Woonplaats { get; set; }
        public string Land { get; set; }
        public Geslacht Geslacht { get; set; }
        public int Leeftijd { get; set; }

        public override string ToString()
        {
            string aanspreking;
            string land;

            if (Geslacht == Geslacht.M)
            {
                aanspreking = "De heer"; 
            }
            else
            {
                aanspreking = "Mevrouw";
            }
            if (Land.Length >0)
            {
                land = Land.Substring(0, 1);
            }
            else
            {
                land = "";
            }

            return $"{aanspreking} {Voornaam} {Familienaam} uit {Woonplaats} ({land}) {Leeftijd} jaar";
        }

        public void Verjaar()
        {
            Leeftijd++;
        }

        public void Verhuis(string nieuweGemeente, string nieuwLand)
        {
            Woonplaats = nieuweGemeente.ToUpper();
            Land = nieuwLand;
        }
    }
}
