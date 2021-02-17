using System;
namespace tiendita
{
    public class Cotizacion
    {
        //atributos
        private int codigoCotizacion;
        private DateTime fechaHora;
        private int codigoVendedor;
        private Prenda prendaCotizada;
        private int unidadesCotizadas;
        private double resultadoCotizacion;

        //geters y seters
        public int CodigoCotizacion { get => codigoCotizacion; set => codigoCotizacion = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        public Prenda PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        public int UnidadesCotizadas { get => unidadesCotizadas; set => unidadesCotizadas = value; }
        public double ResultadoCotizacion { get => resultadoCotizacion; set => resultadoCotizacion = value; }

        //constructor
        public Cotizacion(int codigoCotizacion, DateTime fechaHora, int codigoVendedor, Prenda prendaCotizada, int unidadesCotizadas, double resultadoCotizacion)
        {
            this.codigoCotizacion = codigoCotizacion;
            this.fechaHora = fechaHora;
            this.codigoVendedor = codigoVendedor;
            this.prendaCotizada = prendaCotizada;
            this.unidadesCotizadas = unidadesCotizadas;
            this.resultadoCotizacion = resultadoCotizacion;
        }


        public String ImprimirC()
        {
            return "----------------------" +
                "Cod. Cotizacion :" + codigoCotizacion +
                "Fecha y Hora: " + FechaHora +
                "Cod. Vendedor: " + codigoVendedor +
                PrendaCotizada.ImprimirPr() +
                "Unidades Pedidas: " + UnidadesCotizadas +
                "Precio Final: " + ResultadoCotizacion +
                "-------------------------";
        }



    }
}
