using System;
namespace tiendita
{
    public class Pantalon : Prenda
    {
        //atributos
        private String tipo;

        //geter y seter
        public string Tipo { get => tipo; set => tipo = value; }

        public Pantalon(string Calidad, int CantStock, double Precio, string tipo)
        {
            this.Calidad = Calidad;
            this.CantStock = CantStock;
            this.Precio = Precio;
            this.tipo = tipo;
        }

        public override double PrecioFinal(int cant)
        {
            double precioF = base.PrecioFinal(cant);
            if(Tipo == "chupin")
            {
                precioF = precioF + (precioF / 100 * 12);
            }
            return precioF;
        }

        public override string ImprimirPr()
        {
            return base.ImprimirPr()+
            "Pantalon Tipo: "+ Tipo+
                "------------------------------------";
        }
    }
}
