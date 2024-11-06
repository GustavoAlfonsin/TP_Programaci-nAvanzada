using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Cartas
{
    internal class CartaUnidad : Carta
    {
        public Unidad unidad;
        
        public CartaUnidad(string nombre, string descripcion, int costo, Tipo type, Unidad unidad)
        {
            this.name = nombre;
            this.description = descripcion;
            this.cost = costo;
            this.tipo = type;
            this.unidad = unidad;
        }

        public Unidad CrearUnidad()
        {
            return this.unidad;
        }

    }
}
