using System;
namespace tienditaa
{
    public class Pantalon : Prenda
    {
        //Atributos
        private string Tipo;

        //getter y setter
        public string Tipo1 { get => Tipo; set => Tipo = value; }

        //Constructor
        public Pantalon(string Calidad, float Precio, int CantStock, string Tipo)
        {
            this.Calidad = Calidad;
            this.Precio = Precio;
            this.CantStock = CantStock;
            this.Tipo = Tipo;
        }

        //Metodo imprimir
        public void Imprimir()
        {
            Console.WriteLine("Pantalon");
            Console.WriteLine(Calidad1);
            Console.WriteLine("Precio: " + Precio1);
            Console.WriteLine("Stock: " + CantStock1);
            Console.WriteLine("Tipo: " + Tipo1);
        }
    }
}
