using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szavak
{
    class szavak
    {
        static int tomb = File.ReadAllLines("szoveg.txt").Length;
        static string[] mindenszo = new string[tomb];

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("szoveg.txt");
            for (int i = 0; i < tomb; i++)
            {
                mindenszo[i] = sr.ReadLine();
            }
            sr.Close();

            char[] maganhangzok = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("1.feladat:");
            Console.WriteLine("Adjon meg egy szót!");
            string tartalmaze = (Console.ReadLine());

            int a = 0;


            for (int i = 0; i < maganhangzok.Length; i++)
            {

                if (tartalmaze.Contains(maganhangzok[i]))
                {
                    a++;
                }


            }
            if (a > 0)
            {
                Console.WriteLine("van benne magánhangzó");
            }
            else
            {
                Console.WriteLine("nincs benne magánhangzó");
            }

            int b = 0;
            string szo = "";
            char[] osszesbetu = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("2.feladat.");
            for (int i = 0; i < mindenszo.Length; i++)
            {
                if (mindenszo[i].Length > b)
                {
                    b = mindenszo[i].Length;
                    szo = mindenszo[i];
                }
            }
            Console.WriteLine(b);
            Console.WriteLine(szo);

            Console.WriteLine("3. feladat:");
            List<string> mghSzavak = new List<string>();
            //Hibás a lista ;)
            List<char> mshgLista = new List<char>{ 'a', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            List<char> mghLista = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < mindenszo.Length; i++)
            {
                char[] betuk = mindenszo[i].ToCharArray();
                int mghSzamlalo = 0;
                int mshgSzamlalo = 0;

                for (int j = 0; j < osszesbetu.Length; j++)
                {

                    for (int k = 0; k < betuk.Length; k++)
                    {
                        if (osszesbetu[j] == betuk[k])
                        {
                            if (mghLista.Contains(osszesbetu[j])){
                                mghSzamlalo++;
                            } else {
                                mshgSzamlalo++;
                            }
                            
                        }
                    }
                }

                if (mghSzamlalo > mshgSzamlalo)
                {
                    mghSzavak.Add(mindenszo[i] + " ");
                }
                
            }

            double szazalek = (mghSzavak.Count / mindenszo.Length) * 100;
            mghSzavak.ForEach(Console.Write);
            Console.WriteLine("\n" + mghSzavak.Count + "/" + mindenszo.Length + " : " + szazalek );
            


            




            Console.ReadKey();
        }
    }
}
