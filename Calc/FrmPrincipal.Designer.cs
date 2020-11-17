
namespace Calc
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1valor = new System.Windows.Forms.Label();
            this.txt1valor = new System.Windows.Forms.TextBox();
            this.btnsomar = new System.Windows.Forms.Button();
            this.lbl2valor = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.txt2valor = new System.Windows.Forms.TextBox();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1valor
            // 
            this.lbl1valor.AutoSize = true;
            this.lbl1valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1valor.Location = new System.Drawing.Point(59, 45);
            this.lbl1valor.Name = "lbl1valor";
            this.lbl1valor.Size = new System.Drawing.Size(94, 13);
            this.lbl1valor.TabIndex = 0;
            this.lbl1valor.Text = "Digite o 1 valor";
            // 
            // txt1valor
            // 
            this.txt1valor.Location = new System.Drawing.Point(62, 81);
            this.txt1valor.Name = "txt1valor";
            this.txt1valor.Size = new System.Drawing.Size(100, 20);
            this.txt1valor.TabIndex = 1;
            // 
            // btnsomar
            // 
            this.btnsomar.Location = new System.Drawing.Point(216, 45);
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.Size = new System.Drawing.Size(75, 23);
            this.btnsomar.TabIndex = 2;
            this.btnsomar.Text = "&Somar";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // lbl2valor
            // 
            this.lbl2valor.AutoSize = true;
            this.lbl2valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2valor.Location = new System.Drawing.Point(59, 124);
            this.lbl2valor.Name = "lbl2valor";
            this.lbl2valor.Size = new System.Drawing.Size(94, 13);
            this.lbl2valor.TabIndex = 3;
            this.lbl2valor.Text = "Digite o 2 valor";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(59, 203);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(64, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado";
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.Location = new System.Drawing.Point(216, 81);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnsubtrair.TabIndex = 5;
            this.btnsubtrair.Text = "S&ubtrair";
            this.btnsubtrair.UseVisualStyleBackColor = true;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(216, 119);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(75, 23);
            this.btnmultiplicar.TabIndex = 6;
            this.btnmultiplicar.Text = "&Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(216, 156);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(75, 23);
            this.btndividir.TabIndex = 7;
            this.btndividir.Text = "&Dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(216, 193);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sai&r";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // txt2valor
            // 
            this.txt2valor.Location = new System.Drawing.Point(62, 158);
            this.txt2valor.Name = "txt2valor";
            this.txt2valor.Size = new System.Drawing.Size(100, 20);
            this.txt2valor.TabIndex = 9;
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrar.Location = new System.Drawing.Point(59, 235);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(0, 31);
            this.lblmostrar.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 303);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.txt2valor);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbl2valor);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.txt1valor);
            this.Controls.Add(this.lbl1valor);
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1valor;
        private System.Windows.Forms.TextBox txt1valor;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Label lbl2valor;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txt2valor;
        private System.Windows.Forms.Label lblmostrar;
    }
}

