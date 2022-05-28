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
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema; // nez ovo mozda isto smeta idk
            if (odabranaOprema != null)
            {
                FrmUnosOpreme frmUnosOpreme = new FrmUnosOpreme(odabranaOprema);
                frmUnosOpreme.ShowDialog();
            }
        }

        private void bntUrediClick(object sender, EventArgs e)
        {
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema;
            int indexReda = dgvOprema.CurrentCell.RowIndex; // krece od 0
            DataGridViewRow row = dgvOprema.CurrentCell.OwningRow;
            

            if (odabranaOprema != null)
            {
                
                
                //FrmUnosOpreme frmUnosOpreme = new FrmUnosOpreme(odabranaOprema);
                //frmUnosOpreme.ShowDialog();
            }

            /* // OK OVO DELA AL NE BAS DOBRO
        string sql = $"DELETE FROM Oprema WHERE Id='{indexReda+1}'";

        DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
        DB.OpenConnection();
        DB.ExecuteCommand(sql); // kad odaberem neki drugi izvor, tu baca error
        DB.CloseConnection();
      */
        }

        private void dgvOprema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "Izbrisati ovaj red?";
            string title = "Potvrda";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvOprema.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                MessageBox.Show(id.ToString()); // ok ovo vraca id od reda

                string sql = $"DELETE FROM Oprema WHERE Id='{id}'";

                DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();

                FrmOprema frmOprema = new FrmOprema(); // refreshanje
                Hide();
                frmOprema.ShowDialog();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
