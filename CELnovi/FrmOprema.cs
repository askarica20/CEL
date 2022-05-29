using CELnovi.Models;
using CELnovi.Repositories;
using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CELnovi
{
    public partial class FrmOprema : Form
    {
        public FrmOprema()
        {
            InitializeComponent();
        }
        
        private void FrmOprema_Load(object sender, EventArgs e)
        {
            PrikaziOpremu();
        }

        private void PrikaziOpremu()
        {
            var opreme = RepozitorijOpreme.GetOpremas();
            dgvOprema.DataSource = opreme;

            dgvOprema.Columns["Id"].DisplayIndex = 0;
            dgvOprema.Columns["Naziv"].DisplayIndex = 1;
            dgvOprema.Columns["Vrsta"].DisplayIndex = 2;
            dgvOprema.Columns["DatVrPrimke"].DisplayIndex = 3;
            dgvOprema.Columns["NazivProjekta"].DisplayIndex = 4;
            dgvOprema.Columns["IzvorFinanciranja"].DisplayIndex = 5;
            dgvOprema.Columns["OpisOpreme"].DisplayIndex = 6;
            dgvOprema.Columns["OsobaNabave"].DisplayIndex = 7;
            dgvOprema.Columns["OsobaPrimke"].DisplayIndex = 8;

        }
        
        private void btnUnesi2Click(object sender, EventArgs e)
        {
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema; 
            if (odabranaOprema != null)
            {
                FrmUnosOpreme frmUnosOpreme = new FrmUnosOpreme(odabranaOprema);
                frmUnosOpreme.ShowDialog();
            }
        }

        private void bntUrediClick(object sender, EventArgs e) // UPDATEANJE
        {
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema;
   
            if (odabranaOprema != null) // ak smo kliknuli na nekog
            {
                FrmUpdate frmUpdate = new FrmUpdate(odabranaOprema); // slanje preko konstruktora
                Hide();
                frmUpdate.ShowDialog();
                Close();
            }

        }
       
        private void dgvOprema_CellContentClick(object sender, DataGridViewCellEventArgs e) // BRISANJE NA CLICK NA CELIJU
        { /*
            string message = "Izbrisati ovaj red?";
            string title = "Potvrda";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvOprema.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                // MessageBox.Show(id.ToString()); // ok ovo vraca id od reda

                string sql = $"DELETE FROM Oprema WHERE Id='{id}'";

                DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();

                FrmOprema frmOprema = new FrmOprema(); // refreshanje
                Hide();
                frmOprema.ShowDialog();
                Close();
            } */
        }
       


            private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
