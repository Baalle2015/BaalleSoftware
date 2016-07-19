using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAyat
{
    class ViewMatchedAyats
    {

        public static string ayatstring = "";
        private static int yt;
        
        public static void viewayats(int y)
        {
           
            ayatstring = "";
         
            var result3 = RandomAyat.Program.Mayahs.Where(x => x.Key == y);

            Random r = new Random();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = (ConsoleColor)r.Next(1, 16);
            foreach (var q in result3)
            {
                //Console.Beep();

                    switch (q.Key)
                    {
                        case 1:
                              //  Console.ForegroundColor = ConsoleColor.Green;
                                RandomAyat.Surah_1 surah1 = new RandomAyat.Surah_1();
                                Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());                              
                                Console.WriteLine(surah1.ayatString(q.Value));
                            break;
                        case 2:                          
                              //  Console.ForegroundColor = ConsoleColor.Yellow;
                                RandomAyat.Surah_2 surah2 = new RandomAyat.Surah_2();
                                Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());                      
                                Console.WriteLine(surah2.ayatString(q.Value));                            
                                break;
                         case 3:                
                               // Console.ForegroundColor = ConsoleColor.Blue;
                                RandomAyat.Surah_3 surah3 = new RandomAyat.Surah_3();
                                Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());                           
                                Console.WriteLine(surah3.ayatString(q.Value));                           
                            break;
                        case 4:
                              // Console.ForegroundColor = ConsoleColor.White;
                               RandomAyat.Surah_4 surah4 = new RandomAyat.Surah_4();
                                Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());                              
                                Console.WriteLine(surah4.ayatString(q.Value));                    
                            break;

                    case 5:
                        //Console.ForegroundColor = ConsoleColor.Gray;
                        RandomAyat.Surah_5 surah5= new RandomAyat.Surah_5();
                        Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());
                        Console.WriteLine(surah5.ayatString(q.Value));
                        break;
                    case 6:
                        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        RandomAyat.Surah_6 surah6 = new RandomAyat.Surah_6();
                        Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());
                        Console.WriteLine(surah6.ayatString(q.Value));
                        break;

                    case 7:
                        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        RandomAyat.Surah_7 surah7 = new RandomAyat.Surah_7();
                        Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());
                        Console.WriteLine(surah7.ayatString(q.Value));
                        break;
                    case 8:
                        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        RandomAyat.Surah_8 surah8 = new RandomAyat.Surah_8();
                        Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());
                        Console.WriteLine(surah8.ayatString(q.Value));
                        break;
                    case 9:
                        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        RandomAyat.Surah_9 surah9 = new RandomAyat.Surah_9();
                        Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());
                        Console.WriteLine(surah9.ayatString(q.Value));
                        break;
                    case 10:
                      //  Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        RandomAyat.Surah_10 surah10 = new RandomAyat.Surah_10();
                        Console.WriteLine("\nSurah " + q.Key + " Ayah " + q.Value + " Count " + result3.Count());
                        Console.WriteLine(surah10.ayatString(q.Value));
                        break;
                    default:
                            break;
                    }
                }


            System.Threading.Thread.Sleep(1000);
            }
        }
    }

