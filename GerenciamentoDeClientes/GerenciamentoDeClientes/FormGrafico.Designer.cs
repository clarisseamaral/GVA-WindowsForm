﻿namespace GerenciamentoDeClientes
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoCliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoCliente
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoCliente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoCliente.Legends.Add(legend1);
            this.graficoCliente.Location = new System.Drawing.Point(79, 36);
            this.graficoCliente.Name = "graficoCliente";
            this.graficoCliente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Vendas";
            this.graficoCliente.Series.Add(series1);
            this.graficoCliente.Size = new System.Drawing.Size(356, 131);
            this.graficoCliente.TabIndex = 0;
            this.graficoCliente.Text = "chart1";
            // 
            // FormGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 265);
            this.Controls.Add(this.graficoCliente);
            this.Name = "FormGrafico";
            this.Text = "FormGrafico";
            this.Load += new System.EventHandler(this.FormGrafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graficoCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCliente;
    }
}