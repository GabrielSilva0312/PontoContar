namespace Ponto_Contar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJustificativaEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtJustificativaEntradaAlmoco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJustificativaSaida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.DataEntrada = new System.Windows.Forms.TextBox();
            this.DataSaidaAlmoco = new System.Windows.Forms.TextBox();
            this.DataEntradaAlmoco = new System.Windows.Forms.TextBox();
            this.DataSaida = new System.Windows.Forms.TextBox();
            this.txtJustificativaSaidaAlmoco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(34, 88);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(115, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada";
            // 
            // txtJustificativaEntrada
            // 
            this.txtJustificativaEntrada.Enabled = false;
            this.txtJustificativaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificativaEntrada.Location = new System.Drawing.Point(34, 172);
            this.txtJustificativaEntrada.Multiline = true;
            this.txtJustificativaEntrada.Name = "txtJustificativaEntrada";
            this.txtJustificativaEntrada.Size = new System.Drawing.Size(546, 76);
            this.txtJustificativaEntrada.TabIndex = 3;
            this.txtJustificativaEntrada.TextChanged += new System.EventHandler(this.txtJustificativa_TextChanged);
            this.txtJustificativaEntrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJustificativa_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(187, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(393, 26);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // cmdSair
            // 
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.Location = new System.Drawing.Point(360, 648);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(219, 36);
            this.cmdSair.TabIndex = 7;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(183, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Controle de Horários";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Início Almoço";
            // 
            // txtJustificativaEntradaAlmoco
            // 
            this.txtJustificativaEntradaAlmoco.Enabled = false;
            this.txtJustificativaEntradaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificativaEntradaAlmoco.Location = new System.Drawing.Point(34, 435);
            this.txtJustificativaEntradaAlmoco.Multiline = true;
            this.txtJustificativaEntradaAlmoco.Name = "txtJustificativaEntradaAlmoco";
            this.txtJustificativaEntradaAlmoco.Size = new System.Drawing.Size(546, 76);
            this.txtJustificativaEntradaAlmoco.TabIndex = 16;
            this.txtJustificativaEntradaAlmoco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJustificativaEntradaAlmoco_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fim Almoço";
            // 
            // txtJustificativaSaida
            // 
            this.txtJustificativaSaida.Enabled = false;
            this.txtJustificativaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificativaSaida.Location = new System.Drawing.Point(33, 569);
            this.txtJustificativaSaida.Multiline = true;
            this.txtJustificativaSaida.Name = "txtJustificativaSaida";
            this.txtJustificativaSaida.Size = new System.Drawing.Size(546, 76);
            this.txtJustificativaSaida.TabIndex = 19;
            this.txtJustificativaSaida.TextChanged += new System.EventHandler(this.txtJustificativaSaida_TextChanged);
            this.txtJustificativaSaida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJustificativaSaida_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Saída";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(183, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(182, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Hora:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(183, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hora:";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirmar.Location = new System.Drawing.Point(33, 648);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(220, 36);
            this.cmdConfirmar.TabIndex = 6;
            this.cmdConfirmar.Text = "Confirmar (F10)";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // DataEntrada
            // 
            this.DataEntrada.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntrada.Location = new System.Drawing.Point(242, 120);
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            this.DataEntrada.Size = new System.Drawing.Size(82, 26);
            this.DataEntrada.TabIndex = 24;
            this.DataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataSaidaAlmoco
            // 
            this.DataSaidaAlmoco.BackColor = System.Drawing.SystemColors.Menu;
            this.DataSaidaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSaidaAlmoco.Location = new System.Drawing.Point(242, 254);
            this.DataSaidaAlmoco.Name = "DataSaidaAlmoco";
            this.DataSaidaAlmoco.ReadOnly = true;
            this.DataSaidaAlmoco.Size = new System.Drawing.Size(82, 26);
            this.DataSaidaAlmoco.TabIndex = 25;
            this.DataSaidaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataEntradaAlmoco
            // 
            this.DataEntradaAlmoco.BackColor = System.Drawing.SystemColors.Menu;
            this.DataEntradaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntradaAlmoco.Location = new System.Drawing.Point(241, 385);
            this.DataEntradaAlmoco.Name = "DataEntradaAlmoco";
            this.DataEntradaAlmoco.ReadOnly = true;
            this.DataEntradaAlmoco.Size = new System.Drawing.Size(82, 26);
            this.DataEntradaAlmoco.TabIndex = 26;
            this.DataEntradaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataSaida
            // 
            this.DataSaida.BackColor = System.Drawing.SystemColors.Menu;
            this.DataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSaida.Location = new System.Drawing.Point(242, 517);
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.ReadOnly = true;
            this.DataSaida.Size = new System.Drawing.Size(82, 26);
            this.DataSaida.TabIndex = 27;
            this.DataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJustificativaSaidaAlmoco
            // 
            this.txtJustificativaSaidaAlmoco.Enabled = false;
            this.txtJustificativaSaidaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificativaSaidaAlmoco.Location = new System.Drawing.Point(33, 303);
            this.txtJustificativaSaidaAlmoco.Multiline = true;
            this.txtJustificativaSaidaAlmoco.Name = "txtJustificativaSaidaAlmoco";
            this.txtJustificativaSaidaAlmoco.Size = new System.Drawing.Size(546, 76);
            this.txtJustificativaSaidaAlmoco.TabIndex = 13;
            this.txtJustificativaSaidaAlmoco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJustificativaSaidaAlmoco_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(30, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(454, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Justificativa: Em caso de atraso favor informar no campo abaixo.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(31, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(454, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Justificativa: Em caso de atraso favor informar no campo abaixo.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(31, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(454, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Justificativa: Em caso de atraso favor informar no campo abaixo.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(31, 550);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(454, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Justificativa: Em caso de atraso favor informar no campo abaixo.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 32;
            this.button1.Text = "Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(614, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DataSaida);
            this.Controls.Add(this.DataEntradaAlmoco);
            this.Controls.Add(this.DataSaidaAlmoco);
            this.Controls.Add(this.DataEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtJustificativaSaida);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtJustificativaEntradaAlmoco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtJustificativaSaidaAlmoco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJustificativaEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJustificativaEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJustificativaEntradaAlmoco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJustificativaSaida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.TextBox DataEntrada;
        private System.Windows.Forms.TextBox DataSaidaAlmoco;
        private System.Windows.Forms.TextBox DataEntradaAlmoco;
        private System.Windows.Forms.TextBox DataSaida;
        private System.Windows.Forms.TextBox txtJustificativaSaidaAlmoco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
    }
}

