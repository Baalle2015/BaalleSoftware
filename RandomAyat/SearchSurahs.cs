using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RandomAyat
{
    class SearchSurahs
    {
        public static string AyatString;
       // private static MatchCollection matches;

       public static string[] SplitWords(string s)

        {
            string[] t = Regex.Split(s, @"[^a-zA-Z]+");
            foreach (var item in t)
            {
               // Console.WriteLine(s + " " + item);

            }
         //   System.Threading.Thread.Sleep(10);

            return t ;
        }

        public static void Search(int surahnumber, string searchstring)
        {
            switch (surahnumber)
            {
                case 1:
                    
                    RandomAyat.Surah_1 surah1 = new RandomAyat.Surah_1();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah1.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }
                       
                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {
                                  //  Console.WriteLine("gg");
                                    if (!string.IsNullOrEmpty(s))
                                    {
                                       // Console.WriteLine("CASE 1: " + s);
                                       RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                       // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                          //  Console.WriteLine("case 1: " + match.Value);
                                           // RandomAyat.Program.Mcounter += 1;

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                //  RandomAyat.Program.Mcounter += 1;
                                                //   RandomAyat.Program.percent = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 2:

                    RandomAyat.Surah_2 surah2 = new RandomAyat.Surah_2();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah2.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                           // Console.WriteLine("case 2: " + match.Value);

                                            //  RandomAyat.Program.Mcounter += 1;

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                              //  RandomAyat.Program.Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }

                                        // string s = a2[o];
                                        //    RandomAyat.Program.Mcounter += 1;



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;
                case 3:

                    RandomAyat.Surah_3 surah3 = new RandomAyat.Surah_3();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah3.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                      //  here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                           // Console.WriteLine("case 3: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                             //   RandomAyat.Program.Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }

                                        // string s = a2[o];



                                    }

                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                   
                    break;
                case 4:

                    RandomAyat.Surah_4 surah4 = new RandomAyat.Surah_4();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah4.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                                                                      //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                   
                    break;

                case 5:

                    RandomAyat.Surah_5 surah5 = new RandomAyat.Surah_5();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah5.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 6:

                    RandomAyat.Surah_6 surah6 = new RandomAyat.Surah_6();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah6.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 7:

                    RandomAyat.Surah_7 surah7 = new RandomAyat.Surah_7();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah7.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;
                case 8:

                    RandomAyat.Surah_8 surah8 = new RandomAyat.Surah_8();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah8.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;
                case 9:

                    RandomAyat.Surah_9 surah9 = new RandomAyat.Surah_9();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah9.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;
                case 10:

                    RandomAyat.Surah_10 surah10 = new RandomAyat.Surah_10();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah10.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 11:

                    RandomAyat.Surah_11 surah11 = new RandomAyat.Surah_11();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah11.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 12:

                    RandomAyat.Surah_12 surah12 = new RandomAyat.Surah_12();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah12.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 13:

                    RandomAyat.Surah_13 surah13 = new RandomAyat.Surah_13();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah13.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        ///here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 14:

                    RandomAyat.Surah_14 surah14 = new RandomAyat.Surah_14();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah14.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    
                    break;

                case 15:

                    RandomAyat.Surah_15 surah15 = new RandomAyat.Surah_15();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah15.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                        //    }
                        //}
                        //else
                        //{
                        //    System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                        //    goto here;
                        //}
                    }
                    break;

                case 16:

                    RandomAyat.Surah_16 surah16 = new RandomAyat.Surah_16();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah16.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                                string[] a2 = SplitWords(searchstring);

                                foreach (var s in a2)
                                {

                                    if (!string.IsNullOrEmpty(s))
                                    {
                                        RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                        // Use foreach-loop.



                                        // percentage += 1;

                                        foreach (Match match in RandomAyat.Program.matches)
                                        {
                                            RandomAyat.Program.Mcounter += 1;
                                            //  Console.WriteLine("case 1: " + match.Value);

                                            if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                                //}


                                            }
                                            else
                                            {
                                                //foreach (var item in hh)
                                                //{
                                                //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                                //}

                                                RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                                // Mcounter += 1;
                                                RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                                RandomAyat.Program.Mcounter += 1;

                                            }

                                        }
                                        //RandomAyat.Program.Mcounter += 1;

                                        // string s = a2[o];



                                    }
                                }
                            }
            //}
            //            else
            //            {
            //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
            //                goto here;
            //            }
                    
                    break;

                case 17:

                    RandomAyat.Surah_17 surah17 = new RandomAyat.Surah_17();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah17.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 18:

                    RandomAyat.Surah_18 surah18 = new RandomAyat.Surah_18();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah18.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 19:

                    RandomAyat.Surah_19 surah19 = new RandomAyat.Surah_19();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah19.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 20:

                    RandomAyat.Surah_20 surah20 = new RandomAyat.Surah_20();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah20.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 21:

                    RandomAyat.Surah_21 surah21 = new RandomAyat.Surah_21();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah21.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 22:

                    RandomAyat.Surah_22 surah22 = new RandomAyat.Surah_22();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah22.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 23:

                    RandomAyat.Surah_23 surah23 = new RandomAyat.Surah_23();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah23.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 24:

                    RandomAyat.Surah_24 surah24 = new RandomAyat.Surah_24();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah24.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;

                case 25:

                    RandomAyat.Surah_25 surah25 = new RandomAyat.Surah_25();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah25.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;


                case 26:

                    RandomAyat.Surah_26 surah26 = new RandomAyat.Surah_26();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah26.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;


                case 27:

                    RandomAyat.Surah_27 surah27 = new RandomAyat.Surah_27();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah27.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;


                case 28:

                    RandomAyat.Surah_28 surah28 = new RandomAyat.Surah_28();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah28.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;


                case 29:

                    RandomAyat.Surah_29 surah29 = new RandomAyat.Surah_29();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah29.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;


                case 30:

                    RandomAyat.Surah_30 surah30 = new RandomAyat.Surah_30();
                    for (int i = 1; i < RandomAyat.Program.SurahsAndNumberOfAyats(surahnumber); i++)
                    {
                        AyatString = surah30.ayatString(i).ToString();
                        if (AyatString != "INVALID AYAT NUM")
                        {
                            string[] a = SplitWords(AyatString);

                            foreach (var s in a)
                            {
                                if (!string.IsNullOrEmpty(s))
                                {
                                    // string s = a2[o];
                                    RandomAyat.Program.ls.Add(s);
                                }
                            }
                        }

                        //here:
                        //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //{
                        //    foreach (string line in System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt"))
                        //    {

                        string[] a2 = SplitWords(searchstring);

                        foreach (var s in a2)
                        {

                            if (!string.IsNullOrEmpty(s))
                            {
                                RandomAyat.Program.matches = Regex.Matches(AyatString, "\\b" + s + "\\b");

                                // Use foreach-loop.



                                // percentage += 1;

                                foreach (Match match in RandomAyat.Program.matches)
                                {
                                    RandomAyat.Program.Mcounter += 1;
                                    //  Console.WriteLine("case 1: " + match.Value);

                                    if (RandomAyat.Program.Mayahs.Contains(new KeyValuePair<int, int>(surahnumber, i)) == true)
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("YesYes " + item.Key + " " + item.Value);

                                        //}


                                    }
                                    else
                                    {
                                        //foreach (var item in hh)
                                        //{
                                        //    Console.WriteLine("NoNo " + item.Key + " " + item.Value);

                                        //}

                                        RandomAyat.Program.Mayahs.Add(new KeyValuePair<int, int>(surahnumber, i));
                                        // Mcounter += 1;
                                        RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count; // <-- Use cast
                                        RandomAyat.Program.Mcounter += 1;

                                    }

                                }
                                //RandomAyat.Program.Mcounter += 1;

                                // string s = a2[o];



                            }
                        }
                    }
                    //}
                    //            else
                    //            {
                    //                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FindText.txt");
                    //                goto here;
                    //            }

                    break;
                default:
                    break;
            }
           // Console.WriteLine(RandomAyat.Program.Mcounter);
            RandomAyat.Program.percent2 = (double)(RandomAyat.Program.Mcounter * 100) / RandomAyat.Program.ls.Count(); // <-- Use cast
                                                                                                                      // System.Threading.Thread.Sleep(10000);
           
        }

        private static void drawTextProgressBar(int progress, int total)
        {
            //draw empty progress bar
            Console.CursorLeft = 0;
            Console.Write("["); //start
            Console.CursorLeft = 32;
            Console.Write("]"); //end
            Console.CursorLeft = 1;
            float onechunk = 30.0f / total;

            //draw filled part
            int position = 1;
            for (int i = 0; i < onechunk * progress; i++)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw unfilled part
            for (int i = position; i <= 31; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.CursorLeft = position++;
                Console.Write(" ");
            }

            //draw totals
            Console.CursorLeft = 35;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(progress.ToString() + " of " + total.ToString() + "    "); //blanks at the end remove any excess
        }
    }
}
