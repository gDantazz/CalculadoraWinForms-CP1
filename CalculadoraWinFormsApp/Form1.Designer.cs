namespace CalculadoraWinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btnClear, btnIgual, btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private System.Windows.Forms.Button btnAdd, btnSub, btnMul, btnDiv, btnPow, btnSqrt, btnComma;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtVisor = new TextBox();
            btnClear = new Button();
            btnSqrt = new Button();
            btnPow = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btn0 = new Button();
            btnComma = new Button();
            btnIgual = new Button();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Font = new Font("Segoe UI", 18F);
            txtVisor.Location = new Point(12, 12);
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.Size = new Size(276, 39);
            txtVisor.TabIndex = 0;
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 60);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 45);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(76, 60);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(60, 45);
            btnSqrt.TabIndex = 2;
            btnSqrt.Text = "√";
            // 
            // btnPow
            // 
            btnPow.Location = new Point(140, 60);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(60, 45);
            btnPow.TabIndex = 3;
            btnPow.Text = "x^y";
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(204, 60);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(60, 45);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "/";
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 109);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 45);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            // 
            // btn8
            // 
            btn8.Location = new Point(76, 109);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 45);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            // 
            // btn9
            // 
            btn9.Location = new Point(140, 109);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 45);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            // 
            // btnMul
            // 
            btnMul.Location = new Point(204, 109);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(60, 45);
            btnMul.TabIndex = 8;
            btnMul.Text = "*";
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 158);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 45);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            // 
            // btn5
            // 
            btn5.Location = new Point(76, 158);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 45);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            // 
            // btn6
            // 
            btn6.Location = new Point(140, 158);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 45);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            // 
            // btnSub
            // 
            btnSub.Location = new Point(204, 158);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(60, 45);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 207);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 45);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            // 
            // btn2
            // 
            btn2.Location = new Point(76, 207);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 45);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            // 
            // btn3
            // 
            btn3.Location = new Point(140, 207);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 45);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(204, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 45);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 256);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 45);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            // 
            // btnComma
            // 
            btnComma.Location = new Point(76, 256);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(60, 45);
            btnComma.TabIndex = 18;
            btnComma.Text = ",";
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(140, 256);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(124, 45);
            btnIgual.TabIndex = 19;
            btnIgual.Text = "=";
            // 
            // Form1
            // 
            ClientSize = new Size(292, 306);
            Controls.Add(txtVisor);
            Controls.Add(btnClear);
            Controls.Add(btnSqrt);
            Controls.Add(btnPow);
            Controls.Add(btnDiv);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnMul);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnSub);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btnComma);
            Controls.Add(btnIgual);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
