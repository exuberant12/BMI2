using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    /*
     * Név;Életkor;Magasság;Testsúly
       Kiss Péter;16;175;68
    */

    public class Diak
    {
        public string Név { get; set; }
        public int Életkor { get; set; }
        public int Magasság { get; set; }
        public int Testsúly { get; set; }

        public Diak(string név, int életkor, int magasság, int testsúly)
        {
            Név = név;
            Életkor = életkor;
            Magasság = magasság;
            Testsúly = testsúly;
        }

        public override string? ToString()
        {
            return $"{Név} {Életkor}éves {Magasság}cm {Testsúly}kg";
        }

        public string bmi()
        {
            double magassagm = Magasság / 100.0;
            double bmi = Testsúly / (magassagm * magassagm);
            if (bmi < 18.5)
            {
                return "sovány";
            }
            else if (bmi < 24.9)
            {
                return "normál";
            }
            else if (bmi < 29.9)
            {
                return "túlsúlyos";
            }
            else
            {
                return "elhízott";
            }
        }
    }
}
