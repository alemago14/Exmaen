using System;
namespace tiendita
{
    public class Cotizacion
    {
        //Atributos
        private int codigoCotizacion { get => codigoCotizacion; set => codigoCotizacion = value; }
        private DateTime fechaYhora { get => fechaYhora; set => fechaYhora = value; }
        private Prenda prendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        private int cantUnidades { get => cantUnidades; set => cantUnidades = value; }
        private int codigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        //Constructor
        public Cotizacion(int codigoCotizacion, DateTime fechaYhora, Prenda prendaCotizada, int cantUnidades, int codigoVendedor)
        {
            this.codigoCotizacion = codigoCotizacion;
            this.fechaYhora = fechaYhora;
            this.prendaCotizada = prendaCotizada;
            this.cantUnidades = cantUnidades;
            this.codigoVendedor = codigoVendedor;
        }

        public Cotizacion()
        {
        }

       public float PrecioFinal()
        {
            float preciofinal;
            preciofinal = prendaCotizada.precio * cantUnidades;
            if (prendaCotizada.calidad == "Premium")
            {
                preciofinal = preciofinal + (preciofinal /100*30);
            }
            if(prendaCotizada.manga == "Corta")
            {
                preciofinal = preciofinal + (preciofinal / 100 * 3);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Cotizacion" +codigoCotizacion);
            Console.WriteLine("prenda cotizada:");
            prendaCotizada.Imprimir();
            Console.WriteLine("UNIDADES: " + cantUnidades);
            Console.WriteLine("Vendedor: " + codigoVendedor);

        }
    }
}
