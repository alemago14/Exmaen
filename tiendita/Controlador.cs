using System;
using Gtk;


namespace tiendita
{
    public class Controlador
    {
        //atributos
        public RadioButton rb1, rb2;
        public CheckButton cb1, cb2, cb3, cb4;
        public Entry e1, e2;
        public TiendadeRopa t1;

        //constructor
        public Controlador()
        {

        }


        public Controlador(RadioButton rb1, RadioButton rb2, CheckButton cb1, CheckButton cb2, CheckButton cb3, CheckButton cb4, Entry e1, Entry e2)
        {
            this.rb1 = rb1;
            this.rb2 = rb2;
            this.cb1 = cb1;
            this.cb2 = cb2;
            this.cb3 = cb3;
            this.cb4 = cb4;
            this.e1 = e1;
            this.e2 = e2;
        }

        Vendedor v1 = new Vendedor("Pedro", "Picapiedra", 101);


        //metodos
        public void Total()
        {

            Camisa c1 = new Camisa("normal", 200, 500, "corta", "mao");
            Camisa c2 = new Camisa("premium", 200, 500, "corta", "mao");
            Camisa c3 = new Camisa("normal", 300, 500, "corta", "normal");
            Camisa c4 = new Camisa("premium", 300, 500, "corta", "normal");
            Camisa c5 = new Camisa("normal", 150, 500, "larga", "mao");
            Camisa c6 = new Camisa("premium", 150, 500, "larga", "mao");
            Camisa c7 = new Camisa("normal", 350, 500, "larga", "normal");
            Camisa c8 = new Camisa("premium", 350, 500, "larga", "normal");

            Pantalon p1 = new Pantalon("normal", 1500, 750, "chupin");
            Pantalon p2 = new Pantalon("premium", 1500, 750, "chupin");
            Pantalon p3 = new Pantalon("normal", 500, 750, "normal");
            Pantalon p4 = new Pantalon("premium", 500, 750, "normal");

            int dato1;
            String dato2;
            double dato3;

            if ((rb1.Active == true) && (cb1.Active == true) && (cb2.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c1.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$"+dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == true) && (cb2.Active == true)&&(cb4.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c2.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == true) && (cb2.Active == false)&& (cb4.Active == false))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c3.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == true) && (cb2.Active == false) && (cb4.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c4.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == false) && (cb2.Active == true) && (cb4.Active == false))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c5.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == false) && (cb2.Active == true) && (cb4.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c6.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == false) && (cb2.Active == false) && (cb4.Active == false))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c7.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb1.Active == true) && (cb1.Active == false) && (cb2.Active == false) && (cb4.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = c8.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb2.Active == true) && (cb3.Active == true) && (cb4.Active == false))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = p1.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb2.Active == true) && (cb3.Active == true) && (cb4.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = p2.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb2.Active == true) && (cb3.Active == false) && (cb4.Active == false))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = p3.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }

            if ((rb2.Active == true) && (cb3.Active == false) && (cb4.Active == true))
            {
                dato1 = Int32.Parse(e1.Text);
                dato3 = p1.PrecioFinal(dato1);
                dato2 = dato3.ToString();
                e2.Text = "$" + dato2;

                v1.GenerarCotizacion(c1, dato1, dato3);

            }
        }

        public String CC()
        {
            return v1.ImprimirHistorial();
        }
    }
}
