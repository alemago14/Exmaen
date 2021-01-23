using System;
namespace tiendita
{
    public class Pantalon : Prenda
    {
        //atributo 
        public string tipo { get => tipo; set => tipo = value; }
        public Pantalon()
        {
        }

        public Pantalon(string calidad, float precio, int cantStock, int codigoPrenda, string tipo)
        {
            this.calidad = calidad;
            this.precio = precio;
            this.cantStock = cantStock;
            this.codigoPrenda = codigoPrenda;
            this.tipo = tipo;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Camisa");
            Console.WriteLine("Tipo: " + tipo);
        }
    }
}
