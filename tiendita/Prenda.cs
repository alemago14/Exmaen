using System;
namespace tiendita
{
    public class Prenda
    {
        //atributos
        private String calidad;
        private int cantStock;
        private double precio;

        protected string Calidad { get => calidad; set => calidad = value; }
        protected int CantStock { get => cantStock; set => cantStock = value; }
        protected double Precio { get => precio; set => precio = value; }

        public Prenda()
        {
        }

        public virtual String ImprimirPr()
        {
            return "-----------------------"+ 
            "Calidad: "+ Calidad +
                "Precio: " + Precio +
            "Unidad Disponibles: " + CantStock;
        }

        public virtual double PrecioFinal(int cant)
        {
            double precioF = Precio * cant;
            if(Calidad == "premium")
            {
                precioF = precioF + (precioF / 100 * 30);
            }
            else
            {
                precioF = precioF;
            }

            return precioF;
        }

    }
}
