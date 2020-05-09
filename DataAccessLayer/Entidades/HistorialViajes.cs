namespace DataAccessLayer.Entidades
{
    //Clase para registrar el historial de viajes
	public class HistorialViajes
    {
        //Getters y Setters con sus respectivas variables
        public string Id_Conductor { get; set; }
        public string Id_Viaje { get; set; }
        public string PuntoPartida { get; set; }
        public string PuntoDestino { get; set; }
        public string Desc_Viaje { get; set; }
        public string Can_Horas { get; set; }
        public string Fecha { get; set; }
        public string Estado { get; set; }
    }
}
