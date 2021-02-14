using System;
using System.Collections.Generic;

namespace tienditaa
{


    public class Vendedor
    {
        //Atributos
        private String Nombre, Apellido;
        private int CodigoVendedor;
        private List<Cotizacion> Cotizaciones;


        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public int CodigoVendedor1 { get => CodigoVendedor; set => CodigoVendedor = value; }
        internal List<Cotizacion> Cotizaciones1 { get => Cotizaciones; set => Cotizaciones = value; }



        //Constructores
        public Vendedor(string Nombre, string Apellido, int CodigoVendedor)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.CodigoVendedor = CodigoVendedor;
            Cotizaciones = new List<Cotizacion>();
        }

        //Iniciamos la lista


        //Metodos
        public void GenerarCoti(Cotizacion coti1)
        {
            Cotizaciones.Add(coti1);
        }

        public void ImprimirCotizaciones()
        {
            for(int i=0; i < (Cotizaciones.Capacity - 1) ; i++)
            {
                Cotizaciones[i].ImprimirCotizacion();
            }
        }
    }
}
