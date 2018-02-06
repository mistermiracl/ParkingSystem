using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyEst_BE
{
    public class PuestoBE
    {
        private string id_puesto;
        private int nivel;
        private string bloque;
        private bool estado_disponibilidad;

        public string Id_puesto
        {
            get { return id_puesto; }
            set { id_puesto = value; }
        }
        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public string Bloque
        {
            get { return bloque; }
            set { bloque = value; }
        }
        public bool Estado_disponibilidad
        {
            get { return estado_disponibilidad; }
            set { estado_disponibilidad = value; }
        }
    }
}
