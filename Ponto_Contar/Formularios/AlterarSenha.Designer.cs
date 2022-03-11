namespace Ponto_Contar
{
    partial class AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarSenha));
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.txtAlterarSenha = new System.Windows.Forms.TextBox();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.lblNovaAlterarSenha = new System.Windows.Forms.Label();
            this.txtNovaAlterarSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarNovaAlterarSenha = new System.Windows.Forms.Label();
            this.txtConfirmarNovaAlterarSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirmar.Location = new System.Drawing.Point(85, 220);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 28);
            this.cmdConfirmar.TabIndex = 6;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtAlterarSenha
            // 
            this.txtAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlterarSenha.Location = new System.Drawing.Point(27, 51);
            this.txtAlterarSenha.Name = "txtAlterarSenha";
            this.txtAlterarSenha.PasswordChar = '*';
            this.txtAlterarSenha.Size = new System.Drawing.Size(240, 26);
            this.txtAlterarSenha.TabIndex = 1;
            this.txtAlterarSenha.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtAlterarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarSenha.Location = new System.Drawing.Point(23, 26);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(60, 20);
            this.lblAlterarSenha.TabIndex = 0;
            this.lblAlterarSenha.Text = "Senha:";
            // 
            // lblNovaAlterarSenha
            // 
            this.lblNovaAlterarSenha.AutoSize = true;
            this.lblNovaAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaAlterarSenha.Location = new System.Drawing.Point(23, 88);
            this.lblNovaAlterarSenha.Name = "lblNovaAlterarSenha";
            this.lblNovaAlterarSenha.Size = new System.Drawing.Size(100, 20);
            this.lblNovaAlterarSenha.TabIndex = 2;
            this.lblNovaAlterarSenha.Text = "Nova Senha:";
            // 
            // txtNovaAlterarSenha
            // 
            this.txtNovaAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaAlterarSenha.Location = new System.Drawing.Point(26, 111);
            this.txtNovaAlterarSenha.Name = "txtNovaAlterarSenha";
            this.txtNovaAlterarSenha.PasswordChar = '*';
            this.txtNovaAlterarSenha.Size = new System.Drawing.Size(241, 26);
            this.txtNovaAlterarSenha.TabIndex = 3;
            // 
            // lblConfirmarNovaAlterarSenha
            // 
            this.lblConfirmarNovaAlterarSenha.AutoSize = true;
            this.lblConfirmarNovaAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarNovaAlterarSenha.Location = new System.Drawing.Point(22, 151);
            this.lblConfirmarNovaAlterarSenha.Name = "lblConfirmarNovaAlterarSenha";
            this.lblConfirmarNovaAlterarSenha.Size = new System.Drawing.Size(173, 20);
            this.lblConfirmarNovaAlterarSenha.TabIndex = 4;
            this.lblConfirmarNovaAlterarSenha.Text = "Confirmar Nova Senha:";
            // 
            // txtConfirmarNovaAlterarSenha
            // 
            this.txtConfirmarNovaAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarNovaAlterarSenha.Location = new System.Drawing.Point(25, 174);
            this.txtConfirmarNovaAlterarSenha.Name = "txtConfirmarNovaAlterarSenha";
            this.txtConfirmarNovaAlterarSenha.PasswordChar = '*';
            this.txtConfirmarNovaAlterarSenha.Size = new System.Drawing.Size(241, 26);
            this.txtConfirmarNovaAlterarSenha.TabIndex = 5;
            this.txtConfirmarNovaAlterarSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmarNovaAlterarSenha_KeyDown);
            // 
            // AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(308, 263);
            this.Controls.Add(this.lblConfirmarNovaAlterarSenha);
            this.Controls.Add(this.txtConfirmarNovaAlterarSenha);
            this.Controls.Add(this.lblNovaAlterarSenha);
            this.Controls.Add(this.txtNovaAlterarSenha);
            this.Controls.Add(this.lblAlterarSenha);
            this.Controls.Add(this.txtAlterarSenha);
            this.Controls.Add(this.cmdConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.Load += new System.EventHandler(this.AlterarSenha_Load);
            this.Shown += new System.EventHandler(this.Cadastro_de_Colaborador_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastro_de_Colaborador_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.TextBox txtAlterarSenha;
        private System.Windows.Forms.Label lblAlterarSenha;
        private System.Windows.Forms.Label lblNovaAlterarSenha;
        private System.Windows.Forms.TextBox txtNovaAlterarSenha;
        private System.Windows.Forms.Label lblConfirmarNovaAlterarSenha;
        private System.Windows.Forms.TextBox txtConfirmarNovaAlterarSenha;
    }
}