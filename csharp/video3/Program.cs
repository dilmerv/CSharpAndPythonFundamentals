using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections;

namespace video3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Video 3 Lesson");

            // storing a list of players (string)
            string[] players = new string[] {
                "Player1",
                "Player2",
                "Player3",
                "Player4"
            };

            Console.WriteLine(players[0]);

            // storing a list of ages (int)
            int[] ages = new int[] {
                15,
                18,
                20,
                22
            };
            
            Console.WriteLine(ages[0]);

            // storing a dictionary of social securities

            // 12345
            // 12346
            // 12347

            Dictionary<string, string> socials = new Dictionary<string, string>();
            socials.Add("12345", "Player1");
            socials.Add("12346", "Player2");
            socials.Add("12347", "Player3");

            foreach(string key in socials.Keys)
            {
                Console.WriteLine($"{key}: {socials[key].ToString()}");
            }
        }
    }
}
