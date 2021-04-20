namespace PrimeiroProjeto.formularios
{
    partial class frmenu1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmenu1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velocidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonconctar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonligar = new System.Windows.Forms.Button();
            this.buttondesligar = new System.Windows.Forms.Button();
            this.txtenviar = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.chartVelocidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerChartVelo = new System.Windows.Forms.Timer(this.components);
            this.chartBMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBMS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PrimeiroProjeto.Properties.Resources.simbolo_FE;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarCtrlSToolStripMenuItem,
            this.compilarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarCtrlSToolStripMenuItem
            // 
            this.salvarCtrlSToolStripMenuItem.Name = "salvarCtrlSToolStripMenuItem";
            this.salvarCtrlSToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salvarCtrlSToolStripMenuItem.Text = "Salvar (Ctrl+S)";
            // 
            // compilarToolStripMenuItem
            // 
            this.compilarToolStripMenuItem.Name = "compilarToolStripMenuItem";
            this.compilarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.compilarToolStripMenuItem.Text = "Compilar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficosToolStripMenuItem,
            this.gráficosToolStripMenuItem1});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaturaToolStripMenuItem,
            this.velocidadeToolStripMenuItem,
            this.bateriaToolStripMenuItem,
            this.volanteToolStripMenuItem});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.gráficosToolStripMenuItem.Text = "Sensores";
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            // 
            // velocidadeToolStripMenuItem
            // 
            this.velocidadeToolStripMenuItem.Name = "velocidadeToolStripMenuItem";
            this.velocidadeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.velocidadeToolStripMenuItem.Text = "Velocidade";
            // 
            // bateriaToolStripMenuItem
            // 
            this.bateriaToolStripMenuItem.Name = "bateriaToolStripMenuItem";
            this.bateriaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bateriaToolStripMenuItem.Text = "Bateria";
            // 
            // volanteToolStripMenuItem
            // 
            this.volanteToolStripMenuItem.Name = "volanteToolStripMenuItem";
            this.volanteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.volanteToolStripMenuItem.Text = "Volante";
            // 
            // gráficosToolStripMenuItem1
            // 
            this.gráficosToolStripMenuItem1.Name = "gráficosToolStripMenuItem1";
            this.gráficosToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.gráficosToolStripMenuItem1.Text = "Gráficos ";
            // 
            // buttonconctar
            // 
            this.buttonconctar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconctar.Location = new System.Drawing.Point(20, 54);
            this.buttonconctar.Name = "buttonconctar";
            this.buttonconctar.Size = new System.Drawing.Size(142, 23);
            this.buttonconctar.TabIndex = 2;
            this.buttonconctar.Text = "Conexão ";
            this.buttonconctar.UseVisualStyleBackColor = true;
            this.buttonconctar.Click += new System.EventHandler(this.buttonconectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM3 ",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.comboBox1.Location = new System.Drawing.Point(20, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonligar
            // 
            this.buttonligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonligar.Location = new System.Drawing.Point(20, 83);
            this.buttonligar.Name = "buttonligar";
            this.buttonligar.Size = new System.Drawing.Size(142, 23);
            this.buttonligar.TabIndex = 5;
            this.buttonligar.Text = "Ligando";
            this.buttonligar.UseVisualStyleBackColor = true;
            this.buttonligar.Click += new System.EventHandler(this.buttonligar_Click);
            // 
            // buttondesligar
            // 
            this.buttondesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondesligar.Location = new System.Drawing.Point(20, 112);
            this.buttondesligar.Name = "buttondesligar";
            this.buttondesligar.Size = new System.Drawing.Size(142, 23);
            this.buttondesligar.TabIndex = 6;
            this.buttondesligar.Text = "Desligando";
            this.buttondesligar.UseVisualStyleBackColor = true;
            this.buttondesligar.Click += new System.EventHandler(this.buttondesligar_Click);
            // 
            // txtenviar
            // 
            this.txtenviar.Location = new System.Drawing.Point(42, 196);
            this.txtenviar.Name = "txtenviar";
            this.txtenviar.Size = new System.Drawing.Size(100, 20);
            this.txtenviar.TabIndex = 0;
            this.txtenviar.TextChanged += new System.EventHandler(this.txtenviar_TextChanged);
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            // 
            // chartVelocidade
            // 
            this.chartVelocidade.BackColor = System.Drawing.Color.Silver;
            this.chartVelocidade.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartVelocidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartVelocidade.BackSecondaryColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.chartVelocidade.ChartAreas.Add(chartArea1);
            this.chartVelocidade.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartVelocidade.Legends.Add(legend1);
            this.chartVelocidade.Location = new System.Drawing.Point(185, 54);
            this.chartVelocidade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chartVelocidade.Name = "chartVelocidade";
            this.chartVelocidade.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartVelocidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBackColor = System.Drawing.Color.Silver;
            series1.Legend = "Legend1";
            series1.Name = "Km/h";
            this.chartVelocidade.Series.Add(series1);
            this.chartVelocidade.Size = new System.Drawing.Size(576, 178);
            this.chartVelocidade.TabIndex = 7;
            this.chartVelocidade.Text = "Velocidade";
            this.chartVelocidade.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timerChartVelo
            // 
            this.timerChartVelo.Interval = 250;
            this.timerChartVelo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartBMS
            // 
            this.chartBMS.BackColor = System.Drawing.Color.PaleTurquoise;
            this.chartBMS.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartBMS.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.chartBMS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBMS.Legends.Add(legend2);
            this.chartBMS.Location = new System.Drawing.Point(185, 266);
            this.chartBMS.Name = "chartBMS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Tensão IN";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Tensão células";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Maior tensão";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Menor tensão";
            series6.YValuesPerPoint = 4;
            this.chartBMS.Series.Add(series2);
            this.chartBMS.Series.Add(series3);
            this.chartBMS.Series.Add(series4);
            this.chartBMS.Series.Add(series5);
            this.chartBMS.Series.Add(series6);
            this.chartBMS.Size = new System.Drawing.Size(576, 178);
            this.chartBMS.TabIndex = 8;
            this.chartBMS.Text = "chart1";
            this.chartBMS.Click += new System.EventHandler(this.chartTemperatura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Velocidade (Km/h)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "BMS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ativar Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 23);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(20, 295);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(132, 23);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(20, 324);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(132, 23);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(20, 353);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(132, 23);
            this.richTextBox4.TabIndex = 16;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(20, 382);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(132, 23);
            this.richTextBox5.TabIndex = 17;
            this.richTextBox5.Text = "";
            // 
            // frmenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartBMS);
            this.Controls.Add(this.chartVelocidade);
            this.Controls.Add(this.txtenviar);
            this.Controls.Add(this.buttondesligar);
            this.Controls.Add(this.buttonligar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonconctar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmenu1";
            this.Text = "FE-UFPB";
            this.Load += new System.EventHandler(this.frmenu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velocidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem1;
        private System.Windows.Forms.Button buttonconctar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonligar;
        private System.Windows.Forms.Button buttondesligar;
        private System.Windows.Forms.TextBox txtenviar;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVelocidade;
        private System.Windows.Forms.Timer timerChartVelo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
    }
}