using System;
using System.Collections.Generic;

using System.Data;

using System.Windows.Forms;

namespace ReadQRcode
{
    public partial class RegistrarAsistencia : Form
    {
        private DataTable datos_cole;
        private string id_cole;
        
        public RegistrarAsistencia()
        {
            InitializeComponent();
        }

        public RegistrarAsistencia(DataTable ta)
        {
            InitializeComponent();
            datos_cole = ta;
            cargarForm();

        }


        private void cargarForm()
        {
            id_cole = datos_cole.Rows[0][0].ToString();
            lblCue.Text = datos_cole.Rows[0][3].ToString();
            lblColegio.Text = datos_cole.Rows[0][4].ToString();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            dgvInscriptos.DataSource = new DConectar().traerInscriptos(id_cole);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvInscriptos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int total = dgvInscriptos.RowCount;
            lblTotal.Text = total.ToString();
            for (int i = 0; i < dgvInscriptos.RowCount; i++)
            {
                dgvInscriptos.Rows[i].Cells["chk"].Value = true;

            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < dgvInscriptos.RowCount; i++)
            {
               if((bool)dgvInscriptos.Rows[i].Cells["chk"].Value == true)
                {
                    lista.Add(dgvInscriptos.Rows[i].Cells["RowId"].Value.ToString());
                }
            }
            string resul = new DConectar().Insertar(lista);

            if(resul.Equals("ok"))
            {
                MessageBox.Show("Alumnos registrados correctamente", "Registro OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Se produjo un error al guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            FormInscripcion ins = new FormInscripcion();
            ins.ShowDialog();
            ins.Close();
            cargarGrilla();
        }
    }
}
