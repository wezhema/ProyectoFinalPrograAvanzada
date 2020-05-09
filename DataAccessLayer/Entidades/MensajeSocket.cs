namespace DataAccessLayer.Entidades
{
    //Clase que almacenará la variable que tendrá los datos que serán encapsulados entre el cliente y servidor
    public class MensajeSocket<T>
    {
        //Getters y Setters con sus respectivas variables
        public string Mensaje { get; set; }
        public T Valor { get; set; }
    }
}
