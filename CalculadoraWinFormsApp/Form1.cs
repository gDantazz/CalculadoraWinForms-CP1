using System;
using System.Windows.Forms;

namespace CalculadoraWinFormsApp
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            // Eventos dos números
            btn0.Click += AdicionarNumero;
            btn1.Click += AdicionarNumero;
            btn2.Click += AdicionarNumero;
            btn3.Click += AdicionarNumero;
            btn4.Click += AdicionarNumero;
            btn5.Click += AdicionarNumero;
            btn6.Click += AdicionarNumero;
            btn7.Click += AdicionarNumero;
            btn8.Click += AdicionarNumero;
            btn9.Click += AdicionarNumero;
            btnComma.Click += AdicionarNumero;

            // Eventos das operações
            btnAdd.Click += Operacao;
            btnSub.Click += Operacao;
            btnMul.Click += Operacao;
            btnDiv.Click += Operacao;
            btnPow.Click += Operacao;
            btnSqrt.Click += Operacao;

            // Eventos especiais
            btnClear.Click += btnClear_Click;
            btnIgual.Click += btnIgual_Click;
        }

        private void AdicionarNumero(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (txtVisor.Text == "0" && btn.Text != ",")
                    txtVisor.Text = btn.Text;
                else
                    txtVisor.Text += btn.Text;
            }
        }

        private void Operacao(object sender, EventArgs e)
        {
            if (sender is Button btn && double.TryParse(txtVisor.Text, out valor1))
            {
                operacao = btn.Text;
                txtVisor.Clear();

                if (operacao == "√")
                {
                    valor1 = Math.Sqrt(valor1);
                    txtVisor.Text = valor1.ToString();
                    operacao = "";
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtVisor.Text, out valor2))
                valor2 = 0;

            double resultado = operacao switch
            {
                "+" => valor1 + valor2,
                "-" => valor1 - valor2,
                "*" => valor1 * valor2,
                "/" => valor2 != 0 ? valor1 / valor2 : throw new DivideByZeroException(),
                "x^y" => Math.Pow(valor1, valor2),
                "√" => Math.Sqrt(valor1),
                _ => double.TryParse(txtVisor.Text, out var res) ? res : 0
            };

            if (operacao == "/" && valor2 == 0)
            {
                MessageBox.Show("Não é possível dividir por zero.");
                return;
            }

            txtVisor.Text = resultado.ToString();
            valor1 = resultado;
            operacao = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
        }
    }
}
