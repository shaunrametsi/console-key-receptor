using System;
using System.Drawing;
using System.Threading;
using System.Windows.Input;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
                switch (Console.ReadKey(true).Key)
                {
                    case (ConsoleKey.UpArrow)       : Console.WriteLine("up arrow")     ; break ;
                    case (ConsoleKey.DownArrow)     : Console.WriteLine("down arrow")   ; break ;
                    case (ConsoleKey.LeftArrow)     : Console.WriteLine("left arrow")   ; break ;
                    case (ConsoleKey.RightArrow)    : Console.WriteLine("right arrow")  ; break ;
                    default : Console.WriteLine("unknown"); break;
                }
                    
            }
            
        }

        public static void returnKey()
        {
                
        }
    }
}
