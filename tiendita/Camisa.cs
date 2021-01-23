using System;
namespace tiendita
{
    public class Camisa : Prenda
    {
        //atributos
        public string manga { get => manga; set => manga = value; }
        public string cuello { get => cuello; set => cuello = value; }

        //constructor
        public Camisa()
        {
        }

        public Camisa(string calidad, float precio, int cantStock, int codigoPrenda, string manga, string cuello)
        {
            this.calidad = calidad;
            this.precio = precio;
            this.cantStock = cantStock;
            this.codigoPrenda = codigoPrenda;
            this.manga = manga;
            this.cuello = cuello;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Camisa");
            Console.WriteLine("Manga: "+manga);
            Console.WriteLine("Cuello: " + cuello);
        }
    }
}
