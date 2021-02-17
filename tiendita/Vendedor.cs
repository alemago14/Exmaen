using System;
using System.Collections.Generic;
using System.Linq;

namespace tiendita
{

    public class Vendedor
    {
        //atributos
        private String nombre, apellido;
        private int codigoVendedor;
        private List<Cotizacion> cotizaciones;

        //geters y seters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public List<Cotizacion> Cotizaciones { get => cotizaciones; set => cotizaciones = value; }


        //Constructor
        public Vendedor(string nombre, string apellido, int codigoVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
            List<Cotizacion> coti = new List<Cotizacion>();
        }

        //metodos

        List<Cotizacion> coti = new List<Cotizacion>();

        public void GenerarCotizacion(Prenda prendacotizada, int cant, double resultado)
        {
            //codigo
            Random r1 = new Random();
            int codigo = r1.Next(999, 9999);

            DateTime fyh = DateTime.Now;

            Cotizacion coti1 = new Cotizacion(codigo, fyh, codigoVendedor, prendacotizada, cant, resultado);

            coti.Add(coti1);

        }


        public String ImprimirHistorial()
        {
            String cadena, cad1 = " ";

            if (coti.Count()!= 0)
            {
                for (int i = 0; i < coti.Count(); i ++ )
                {
                    cadena = coti[i].ImprimirC();
                    cad1 = cad1 + cadena;
                    return cad1;
                }
            }

            return "Todavia no se hacen cotizaciones.";
        }


    }
}
