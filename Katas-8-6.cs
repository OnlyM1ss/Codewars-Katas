using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
        public static int find_it(int[] seq)
        {

            int[] tmparray = new int[seq.Length];
            var gt20 = from num in seq
                       where num % 2 == 1
                       orderby num
                       select num;
            foreach(int i in gt20)
            {
                return i;
            }
            for(int i = 0;i<seq.Length;i++)
            {
                if (seq[i] == seq[i + 1])
                {

                }
            }
            return -1;
        }
        public static string Maskify(string cc)
        {
            char[] ccarray = cc.ToCharArray();
            for(int i = 0; i<ccarray.Length - 4;i++)
            {
                ccarray[i] = '#';
            }
            cc = new string(ccarray);
            return cc;
        }
        public static bool IsIsogram(string str)
        {
            char[] ch = str.OrderBy(x => x).ToArray();
            for(int i = 0;i<str.Length;i++)
            {
                if(ch[i+1] == ch[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(names => names.Length <= 4);
        }
        public static int Number(List<int[]> peopleListInOut)
        {
            int person = 0;
            List<int> list = new List<int>();
            foreach(int[] array in peopleListInOut)
            {
                
                    list.Add(array[0] - array[1]);
            }
            foreach(int i in list)
            {
                person += i;
            }
            return person>=0?person:0;
        }
        public static int CountBits(int n)
        {
            if (n < 0) return -1;
            else
            {
                int buf = 0;
                string str = Convert.ToString(n,2);
                foreach(char i in str)
                {
                    if (i == '1') buf += 1;
                }
                return buf;
            }
        }
        public static string Greet(string language)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
{"danish", "Velkomst"},
{"dutch", "Welkom"},
{"estonian", "Tere tulemast"},
{"finnish", "Tervetuloa"},
{"flemish", "Welgekomen"},
{"french", "Bienvenue"},
{"german", "Willkommen"},
{"irish", "Failte"},
{"italian", "Benvenuto"},
{"latvian", "Gaidits"},
{"lithuanian", "Laukiamas"},
{"polish", "Witamy"},
{"spanish", "Bienvenido"},
{"swedish", "Valkommen"},
{"welsh", "Croeso"}
            };
            foreach(var pair in dict)
            {
                if(pair.Key ==language)
                {
                    return pair.Value;
                }
            }
            return "Welcome";
        }
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
            // your code ...
        }
        public static bool ValidatePin(string pin)
        {
            try
            {
                int dig = Int32.Parse(pin);
                int mnem = Convert.ToChar(34);
                foreach(char ch in pin)
                {
                    try
                    {
                        int.Parse(ch.ToString());
                    }
                    catch
                    {
                        return false;
                    }
                }
                return ((pin.Length==4||pin.Length ==6))&&dig>-1?true:false;
            }
            catch
            {
                return false;
            }
        }
        public static String LongestConsec(string[] strarr, int k)
        {
                string longest = "";
                for(int i =0;i<k;i++)
                {
                    if (strarr[i].Length > strarr[i + 1].Length) longest = strarr[i];
                }
                return longest;
        }
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
        //public static string PigIt(string str)
        //{
        //    string fullStr;
        //    string[] substr = str.Split(' ');
        //    foreach(string each in substr)
        //    {
        //        StringBuilder sb = new StringBuilder
        //        fullStr = each + each[each.Length] + "ay" +" ";
        //    }
        //    return fullStr;
        //}
    }
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 0)
            {
                string strhour;
                string strminuts;
                string strseconds;
                int hours = (seconds / 3600);
                int minuts = (seconds - hours) - (seconds / 60);
                seconds = seconds - (minuts + hours);
                if ((hours) <= 9)
                {
                    strhour = "0" + hours.ToString();
                }
                else strhour = hours.ToString();
                if (seconds <= 9)
                {
                    strminuts = "0" + seconds.ToString();
                }
                else strminuts = seconds.ToString();
                if (minuts <= 9)
                {
                    strseconds = "0" + minuts.ToString();
                }
                else strseconds = minuts.ToString();
                return String.Concat(strhour + ":" + strminuts + ":"  + strseconds);
            }
            else return "00:00:00";
        }
    }

}
