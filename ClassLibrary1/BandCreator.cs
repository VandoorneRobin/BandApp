using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public static class BandCreator
    {
        static BandCreator()
        {

        }

        public static List<Band> StartUp()
        {
            return new List<Band>()
            {
                new Band(){
                    Naam = "Kraantje Pappie",
                    Jaar = 2008,
                    Leden = new List<BandLid>()
                        {
                            new BandLid() {Naam="Kraantje Pappie", Geslacht=Geslacht.Man, Leeftijd = 29, Levend= true}
                        }
                },new Band() { Naam="The Beatles", Jaar=1960,
                    Leden = new List<BandLid>()
                        {
                            new BandLid() { Naam="George", Geslacht=Geslacht.Man, Leeftijd=55, Levend=false },
                            new BandLid() { Naam="Ringo", Geslacht=Geslacht.Man, Leeftijd=64, Levend=true },
                            new BandLid() { Naam="Paul", Geslacht=Geslacht.Man, Leeftijd=76, Levend=true },
                            new BandLid() { Naam="John", Geslacht=Geslacht.Man, Leeftijd=35, Levend=false }
                        }
                },
                new Band() { Naam="Nicole & Hugo", Jaar=1302,
                    Leden = new List<BandLid>()
                        {
                            new BandLid() { Naam="Nicole", Geslacht=Geslacht.Vrouw, Leeftijd=105, Levend=true },
                            new BandLid() { Naam="Hugo", Geslacht=Geslacht.Man, Leeftijd=103, Levend=true },
                        }
                }
            };
        }
    }
}
