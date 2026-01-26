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


            
            
        }
    }
}
