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
        /// <summary>
        /// Resetea los valores elegidos de las comboBox de las calificaciones en base a las preguntas a null.
        /// </summary>
        public void ResetCalificaciones()
        {
            cbDisGrafico.SelectedItem = null;
            cbImagenes.SelectedItem = null;
            cbAreaNav.SelectedItem = null;
            cbOrientacion.SelectedItem = null;
            cbInformacion.SelectedItem = null;
            cbInter.SelectedItem = null;
            cbAreaBusq.SelectedItem = null;
            cbResultadosBusq.SelectedItem = null;
        }
        /// <summary>
        /// Convoca un messageBox para confirmar si el usuario quiere volver a la página de inicio sin guardar datos de calificación.
        /// </summary>
        public void ConfirmacionVolver()
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que querés volver a inicio? Las calificaciones seleccionadas no se guardarán.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ResetCalificaciones();
                tabsInterfaz.SelectedIndex = 0;
            }
        }

        public void MensajeResultado(float Num)
        {
            if (Num <= 39.99f)
            {
                MessageBox.Show("La página tiene una usabilidad penosa.", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Num <= 54.99f)
            {
                MessageBox.Show("La página tiene una usabilidad mediocre.", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Num <= 69.99f)
            {
                MessageBox.Show("La página tiene cierto grado de usabilidad, es buena pero no podría ser mejor.", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Num <= 79.99f)
            {
                MessageBox.Show("La página goza de un buen nivel de usabilidad.", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Num <= 94.99f)
            {
                MessageBox.Show("La página está diseñada de una manera muy profesional, aportando un nivel sustancial de usabilidad.", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Num <= 100.0f)
            {
                MessageBox.Show("La página es una oda a las heurísticas de Nielsen, cuenta con todo lo que tiene que tener y es prácticamente perfecta en cuestiones de usabilidad.", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            tabsInterfaz.ItemSize = new System.Drawing.Size(0, 1);
            tabsInterfaz.SizeMode = TabSizeMode.Fixed;
        }

        private void btnEvaluarDiseño_Click(object sender, EventArgs e)
        {
            ResetCalificaciones();
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
                MessageBox.Show("La configuración se guardó exitosamente.", "Guardado con Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Un valor máximo de una o más características no fue seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que querés volver a inicio? Los cambios que no hayas guardado se perderán.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                tabsInterfaz.SelectedIndex = 0;
                cBoxDisGr.SelectedItem = NotaMaxDisGr.ToString();
                cBoxImag.SelectedItem = NotaMaxImag.ToString();
                cBoxArNav.SelectedItem = NotaMaxArNav.ToString();
                cBoxOri.SelectedItem = NotaMaxOri.ToString();
                cBoxInfo.SelectedItem = NotaMaxInfo.ToString();
                cBoxIntern.SelectedItem = NotaMaxIntern.ToString();
                cBoxArBusq.SelectedItem = NotaMaxArBusq.ToString();
                cBoxRes.SelectedItem = NotaMaxRes.ToString();
            }
        }

        private void btInicio2_Click(object sender, EventArgs e)
        {
            ConfirmacionVolver();
        }

        private void btInicio3_Click(object sender, EventArgs e)
        {
            ConfirmacionVolver();
        }

        private void btInicio4_Click(object sender, EventArgs e)
        {
            ConfirmacionVolver();
        }

        private void btInicio5_Click(object sender, EventArgs e)
        {
            ConfirmacionVolver();
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 1;
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 3;
        }

        private void btSiguiente1_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 4;
        }

        private void btSiguiente2_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 5;
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (cbDisGrafico.Text != "" && cbImagenes.Text != "" && cbAreaNav.Text != "" && cbOrientacion.Text != "" && cbInformacion.Text != "" && cbInter.Text != "" && cbAreaBusq.Text != "" && cbResultadosBusq.Text != "")
            {
                tabsInterfaz.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Uno o más criterios no fueron calificados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAtras1_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 2;
        }

        private void btAtras2_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 3;
        }

        private void btAtras3_Click(object sender, EventArgs e)
        {
            tabsInterfaz.SelectedIndex = 4;
        }
    }
}
