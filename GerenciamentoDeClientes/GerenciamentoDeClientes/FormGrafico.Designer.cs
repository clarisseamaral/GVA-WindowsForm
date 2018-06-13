namespace GerenciamentoDeClientes
{
    partial class FormGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoVendasPorMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gfcValorVendidoMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gfcClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gfcClientesGeramValor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblNotificacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendasPorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcValorVendidoMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcClientesGeramValor)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoVendasPorMes
            // 
            chartArea5.Name = "VendasPorMes";
            this.graficoVendasPorMes.ChartAreas.Add(chartArea5);
            this.graficoVendasPorMes.Location = new System.Drawing.Point(71, 79);
            this.graficoVendasPorMes.Name = "graficoVendasPorMes";
            this.graficoVendasPorMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "VendasPorMes";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.XValueMember = "Mes";
            series5.YValueMembers = "Qtd";
            this.graficoVendasPorMes.Series.Add(series5);
            this.graficoVendasPorMes.Size = new System.Drawing.Size(273, 137);
            this.graficoVendasPorMes.TabIndex = 0;
            this.graficoVendasPorMes.Text = "chart1";
            // 
            // gfcValorVendidoMes
            // 
            chartArea6.Name = "ValorVendidoPorMes";
            this.gfcValorVendidoMes.ChartAreas.Add(chartArea6);
            this.gfcValorVendidoMes.Location = new System.Drawing.Point(71, 231);
            this.gfcValorVendidoMes.Name = "gfcValorVendidoMes";
            this.gfcValorVendidoMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ValorVendidoPorMes";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.XValueMember = "Mes";
            series6.YValueMembers = "Valor";
            this.gfcValorVendidoMes.Series.Add(series6);
            this.gfcValorVendidoMes.Size = new System.Drawing.Size(273, 137);
            this.gfcValorVendidoMes.TabIndex = 1;
            this.gfcValorVendidoMes.Text = "chart1";
            // 
            // gfcClientes
            // 
            chartArea7.Name = "TopClientes";
            this.gfcClientes.ChartAreas.Add(chartArea7);
            legend3.Name = "Legend1";
            this.gfcClientes.Legends.Add(legend3);
            this.gfcClientes.Location = new System.Drawing.Point(452, 79);
            this.gfcClientes.Name = "gfcClientes";
            this.gfcClientes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.ChartArea = "TopClientes";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.XValueMember = "Cliente";
            series7.YValueMembers = "Cliente";
            this.gfcClientes.Series.Add(series7);
            this.gfcClientes.Size = new System.Drawing.Size(273, 137);
            this.gfcClientes.TabIndex = 2;
            this.gfcClientes.Text = "chart1";
            this.gfcClientes.Click += new System.EventHandler(this.gfcClientes_Click);
            // 
            // gfcClientesGeramValor
            // 
            chartArea8.Name = "TopClientes";
            this.gfcClientesGeramValor.ChartAreas.Add(chartArea8);
            legend4.Name = "Legend1";
            this.gfcClientesGeramValor.Legends.Add(legend4);
            this.gfcClientesGeramValor.Location = new System.Drawing.Point(452, 231);
            this.gfcClientesGeramValor.Name = "gfcClientesGeramValor";
            this.gfcClientesGeramValor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series8.ChartArea = "TopClientes";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            series8.XValueMember = "Cliente";
            series8.YValueMembers = "Cliente";
            this.gfcClientesGeramValor.Series.Add(series8);
            this.gfcClientesGeramValor.Size = new System.Drawing.Size(273, 137);
            this.gfcClientesGeramValor.TabIndex = 3;
            this.gfcClientesGeramValor.Text = "chart1";
            this.gfcClientesGeramValor.Click += new System.EventHandler(this.gfcClientesGeramValor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "à";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(286, 43);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(100, 20);
            this.txtDataFinal.TabIndex = 33;
            this.txtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(157, 43);
            this.txtDataInicial.Mask = "00/00/0000";
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(100, 20);
            this.txtDataInicial.TabIndex = 32;
            this.txtDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Período:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::GerenciamentoDeClientes.Properties.Resources.search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Location = new System.Drawing.Point(615, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "     Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblNotificacao
            // 
            this.lblNotificacao.AutoSize = true;
            this.lblNotificacao.ForeColor = System.Drawing.Color.Red;
            this.lblNotificacao.Location = new System.Drawing.Point(28, 25);
            this.lblNotificacao.Name = "lblNotificacao";
            this.lblNotificacao.Size = new System.Drawing.Size(0, 13);
            this.lblNotificacao.TabIndex = 35;
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 402);
            this.ControlBox = false;
            this.Controls.Add(this.lblNotificacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gfcClientesGeramValor);
            this.Controls.Add(this.gfcClientes);
            this.Controls.Add(this.gfcValorVendidoMes);
            this.Controls.Add(this.graficoVendasPorMes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGrafico";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGrafico_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendasPorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcValorVendidoMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcClientesGeramValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVendasPorMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart gfcValorVendidoMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart gfcClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart gfcClientesGeramValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.MaskedTextBox txtDataInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblNotificacao;
    }
}