using System;
using System.Collections.Generic;

namespace tienditaa
{
    public class TiendaDeRopa
    {
        //Atributos
        private String Nombre, Direccion;
        private List<Prenda> Prendas;
        private List<Vendedor> Vendedores;

        //Getters y setters
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public List<Prenda> Prendas1 { get => Prendas; set => Prendas = value; }
        public List<Vendedor> Vendedores1 { get => Vendedores; set => Vendedores = value; }

        public TiendaDeRopa(string nombre, string direccion, List<Prenda> prendas, List<Vendedor> vendedores)
        {
            Nombre = nombre;
            Direccion = direccion;
            Prendas = prendas;
            Vendedores = vendedores;
        }
    }
}
