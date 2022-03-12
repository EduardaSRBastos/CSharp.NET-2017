namespace Exercicio_7
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbSequencial = new System.Windows.Forms.RadioButton();
            this.rtbPares = new System.Windows.Forms.RadioButton();
            this.lstNumero = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbPares);
            this.groupBox1.Controls.Add(this.rtbSequencial);
            this.groupBox1.Location = new System.Drawing.Point(7, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                 Seleção do tipo de listagem          ";
            // 
            // rtbSequencial
            // 
            this.rtbSequencial.AutoSize = true;
            this.rtbSequencial.Location = new System.Drawing.Point(6, 32);
            this.rtbSequencial.Name = "rtbSequencial";
            this.rtbSequencial.Size = new System.Drawing.Size(78, 17);
            this.rtbSequencial.TabIndex = 0;
            this.rtbSequencial.TabStop = true;
            this.rtbSequencial.Text = "Sequencial";
            this.rtbSequencial.UseVisualStyleBackColor = true;
            // 
            // rtbPares
            // 
            this.rtbPares.AutoSize = true;
            this.rtbPares.Location = new System.Drawing.Point(171, 32);
            this.rtbPares.Name = "rtbPares";
            this.rtbPares.Size = new System.Drawing.Size(55, 17);
            this.rtbPares.TabIndex = 1;
            this.rtbPares.TabStop = true;
            this.rtbPares.Text = "Pares ";
            this.rtbPares.UseVisualStyleBackColor = true;
            // 
            // lstNumero
            // 
            this.lstNumero.FormattingEnabled = true;
            this.lstNumero.Location = new System.Drawing.Point(13, 111);
            this.lstNumero.Name = "lstNumero";
            this.lstNumero.Size = new System.Drawing.Size(158, 173);
            this.lstNumero.TabIndex = 1;
            this.lstNumero.SelectedIndexChanged += new System.EventHandler(this.lstNumero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limite";
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(70, 21);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 3;
            this.txtLimite.TextChanged += new System.EventHandler(this.txtLimite_TextChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(183, 111);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 290);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNumero);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rtbPares;
        private System.Windows.Forms.RadioButton rtbSequencial;
        private System.Windows.Forms.ListBox lstNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnListar;
    }
}

