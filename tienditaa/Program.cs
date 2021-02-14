using System;
using System.Collections.Generic;

namespace tienditaa
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Vendedor> Vendedores = new List<Vendedor>();
            Vendedor v1 = new Vendedor("Pedro", "Picapiedra", 52);
            Vendedores.Add(v1);

            List<Prenda> Prendas = new List<Prenda>();
            Camisa c1 = new Camisa("premium", 550, 200, "corta", "mao");
            Camisa c2 = new Camisa("standard", 550, 200, "corta", "mao");
            Camisa c3 = new Camisa("premium", 525, 300, "corta", "normal");
            Camisa c4 = new Camisa("standard", 525, 300, "corta", "normal");
            Camisa c5 = new Camisa("premium", 550, 150, "larga", "mao");
            Camisa c6 = new Camisa("standard", 550, 150, "larga", "mao");
            Camisa c7 = new Camisa("premium", 550, 350, "larga", "normal");
            Camisa c8 = new Camisa("standard", 550, 350, "larga", "normal");
            Pantalon p1 = new Pantalon("premium", 550, 1500, "chupin");
            Pantalon p2 = new Pantalon("standard", 550, 1500, "chupin");
            Pantalon p3 = new Pantalon("premium", 550, 500, "normal");
            Pantalon p4 = new Pantalon("standard", 550, 500, "normal");
            Prendas.Add(c1);
            Prendas.Add(c2);
            Prendas.Add(c3);
            Prendas.Add(c4);
            Prendas.Add(c5);
            Prendas.Add(c6);
            Prendas.Add(c7);
            Prendas.Add(c8);
            Prendas.Add(p1);
            Prendas.Add(p2);
            Prendas.Add(p3);
            Prendas.Add(p4);

            //Instancia del objeto tienda
            TiendaDeRopa t1 = new TiendaDeRopa("La Esquina", "San Martin 100", Prendas, Vendedores);

            //menu
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Tienda: " + t1.Nombre1 + " Dirección: " + t1.Direccion1);
            Console.WriteLine("Vendedor: " + v1.Nombre1 + " " + v1.Apellido1);

            int opcion = 0;
            while(opcion != 9)
            {
                Console.WriteLine("Que desea cotizar");
                Console.WriteLine("1 para Camisas.");
                Console.WriteLine("2 para Pantalon.");
                Console.WriteLine("3 para imprimir cotizaciones anteriores.");
                Console.WriteLine("9 para salir");

                string ca1 = Console.ReadLine();
                opcion = int.Parse(ca1);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Camisa tipo:");
                        Console.WriteLine("1 para Premium.");
                        Console.WriteLine("2 para Standard.");


                        ca1 = Console.ReadLine();
                        opcion = int.Parse(ca1);


                        switch (opcion)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Camisa Premium:");
                                Console.WriteLine("1 para Manga Corta.");
                                Console.WriteLine("2 para Manga Larga.");
                                ca1 = Console.ReadLine();
                                opcion = int.Parse(ca1);

                                switch (opcion)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Camisa Premium - Manga Corta:");
                                        Console.WriteLine("1 para Cuello Normal.");
                                        Console.WriteLine("2 para Cuello Mao.");
                                        ca1 = Console.ReadLine();
                                        opcion = int.Parse(ca1);

                                        switch (opcion)
                                        {
                                            case 1:
                                                //Iniciar cotizacion
                                                //Camisa c3 = new Camisa("premium", 525, 300, "corta", "normal");
                                                Console.Clear(); //Limpiar consola
                                                Console.WriteLine("Ha seleccionado Camisa Premium manga corta cuello normal");
                                                Console.WriteLine("Ingrese la cantidad a comprar: ");
                                                string st = Console.ReadLine();
                                                int cantStock = int.Parse(st);

                                                //Calculamos el precio
                                                float resultadoCotizacion = c3.Precio1 * cantStock;

                                                //dETERMINAR SI LA PRENDA ES PREMIUM O NO
                                                if (c3.Calidad1 == "premium")
                                                {
                                                    resultadoCotizacion = resultadoCotizacion + resultadoCotizacion / 100 * 30;
                                                }

                                                //Si la camisa es de tipo manga corta, el precio se rebaja en un 10%.
                                                if (c3.Manga1 == "corta")
                                                {
                                                    resultadoCotizacion = resultadoCotizacion - resultadoCotizacion / 100 * 10;
                                                }

                                                //Si la camisa tiene cuello mao, el precio aumenta en un 3%.
                                                if (c3.Cuello1 == "mao")
                                                {
                                                    resultadoCotizacion = resultadoCotizacion + resultadoCotizacion / 100 * 3;
                                                }

                                                Console.WriteLine(resultadoCotizacion);

                                                //generamos un numero de factura aleatorio
                                                Random r = new Random();
                                                int codigo = r.Next(999, 9999);

                                                //Instanciamos la cotizacion
                                                Cotizacion coti1 = new Cotizacion(codigo, v1.CodigoVendedor1, cantStock, DateTime.Now, c3, resultadoCotizacion);

                                                v1.GenerarCoti(coti1);
                                                coti1.ImprimirCotizacion();
                                                break;

                                            case 2:
                                                //Iniciar cotizacion
                                                //Camisa c1 = new Camisa("premium", 550, 200, "corta", "mao");
                                                Console.Clear(); //Limpiar consola
                                                Console.WriteLine("Ha seleccionado Camisa Premium manga corta cuello mao");
                                                Console.WriteLine("Ingrese la cantidad a comprar: ");
                                                 st = Console.ReadLine();
                                                 cantStock = int.Parse(st);

                                                //Calculamos el precio
                                                 resultadoCotizacion = c1.Precio1 * cantStock;

                                                //dETERMINAR SI LA PRENDA ES PREMIUM O NO
                                                if (c1.Calidad1 == "premium")
                                                {
                                                    resultadoCotizacion = resultadoCotizacion + resultadoCotizacion / 100 * 30;
                                                }

                                                //Si la camisa es de tipo manga corta, el precio se rebaja en un 10%.
                                                if (c1.Manga1 == "corta")
                                                {
                                                    resultadoCotizacion = resultadoCotizacion - resultadoCotizacion / 100 * 10;
                                                }

                                                //Si la camisa tiene cuello mao, el precio aumenta en un 3%.
                                                if (c1.Cuello1 == "mao")
                                                {
                                                    resultadoCotizacion = resultadoCotizacion + resultadoCotizacion / 100 * 3;
                                                }

                                                Console.WriteLine(resultadoCotizacion);

                                                //generamos un numero de factura aleatorio
                                                r = new Random();
                                                codigo = r.Next(999, 9999);

                                                //Instanciamos la cotizacion
                                                 coti1 = new Cotizacion(codigo, v1.CodigoVendedor1, cantStock, DateTime.Now, c1, resultadoCotizacion);

                                                v1.GenerarCoti(coti1);
                                                coti1.ImprimirCotizacion();
                                                break;
                                        }

                                        break;
                                }

                                break;
                        }

                        break;

                    case 3:
                        v1.ImprimirCotizaciones();
                        break;

                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        break;
                }
            }
        }
    }
}
