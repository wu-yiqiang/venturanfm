using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mes.Utils
{
    public class UserCheckUtils
    {
        public static bool CheckedInput(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            return true;
        }
    }
}
