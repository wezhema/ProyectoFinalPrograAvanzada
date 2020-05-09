using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entidades
{
	public class Viajes
    {
        public string Id_Conductor { get; set; }
        public int Id_Viaje { get; set; }
        public string PuntoPartida { get; set; }
        public string PuntoDestino { get; set; }
        public string Desc_Viaje { get; set; }
        public string Can_Horas { get; set; }
        public string Estado { get; set; }

    }
}
