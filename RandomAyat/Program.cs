using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomAyat;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Collections;
using System.Data;
using System.IO;
using ColorConsole;
using System.Drawing;
using System.Data.SqlClient;

namespace RandomAyat
{
    class Program
    {
        static public String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static List<KeyValuePair<int, int>> Mayahs = new List<KeyValuePair<int, int>>();

        static public int[,] SurahAndAyats = new int[114, 2];
        static public int ayatnumber = 0;
        public static int i3 = 0;
        public static int Mcounter = 0;
        public static int rayat;
        public static int percentage = 0;
        public static int nos;
        public static double percent2;
        public static string[] Matched = new string[1000000];
        public static string matchedwords;
        public static int wcount;
        public static List<string> ls = new List<string>();
        public static List<int> matchedayats = new List<int>();
        public static int[,] Mayats = new int[144, 2];
        public static bool breakFlag = true;

        public static StringBuilder sb = new StringBuilder();
        public static string lmw = "Matched words: ";
        public static string trimmed;
        public static string valuenow;
        public static ArrayList matchedAyats = new ArrayList();
        public static int mai = 0;
        public static int iii;
        public static int pos;
        public static int fmv = 0;
        public static string regex;
        public static string searchstring;
        public static int snumber;
        public static MatchCollection matches;
        public static int ii;
        public static double nn;
        private static string line;
        public static Random rnd;
        public static string[] allw2;
        public static int i11;
        public static int i77;
        public static int nv;
        public static string text34;
        public static string text33;
        public static string text35;

        public static int Ti = 0;
        private static IEnumerable<KeyValuePair<int, int>> result3;

        public static int K { get; private set; }
        public static string AyatString { get; private set; }

        private static void drawTextProgressBar(int progress, int total)
        {
           // Console.Beep();
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 32;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;
          //  Console.WriteLine(onechunk);
            //draw filled part
            int position = 1;
            double h = 30.1 / total;
            for (int i = 0; i < h  /*or h*/* progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw totals
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + "% of Search complete.("+ RandomAyat.Program.ls.Count + "/" + RandomAyat.Program.clisnum + ")" /*+ total.ToString() + "% (SEARCH PROGRESS)    "*/); //blanks at the end remove any excess
        }

     public static  Colorful.Formatter[] fruits = new Colorful.Formatter[]
{
    new   Colorful.Formatter("bananas", System.Drawing.Color.LightGoldenrodYellow),
    new   Colorful.Formatter("strawberries", Color.Pink),
    new   Colorful.Formatter("mangoes", Color.PeachPuff),
    new   Colorful.Formatter("pineapples", Color.Yellow),
    new   Colorful.Formatter("cherries", Color.Red),
    new   Colorful.Formatter("oranges", Color.Orange),
    new   Colorful.Formatter("apples", Color.LawnGreen),
    new   Colorful.Formatter("peaches", Color.MistyRose),
    new   Colorful.Formatter("plums", Color.Indigo),
    new   Colorful.Formatter("melons", Color.LightGreen),
};
        static void Main(string[] args)
        {
            start:
            int bufSize = 2500000;
            Stream inStream = Console.OpenStandardInput(bufSize);
            //Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));
            //for (int i = 0; i < 1000; i++)
            //{
            //   // Console.Clear();

            //  Colorful.Console.WriteAscii("Welcome");
            //  //Colorful.Console.WriteAscii("To ");
            //  //Colorful.Console.WriteAscii("");
            //  //   Colorful.Console.WriteAscii("Welcome To QuranUltimate Welcome ", System.Drawing.Color.Orange);

            //  //}
            Console.SetCursorPosition(25, 5);
            Console.WriteLine("WHAT DO YOU WANT TO DO?...");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("1)Search");
            Console.SetCursorPosition(25, 8);
            Colorful.FigletFont cc = new Colorful.FigletFont();

            // Console.WriteLine(fruits);
            Console.WriteLine("2)Delete");
            Console.SetCursorPosition(25, 9);

            Console.WriteLine("3)Update");
            //  Console.SetCursorPosition(25, 11);
            //  //string dream = "a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";
            //  //Colorful.Formatter[] fruits2 = new Colorful.Formatter[100];

            //  //fruits2[0] = new Colorful.Formatter("ORANGE", System.Drawing.Color.Orange);

            //  //foreach (Colorful.Formatter item in fruits2)
            //  //{
            //  //    Console.WriteLine(item);
            //  //}
            ////  Colorful.Console.WriteLineFormatted(dream, Color.Gray, fruits);
            //  Console.WriteLine("Please select 1,2 or 3");
            //  // Console.Read();
            //  List<string> list= getdata();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter search text...");
                    
                   searchstring = Console.ReadLine();
                    if (searchstring != null)
                    {
                        Console.WriteLine("Are you sure to want to search for above text? Y/N");//,Console.ForegroundColor= ConsoleColor.Blue);

                        switch (Console.ReadLine())
                        {
                            case "Y":
                            case "y":
                                Loop();

                                break;

                            case "N":
                            case "n":

                                Console.Clear();

                                goto start;
                                break;

                            default:
                                break;
                        }
                    }

                    break;
                case 2:

                    break;

                case 3:

                    break;

                default:
                    break;
            }




        }

