using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vb2018
{
    class Program
    {
        public static List<Stadionok> stadion = new List<Stadionok>();
        public static string be="";
        public static void beolv(string f_neve)
        {

            FileStream f = new FileStream(@f_neve, FileMode.Open);
            StreamReader r = new StreamReader(f,Encoding.Default);
            r.ReadLine();
            while (!r.EndOfStream)
            {
                string[] t = r.ReadLine().Split(';');
                stadion.Add(new Stadionok(t[0], t[1], t[2], int.Parse(t[3])));
            }
            r.Close();
            f.Close();
        }
        public static void f4()
        {
            Console.WriteLine("4. feladat: A legkevesebb férőhely: ");
            string[] t = {"",""};
            int min = int.MaxValue;
            foreach (Stadionok s in stadion)
                if (s.f_hely < min)
                {
                    min = s.f_hely;
                    t[0] = s.varos;
                    t[1] = s.nev1;
                }
            Console.WriteLine("Varos: "+t[0]+"\n\tStadion: "+t[1]+"\n\tFérőhely: "+min);

        }
        public static void f5()
        {
            double avg = 0;
            int sum = 0;
            foreach (Stadionok s in stadion) sum += s.f_hely;
            avg = (double)sum / stadion.Count;
            Console.WriteLine("5. feladat: Átlagos férőhelyszám: "+Math.Round(avg,1));
        }
        public static void f6()
        {
            int c = 0;
            foreach (Stadionok s in stadion) if (s.nev2 != "n.a.") c++;
            Console.WriteLine("6. feladat: Két néven is ismert stadionok száma: "+c);
        }
        public static void f7()
        {
            while (be.Length <2)
            {
                Console.Write("7. feladat: Kérem a város nevét: ");
                be = Console.ReadLine();
            }
        }
        public static void f8()
        {
            if (stadion.Exists(x => x.varos.ToLower() == be.ToLower()))
                Console.WriteLine("8. feladat: A megadott város VB helyszín.");
            else
                Console.WriteLine("8. feladat: A megadott város NEM VB helyszín.");
        }
        public static void f9()
        {
            List<string> varosok = new List<string>();
            foreach (Stadionok s in stadion) if (!varosok.Contains(s.varos)) varosok.Add(s.varos);
            Console.WriteLine("9. feladat: "+varosok.Count+" különböző városban voltak mérkőzések");
        }
        static void Main(string[] args)
        {
            beolv("vb2018.txt");
            Console.WriteLine("3. feladat: Stadionok száma: "+stadion.Count);
            f4();
            f5();
            f6();
            f7();
            f8();
            f9();
            Console.ReadKey();
        }
    }
}
