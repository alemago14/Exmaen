using System;
namespace tiendita
{
    public class Tienda
    {
        //Atributos y getter y setter
        public string nombre { get => nombre; set => nombre = value; }
        public string direccion { get => direccion; set => direccion = value; }
        public Prenda prendas { get => prendas; set => prendas = value; }
        public Vendedor vendedores { get => vendedores; set => vendedores = value; }

        //Constructor
        public Tienda(string nombre, string direccion, Prenda prendas, Vendedor vendedores)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.prendas = prendas;
            this.vendedores = vendedores;
        }

        public Tienda()
        {
        }


    }
}
