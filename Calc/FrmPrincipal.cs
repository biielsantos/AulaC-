using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txt1valor.Focus();
            txt1valor.Select();
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 + valor2;
            lblmostrar.Text = resultado.ToString();
            txt1valor.Text = "";
            txt2valor.Text = "";
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 - valor2;
            lblmostrar.Text = resultado.ToString();
            txt1valor.Text = "";
            txt2valor.Text = "";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 * valor2;
            lblmostrar.Text = resultado.ToString();
            txt1valor.Text = "";
            txt2valor.Text = "";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = Convert.ToDouble(txt1valor.Text);
            valor2 = Convert.ToDouble(txt2valor.Text);
            resultado = valor1 / valor2;
            lblmostrar.Text = resultado.ToString();
            txt1valor.Text = "";
            txt2valor.Text = "";
        }
    }
}
