using MaquinaExpendedoraPizzas.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedoraPizzas
{
    /// <summary>
    /// Class <c>VendingMachine</c> models a design for real world vending machine / finite state machine
    /// @author Jorge A. Lopez
    /// </summary>
    internal class VendingMachine : IVendingMachineState
    {
        /// Variable to maintain the internal state
        private IVendingMachineState vendingMachineState { get; set; }
        public int MoneyCount { get; set; }

        public VendingMachine()
        {
            MoneyCount = 0;
            vendingMachineState = new NoMoneyState();
        }

        public void DispenseProduct(string x, int y)
        {
            if (MoneyCount > 0)
            {
                vendingMachineState = new HasMoneyState();
                vendingMachineState.DispenseProduct(x,y);
            }else if (MoneyCount == 0)
            {
                vendingMachineState = new HasMoneyState();
                vendingMachineState.DispenseProduct(x, y);
            }
        }

    }
}
