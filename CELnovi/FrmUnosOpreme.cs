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
    public partial class FrmUnosOpreme : Form
    {
        public FrmUnosOpreme()
        {
            InitializeComponent();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void FrmUnosOpreme_Load(object sender, EventArgs e)
        {

        }

        private void btnPopisClick(object sender, EventArgs e)
        {
            FrmOprema frmOprema = new FrmOprema(); // kad se klikne gumb, stara forma se zapre i otpre se nova 
            Hide();
            frmOprema.ShowDialog();
            Close();
        }

        private void btnUnesiClick(object sender, EventArgs e)
        {

        }
    }
}
