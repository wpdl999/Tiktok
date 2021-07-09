using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignemnt02
{
    class TikTokManager
    {
        static List<TikTok> TIKTOKS;
        private static string FILENAME;

        static TikTokManager()
        {
            TIKTOKS = new List<TikTok>();
            FILENAME = "tiktoks.txt";
            TextReader reader = new StreamReader(FILENAME);
            string line = reader.ReadLine();
            while (line != null)
            {
                TIKTOKS.Add(TikTok.Parse(line));
                line = reader.ReadLine();
            }

            reader.Close();
        }

        public static void Initialize()
        {
            List<TikTok> tiktoks = new List<TikTok>();
            TIKTOKS = tiktoks;
            tiktoks.Add(new TikTok("Sumin", 4, "#suminjjang", Audience.Special));
            tiktoks.Add(new TikTok("Chad", 3, "#chad", Audience.World));
            tiktoks.Add(new TikTok("Josep", 7, "#josep", Audience.Group));
            tiktoks.Add(new TikTok("Alba", 2, "#alba", Audience.Special));
            tiktoks.Add(new TikTok("David", 5, "#david", Audience.World));
        }

        public static void Show()
        {
            foreach (var a in TIKTOKS)
            {
                Console.WriteLine(a);
            }
        }

        public static void Show(string tag)
        {
            foreach (var b in TIKTOKS)
            {
                if (tag == b.HashTag)
                {
                    Console.WriteLine(b);
                }
            }
        }

        public static void Show(int length)
        {
            foreach (var c in TIKTOKS)
            {
                if (length == c.Length)
                {
                    Console.WriteLine(c);
                }

            }

        }

        public static void Show(Audience audience)
        {
            foreach (var d in TIKTOKS)
            {
                if (audience == d.Audience)
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}

