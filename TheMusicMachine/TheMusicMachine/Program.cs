using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMusicMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            string letter = "|";

            if(args.Length == 1)
            {
                letter = args[0];
            }


            switch (Convert.ToChar(letter.ToLower()))
            {
                //Was given no value (or a crazy person tried to type '|')
                case '|':
                    //Not sure what to do
                    //So we do nothing
                    break;
                //Row 1
                case 'z':
                    Console.Beep(100, 100);
                    break;
                case 'x':
                    Console.Beep(175, 100);
                    break;
                case 'c':
                    Console.Beep(250, 100);
                    break;
                case 'v':
                    Console.Beep(325, 100);
                    break;
                case 'b':
                    Console.Beep(400, 100);
                    break;
                case 'n':
                    Console.Beep(475, 100);
                    break;
                case 'm':
                    Console.Beep(550, 100);
                    break;
                case ',':
                    Console.Beep(625, 100);
                    break;
                case '.':
                    Console.Beep(700, 100);
                    break;
                case '/':
                    Console.Beep(775, 100);
                    break;
                //Row 2
                case 'a':
                    Console.Beep(850, 100);
                    break;
                case 's':
                    Console.Beep(925, 100);
                    break;
                case 'd':
                    Console.Beep(1000, 100);
                    break;
                case 'f':
                    Console.Beep(1075, 100);
                    break;
                case 'g':
                    Console.Beep(1150, 100);
                    break;
                case 'h':
                    Console.Beep(1225, 100);
                    break;
                case 'j':
                    Console.Beep(1300, 100);
                    break;
                case 'k':
                    Console.Beep(1375, 100);
                    break;
                case 'l':
                    Console.Beep(1450, 100);
                    break;
                case ';':
                    Console.Beep(1525, 100);
                    break;
                case '\'':
                    Console.Beep(1600, 100);
                    break;
                //Row 3
                //About time!!!
                case 'q':
                    Console.Beep(1675, 100);
                    break;
                case 'w':
                    Console.Beep(1750, 100);
                    break;
                case 'e':
                    Console.Beep(1825, 100);
                    break;
                case 'r':
                    Console.Beep(1900, 100);
                    break;
                case 't':
                    Console.Beep(1975, 100);
                    break;
                case 'y':
                    Console.Beep(2150, 100);
                    break;
                case 'u':
                    Console.Beep(2225, 100);
                    break;
                case 'i':
                    Console.Beep(2300, 100);
                    break;
                case 'o':
                    Console.Beep(2375, 100);
                    break;
                case 'p':
                    Console.Beep(2450, 100);
                    break;
                case '[':
                    Console.Beep(2525, 100);
                    break;
                case ']':
                    Console.Beep(2600, 100);
                    break;
                default:
                    //You messed up
                    //We do nuttin
                    break;

                //Woot! We're done!

                ///////////////////
                //  That's all   //
                //    folks!     //
                //    - Matt     //
                ///////////////////
            }

        }

    }
}
