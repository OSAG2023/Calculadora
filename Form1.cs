using System.Data;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BttnNumero1_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "1";
        }

        private void BttnNumero2_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "2";
        }

        private void BttnNumero3_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "3";
        }

        private void BttnNumero4_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "4";
        }

        private void BttnNumero5_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "5";
        }

        private void BttnNumero6_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "6";
        }

        private void BttnNumero7_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "7";
        }

        private void BttnNumero8_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "8";
        }

        private void BttnNumero9_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "9";
        }

        private void BttnNumero0_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "0";
        }

        private void BttnDividir_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "/";
        }

        private void BttnIgual_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            double total = Convert.ToDouble(dt.Compute(txtMostrar.Text, ""));
            txtMostrar.Text = total.ToString();
        }

        private void BttnPunto_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += ".";
        }

        private void BttnSumar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "+";
        }

        private void BttnMultiplicar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "*";
        }

        private void BttnBorrartodo_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = "";
        }

        private void BttnPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                double resultado = Convert.ToDouble(dt.Compute(txtMostrar.Text, ""));
                txtMostrar.Text = resultado.ToString();
            }
            catch (Exception)
            {
                // Mostrar un mensaje de error al usuario si la expresión no es válida
                MessageBox.Show("Por favor ingresa una expresión válida");
            }

        }

        private void BttnRestar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text += "-";
        }

        private void txtMostrar_TextChanged(object sender, EventArgs e)
        {
            txtMostrar.Text = "";
        }
    }
}