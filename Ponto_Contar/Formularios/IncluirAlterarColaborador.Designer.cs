﻿namespace Ponto_Contar
{
    partial class IncluirAlterarColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncluirAlterarColaborador));
            this.cmdSair = new System.Windows.Forms.Button();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.lblCTPS = new System.Windows.Forms.Label();
            this.txtCTPS = new System.Windows.Forms.TextBox();
            this.txtDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.grpJornadaDeTrabalho = new System.Windows.Forms.GroupBox();
            this.grpAlmoco = new System.Windows.Forms.GroupBox();
            this.lblSaidaAlmoco = new System.Windows.Forms.Label();
            this.txtSaidaAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.lblEntradaAlmoco = new System.Windows.Forms.Label();
            this.txtHoraEntradaAlmoco = new System.Windows.Forms.MaskedTextBox();
            this.grpEntradaSaida = new System.Windows.Forms.GroupBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.grpJornadaDeTrabalho.SuspendLayout();
            this.grpAlmoco.SuspendLayout();
            this.grpEntradaSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSair
            // 
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.Location = new System.Drawing.Point(402, 313);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(110, 28);
            this.cmdSair.TabIndex = 11;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConfirmar.Location = new System.Drawing.Point(157, 313);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 28);
            this.cmdConfirmar.TabIndex = 10;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(577, 111);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(63, 24);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(27, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncao.Location = new System.Drawing.Point(23, 88);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(67, 20);
            this.lblFuncao.TabIndex = 4;
            this.lblFuncao.Text = "Função:";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncao.Location = new System.Drawing.Point(26, 111);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(241, 26);
            this.txtFuncao.TabIndex = 5;
            // 
            // lblCTPS
            // 
            this.lblCTPS.AutoSize = true;
            this.lblCTPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTPS.Location = new System.Drawing.Point(299, 88);
            this.lblCTPS.Name = "lblCTPS";
            this.lblCTPS.Size = new System.Drawing.Size(54, 20);
            this.lblCTPS.TabIndex = 6;
            this.lblCTPS.Text = "CTPS:";
            // 
            // txtCTPS
            // 
            this.txtCTPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTPS.Location = new System.Drawing.Point(302, 111);
            this.txtCTPS.Name = "txtCTPS";
            this.txtCTPS.Size = new System.Drawing.Size(243, 26);
            this.txtCTPS.TabIndex = 7;
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataAdmissao.Location = new System.Drawing.Point(389, 49);
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(138, 26);
            this.txtDataAdmissao.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(385, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(122, 20);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Admissão:";
            // 
            // grpJornadaDeTrabalho
            // 
            this.grpJornadaDeTrabalho.Controls.Add(this.grpAlmoco);
            this.grpJornadaDeTrabalho.Controls.Add(this.grpEntradaSaida);
            this.grpJornadaDeTrabalho.Location = new System.Drawing.Point(12, 154);
            this.grpJornadaDeTrabalho.Name = "grpJornadaDeTrabalho";
            this.grpJornadaDeTrabalho.Size = new System.Drawing.Size(632, 135);
            this.grpJornadaDeTrabalho.TabIndex = 9;
            this.grpJornadaDeTrabalho.TabStop = false;
            this.grpJornadaDeTrabalho.Text = "Jornada de Trabalho:";
            // 
            // grpAlmoco
            // 
            this.grpAlmoco.Controls.Add(this.lblSaidaAlmoco);
            this.grpAlmoco.Controls.Add(this.txtSaidaAlmoco);
            this.grpAlmoco.Controls.Add(this.lblEntradaAlmoco);
            this.grpAlmoco.Controls.Add(this.txtHoraEntradaAlmoco);
            this.grpAlmoco.Location = new System.Drawing.Point(321, 19);
            this.grpAlmoco.Name = "grpAlmoco";
            this.grpAlmoco.Size = new System.Drawing.Size(301, 102);
            this.grpAlmoco.TabIndex = 1;
            this.grpAlmoco.TabStop = false;
            this.grpAlmoco.Text = "Almoço:";
            // 
            // lblSaidaAlmoco
            // 
            this.lblSaidaAlmoco.AutoSize = true;
            this.lblSaidaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaAlmoco.Location = new System.Drawing.Point(158, 32);
            this.lblSaidaAlmoco.Name = "lblSaidaAlmoco";
            this.lblSaidaAlmoco.Size = new System.Drawing.Size(38, 20);
            this.lblSaidaAlmoco.TabIndex = 2;
            this.lblSaidaAlmoco.Text = "Até:";
            // 
            // txtSaidaAlmoco
            // 
            this.txtSaidaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidaAlmoco.Location = new System.Drawing.Point(162, 55);
            this.txtSaidaAlmoco.Mask = "00:00";
            this.txtSaidaAlmoco.Name = "txtSaidaAlmoco";
            this.txtSaidaAlmoco.Size = new System.Drawing.Size(117, 26);
            this.txtSaidaAlmoco.TabIndex = 3;
            this.txtSaidaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaidaAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // lblEntradaAlmoco
            // 
            this.lblEntradaAlmoco.AutoSize = true;
            this.lblEntradaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaAlmoco.Location = new System.Drawing.Point(10, 32);
            this.lblEntradaAlmoco.Name = "lblEntradaAlmoco";
            this.lblEntradaAlmoco.Size = new System.Drawing.Size(34, 20);
            this.lblEntradaAlmoco.TabIndex = 0;
            this.lblEntradaAlmoco.Text = "De:";
            // 
            // txtHoraEntradaAlmoco
            // 
            this.txtHoraEntradaAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntradaAlmoco.Location = new System.Drawing.Point(14, 55);
            this.txtHoraEntradaAlmoco.Mask = "00:00";
            this.txtHoraEntradaAlmoco.Name = "txtHoraEntradaAlmoco";
            this.txtHoraEntradaAlmoco.Size = new System.Drawing.Size(117, 26);
            this.txtHoraEntradaAlmoco.TabIndex = 1;
            this.txtHoraEntradaAlmoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraEntradaAlmoco.ValidatingType = typeof(System.DateTime);
            // 
            // grpEntradaSaida
            // 
            this.grpEntradaSaida.Controls.Add(this.lblSaida);
            this.grpEntradaSaida.Controls.Add(this.txtSaida);
            this.grpEntradaSaida.Controls.Add(this.lblEntrada);
            this.grpEntradaSaida.Controls.Add(this.txtHoraEntrada);
            this.grpEntradaSaida.Location = new System.Drawing.Point(14, 19);
            this.grpEntradaSaida.Name = "grpEntradaSaida";
            this.grpEntradaSaida.Size = new System.Drawing.Size(301, 102);
            this.grpEntradaSaida.TabIndex = 0;
            this.grpEntradaSaida.TabStop = false;
            this.grpEntradaSaida.Text = "Entrada e Saída:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(158, 32);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(54, 20);
            this.lblSaida.TabIndex = 2;
            this.lblSaida.Text = "Saída:";
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.Location = new System.Drawing.Point(162, 55);
            this.txtSaida.Mask = "00:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(117, 26);
            this.txtSaida.TabIndex = 3;
            this.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(10, 32);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(70, 20);
            this.lblEntrada.TabIndex = 0;
            this.lblEntrada.Text = "Entrada:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntrada.Location = new System.Drawing.Point(14, 55);
            this.txtHoraEntrada.Mask = "00:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(117, 26);
            this.txtHoraEntrada.TabIndex = 1;
            this.txtHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // IncluirAlterarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(652, 362);
            this.Controls.Add(this.grpJornadaDeTrabalho);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtDataAdmissao);
            this.Controls.Add(this.lblCTPS);
            this.Controls.Add(this.txtCTPS);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.cmdSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IncluirAlterarColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colaborador";
            this.Load += new System.EventHandler(this.IncluirAlterarColaborador_Load);
            this.Shown += new System.EventHandler(this.Cadastro_de_Colaborador_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cadastro_de_Colaborador_KeyDown);
            this.grpJornadaDeTrabalho.ResumeLayout(false);
            this.grpAlmoco.ResumeLayout(false);
            this.grpAlmoco.PerformLayout();
            this.grpEntradaSaida.ResumeLayout(false);
            this.grpEntradaSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label lblCTPS;
        private System.Windows.Forms.TextBox txtCTPS;
        private System.Windows.Forms.DateTimePicker txtDataAdmissao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grpJornadaDeTrabalho;
        private System.Windows.Forms.GroupBox grpAlmoco;
        private System.Windows.Forms.Label lblSaidaAlmoco;
        private System.Windows.Forms.MaskedTextBox txtSaidaAlmoco;
        private System.Windows.Forms.Label lblEntradaAlmoco;
        private System.Windows.Forms.MaskedTextBox txtHoraEntradaAlmoco;
        private System.Windows.Forms.GroupBox grpEntradaSaida;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
    }
}