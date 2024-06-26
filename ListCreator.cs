using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Crucifixion
{
    internal class ListCreator
    {
        public static List<HashSet<string>> CreateList()
        {
            List<HashSet<string>> list = new List<HashSet<string>>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new HashSet<string>());
            }

            return list;
        }
    }
}
