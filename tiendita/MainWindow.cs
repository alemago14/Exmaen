using System;
using System.Collections.Generic;
using Gtk;
using tiendita;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        Vendedor v1 = new Vendedor("Pedro", "Picapiedra", 101);
        List<Vendedor> vendedores = new List<Vendedor>();
        vendedores.Add(v1);

        List<Prenda> prendas = new List<Prenda>();
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
        prendas.Add(c1);
        prendas.Add(c2);
        prendas.Add(c3);
        prendas.Add(c4);
        prendas.Add(c5);
        prendas.Add(c6);
        prendas.Add(c7);
        prendas.Add(c8);
        prendas.Add(p1);
        prendas.Add(p2);
        prendas.Add(p3);
        prendas.Add(p4);

        TiendadeRopa t1 = new TiendadeRopa("Topper", "San Martin 503", vendedores, prendas);


        label2.Text = t1.nmb();
        label3.Text = t1.Direccion;

        label4.Text = v1.Nombre + " " + v1.Apellido + " Cod:";

         


    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    Controlador con1 = new Controlador();

    protected void Click(object sender, EventArgs e)
    {
        con1 = new Controlador(radiobutton1, radiobutton2, checkbutton1, checkbutton2, checkbutton3, checkbutton4, entry1, entry2);
        con1.Total();
    }

    protected void click2(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, con1.CC());
        md.Run();
        md.Destroy();
    }
}
