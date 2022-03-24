using System;
using System.Collections.Generic;
using System.Linq;

namespace Tema_5_Methodai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int num1 = 5;
            //int num2 = 10;

            ////Return Methodai
            //int sum = AddTwoNumbers(5, 10);
            //int sum2 = AddTwoNumbers(num1, num2);

            ////Void Methodai
            //List<string> stringList = new List<string>();
            //AddToList(stringList, "Vilnius");
            //AddToList(stringList, "Kaunas");
            //AddToList(stringList, "Klaipeda");

            //List<string> stringList1 = AddToList("Vilnius");
            //List<string> stringList2 = AddToList("Kaunas");
            //List<string> stringList3 = AddToList("Klaipeda");

            ////Public ir Private skirtumas
            //var testClass = new Test();
            //testClass.SayHelloPublic("Jonas");


            //MiniCalculator("+", 9, 1);
            //MiniCalculator("-", 8, 4);

            //MiniCalculator2("+", 9, 1);
            //MiniCalculator2("-", 8, 4);

            ////NupiestiRemeli(10);
            ////NupiestiRemeli(10, 10);

            //int sum1 = CalculateSumRecursively(1, 10);

            //---------------------------------------------------- 1 UZDUOTIS -----------------------------------------------------------

            //string vardas = GetName();
            //Console.WriteLine($"Jusu vardas yra: {vardas}");

            //ARBA 
            //JusuVardas();

            //----------------------------------------------------- 2 UZDUOTIS --------------------------------------------------------

            //string vardas = GetName();
            //double skaicius = GetNumber();
            //KartotiVarda(vardas, skaicius);

            ////ARBA
            ////string vardas = GetName();
            ////Kartoti2(vardas);
            ///
            //--------------------------------------------------- 3 UZDUOTIS ---------------------------------------------------------

            //int kiek = KiekSimboliu();
            //Raso(kiek);

            //--------------------------------------------------- 4 UZDUOTIS ---------------------------------------------------------

            ////Kmi();//kazkodel neveikia

            //double svoris = Kilogramai();
            //double ugisKvadratu = MetraiKvadratu();
            //double kmi = svoris / ugisKvadratu;
            //Console.WriteLine($"Jusu KMI yra: {kmi}");

            //--------------------------------------------------- 5 UZDUOTIS --------------------------------------------------------

            //TarpSkaitis();

            //--------------------------------------------------- 6 UZDUOTIS --------------------------------------------------------

            //PrintOutArrayList();
            //int arejuSK = ArejuSkaicius();
            //int suma = ArejuSuma();
            //Console.WriteLine($"Suma: {suma}, viso: {arejuSK} elementai");
            ////ArejuSumaElementai();

            //--------------------------------------------------- 7 UZDUOTIS --------------------------------------------------------

            //PakeltiLaipsniu();
           
            //--------------------------------------------------- 8 UZDUOTIS --------------------------------------------------------



        }//---------------------------------------------------------------------------------------------------------------------------
        public static void PakeltiLaipsniu()
        {
            double sk1 = Gauti1Sk();
            double sk2 = Gauti2Sk();
            double laipsnis = Math.Pow(sk1, sk2);
            Console.WriteLine($"Skaiciu {sk1} pakelus laipsniu {sk2} gauname: {laipsnis}");
        }
        public static double Gauti1Sk()
        {
            Console.WriteLine("Iveskite pirma skaiciu: ");
            double skaicius1 = double.Parse(Console.ReadLine());
            return skaicius1;
        }
        public static double Gauti2Sk()
        {
            Console.WriteLine("Ivbeskite antras skaiciu: ");
            double skaicius2 = double.Parse(Console.ReadLine());
            return skaicius2;
        }
        public static void ArejuSumaElementai(int arejuSK, int suma)
        {
            arejuSK = ArejuSkaicius();
            suma = ArejuSuma();
            Console.WriteLine($"Suma: {suma}, viso: {arejuSK} elementai");
        }
        public static void PrintOutArrayList()
        {
            int[] arejus = new int[] { 1, 24, 46, 71, 18 };
            //foreach (var item in arejus)
            //{
                
            //    Console.WriteLine(item);
            //}
            Console.WriteLine($"Array sarasas: {string.Join(", ", arejus)}");
        }
        public static int ArejuSkaicius()
        {
            int[] arejus = new int[] { 1, 24, 46, 71, 18 };
            int arejuSK = arejus.Length;
           
            return arejuSK;
        }        
        public static int ArejuSuma()
        {

            int[] arejus = new int[] { 1, 24, 46, 71, 18 };
            int suma = 0;
            for (int i = 0; i < arejus.Length; i++)
            {
                suma += arejus[i];
            }
            return suma;

            //int[] skaiciai = new int[10];

            //Random random = new Random();

            //for (int i = 0; i < skaiciai.Length; i++)
            //{
            //    skaiciai[i] = random.Next(1, 100);
            //}
            //foreach (var item in skaiciai)
            //{
            //    Console.WriteLine(item);
            //}
            //return skaiciai;

            //int[] intai = new int[5] { 1, 2, 3, 4, 5 };
            //return intai;


            //double[] dablai = new double[10];
            //dablai[1] = 1;
            //dablai[2] = 2;
            //dablai[3] = 3;
            //dablai[4] = 4;
            //dablai[5] = 5;
            //dablai[6] = 6;
            //dablai[7] = 7;
            //dablai[8] = 8;
            //dablai[9] = 9;
            //dablai[10] =10 ;
            //return dablai[] ;
        }
        public static void TarpSkaitis()
        {
            Console.WriteLine("Iveskite bet koki sakini: ");
            string sakinys = Console.ReadLine();
            int countSpaces = sakinys.Count(Char.IsWhiteSpace);
            Console.WriteLine($"Jusu sakinyje buvo {countSpaces} tarpu");
        }
        public static void Kmi(double svoris, double ugisKvadratu)
        {
            svoris = Kilogramai();
            ugisKvadratu = MetraiKvadratu();
            double kmi = svoris / ugisKvadratu;
            Console.WriteLine($"Jusu KMI yra: {kmi}");
        }
        public static double MetraiKvadratu()
        {
            Console.WriteLine("Iveskite savo ugi metrais: ");
            double ugis = double.Parse(Console.ReadLine());
            double ugisKvadratu = ugis * ugis;
            return ugisKvadratu;
        } 
        public static double Kilogramai()
        {
            Console.WriteLine("Iveskite savo svori kilogramais: ");
            double svoris = double.Parse(Console.ReadLine());
            return svoris;
        }
        public static void Raso(int kiek)
        {
            //Console.WriteLine($"# {* kiek}");//NEVEIKIA :D 
            string str = new string('#', kiek);
            Console.WriteLine(str);
        }        
        public static int KiekSimboliu()
        {
            Console.WriteLine("Iveskite bet kokiu simboliu seka: ");
            string input = Console.ReadLine();
            int kiek = input.Length;
            Console.WriteLine(kiek);
            return kiek;
        }
        public static void JusuVardas()
        {
            Console.WriteLine("Iveskite savo varda: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Jusu vardas yra: {name}");
        }
        public static string GetName()
        {
            Console.WriteLine("Sveiki, iveskite savo varda: ");
            string vardas = Console.ReadLine();
            return vardas;
        }
        public static double GetNumber()
        {
            Console.WriteLine("Iveskite kiek kartu norite isvesti i konsole savo varda: ");
            double skaicius = double.Parse(Console.ReadLine());
            return skaicius ;
        }
        public static void KartotiVarda(string vardas, double skaicius)
        {            
            for (int i = 0; i < skaicius; i++)
            {
                Console.WriteLine($"Sveiki {vardas}");
            }
        }
        public static void Kartoti2(string vardas)
        {
            Console.WriteLine("Kiek?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{vardas}");
            }
        }
        
        //-----------------------------------------------------------------------------------------------------------------------

        #region Basic Methodai

        public static int AddTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static int SubstractTwoNumbers(int x, int y)
        {
            int diff = x - y;
            return diff;
        }

        public static void MiniCalculator(string simbolis, int x, int y)
        {
            switch (simbolis)
            {
                case "+":
                    int sum = AddTwoNumbers(x, y);
                    Console.WriteLine($"Suma yra: {sum}");
                    break;
                case "-":
                    int diff = SubstractTwoNumbers(x, y);
                    Console.WriteLine($"Skirtumas yra: {diff}");
                    break;
                default:
                    Console.WriteLine("Nezinomas simbolis");
                    break;
            }
        }

        //C# 8 Swtich Expression
        public static void MiniCalculator2(string simbolis, int x, int y)
        {
            int result = simbolis switch
            {
                "+" => AddTwoNumbers(x, y),
                "-" => SubstractTwoNumbers(x, y),
                _ => 0
            };

            Console.WriteLine($"Resultas {x} {simbolis} {y} = {result}");
        }

        public static void AddToList(List<string> stringList, string stringToAdd)
        {
            stringList.Add(stringToAdd);
        }

        public static List<string> AddToList(string stringToAdd)
        {
            List<string> stringList = new List<string>();
            stringList.Add(stringToAdd);
            return stringList;
        }

        #endregion

        #region Methodu perkrovimas (Methods Overloading)

        private static void NupiestiRemeli(int remelioIlgis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            //vidurine eilute
            Console.Write("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
            int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
            int kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }

        private static void NupiestiRemeli(int remelioIlgis, int remelioPlotis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis;
            int kokiRemelioPlotiNupiesti = remelioPlotis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            int kiekTarpuPraleisti = 0;

            for (int i = 0; i < kokiRemelioPlotiNupiesti; i++)
            {
                //vidurine eilute
                Console.WriteLine("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
                int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
                kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;
            }

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }

        private static void NupiestiRemeli(int remelioIlgis, string remelioPlotis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis;
            string kokiRemelioPlotiNupiesti = remelioPlotis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            int kiekTarpuPraleisti = 0;

            for (int i = 0; i < kokiRemelioPlotiNupiesti.Length; i++)
            {
                //vidurine eilute
                Console.WriteLine("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
                int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
                kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;
            }

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }

        private static void NupiestiRemeli(string remelioIlgis, int remelioPlotis)
        {
            Console.Clear();

            int kiekRemelioSimboliuNupiesti = remelioIlgis.Length;
            int kokiRemelioPlotiNupiesti = remelioPlotis;
            string remelioSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesime virsutine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();

            int kiekTarpuPraleisti = 0;

            for (int i = 0; i < kokiRemelioPlotiNupiesti; i++)
            {
                //vidurine eilute
                Console.WriteLine("{0}{1}{2}", remelioSimbolis, tarpelioSimbolis, kiekRemelioSimboliuNupiesti);
                int skaiciausIlgis = kiekRemelioSimboliuNupiesti.ToString().Length;
                kiekTarpuPraleisti = remelioSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;
            }

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }

            Console.Write(remelioSimbolis);
            Console.WriteLine();

            //apatine eilute
            for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remelioSimbolis);
            }

            Console.WriteLine();
        }
        #endregion

        #region Rekursija 

        private static int CalculateSumRecursively(int x, int y)
        {
            int sum = x;

            if (x < y)
            {
                x++;
                return sum += CalculateSumRecursively(x, y);
            }

            return sum;
        }

        #endregion
       




    }
}