using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entidades
{
    public class MensajeSocket<T>
    {
        public string Mensaje { get; set; }
        public T Valor { get; set; }
    }
}
