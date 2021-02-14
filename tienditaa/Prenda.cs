using System;
namespace tienditaa
{
     public class Prenda
    {
        //Atributos 
        protected String Calidad;
        protected float Precio;
        protected int CantStock;

        //Getters y setters
        public float Precio1 { get => Precio; set => Precio = value; }
        public int CantStock1 { get => CantStock; set => CantStock = value; }
        public string Calidad1 { get => Calidad; set => Calidad = value; }

        public Prenda()
        {
        }


    }
}
