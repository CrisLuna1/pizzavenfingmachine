using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedoraPizzas.StatePattern
{
    internal class NoMoneyState : IVendingMachineState
    {
        /**
        * @author Jorge A. Lopez
        * @date 10/21/2022
        */
        public void DispenseProduct(String x, int y)
        {
            MessageBox.Show("No se ha seleccionado un producto y no se ha introducido dinero","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
           
        }

    }
}
