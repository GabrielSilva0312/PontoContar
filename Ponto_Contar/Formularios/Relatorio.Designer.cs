namespace Ponto_Contar
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.GridLancamento = new System.Windows.Forms.DataGridView();
            this.GridUsuarios = new System.Windows.Forms.DataGridView();
            this.cmdRelatorio = new System.Windows.Forms.Button();
            this.cmdAjustarLancamento = new System.Windows.Forms.Button();
            this.cmdLancamentoManual = new System.Windows.Forms.Button();
            this.cmdExportarParaExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridLancamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuários:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(317, 13);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(111, 26);
            this.txtDataInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Final:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(537, 14);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(111, 26);
            this.txtDataFinal.TabIndex = 5;
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPesquisar.Location = new System.Drawing.Point(280, 536);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(111, 28);
            this.cmdPesquisar.TabIndex = 6;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.Location = new System.Drawing.Point(992, 536);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(105, 28);
            this.cmdSair.TabIndex = 7;
            this.cmdSair.Text = "Sair";
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // GridLancamento
            // 
            this.GridLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLancamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLancamento.Location = new System.Drawing.Point(212, 57);
            this.GridLancamento.Name = "GridLancamento";
            this.GridLancamento.Size = new System.Drawing.Size(912, 473);
            this.GridLancamento.TabIndex = 8;
            this.GridLancamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuarios.Location = new System.Drawing.Point(16, 58);
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.Size = new System.Drawing.Size(178, 472);
            this.GridUsuarios.TabIndex = 9;
            this.GridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarios_CellClick);
            this.GridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuarios_CellContentClick);
            // 
            // cmdRelatorio
            // 
            this.cmdRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRelatorio.Location = new System.Drawing.Point(109, 536);
            this.cmdRelatorio.Name = "cmdRelatorio";
            this.cmdRelatorio.Size = new System.Drawing.Size(111, 28);
            this.cmdRelatorio.TabIndex = 10;
            this.cmdRelatorio.Text = "Relatório";
            this.cmdRelatorio.UseVisualStyleBackColor = true;
            this.cmdRelatorio.Click += new System.EventHandler(this.cmdRelatorio_Click);
            // 
            // cmdAjustarLancamento
            // 
            this.cmdAjustarLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAjustarLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAjustarLancamento.Location = new System.Drawing.Point(682, 17);
            this.cmdAjustarLancamento.Name = "cmdAjustarLancamento";
            this.cmdAjustarLancamento.Size = new System.Drawing.Size(206, 27);
            this.cmdAjustarLancamento.TabIndex = 12;
            this.cmdAjustarLancamento.Text = "Ajustar Lançamento";
            this.cmdAjustarLancamento.UseVisualStyleBackColor = true;
            this.cmdAjustarLancamento.Click += new System.EventHandler(this.cmdAjustarLancamento_Click);
            // 
            // cmdLancamentoManual
            // 
            this.cmdLancamentoManual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdLancamentoManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLancamentoManual.Location = new System.Drawing.Point(921, 17);
            this.cmdLancamentoManual.Name = "cmdLancamentoManual";
            this.cmdLancamentoManual.Size = new System.Drawing.Size(203, 27);
            this.cmdLancamentoManual.TabIndex = 13;
            this.cmdLancamentoManual.Text = "Lançamento Manual";
            this.cmdLancamentoManual.UseVisualStyleBackColor = true;
            this.cmdLancamentoManual.Click += new System.EventHandler(this.cmdLancamentoManual_Click);
            // 
            // cmdExportarParaExcel
            // 
            this.cmdExportarParaExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExportarParaExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarParaExcel.Location = new System.Drawing.Point(439, 536);
            this.cmdExportarParaExcel.Name = "cmdExportarParaExcel";
            this.cmdExportarParaExcel.Size = new System.Drawing.Size(179, 28);
            this.cmdExportarParaExcel.TabIndex = 14;
            this.cmdExportarParaExcel.Text = "Exportar p/ Excel";
            this.cmdExportarParaExcel.UseVisualStyleBackColor = true;
            this.cmdExportarParaExcel.Click += new System.EventHandler(this.cmdExportarParaExcel_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1136, 576);
            this.Controls.Add(this.cmdExportarParaExcel);
            this.Controls.Add(this.cmdLancamentoManual);
            this.Controls.Add(this.cmdAjustarLancamento);
            this.Controls.Add(this.cmdRelatorio);
            this.Controls.Add(this.GridUsuarios);
            this.Controls.Add(this.GridLancamento);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLancamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdSair;
        private System.Windows.Forms.DataGridView GridLancamento;
        private System.Windows.Forms.DataGridView GridUsuarios;
        private System.Windows.Forms.Button cmdRelatorio;
        private System.Windows.Forms.Button cmdAjustarLancamento;
        private System.Windows.Forms.Button cmdLancamentoManual;
        private System.Windows.Forms.Button cmdExportarParaExcel;
    }
}