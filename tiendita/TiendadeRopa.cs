using System;
using System.Collections.Generic;

namespace tiendita
{
    public class TiendadeRopa
    {
        //atributos
        private String nombre, direccion;
        private List<Vendedor> vendedores;
        private List<Prenda> prendas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Vendedor> Vendedores { get => vendedores; set => vendedores = value; }
        public List<Prenda> Prendas { get => prendas; set => prendas = value; }

        //Constructores
        public TiendadeRopa(string nombre, string direccion, List<Vendedor> vendedores, List<Prenda> prendas)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.vendedores = vendedores;
            this.prendas = prendas;
        }

        public String nmb()
        {
            return nombre;
        }

    }
}