        private static List<string> getdata()
        {
            SqlConnection conn = new SqlConnection(@"Server= mssql4.gear.host;User ID= mydata2016;Password= @alaalim2017991 ");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users",conn);
            List<string> results = new List<string>();
            using (System.Data.SqlClient.SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    results.Add((string)rdr["First_Name"]);
            }
            return results;

        }

      
        public static string[] SplitWords(string s)

        {
            string[] t = Regex.Split(s, @"[^a-zA-Z]+");
            foreach (var item in t)
            {
                // Console.WriteLine(s + " " + item);

            }
            //   System.Threading.Thread.Sleep(10);

            return t;
        }
        private static void listget()
        {
            for (int i = 1; i < 114; i++)
            {
                switch (i)
                {
                    case 1:
                        Surah_1 surah1 = new Surah_1();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah1.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 2:
                        Surah_2 surah2 = new Surah_2();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah2.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 3:
                        Surah_3 surah3 = new Surah_3();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah3.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                    ls.Add(s);
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        Surah_4 surah4 = new Surah_4();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah4.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                    ls.Add(s);
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        Surah_5 surah5 = new Surah_5();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah5.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 6:
                        Surah_6 surah6 = new Surah_6();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah6.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                      ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 7:
                        Surah_7 surah7 = new Surah_7();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah7.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 8:
                        Surah_8 surah8 = new Surah_8();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah8.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 9:
                        Surah_9 surah9 = new Surah_9();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah9.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 10:
                        Surah_10 surah10 = new Surah_10();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah10.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                       ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 11:
                        Surah_11 surah11 = new Surah_11();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah11.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 12:
                        Surah_12 surah12 = new Surah_12();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah12.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 13:
                        Surah_13 surah13 = new Surah_13();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah13.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 14:
                        Surah_14 surah14 = new Surah_14();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah14.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 15:
                        Surah_15 surah15 = new Surah_15();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah15.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    case 16:
                        Surah_16 surah16 = new Surah_16();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah16.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 17:
                        Surah_17 surah17 = new Surah_17();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah17.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 18:
                        Surah_18 surah18 = new Surah_18();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah18.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                      

                    case 19:
                        Surah_19 surah19 = new Surah_19();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah19.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 20:
                        Surah_20 surah20 = new Surah_20();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah20.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 21:
                        Surah_21 surah21 = new Surah_21();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah21.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 22:
                        Surah_22 surah22 = new Surah_22();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah22.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 23:
                        Surah_23 surah23 = new Surah_23();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah23.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 24:
                        Surah_24 surah24 = new Surah_24();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah24.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 25:
                        Surah_25 surah25 = new Surah_25();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah25.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 26:
                        Surah_26 surah26 = new Surah_26();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah26.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 27:
                        Surah_27 surah27 = new Surah_27();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah27.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 28:
                        Surah_28 surah28 = new Surah_28();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah28.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 29:
                        Surah_29 surah29 = new Surah_29();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah29.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;

                    case 30:
                        Surah_30 surah30 = new Surah_30();
                        for (int j = 0; j < SurahsAndNumberOfAyats(i); j++)
                        {
                            AyatString = surah30.ayatString(j).ToString();
                            if (AyatString != "INVALID AYAT NUM")
                            {
                                string[] a = SplitWords(AyatString);

                                foreach (var s in a)
                                {
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        // string s = a2[o];
                                        ls.Add(s);
                                    }
                                }
                            }
                        }

                        break;
                    default:
                        break;
                }
            }
           
           
        }

        private static Random _random = new Random();
        private static int clisnum;
        private static double percent;

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        public static void Loop()

        {
           

            while (breakFlag)
            {

               
                //Array.Clear(Mayats, 0, Mayats.Length);
                i11 = 0;
                percentage = 0;
               // percent = 0;
                ayatnumber = 0;
                snumber = 0;
                text34 = "";
                text33 = "";
                matchedAyats.Clear();
                matchedayats.Clear();
                ayatnumber = 0;
                Mcounter = 0;
                ls.Clear();
                Console.ForegroundColor = ConsoleColor.White;
              RandomAyat.Program.percent = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count(); // <-- Use cast

                List<Tuple<object, string, string,string, string, string, string, string>> dictionary = new List<Tuple<object, string,string,string, string, string, string, string>>();


                // dictionary.Add(Tuple.Create<object, string, string, string, string, string, string, string>("","", "", "", "", "","","",""));
               // percent = (double)(Mayahs.Count * 100) / ls.Count; // <-- Use cast

                listget();
                clisnum = ls.Count();
                ls.Clear();
                for (i11 = 1; i11 <= 32; i11++)
                {

                   RandomAyat.SearchSurahs.Search(i11, searchstring);
                    //percentageCount();
                    RandomAyat.Program.percent = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count(); // <-- Use cast


                    if (percent >= 75 && i11 == 32)
                    {
                        //if (Convert.ToInt32(percent2) < 101)
                        //{

                        //}
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        percent2 = (double)(ls.Count * 100) / clisnum; // <-- Use cast

                        drawTextProgressBar(Convert.ToInt32(percent2), 100);

                        Console.WriteLine("\nSuccess there is " + String.Format("{0:.##}", percent) + "% match rate");
                        //Console.WriteLine(Mcounter);
                        //Console.WriteLine(ls.Count());
                        Console.WriteLine("Do you want to view matched ayats? Y/N");
                   
                        switch (Console.ReadLine())
                        {
                            case "N":
                            case "n":
                                Console.WriteLine("Do you want to Exit the program? Y/N");
                                switch (Console.ReadLine())
                                {
                                    case "N":
                                    case "n":
                                        break;
                                    case "Y":
                                    case "y":

                                        Console.WriteLine("THANK YOU FOR USING QUR'AN-SEARCH");

                                       // Console.SetCursorPosition(600 , 77);
                                       // Console.Write("s");
                                        //System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AyuutoDB;Integrated Security=True");
                                        //conn.Open();
                                        //System.Data.SqlClient.SqlCommand sqlcmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM Users WHERE Age = 24", conn);
                                        //System.Data.SqlClient.SqlDataAdapter sqlda = new System.Data.SqlClient.SqlDataAdapter(sqlcmd);
                                        //DataTable dt = new DataTable();
                                        //sqlda.Fill(dt);
                                        //foreach (DataRow row in dt.Rows)
                                        //{
                                        //    Console.WriteLine((row["First_Name"].ToString()));

                                        //    Console.WriteLine(row["Last_Name"].ToString());
                                        //    Console.WriteLine(row["Age"].ToString());

                                        //    //  item.SubItems.Add("Ahmed");


                                        //}



                                        Environment.Exit(0);
                                        break;

                                    default:
                                        break;
                                }
                                break;
                            case "Y":
                            case "y":

                                //foreach (var item in Mayahs)
                                //{
                                //    Random r = new Random();
                                //    K++;
                                //    //Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                                //    if (item.Key == 1 || item.Key == 3 || item.Key == 5 || item.Key == 7 || item.Key == 9)
                                //    {
                                //        Console.BackgroundColor = (ConsoleColor)1;

                                //    }

                                //    if (item.Key == 2 || item.Key == 4 || item.Key == 6 || item.Key == 8 || item.Key == 10)
                                //    {
                                //        Console.BackgroundColor = (ConsoleColor)12;

                                //    }
                                //    if (Console.BackgroundColor==ConsoleColor.White)
                                //    {
                                //        Console.ForegroundColor = ConsoleColor.Black;

                                //    }
                                //    else
                                //    {
                                //        Console.ForegroundColor = ConsoleColor.White;


                                //    }
                                //    // Console.BackgroundColor = GetRandomConsoleColor();
                                //    Console.WriteLine(item + ": " + K);
                                //   // Console.BackgroundColor = ConsoleColor.Yellow;

                                //    System.Threading.Thread.Sleep(100);
                                //}
                              //  breakFlag=false;
                                if (Mayahs.Count >= 1)
                                {
                                    for (i77 = 1; i77 <= 114; i77++)
                                    {


                                      RandomAyat.ViewMatchedAyats.viewayats(i77);


                                    }
                                }
                                else
                                {
                                    //Console.WriteLine(Mayahs.Count);
                                }



                                break;

                        }


                        break;



                    }

                    else
                    {
                        if (percent < 75)
                        {
                            //Console.WriteLine(Convert.ToInt32(percent));
                            //for (int i = 0; percent <= 74; i++)
                            //{
                            //    //ExportXml(file, styleSheet);
                            //    drawTextProgressBar(Convert.ToInt32(percent), 74);
                            //    // count++;
                            //}
                            if (percent >= 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Sorry the matched accuracy is only " + String.Format("{0:.##}", percent2) + "% it has to be at least 75%");
                                Console.WriteLine(Mcounter);
                                Console.WriteLine(ls.Count());
                                Console.WriteLine(i11);
                                Console.WriteLine(Convert.ToInt32(percent2));

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Sorry the matched accuracy is only " + "0" + "% it has to be at least 75%");

                                //Console.WriteLine(Mcounter);
                                //Console.WriteLine(ls.Count());
                                //Console.WriteLine(i11);
                            }

                        }
                        else
                        {
                            //if (Convert.ToInt32(percent2) < 101)
                            //{
                            //    drawTextProgressBar(Convert.ToInt32(percent2), 100);

                            //}
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Success an accuracy rate of " + String.Format("{0:.##}", percent2) + "% is attained but search is not yet complete please wait until search is complete");
                            Console.WriteLine(Mcounter);
                            Console.WriteLine(ls.Count());
                            Console.WriteLine(i11);

                        }
                        percent2 = (double)(ls.Count * 100) / clisnum; // <-- Use cast

                        if (Convert.ToInt32(percent2) <= 100)
                        {

                            drawTextProgressBar(Convert.ToInt32(percent2), 100);
                            if (percent2 != 100)
                            {
                               // Console.Beep();

                            }
                        }


                    }

                    //for (int i = 0; Convert.ToInt32(percent) < 74; i++)
                    //{

                        //ExportXml(file, styleSheet);
                        // count++;
                    //}
                    System.Threading.Thread.Sleep(3000);

                }



                //if (i11 >= 114)
                //{


                //}

            }
        }

        //public static void percentageCount()
        //{

            
        //    if (percent >= 1 )
        //    {
                
        //        if (percent != 70)
        //        {
        //            Console.Clear();
        //            Console.WriteLine(String.Format("{0:.##}", percent) + "%");
        //        }
               

        //    }
              
            
           


        //}

       


      








       
       




   
      



    


        public static Boolean findString(String baseString, String strinfToFind, String separator)
        {
            foreach (String str in baseString.Split(separator.ToCharArray()))
            {
                if (str.Equals(strinfToFind))
                {
                    return true;
                }
            }
            return false;
        }


      public static int SurahsAndNumberOfAyats(int snumber)
        {


         
            switch (snumber)
            {

                case 1:
                    ayatnumber = 6;
                    break;
                case 2:
                    ayatnumber = 286;

                    break;
                case 3:
                    ayatnumber = 200;

                    break;
                case 4:
                    ayatnumber = 176;
                    break;
                case 5:
                    ayatnumber = 120;
                    break;
                case 6:
                    ayatnumber = 165;
                    break;
                case 7:
                    ayatnumber = 206;
                    break;
                case 8:
                    ayatnumber = 75;
                    break;
                case 9:
                    ayatnumber = 129;
                    break;
                case 10:
                    ayatnumber = 109;
                    break;

                case 11:
                    ayatnumber = 123;
                    break;
                case 12:
                    ayatnumber = 111;
                    break;
                case 13:
                    ayatnumber = 43;
                    break;
                case 14:
                    ayatnumber = 52;
                    break;
                case 15:
                    ayatnumber = 99;
                    break;
                case 16:
                    ayatnumber = 128;
                    break;
                case 17:
                    ayatnumber = 111;
                    break;
                case 18:
                    ayatnumber = 110;
                    break;
                case 19:
                    ayatnumber = 98;
                    break;
                case 20:
                    ayatnumber = 135;
                    break;

                case 21:
                    ayatnumber = 112;
                    break;
                case 22:
                    ayatnumber = 78;
                    break;
                case 23:
                    ayatnumber = 118;
                    break;
                case 24:
                    ayatnumber = 64;
                    break;
                case 25:
                    ayatnumber = 77;
                    break;
                case 26:
                    ayatnumber = 227;
                    break;
                case 27:
                    ayatnumber = 93;
                    break;
                case 28:
                    ayatnumber = 88;
                    break;
                case 29:
                    ayatnumber = 69;
                    break;
                case 30:
                    ayatnumber = 60;
                    break;

                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 35:
                    break;
                case 36:
                    break;
                case 37:
                    break;
                case 38:
                    break;
                case 39:
                    break;
                case 40:
                    break;

                case 41:
                    break;
                case 42:
                    break;
                case 43:
                    break;
                case 44:
                    break;
                case 45:
                    break;
                case 46:
                    break;
                case 47:
                    break;
                case 48:
                    break;
                case 49:
                    break;
                case 50:
                    break;

            }
            return ayatnumber;
        }

    }



}



     
        






    

