
using System.Data;

using System.Windows.Forms;

namespace ReadQRcode
{
    public partial class TotalInscriptos : Form
    {
        public TotalInscriptos()
        {
            InitializeComponent();
            dgvTotal.DataSource = new DConectar().colegiosGetAll();
        }

        private void dgvTotal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string cue = dgvTotal.CurrentRow.Cells["RowCue"].Value.ToString();
            DataTable tabla = new DConectar().consultarRegistroManualmente(cue);

            if (tabla != null)
            {
                if (tabla.Rows.Count > 0)
                {
                    RegistrarAsistencia reg = new RegistrarAsistencia(tabla);
                    reg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("CUE no encontrado");
                }
            }
            else
            {
                MessageBox.Show("CUE no encontrado");
            }

        }
    }
}
