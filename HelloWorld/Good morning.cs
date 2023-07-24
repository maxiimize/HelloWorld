using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace goodMorning
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22222222;
            if (time >= 20)
            {
                Console.WriteLine("Good evening.");
                }
            else if (time >= 12)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good morning.");
            }
        }
        }
                
    }    