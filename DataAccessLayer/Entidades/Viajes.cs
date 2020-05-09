namespace DataAccessLayer.Entidades
{
    //Clase que almacenará los viajes
	public class Viajes
    {
        //Getters y Setters con sus respectivas variables
        public string Id_Conductor { get; set; }
        public int Id_Viaje { get; set; }
        public string PuntoPartida { get; set; }
        public string PuntoDestino { get; set; }
        public string Desc_Viaje { get; set; }
        public string Can_Horas { get; set; }
        public string Estado { get; set; }

    }
}
