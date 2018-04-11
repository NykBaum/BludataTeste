namespace TesteBludata
{
    partial class Filtrar
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataNascIni = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCadastroIni = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataNascFim = new System.Windows.Forms.DateTimePicker();
            this.dtpCadastroFim = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(162, 107);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 18;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(231, 20);
            this.txtNome.TabIndex = 15;
            // 
            // dtpDataNascIni
            // 
            this.dtpDataNascIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascIni.Location = new System.Drawing.Point(87, 45);
            this.dtpDataNascIni.Name = "dtpDataNascIni";
            this.dtpDataNascIni.ShowCheckBox = true;
            this.dtpDataNascIni.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNascIni.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dt. Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // dtpCadastroIni
            // 
            this.dtpCadastroIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastroIni.Location = new System.Drawing.Point(87, 77);
            this.dtpCadastroIni.Name = "dtpCadastroIni";
            this.dtpCadastroIni.ShowCheckBox = true;
            this.dtpCadastroIni.Size = new System.Drawing.Size(100, 20);
            this.dtpCadastroIni.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dt. Cadastro";
            // 
            // dtpDataNascFim
            // 
            this.dtpDataNascFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascFim.Location = new System.Drawing.Point(218, 45);
            this.dtpDataNascFim.Name = "dtpDataNascFim";
            this.dtpDataNascFim.ShowCheckBox = true;
            this.dtpDataNascFim.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNascFim.TabIndex = 22;
            // 
            // dtpCadastroFim
            // 
            this.dtpCadastroFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCadastroFim.Location = new System.Drawing.Point(218, 77);
            this.dtpCadastroFim.Name = "dtpCadastroFim";
            this.dtpCadastroFim.ShowCheckBox = true;
            this.dtpCadastroFim.Size = new System.Drawing.Size(100, 20);
            this.dtpCadastroFim.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "até";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "até";
            // 
            // Filtrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 141);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpCadastroFim);
            this.Controls.Add(this.dtpDataNascFim);
            this.Controls.Add(this.dtpCadastroIni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpDataNascIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Filtrar";
            this.Text = "Filtrar";
            this.Load += new System.EventHandler(this.Filtrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataNascIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCadastroIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataNascFim;
        private System.Windows.Forms.DateTimePicker dtpCadastroFim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}