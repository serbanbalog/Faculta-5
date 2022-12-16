using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculta_5
{
    public static class Engine
    {
        public static int nc;
        public static int nu;
        public static List<T> History = new List<T>();
        public static List<string> h1;
        public static List<string> h2;
        public static List<string> h3;
        public static int hCrt = 1;
        public static List<string> Load(string fileName)
        {
            List<string> list = new List<string>();
            string buffer;
            TextReader load = new StreamReader(fileName);
            while((buffer = load.ReadLine()) != null)
            {
                list.Add(buffer);
            }   
            load.Close();
            return list;
        }

    }
   
}
