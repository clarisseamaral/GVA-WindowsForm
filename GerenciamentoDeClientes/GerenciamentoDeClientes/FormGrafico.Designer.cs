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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoVendasPorMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gfcValorVendidoMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gfcClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gfcClientesGeramValor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendasPorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcValorVendidoMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcClientesGeramValor)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoVendasPorMes
            // 
            chartArea1.Name = "VendasPorMes";
            this.graficoVendasPorMes.ChartAreas.Add(chartArea1);
            this.graficoVendasPorMes.Location = new System.Drawing.Point(71, 79);
            this.graficoVendasPorMes.Name = "graficoVendasPorMes";
            this.graficoVendasPorMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "VendasPorMes";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Mes";
            series1.YValueMembers = "Qtd";
            this.graficoVendasPorMes.Series.Add(series1);
            this.graficoVendasPorMes.Size = new System.Drawing.Size(273, 137);
            this.graficoVendasPorMes.TabIndex = 0;
            this.graficoVendasPorMes.Text = "chart1";
            // 
            // gfcValorVendidoMes
            // 
            chartArea2.Name = "ValorVendidoPorMes";
            this.gfcValorVendidoMes.ChartAreas.Add(chartArea2);
            this.gfcValorVendidoMes.Location = new System.Drawing.Point(71, 231);
            this.gfcValorVendidoMes.Name = "gfcValorVendidoMes";
            this.gfcValorVendidoMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ValorVendidoPorMes";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Mes";
            series2.YValueMembers = "Valor";
            this.gfcValorVendidoMes.Series.Add(series2);
            this.gfcValorVendidoMes.Size = new System.Drawing.Size(273, 137);
            this.gfcValorVendidoMes.TabIndex = 1;
            this.gfcValorVendidoMes.Text = "chart1";
            // 
            // gfcClientes
            // 
            chartArea3.Name = "TopClientes";
            this.gfcClientes.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.gfcClientes.Legends.Add(legend1);
            this.gfcClientes.Location = new System.Drawing.Point(452, 79);
            this.gfcClientes.Name = "gfcClientes";
            this.gfcClientes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "TopClientes";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "Cliente";
            series3.YValueMembers = "Cliente";
            this.gfcClientes.Series.Add(series3);
            this.gfcClientes.Size = new System.Drawing.Size(273, 137);
            this.gfcClientes.TabIndex = 2;
            this.gfcClientes.Text = "chart1";
            this.gfcClientes.Click += new System.EventHandler(this.gfcClientes_Click);
            // 
            // gfcClientesGeramValor
            // 
            chartArea4.Name = "TopClientes";
            this.gfcClientesGeramValor.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.gfcClientesGeramValor.Legends.Add(legend2);
            this.gfcClientesGeramValor.Location = new System.Drawing.Point(452, 231);
            this.gfcClientesGeramValor.Name = "gfcClientesGeramValor";
            this.gfcClientesGeramValor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "TopClientes";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "Cliente";
            series4.YValueMembers = "Cliente";
            this.gfcClientesGeramValor.Series.Add(series4);
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
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 402);
            this.ControlBox = false;
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
    }
}