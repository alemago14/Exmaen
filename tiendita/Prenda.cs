using System;
namespace tiendita
{
    public abstract class Prenda
    {
        //atributos
        public string calidad { get => calidad; set => calidad = value; }
        public float precio { get => precio; set => precio = value; }
        public int cantStock { get => cantStock; set => cantStock = value; }
        public int codigoPrenda { get => codigoPrenda; set => codigoPrenda = value; }

        public Prenda()
        {
        }

        public abstract void Imprimir(); 
    }
}
