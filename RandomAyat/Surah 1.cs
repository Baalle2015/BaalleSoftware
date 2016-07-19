using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAyat
{
    public class Surah_1
    {
        public static int ayat = 0;
        public static string StringAyat = "";
       
            public string ayatString(int ayatnumber)
            {

                switch (ayatnumber)
                {
                    //case 1:
                    //    StringAyat = "In the name of Allah, the Beneficent, the Merciful (1)";
                    //    break;
                    case 1:
                        StringAyat = "Praise be to Allah, Lord of the Worlds, (2)";
                        break;
                    case 2:
                        StringAyat = "The Beneficent, the Merciful. (3)";
                        break;
                    case 3:
                        StringAyat = "Owner of the Day of Judgment, (4)";
                        break;
                    case 4:
                        StringAyat = "Thee(alone) we worship; Thee(alone) we ask for help. (5)";
                        break;
                    case 5:
                        StringAyat = "Show us the straight path, (6)";
                        break;
                    case 6:
                        StringAyat = "The path of those whom Thou hast favoured. Not (the path) of those who earn Thine anger nor of those who go astray. (7)";
                        break;
                default:
                    StringAyat = "INVALID AYAT NUM";
                    break;
            }
                return StringAyat;

            }




        }

       
               
               
                  
           
                     
              

            }
        
    

