using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_CSharp
{
    public partial class Form1: Form
{
    private Carro carro;
    private Avión avión;

    public Form1()
    {
        InitializeComponent();
        carro = new Carro();
        avión = new Avión();
    }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            lblFinal.Text = "";
            carro.Sonido();
            lblFinal.Text = "El carro hace RUUUUMMMMM'" + Environment.NewLine;

            lVehiculos Vehiculos = carro;
            carro.accion();
            lblFinal.Text += "Arrancó el carro";
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {
            lblFinal.Text = "";
            avión.Sonido();
            lblFinal.Text = "El avión hace FIUUUUMMM" + Environment.NewLine;

            lVehiculos Vehiculos = avión;
            avión.accion();
            lblFinal.Text += "Arrancó el avión";
        }
    }

}

