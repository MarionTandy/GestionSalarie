using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionSalaraies
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUtilisateurs frmUtilisateurs = new FrmUtilisateurs();
            frmUtilisateurs.MdiParent = this; 
            frmUtilisateurs.Show(); 
        }

        private void gestionDesSalariésToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             FrmSalaries.SingleFrmSalaries.MdiParent = this; 
             FrmSalaries.SingleFrmSalaries.Show(); 
        }
    }
}
