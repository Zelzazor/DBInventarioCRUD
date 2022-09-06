using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBInventarioCRUD
{
    static class Utils
    {   
        public static bool IsAnyNullOrEmpty(object myObject)
        {
            return myObject.GetType().GetProperties()
                   .Where(pi => pi.PropertyType == typeof(string))
                   .Select(pi => (string)pi.GetValue(myObject))
                   .Any(value => string.IsNullOrEmpty(value));
        }
    }
}
