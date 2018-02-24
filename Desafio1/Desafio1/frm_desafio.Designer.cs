namespace Desafio1
{
    partial class frm_desafio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.list_input = new System.Windows.Forms.ListBox();
            this.btn_add_array = new System.Windows.Forms.Button();
            this.btn_fill_list = new System.Windows.Forms.Button();
            this.lbl_strings = new System.Windows.Forms.Label();
            this.list_strings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_decimal = new System.Windows.Forms.ListBox();
            this.btn_divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(25, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Digite as palavras";
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(28, 30);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(192, 20);
            this.txt_Input.TabIndex = 1;
            // 
            // list_input
            // 
            this.list_input.FormattingEnabled = true;
            this.list_input.Location = new System.Drawing.Point(28, 141);
            this.list_input.Name = "list_input";
            this.list_input.Size = new System.Drawing.Size(192, 134);
            this.list_input.TabIndex = 2;
            // 
            // btn_add_array
            // 
            this.btn_add_array.Location = new System.Drawing.Point(66, 56);
            this.btn_add_array.Name = "btn_add_array";
            this.btn_add_array.Size = new System.Drawing.Size(104, 23);
            this.btn_add_array.TabIndex = 3;
            this.btn_add_array.Text = "Adicionar ao Vetor";
            this.btn_add_array.UseVisualStyleBackColor = true;
            this.btn_add_array.Click += new System.EventHandler(this.btn_add_array_Click);
            // 
            // btn_fill_list
            // 
            this.btn_fill_list.Location = new System.Drawing.Point(84, 94);
            this.btn_fill_list.Name = "btn_fill_list";
            this.btn_fill_list.Size = new System.Drawing.Size(75, 23);
            this.btn_fill_list.TabIndex = 4;
            this.btn_fill_list.Text = "Preencher";
            this.btn_fill_list.UseVisualStyleBackColor = true;
            this.btn_fill_list.Click += new System.EventHandler(this.btn_fill_list_Click);
            // 
            // lbl_strings
            // 
            this.lbl_strings.AutoSize = true;
            this.lbl_strings.Location = new System.Drawing.Point(359, 13);
            this.lbl_strings.Name = "lbl_strings";
            this.lbl_strings.Size = new System.Drawing.Size(39, 13);
            this.lbl_strings.TabIndex = 5;
            this.lbl_strings.Text = "Strings";
            // 
            // list_strings
            // 
            this.list_strings.FormattingEnabled = true;
            this.list_strings.Location = new System.Drawing.Point(362, 30);
            this.list_strings.Name = "list_strings";
            this.list_strings.Size = new System.Drawing.Size(191, 108);
            this.list_strings.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Decimal";
            // 
            // list_decimal
            // 
            this.list_decimal.FormattingEnabled = true;
            this.list_decimal.Location = new System.Drawing.Point(365, 167);
            this.list_decimal.Name = "list_decimal";
            this.list_decimal.Size = new System.Drawing.Size(188, 108);
            this.list_decimal.TabIndex = 8;
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(255, 141);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 9;
            this.btn_divide.Text = ">>>>";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // frm_desafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 301);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.list_decimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_strings);
            this.Controls.Add(this.lbl_strings);
            this.Controls.Add(this.btn_fill_list);
            this.Controls.Add(this.btn_add_array);
            this.Controls.Add(this.list_input);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_desafio";
            this.Text = "Desafio 01 - Rodrigo Costa 52718";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.ListBox list_input;
        private System.Windows.Forms.Button btn_add_array;
        private System.Windows.Forms.Button btn_fill_list;
        private System.Windows.Forms.Label lbl_strings;
        private System.Windows.Forms.ListBox list_strings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_decimal;
        private System.Windows.Forms.Button btn_divide;
    }
}

