using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazione
    {
        public static bool IsDetermined(double a)
        {
            if (a != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return true;
            }
            return false;
        }
}
