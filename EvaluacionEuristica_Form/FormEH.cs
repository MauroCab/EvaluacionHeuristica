using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionEuristica_Form
{
    public partial class FormEH : Form
    {
        int NotaMax;
        int NotaMaxDisGr;
        int NotaMaxImag;
        int NotaMaxArNav;
        int NotaMaxOri;
        int NotaMaxInfo;
        int NotaMaxIntern;
        int NotaMaxArBusq;
        int NotaMaxRes;
        public void CalcNotaMax()
        {
            NotaMaxDisGr = Convert.ToInt32(cBoxDisGr.Text); NotaMaxImag = Convert.ToInt32(cBoxImag.Text);
            NotaMaxArNav = Convert.ToInt32(cBoxArNav.Text); NotaMaxOri = Convert.ToInt32(cBoxOri.Text);
            NotaMaxInfo = Convert.ToInt32(cBoxInfo.Text); NotaMaxIntern = Convert.ToInt32(cBoxIntern.Text);
            NotaMaxArBusq = Convert.ToInt32(cBoxArBusq.Text); NotaMaxRes = Convert.ToInt32(cBoxRes.Text);
            NotaMax = NotaMaxDisGr + NotaMaxImag + NotaMaxArNav + NotaMaxOri + NotaMaxInfo + NotaMaxIntern + NotaMaxArBusq + NotaMaxRes;
            lbCnfNotaMax.Text = NotaMax.ToString();
        }
        
        public FormEH()
        {
            InitializeComponent();
            cBoxDisGr.SelectedItem = "10";
            cBoxImag.SelectedItem = "10";
            cBoxArNav.SelectedItem = "10";
            cBoxOri.SelectedItem = "10";
            cBoxInfo.SelectedItem = "10";
            cBoxIntern.SelectedItem = "10";
            cBoxArBusq.SelectedItem = "10";
            cBoxRes.SelectedItem = "10";
            CalcNotaMax();
        }

        private void btnEvaluarDiseño_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 2;
        }

        private void btnEvaluarNav_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 3;
        }

        private void btnEvaluarCont_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluarBusq_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 5;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 4;
        }

        private void btGUARDAR_Click(object sender, EventArgs e)
        {
            if (cBoxDisGr.Text != "" && cBoxImag.Text != "" && cBoxArNav.Text != "" && cBoxOri.Text != "" && cBoxInfo.Text != "" && cBoxIntern.Text != "" && cBoxArBusq.Text != "" && cBoxRes.Text != "")
            {
                CalcNotaMax();
                lbCnfNotaMax.Text = NotaMax.ToString();
            }
            else
            {
                MessageBox.Show("Un valor máximo de una o más características no fue seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 0;
        }

        private void btInicio2_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 0;
        }

        private void btInicio3_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 0;
        }

        private void btInicio4_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 0;
        }

        private void btInicio5_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 0;
        }
    }
}
