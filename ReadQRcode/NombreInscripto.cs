using System;

using System.Data;

using System.Windows.Forms;

namespace ReadQRcode
{
    public partial class NombreInscripto : Form
    {
        string dni;
        bool aceptar = false;
        string id_cole;
        DataTable tabla;


        public NombreInscripto()
        {
            InitializeComponent();
            
        }

        public NombreInscripto(string mDni)
        {
            InitializeComponent();
            //label1.Text = dni;
            dni = mDni;
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            tabla = new DataTable();
            tabla = new DConectar().consultar(dni);

            if( (tabla==null) || (tabla.Rows.Count < 1))
            {

            }
            else
            {
                id_cole= tabla.Rows[0][0].ToString();
                lblNombre.Text = tabla.Rows[0][1].ToString();
                lblDni.Text= tabla.Rows[0][2].ToString();
                lblCue.Text= tabla.Rows[0][3].ToString();
                lblColegio.Text= tabla.Rows[0][4].ToString();
            }
            
        }

        public bool aceptarCancelat()//metodo para saber si hizo click en aceptar o cancelar
        {
            return aceptar;
        }

       
        public DataTable getTabla()//retorno la tabla con los datos obtenidos
        {
            return tabla;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar = true;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            this.Dispose();
        }
    }
}
