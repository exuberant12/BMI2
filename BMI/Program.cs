namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diak> list = new List<Diak>();
            var sorok = File.ReadAllLines("BMI.txt"
                ,System.Text.Encoding.Latin1).Skip(1);
            foreach (var sor in sorok)
            {
                Console.WriteLine(sor);
                string[] darabok =sor.Split(';');
                string név = darabok[0];
                int életkor = int.Parse(darabok[1]);
                int magasság = int.Parse(darabok[2]);
                int testsúly = int.Parse(darabok[3]);
                Diak d=new Diak(név, életkor, magasság, testsúly);
                list.Add(d);
            }
            Console.Clear();
            foreach (var d in list)
            {
                Console.WriteLine( );
                Console.WriteLine(d);
            }
            Console.WriteLine($"3. a, Feladat: A diákok száma: {list.Count}");


            Diak legmagasabb = list[0];
            foreach (var d in list)
            {
                if (d.Magasság > legmagasabb.Magasság)
                {
                    legmagasabb = d;
                }
            }
            Console.WriteLine($"3. b, Feladat: A legmagasabb diák: {legmagasabb.Név}, " +
                $"{legmagasabb.Magasság} cm");


            foreach (var d in list)
            {
                    Console.WriteLine(d.Név+":"+d.bmi() );
            }


            double atlag = 0;
            foreach (var d in list)
            {
                atlag += d.Testsúly;
            }
            atlag /= list.Count;
            Console.WriteLine($"5. a, feladat átlagos testsúly: " + $"{atlag:F1} kg");



            int egeszsegesDb = 0;
            foreach (var d in list)
            {
                if (d.bmi() == "normál")
                {
                    egeszsegesDb++;
                }
            }

            Console.WriteLine($"5. b, feladat: Egészséges BMI-jű diákok száma: {egeszsegesDb}");

            bool vanTothEva = false;

            foreach (var d in list)
            {
                if (d.Név == "Tóth Éva")
                {
                    vanTothEva = true;
                    break;
                }
            }


            if (vanTothEva)
                Console.WriteLine("5. c, feladat: Van Tóth Éva a diákok között");
            else
                Console.WriteLine("5. c, feladat: Nincs Tóth Éva a diákok között");

            Console.ReadKey();

            string fajlba = "Név; BMI/n";
            foreach (var d in list)
            {
                double magassagm = d.Magasság / 100.0;
                double BMI = d.Testsúly / (magassagm * magassagm);

                fajlba += $"{d.Név};{BMI:F1}\n";
            }
            File.WriteAllText("egeszseges_diakok.txt", fajlba);
        }
    }
}
