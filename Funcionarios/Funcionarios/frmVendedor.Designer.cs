namespace Funcionarios
{
    partial class frmVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVender = new System.Windows.Forms.Button();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMostrarComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(140, 86);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(107, 60);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(160, 20);
            this.txtValorVenda.TabIndex = 1;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(75, 9);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(140, 33);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor";
            this.lblVendedor.Click += new System.EventHandler(this.lblVendedor_Click);
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(12, 63);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(91, 13);
            this.lblValorVenda.TabIndex = 4;
            this.lblValorVenda.Text = "Valor Venda   R$:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(192, 135);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnMostrarComissao
            // 
            this.btnMostrarComissao.Location = new System.Drawing.Point(24, 135);
            this.btnMostrarComissao.Name = "btnMostrarComissao";
            this.btnMostrarComissao.Size = new System.Drawing.Size(118, 23);
            this.btnMostrarComissao.TabIndex = 7;
            this.btnMostrarComissao.Text = "Mostrar Comissão";
            this.btnMostrarComissao.UseVisualStyleBackColor = true;
            this.btnMostrarComissao.Click += new System.EventHandler(this.btnMostrarComissao_Click);
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 172);
            this.Controls.Add(this.btnMostrarComissao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.btnVender);
            this.Name = "frmVendedor";
            this.Text = "Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMostrarComissao;
    }
}