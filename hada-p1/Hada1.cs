using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hada_p1
{
    public static class HadaP1
    {
        // Convierte segundos a minutos
        public static double SecondsToMinutes(double seconds)
        {
            return seconds / 60;
        }

        // Convierte minutos a segundos
        public static double MinutesToSeconds(double minutes)
        {
            return minutes * 60;
        }
    }
}
