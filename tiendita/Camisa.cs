using System;
namespace tiendita
{
    public class Camisa : Prenda
    {
        //atributos
        private String manga;
        private String cuello;

        //constructores
        public Camisa(string Calidad, int CantStock, double Precio, string manga, string cuello)
        {
            this.Calidad = Calidad;
            this.CantStock = CantStock;
            this.Precio = Precio;
            this.Manga = manga;
            this.Cuello = cuello;
        }

        public string Manga { get => manga; set => manga = value; }
        public string Cuello { get => cuello; set => cuello = value; }

        public override double PrecioFinal(int cant)
        {
            double precioF = base.PrecioFinal(cant);
            if(Manga == "corta")
            {
                precioF = precioF - (precioF / 100 * 10);
            }
            if(Cuello == "mao")
            {
                precioF = precioF + (precioF / 100 * 30);
            }
            return precioF;
        }

        public override string ImprimirPr()
        {
            return base.ImprimirPr() +
                "Camisa Manga: " + Manga +
                "Cuello: " + Cuello +
                "--------------------------------------";
        }
    }
}
