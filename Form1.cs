using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reajustesalarial
{
    public partial class fmReajusteSalalrial : Form
    {
        //Valores para checagem de RadioButton
        RadioButton rbCategoria = null;
        RadioButton rbTurno = null;

        Double salarioMinimo = 0;
        Double salarioBruto = 0;
        Double horasTrabalhadas = 0;
        Double coeficiente =0;
        Double sLiquido = 0;

        Double getCoeficiente()
        {
            if (rbMatutino.Checked)
            {
                coeficiente = (salarioMinimo * 1.01) - salarioMinimo;
            }
            else if (rbVespertino.Checked)
            {
                coeficiente = (salarioMinimo * 1.02) - salarioMinimo;
            }
            else
            {
                coeficiente = (salarioMinimo * 1.03) - salarioMinimo;
            }

            return coeficiente; 
        }

        Double getSalarioBruto()
        {
            salarioBruto = getCoeficiente() * horasTrabalhadas;

            return Math.Round(salarioBruto, 2);
        }

        Double getImpostoHipotetilco()
        {
            Double imposto=0;
            

            if (rbCalouro.Checked)
            {
                if (salarioBruto < 300)
                {
                    imposto = salarioBruto * 0.01;
                }
                else
                {
                    imposto = salarioBruto * 0.02;
                }
            }
            else if (rbVeterano.Checked)
            {
                if (salarioBruto < 400)
                {
                    imposto = salarioBruto * 0.03;
                }
                else
                {
                    imposto = salarioBruto * 0.04;
                }
            }

            return imposto;
        }

        Double getGratificação()
        {
            Double gratificacao;  
            if (rbNoturno.Checked  && horasTrabalhadas > 80)
            {
                gratificacao = 50;
            }
            else
            {
                gratificacao =30;
            }

            return gratificacao;
        }

        Double getAuxilioAlimentacao()
        {
            Double auxilio =0;
            Double terco = 0.3333333333;
            //salalrio bruto menor que o terço do salario minimo. 
           
            if (rbCalouro.Checked || (getSalarioBruto() < salarioMinimo/2))
            {
                auxilio = getSalarioBruto() * terco;
            }
            else
            {
                auxilio = getSalarioBruto() * (terco/2);
            }

            return auxilio;
        }

        Double getLiquido()
        {
            sLiquido = getSalarioBruto() - getImpostoHipotetilco() + getGratificação() + getAuxilioAlimentacao();
            if (sLiquido < 350)
            {
                txtResultado.Text = "Mal Remunerado.";
                txtResultado.BackColor = Color.Red;
                txtResultado.ForeColor = Color.White;

            }
            else if(sLiquido >= 550 && sLiquido <= 600)
            {
                txtResultado.Text = "Normal.";
                txtResultado.BackColor = Color.Yellow;
                txtResultado.ForeColor = Color.Blue;
            }
            else
            {
                txtResultado.Text = "Bem Remuneraldo.";
                txtResultado.BackColor = Color.Green;
                txtResultado.ForeColor = Color.White;
            }

            return sLiquido;
        }
        public fmReajusteSalalrial()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            if (txtHorasTrabalhadas.Text == "" || txtSalarioMinimo.Text == "")
            {
                MessageBox.Show("Verifique os campos Salario Minimo e Horas Trabalhadas, os campos devem estar preenchidos", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                salarioMinimo = Convert.ToDouble(txtSalarioMinimo.Text);
                horasTrabalhadas = Convert.ToDouble(txtHorasTrabalhadas.Text);
                
                getCoeficiente();
                getSalarioBruto();
                getImpostoHipotetilco();


                lbDescricao.Text =
                    "Valor do coeficiente:\n" +
                    "Salario bruto:\n" +
                    "Valor do imposto:\n" +
                    "Valor da gratificaçâo:\n" +
                    "Valor do auxilio alimentação:\n" +
                    "Salario liquido:";

                
                lbValor.Text =
                    "R$  " + string.Format("{0:N}", getCoeficiente()) +
                    "\nR$  " + string.Format("{0:N}", getSalarioBruto()) +
                    "\nR$  " + string.Format("{0:N}", getImpostoHipotetilco()) +
                    "\nR$  " + string.Format("{0:N}", getGratificação()) +
                    "\nR$  " + string.Format("{0:N}", getAuxilioAlimentacao()) +
                    "\nR$  " + string.Format("{0:N}", getLiquido());
               
            }
        }

        private void RbCalouro_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbCheked = (RadioButton)sender;

            if (rbCheked.Checked)
            {
                rbCategoria = rbCheked;
                SetTurno();
            }

            int SetTurno()
            {

                return 0;
            }
        }

        private void RbMatutino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbCheked = (RadioButton)sender;

            if (rbCheked.Checked)
            {
                rbTurno = rbCheked;
                SetTurno();
            }

            int SetTurno()
            {

                return 0;
            }
        }

        private void TxtSalarioMinimo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btCalcular.Focus();
            }

            
        }

        private void PnlDescricao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
