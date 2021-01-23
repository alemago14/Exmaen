using System;
using System.Collections.Generic;

namespace tiendita
{

    public class Vendedor
    {
        //atrbutos
        private String nombre, apellido;
        private int codigoVendedor;

        //creacion de la lista de cotizaciones
        List<Cotizacion> vectorC = new List<Cotizacion>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }

        public Vendedor(string nombre, string apellido, int codigoVendedor)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.CodigoVendedor = codigoVendedor;
        }

        public Vendedor()
        {
        }

        public void GenerarCotizacion(Cotizacion c)
        {
            vectorC.Add(c);
        }

        public void HistorialCotizaciones()
        {
            //Paso de la lista de cotizaciones a array
            Cotizacion[] coti = vectorC.ToArray();

            //Recorrer el array para imprimir el historial
            for (int i = 0, cotiLength = coti.Length; i < cotiLength; i++)
            {
                coti[i].Imprimir();
            }
        }

    }
}
