using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIMC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtpeso;
            txtpeso.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
            resultado = (peso / (altura * altura));
            lblmostrar.Text = resultado.ToString("F");
            txtaltura.Text = "";
            txtpeso.Text = "";
            if (resultado < 18){
                MessageBox.Show("Magreza", "IMC", MessageBoxButtons.OK);
            }
            else if(resultado <= 24){
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK);
            }
            else if (resultado <= 29)
            {
                MessageBox.Show("Sobrepeso", "IMC", MessageBoxButtons.OK);
            }
            else if (resultado <= 39)
            {
                MessageBox.Show("Obesidade", "IMC", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Obesidade Grave", "IMC", MessageBoxButtons.OK);
            }
        }
    }
}
