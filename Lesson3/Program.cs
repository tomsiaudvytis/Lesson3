using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            var listas = new List<int>()
            {
                1,2,3,4,5,6,7,8
            };

            var list2 = listas.Take(5);


            #region NamuUzduotys
            //Console.WriteLine("iveskite zodi");
            //string zodis = Console.ReadLine();
            //int count = zodis.Length;

            //char[] array = zodis.ToCharArray();
            //Console.Write(zodis[count - 1]);
            //for (int i = 1; i < count - 1; i++)
            //{
            //    Console.Write(zodis[i]);
            //};
            //Console.Write(zodis[0]);

            //Console.WriteLine("Iveskite zodi");
            //string zodis = Console.ReadLine();
            //string pirmaRaide = zodis.Substring(0, 1);
            //string paskutineRaide = zodis.Substring(zodis.Length - 1);
            //string beraidziu = zodis.Substring(1, zodis.Length - 2);
            //Console.WriteLine("Sukeitus pirma ir paskutine zodzio raides, naujas zodis bus " + paskutineRaide + beraidziu + pirmaRaide);

            //int day = (int)DateTime.Now.DayOfWeek;
            //int iki5 = 5 - day;
            //if (day == 5)
            //{
            //    Console.Write("siandien penktadienis");
            //}
            //if (day == 6)
            //{
            //    Console.Write("iki penktadienio liko 6 dienos");
            //}
            //if (day == 7)
            //{
            //    Console.Write("iki penktadienio liko 5 dienos");
            //}
            //else
            //{
            //    Console.WriteLine($"iki penktadienio liko {iki5} dienos");
            //}
            //Console.ReadLine();

            //var dayOfWeek = DateTime.Now.DayOfWeek;

            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Iki penktadienio liko 5");
            //        break;
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("Iki penktadienio liko 4");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine("Iki penktadienio liko 3");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("Iki penktadienio liko 2");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("Iki penktadienio liko 1");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Siandien penktadienis");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("Iki penktadienio liko 6");
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            //Uzduotis1();
            //Uzduotis2();
            //Uzduotis3();
            //Uzduotis4();
            //Uzduotis5();
            //Skaiciuotuvas();
            Console.ReadLine();

        }

        static void Uzduotis1()
        {
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
                if (i == 6)
                {
                    break;
                }
            }
        }

        static void Uzduotis2()
        {
            Console.WriteLine("Pradzia:");
            int pradzia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pabaiga:");
            int pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia > pabaiga)
            {
                Console.WriteLine("Blogi reziai.");
            }
            else
            {
                for (int i = pradzia; i <= pabaiga; i++)
                {
                    Console.WriteLine($"{i} {i * i}");
                }
            }
        }

        static void Uzduotis3()
        {
            int suma = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //suma = suma + i;
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }

        static void Uzduotis4()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int skaicius = 0;
            while (skaicius < 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }

        static void Uzduotis5()
        {
            Console.WriteLine("Pasirinkite: 1-Laptopas / 2-Stacionarus kompiuteris");
            string pasirinkimas = Console.ReadLine();

            while (pasirinkimas != "1" && pasirinkimas != "2")
            {
                Console.Clear();
                Console.WriteLine("Klaida. Tokio pasirinkimo nera.");
                Console.WriteLine("Iveskite is naujo:");
                pasirinkimas = Console.ReadLine();
            }
            Console.Clear();

            if (pasirinkimas == "1")
            {
                Console.WriteLine("Jus pasirinkote laptopa.");
            }
            else if (pasirinkimas == "2")
            {
                Console.WriteLine("Jus pasirinkote stacionaru kompiuteri.");
            }
        }

        static void Skaiciuotuvas()
        {
            string skaiciuoti = "TAIP";
            while (skaiciuoti == "TAIP")
            {
                Console.Write("Iveskite 1-aji skaiciu: ");
                double skaicius1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Iveskite 2-aji skaiciu: ");
                double skaicius2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Iveskite norima atlikti veiksma (+;-;*;/): ");
                string veiksmas = Console.ReadLine();

                Console.Clear();
                switch (veiksmas)
                {
                    case "+":
                        Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {skaicius1 + skaicius2}");
                        break;
                    case "-":
                        Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {skaicius1 - skaicius2}");
                        break;
                    case "*":
                        Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {skaicius1 * skaicius2}");
                        break;
                    case "/":
                        Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {skaicius1 / skaicius2}");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Ar norite skaiciuoti dar karta? ");
                skaiciuoti = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            Console.WriteLine("Skaiciotuvas issijungia..");
        }


    }
}
