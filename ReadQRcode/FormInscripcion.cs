using System;

using System.Data;

using System.Windows.Forms;

namespace ReadQRcode
{
    public partial class FormInscripcion : Form
    {
        string id;
        public FormInscripcion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCue.Text))
            {
                MessageBox.Show("Ingrese un CUE");
                txtCue.Focus();
                return;
            }
            DataTable tabla = new DataTable();
            tabla = new DConectar().obtenerDatosCole(txtCue.Text);

            if(tabla.Rows.Count>0)
            {
                id=tabla.Rows[0][0].ToString();
                lblNombre.Text = tabla.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("No se encontraron colegios con ese CUE. Verifique que cumpla con el formato 140111100");
                txtCue.Focus();
            }
                        
        }

        public string GetIdCole()
        {
            return id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(txtCue.Text)) || (string.IsNullOrEmpty(txtNombre.Text)) || (string.IsNullOrEmpty(txtApellido.Text)) || (string.IsNullOrEmpty(txtDni.Text)))
            {
                MessageBox.Show("Todos los campos (menos mail) son obligatorios");
                return;
            }

            string resul = new DConectar().InsertarPersona(txtApellido.Text,txtNombre.Text,txtDni.Text,txtMail.Text,chkDocente.Checked,id);

            if(resul.Equals("ok"))
            {
                MessageBox.Show("La persona fue registrada correctamente");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al registrar a la persona");
            }
        }
    }
}
