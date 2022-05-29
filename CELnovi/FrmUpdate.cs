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
    public partial class FrmUpdate : Form
    {
        private Oprema oprema;

        public FrmUpdate(Oprema odabranaOprema)
        {
            InitializeComponent(); // konstruktor u koji se proslijedi odabrana oprema iz datagridviewa
            oprema = odabranaOprema;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            // .Show(oprema.IzvorFinanciranja.ToString()); // OK I TU DELA
            // MessageBox.Show(oprema.IzvorFinanciranja.Id.ToString());// OK I TU ISTO DELA
            Text = oprema.Naziv; // gore napiše kojeg smo odabrali OK OVO DELA OMG KAKAV SAM JA GAS
            List<IzvorFinanciranjaKlasa> izvorFinanciranjaUpdate = RepozitorijIzvoraFinanciranja.GetIzvoreFinanciranja();
            cboIzvorFinanciranjaUpdate.DataSource = izvorFinanciranjaUpdate; // da se prikaze dropdown opet
            // List<Oprema> opreme = RepozitorijOpreme.GetOpremas();
            // cboIzvorFinanciranjaUpdate.DataSource = opreme; // otvori se padajući za aktivnosti
            txtIdUpdate.Text = oprema.Id.ToString();
            txtNazivOpremeUpdate.Text = oprema.Naziv; // prikaz odabrane opreme u polju u formi
            txtVrstaOpremeUpdate.Text= oprema.Vrsta;
            txtDatVrPrimkeUpdate.Text = oprema.DatVrPrimke;
            txtNazivProjektaUpdate.Text = oprema.NazivProjekta;
            txtOpisOpremeUpdate.Text = oprema.OpisOpreme;
            txtOsobaNabaveUpdate.Text = oprema.OsobaNabave;
            txtOsobaPrimkeUpdate.Text = oprema.OsobaPrimke;

            var tekstIzComboboxa = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(oprema.IzvorFinanciranja.Id).ToString();
            cboIzvorFinanciranjaUpdate.Text = tekstIzComboboxa; // ovo vraca taj tekst, al se nemre promijenit nikaj

            // novaOprema.IzvorFinanciranja = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(cboIzvorFinanciranja.SelectedIndex+1);


            // cboIzvorFinanciranjaUpdate.SelectedIndex = oprema.IzvorFinanciranja.Id.ToString());
            // cboIzvorFinanciranjaUpdate.SelectedIndex = int.Parse(oprema.izvorFinanciranja.Id.ToString());
            //MessageBox.Show(RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(oprema.IzvorFinanciranja.Id).ToString());
            //MessageBox.Show(RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(oprema.IzvorFinanciranja.Id));
            //cboIzvorFinanciranjaUpdate.SelectedIndex = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(oprema.IzvorFinanciranja.Id);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmOprema frmOprema = new FrmOprema(); 
            Hide();
            frmOprema.ShowDialog();
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int idUpdate = int.Parse(txtIdUpdate.Text); // ovo su novi inputi nakon izmjene
            string nazivUpdate = txtNazivOpremeUpdate.Text;
            string vrstaUpdate = txtVrstaOpremeUpdate.Text;
            string datVrPrimkeUpdate = txtDatVrPrimkeUpdate.Text;
            string nazivProjektaUpdate = txtNazivProjektaUpdate.Text;
            int izvorFinanciranjaUpdate = cboIzvorFinanciranjaUpdate.SelectedIndex;
            string opisOpremeUpdate = txtOpisOpremeUpdate.Text;
            string osobaNabaveUpdate = txtOsobaNabaveUpdate.Text;
            string osobaPrimkeUpdate = txtOsobaPrimkeUpdate.Text;
            // MessageBox.Show(izvorFinanciranjaUpdate.ToString());
            Oprema updateanaOprema = new Oprema(); // stvara se novi objekt da se moze poslat ko objekt u funkciju za updateanje

            updateanaOprema.Id = idUpdate;
            updateanaOprema.Naziv = nazivUpdate;
            updateanaOprema.Vrsta = vrstaUpdate;
            updateanaOprema.DatVrPrimke = datVrPrimkeUpdate;
            updateanaOprema.NazivProjekta = nazivProjektaUpdate;
            updateanaOprema.IzvorFinanciranja = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(cboIzvorFinanciranjaUpdate.SelectedIndex + 1); // +1 jer ide od nultog ova metoda
            // MessageBox.Show("updateanaOprema.IzvorFinanciranja ="+(cboIzvorFinanciranjaUpdate.SelectedIndex + 1).ToString());
            // MessageBox.Show("nastavak:" + RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(cboIzvorFinanciranjaUpdate.SelectedIndex + 1));
            updateanaOprema.OpisOpreme = opisOpremeUpdate;
            updateanaOprema.OsobaNabave = osobaNabaveUpdate;
            updateanaOprema.OsobaPrimke = osobaPrimkeUpdate;

            RepozitorijOpreme.UpdateOpreme(updateanaOprema);

            MessageBox.Show("Uspješan update!");

            FrmOprema frmOprema = new FrmOprema();
            Hide();
            frmOprema.ShowDialog();
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            string message = "Izbrisati ovaj red?";
            string title = "Potvrda";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int idUpdate = int.Parse(txtIdUpdate.Text);
                Oprema updateanaOprema = new Oprema();
                updateanaOprema.Id = idUpdate;
                RepozitorijOpreme.IzbrisiOpremu(updateanaOprema.Id);

                FrmOprema frmOprema = new FrmOprema();
                Hide();
                MessageBox.Show("Uspješno brisanje!");
                frmOprema.ShowDialog();
                Close();
            }


            
        }


    }
}
