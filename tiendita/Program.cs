using System;

namespace tiendita
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Prenda[] prendas;
            prendas = new Prenda[5];
            prendas[0] = new Camisa("Premiun", 512, 200, 01, "Corta", "Mao");
            prendas[1] = new Camisa("Premiun", 512, 300, 02, "Corta", "Normal");
            prendas[2] = new Camisa("Premiun", 512, 150, 03, "Larga", "Mao");
            prendas[3] = new Camisa("Premiun", 512, 350, 04, "Larga", "Normal");

            Vendedor[] vendedores;
            vendedores = new Vendedor[1];
            vendedores[0] = new Vendedor("Angel", "Estrada", 101);

            Tienda t1 = new Tienda("America", "buenos aires 512", prendas[1], vendedores[0]);

            Cotizacion c1 = new Cotizacion(123, DateTime.Now, prendas[1], 20, 101);
            vendedores[0].GenerarCotizacion(c1);
            vendedores[0].HistorialCotizaciones();

        }
    }
}
