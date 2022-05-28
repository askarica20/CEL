using CELnovi.Models;
using CELnovi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgvOprema.Columns["IzvorFinanciranja"].DisplayIndex = 5; // nez
            dgvOprema.Columns["OpisOpreme"].DisplayIndex = 6;
            dgvOprema.Columns["OsobaNabave"].DisplayIndex = 7;
            dgvOprema.Columns["OsobaPrimke"].DisplayIndex = 8;

        }
        
        private void btnUnesi2Click(object sender, EventArgs e)
        {
            /*
            FrmUnosOpreme frmUnosOpreme = new FrmUnosOpreme();
            Hide();
            frmUnosOpreme.ShowDialog();
            Close(); */
            
            
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema; // nez ovo mozda isto smeta idk
            if (odabranaOprema != null)
            {
                FrmUnosOpreme frmUnosOpreme = new FrmUnosOpreme(odabranaOprema);
                frmUnosOpreme.ShowDialog();
            }
        }

        private void bntUrediClick(object sender, EventArgs e)
        {

        }
    }
}
