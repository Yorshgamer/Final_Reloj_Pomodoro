using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace Reloj
{
    public class Alarma
    {
        public TimeSpan Hora { get; set; }
        public List<DayOfWeek> Dias { get; set; }

        public Alarma(TimeSpan hora, List<DayOfWeek> dias)
        {
            Hora = hora;
            Dias = dias;
        }

        public bool EsHoraDeSonar()
        {
            DateTime ahora = DateTime.Now;
            return Dias.Contains(ahora.DayOfWeek) && ahora.TimeOfDay >= Hora && ahora.TimeOfDay < Hora.Add(new TimeSpan(0, 1, 0));
        }
    }
}