namespace MaquinaExpendedoraPizzas
{


    public partial class Form1 : Form
    {
        VendingMachine vendingMachine;

        public Form1()
        {
            InitializeComponent();

            vendingMachine = new();

            DisableButtons();

        }

        public void MoneyStateReset()
        {
            vendingMachine.MoneyCount = 0;
        }

        //Actualizar el contador
        public void actualizarContador()
        {
            if (vendingMachine.MoneyCount >= 50) {

                vendingMachine.MoneyCount = 50;
                lblContadorTxt.Text = vendingMachine.MoneyCount.ToString();
            }
            else
            {
                lblContadorTxt.Text = vendingMachine.MoneyCount.ToString();
            }
            validadBtn();
            validaBotonPizza();
        }

        //Extraer digito de label --Luna
        public string Existencias(string cadena)
        {
            var resultado = Convert.ToInt32(cadena.Substring(11, 1)) - 1;
            string devolver = Convert.ToString(resultado);
            return devolver;
        }

        public void validadBtn()
        {
            if(vendingMachine.MoneyCount % 5 == 0)
            {
                EnableMoneyButtons(new Button[] { btn10, btn5, btn20 });
            }
            else
            {
                DisableButtons(new Button[] { btn10, btn5, btn20, btn50 });
            }
        }

        public void validaBotonPizza()
        {
            if (vendingMachine.MoneyCount >= 35)
            {
                EnableItemButtons(new Button[] { btnP1, btnJ2, btnN11 });

                if (vendingMachine.MoneyCount >= 40)
                {
                    EnableItemButtons(new Button[] { btnQ5, btnV9, btnC12 });
                }
                if (vendingMachine.MoneyCount >= 45)
                {
                    EnableItemButtons(new Button[] { btnM3, btnC6, btnD8 });
                }
                if (vendingMachine.MoneyCount == 50)
                {
                    EnableItemButtons(new Button[] { btnH3, btnS7, btnC10 });
                }
            }
            else
            {
                DisableButtons();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarContador();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            vendingMachine.MoneyCount += Denominacion.UN_QUETZAL;
            actualizarContador();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            vendingMachine.MoneyCount += Denominacion.CINCO_QUETZALES;
            actualizarContador();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            vendingMachine.MoneyCount += Denominacion.DIEZ_QUETZALES;
            actualizarContador();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            vendingMachine.MoneyCount += Denominacion.VEINTE_QUETZALES;
            actualizarContador();
        }

        private void btn50_Click(object sender, EventArgs e)
{
            vendingMachine.MoneyCount += Denominacion.CINCUENTA_QUETZALES;
            actualizarContador();
        }

        

        public void DisableButtons()
        {
            btnP1.Enabled = false;
            btnJ2.Enabled = false;
            btnN11.Enabled = false;
            btnQ5.Enabled = false;
            btnV9.Enabled = false;
            btnC12.Enabled = false;
            btnM3.Enabled = false;
            btnC6.Enabled = false;
            btnD8.Enabled = false;
            btnH3.Enabled = false;
            btnS7.Enabled = false;
            btnC10.Enabled = false;

            btnP1.BackColor = Color.Red;
            btnJ2.BackColor = Color.Red;
            btnN11.BackColor = Color.Red;
            btnQ5.BackColor = Color.Red;
            btnV9.BackColor = Color.Red;
            btnC12.BackColor = Color.Red;
            btnM3.BackColor = Color.Red;
            btnC6.BackColor = Color.Red;
            btnD8.BackColor = Color.Red;
            btnH3.BackColor = Color.Red;
            btnS7.BackColor = Color.Red;
            btnC10.BackColor = Color.Red;
        }
        public void EnableItemButtons(Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
                btn.BackColor = Color.Green;
            }
        }
        public void EnableMoneyButtons(Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
            }
        }
        public void DisableButtons(Button[] buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }
        private void btnCompletar_Click(object sender, EventArgs e)
        {
            //vendingMachine.DispenseProduct();
        }

        private void btnJ2_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelJ2.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelJ2.Text = "Existencia " + Existencias(labelJ2.Text);
                vendingMachine.MoneyCount -= Precios.JAMON;

                vendingMachine.DispenseProduct("Jamon", vendingMachine.MoneyCount);

                actualizarContador();
                MoneyStateReset();
            }
        }

        private void btnS7_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelS7.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelS7.Text = "Existencia " + Existencias(labelS7.Text);
                vendingMachine.MoneyCount -= Precios.SUPREMA;
                vendingMachine.DispenseProduct("SUPREMA", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelP1.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelP1.Text = "Existencia " + Existencias(labelP1.Text);
                vendingMachine.MoneyCount -= Precios.PEPERONI;
                vendingMachine.DispenseProduct("PEPERONI", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnQ5_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelQ5.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelQ5.Text = "Existencia " + Existencias(labelQ5.Text);
                vendingMachine.MoneyCount -= Precios.CUATRO_QUESOS;
                vendingMachine.DispenseProduct("4 Queso", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnH3_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelH4.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelH4.Text = "Existencia " + Existencias(labelH4.Text);
                vendingMachine.MoneyCount -= Precios.HAWAIANA;
                vendingMachine.DispenseProduct("Hawaina", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnV9_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelV9.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelV9.Text = "Existencia " + Existencias(labelV9.Text);
                vendingMachine.MoneyCount -= Precios.VEGANA;
                vendingMachine.DispenseProduct("Vegana", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnN11_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelN11.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelN11.Text = "Existencia " + Existencias(labelN11.Text);
                vendingMachine.MoneyCount -= Precios.NAPOLITANA;
                vendingMachine.DispenseProduct("Napolitana", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnC6_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelC6.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelC6.Text = "Existencia " + Existencias(labelC6.Text);
                vendingMachine.MoneyCount -= Precios.CINCO_CARNES;
                vendingMachine.DispenseProduct("5 Carnes", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelC10.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelC10.Text = "Existencia " + Existencias(labelC10.Text);
                vendingMachine.MoneyCount -= Precios.CHURRASCO;
                vendingMachine.DispenseProduct("Churrasco", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnC12_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelC12.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelC12.Text = "Existencia " + Existencias(labelC12.Text);
                vendingMachine.MoneyCount -= Precios.CHAMPINONES;
                vendingMachine.DispenseProduct("Championes", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnD8_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelD8.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelD8.Text = "Existencia " + Existencias(labelD8.Text);
                vendingMachine.MoneyCount -= Precios.DELUXE;
                vendingMachine.DispenseProduct("Deluxe", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
        }

        private void btnM3_Click_1(object sender, EventArgs e)
        {
            Console.Beep();

            if (labelM3.Text.Equals("Existencia 0"))
            {
                MessageBox.Show("Agotado, escoja otra especialidad");

            }
            else
            {
                labelM3.Text = "Existencia " + Existencias(labelM3.Text);
                vendingMachine.MoneyCount -= Precios.MARGARITA;
                vendingMachine.DispenseProduct("Margarita", vendingMachine.MoneyCount);
                MoneyStateReset();
                actualizarContador();
            }
           
        }
    }


}