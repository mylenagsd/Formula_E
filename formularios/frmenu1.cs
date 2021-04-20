using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace PrimeiroProjeto.formularios
{
    public partial class frmenu1 : Form
    {
        public frmenu1()
        {
            InitializeComponent();
            chartVelocidade.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartBMS.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        int x = 1;

        private void atualizalistaCOMs()
        {
            int i;
            bool quantdiferente; // sinaliza que a quantidade de portas mudou
            i = 0;
            quantdiferente = false;

            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantdiferente = true;
                    }
                }
            }
            else
            {
                quantdiferente = false;
            }
            if (quantdiferente = false) // senão for encontrada a diferença, irá retornar.
            {
                return;
            }
            comboBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames()) // adicionar apenas as portas disponíveis na lista
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.SelectedIndex = 0;
        } 

             
        bool conexao = false;

        private void buttonconectar_Click(object sender, EventArgs e)
        {
            if (!conexao)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    buttonconctar.Text = "encerrar a conexão em série";
                    conexao = true;

                }
                catch (ArgumentException ex)
               
                {
                    MessageBox.Show("Selecione a porta antes","AVISO");
                    serialPort1.Close();

                }
                conexao = true;
            }

            else
            {
                buttonconctar.Text = "iniciar conexao";
                conexao = false;
                if (serialPort1 != null)
                {
                    serialPort1.Close();
                }
            }
             }
           

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmenu1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonligar_Click(object sender, EventArgs e)
        {
            if (conexao)
                serialPort1.WriteLine("l");
            }

        private void buttondesligar_Click(object sender, EventArgs e)
        {
            if (conexao)
                serialPort1.WriteLine("d");
        }

        

        private void txtenviar_TextChanged(object sender, EventArgs e)
        {
            //string estado;
            //estado = serialPort1.ReadLine();

            //txtenviar.Text = estado.Trim();
        }

        private void txtreceber_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //double ychart;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string estado;
            estado = serialPort1.ReadLine();

            txtenviar.Text = estado.Trim();
            txtenviar.Update();

            if (chartVelocidade.Series[0].Points.Count > 10)
            {
                chartVelocidade.Series[0].Points.RemoveAt(0);
                chartVelocidade.Update();
            }

            string phrase = serialPort1.ReadLine();
            string[] words = phrase.Split(';');
            
            
            //if (words[0]== "")
            //{
            //    chartVelocidade.Series[0].Points.AddXY(x++, words[1]);
            //}

                   
            if(chartBMS.Series[0].Points.Count > 10)
            {
                chartBMS.Series[0].Points.RemoveAt(0);
                chartBMS.Update();
            }

            //Temperatura da carcaça BMS
            if (words[0] == "2D")
            {
                chartBMS.Series[0].Points.AddXY(x++, words[1]);
                richTextBox1.Text = words[1];
            }

           
            if (chartBMS.Series[1].Points.Count > 10)
            {
                chartBMS.Series[1].Points.RemoveAt(0);
                chartBMS.Update();
            }

            //Tensão de entrada BMS
            if (words[0] == "46")
            {
                chartBMS.Series[1].Points.AddXY(x++, words[1]);
                richTextBox2.Text = words[1];
            }


            if (chartBMS.Series[2].Points.Count > 10)
            {
                chartBMS.Series[2].Points.RemoveAt(0);
                chartBMS.Update();
            }

            //Tensão total das células BMS
            if (words[0] == "14")
            {
                chartBMS.Series[2].Points.AddXY(x++, words[1]);
                richTextBox3.Text = words[1];
            }


            if (chartBMS.Series[3].Points.Count > 10)
            {
                chartBMS.Series[3].Points.RemoveAt(0);
                chartBMS.Update();
            }

            //Maior tensão numa célula BMS
            if (words[0] == "33")
            {
                chartBMS.Series[3].Points.AddXY(x++, words[1]);
                richTextBox4.Text = words[1];
            }


            if (chartBMS.Series[4].Points.Count > 10)
            {
                chartBMS.Series[4].Points.RemoveAt(0);
                chartBMS.Update();
            }

            //Menor tensão numa célula BMS
            if (words[0] == "32")
            {
                chartBMS.Series[4].Points.AddXY(x++, words[1]);
                richTextBox5.Text = words[1];
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            timerChartVelo.Enabled = true;
                      
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void chartTemperatura_Click(object sender, EventArgs e)
        {

        }
    }

       
        
    }

