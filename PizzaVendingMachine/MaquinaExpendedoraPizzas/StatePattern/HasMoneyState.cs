using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedoraPizzas.StatePattern
{
    internal class HasMoneyState : IVendingMachineState
    {

        public void DispenseProduct(String x, int cambio)
       
        {
            MessageBox.Show($"Se ha entregado tu pizza de {x} y tu cambio es: {cambio}", "Muchas gracias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
