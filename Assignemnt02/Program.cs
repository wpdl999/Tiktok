using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignemnt02
{
    class Program
    {
        static void Main(string[] args)
        {
            TikTokManager.Show();
            TikTokManager.Show("#chad");
            TikTokManager.Show(7);
            TikTokManager.Show(Audience.Group);
            TikTokManager.Show(Audience.Special);

            Console.WriteLine("\n\n\n\n");
            TikTokManager.Initialize();
            TikTokManager.Show();
            TikTokManager.Show("#alba");
            TikTokManager.Show(3);
            TikTokManager.Show(Audience.World);
            Console.ReadKey();
        }
    }
}
