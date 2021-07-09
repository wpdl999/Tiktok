using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt02
{
    class TikTok
    {
        private static int _ID;

        public string Originator { get; set; }
        public int Length { get; set; }
        public string HashTag { get; set; }
        public Audience Audience { get; set; }
        public string Id { get; set; }

        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
            _ID++;
            Id = _ID.ToString();
        }

        private TikTok(string id, string originator, int length, string hashTag, Audience audience)
        {
            Id = id;
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
        }

        public override string ToString()
        {
            return $"{Id},{Originator},{Length},{HashTag},{Audience}";
        }

        public static TikTok Parse(string line)
        {
            string[] splited = line.Split('\t');
            int length = Int32.Parse(splited[2]);

            Audience audience = (Audience)Enum.Parse(typeof(Audience), splited[4]);
            return new TikTok(splited[0], splited[1], length, splited[3], audience);
        }
    }
}
