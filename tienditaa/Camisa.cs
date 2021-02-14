using System;
namespace tienditaa
{
    public class Camisa : Prenda
    {
        //Atributos
        private String Manga, Cuello;

        //Getters y setters
        public string Manga1 { get => Manga; set => Manga = value; }
        public string Cuello1 { get => Cuello; set => Cuello = value; }

        public Camisa(string Calidad, float Precio, int CantStock, string Manga, string Cuello)
        {
            this.Calidad = Calidad;
            this.Precio = Precio;
            this.CantStock = CantStock;
            this.Manga = Manga;
            this.Cuello = Cuello;
        }

        //Metodo imprimir
        public void Imprimir()
        {
            Console.WriteLine("Camisa");
            Console.WriteLine(Calidad1);
            Console.WriteLine("Precio: " + Precio1);
            Console.WriteLine("Stock: " + CantStock1);
            Console.WriteLine("Manga: " + Manga1);
            Console.WriteLine("Cuello: " + Cuello1);
        }
    }
}
