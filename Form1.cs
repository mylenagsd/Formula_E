using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PrimeiroProjeto
{
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void báteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void atualizacao_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar2.Value = progressBar2.Value + 2;
            }
            catch
            {
                atualizacao.Enabled = false;
                this.Visible = false;

                formularios.frmenu1 frm = new formularios.frmenu1();
                frm.ShowDialog();

              
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
