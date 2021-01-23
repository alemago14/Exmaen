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
            Vendedor v1 = new Vendedor("Angel", "Estrada", 101);

            Tienda t1 = new Tienda("America", "buenos aires 512", prendas, vendedores);

            Cotizacion c1 = new Cotizacion(123, DateTime.Now, prendas[1], 20, 101);
            vendedores[0].GenerarCotizacion(c1);
            vendedores[0].HistorialCotizaciones();
            Console.WriteLine("BIENVENIDO");
            Console.WriteLine("TIENDA:" + t1.nombre);
            Console.WriteLine("VENDEDOR:" + v1.Nombre);
            Console.WriteLine("Si desea comprar: ");
            Console.WriteLine("Camisa ingrese 1");
            Console.WriteLine("Pantalon ingrese 2");
            Console.WriteLine("Para salir presione 0");
            Console.WriteLine("Pantalon comun premium. Ingrese 1");
            Console.WriteLine("Pantalon comun Standard. Ingrese 2");
            Console.WriteLine("Pantalon chupin premium. Ingrese 3");
            Console.WriteLine("Pantalon chupin Standar. Ingrese 4");
            Console.WriteLine("Camisa Manga Corta cuello normal premium. Ingrese 5");
            Console.WriteLine("Camisa Manga Corta cuello normal Standard. Ingrese 6");
            Console.WriteLine("Camisa Manga Corta cuello mao premium. Ingrese 7");
            Console.WriteLine("Camisa Manga Corta cuello mao Standard. Ingrese 8");


        }
    }
}
