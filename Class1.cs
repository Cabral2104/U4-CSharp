using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_CSharp
{
    public abstract class Vehiculos
    {
        public abstract void Sonido();
    }

    public class Carro : Vehiculos, lVehiculos
    {
        public override void Sonido()
        {
            MessageBox.Show("RUUUUMMMMMMMM!");
        }

        public void accion()
        {
            MessageBox.Show("Arrancaste el carro");
        }
    }

    public class Avión : Vehiculos, lVehiculos
    {
        public override void Sonido()
        {
            MessageBox.Show("FIUUUUUMMMMMM!");
        }

        public void accion()
        {
            MessageBox.Show("El avión esta tomando altura");
        }
    }

    public interface lVehiculos
    {
        void accion();
    }
}
