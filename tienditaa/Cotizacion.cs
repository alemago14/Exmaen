using System;

namespace tienditaa
{
    public class Cotizacion
    {
        //Atributos
        private int NumeroCotizacion, CodigoVendedor, CantUnidades;
        private DateTime FechaYHora;
        private Prenda PrendaCotizada;
        private float ResultadoCotizacion;

        //Getters y Setters
        public int NumeroCotizacion1 { get => NumeroCotizacion; set => NumeroCotizacion = value; }
        public int CodigoVendedor1 { get => CodigoVendedor; set => CodigoVendedor = value; }
        public int CantUnidades1 { get => CantUnidades; set => CantUnidades = value; }
        public DateTime FechaYHora1 { get => FechaYHora; set => FechaYHora = value; }
        public Prenda PrendaCotizada1 { get => PrendaCotizada; set => PrendaCotizada = value; }
        public float ResultadoCotizacion1 { get => ResultadoCotizacion; set => ResultadoCotizacion = value; }

        //Constructor
        public Cotizacion(int NumeroCotizacion, int CodigoVendedor, int CantUnidades, DateTime FechaYHora, Prenda PrendaCotizada, float ResultadoCotizacion)
        {
            this.NumeroCotizacion = NumeroCotizacion;
            this.CodigoVendedor = CodigoVendedor;
            this.CantUnidades = CantUnidades;
            this.FechaYHora = FechaYHora;
            this.PrendaCotizada = PrendaCotizada;
            this.ResultadoCotizacion = ResultadoCotizacion;
        }

        //metodos
        public void ImprimirCotizacion()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Cotizacion N°" + NumeroCotizacion);
            Console.WriteLine("Codigo Vendedor: " + CodigoVendedor);
            Console.WriteLine("Cantidades pedidas" + CantUnidades);
            Console.WriteLine("Fecha y hora" + FechaYHora);
            Console.WriteLine("Prenda: ");
            Console.WriteLine("Precio final: $" + ResultadoCotizacion);
            Console.WriteLine("---------------------------------------------------");
        }



    }
}