using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalariesDll;
using GestionSalaraies.Properties;
using Utilitaires;


namespace GestionSalaraies
{
    public partial class FrmSalaries : Form
    { 
        private static FrmSalaries singleFrmSalaries = new FrmSalaries(); 
        public static FrmSalaries SingleFrmSalaries { get { return singleFrmSalaries;  } }
        public bool isNew = false ; 
        Salaries salaries;
        Salarie salarie;
        Commercial commercial; 
        
        private FrmSalaries()
        {
            InitializeComponent();
            
        }

        #region Gestion des contextes
        enum Contextes
        {
            Initial = 0,
            Consultation = 1,
            ModificationInitiale = 2,
            Modification = 3,
            ModificationIssue = 4,
            AjoutInitial = 5,
            Ajout = 6, 
            AjoutValider = 7, 
            AjoutAnnuler = 8

        }

        void GestionnaireContextes(Contextes contexte)

        {
            switch (contexte)
            {
                case Contextes.Initial:
                    cbSalarie.Enabled = (cbSalarie.Items.Count > 0);
                    btnNouveau.Enabled = true;
                    gbSalaries.Visible = false;
                    txtNom.ReadOnly = true ;
                    txtPrenom.ReadOnly = true;
                    txtCharges.ReadOnly = true;
                    txtDate.ReadOnly = true;
                    txtSalaire.ReadOnly = true;
                    txtChiffre.ReadOnly = true;
                    txtCommission.ReadOnly = true; 
                    btnAnnuler.Enabled = false;
                    btnModifier.Enabled = false;
                    btnValider.Enabled = false;
                    lblMatricule.Visible = false;
                    txtMatricule.Visible = false;
                    cbSalarie.Focus(); 
                    break;

                case Contextes.Consultation: //pour les non-admins
                    gbSalaries.Visible = true;
                    break; 

                case Contextes.ModificationInitiale: //sur selection d'un salarié dans la combobox
                    gbSalaries.Visible = true;
                    cbSalarie.Enabled = true; 
                    btnModifier.Enabled = true;
                    btnNouveau.Enabled = true;
                    btnAnnuler.Enabled = false;
                    btnValider.Enabled = false;
                    txtNom.ReadOnly = true;
                    txtPrenom.ReadOnly = true;
                    txtCharges.ReadOnly = true;
                    txtDate.ReadOnly = true;
                    txtChiffre.ReadOnly = true;
                    txtCommission.ReadOnly = true;
                    txtSalaire.ReadOnly = true;
                    cbChoix.Visible = true;
                    cbChoix.Enabled = false; 
                    lblChoix.Visible = true;
                    break;

                case Contextes.Modification: //sur clic du bouton Modifier et si un salarié est selectionné.  
                    txtNom.ReadOnly = false;
                    txtNom.Focus();  
                    txtPrenom.ReadOnly = false;
                    txtCharges.ReadOnly = false;
                    txtDate.ReadOnly = false;
                    txtSalaire.ReadOnly = false;
                    txtChiffre.ReadOnly = false;
                    txtCommission.ReadOnly = false;
                    btnAnnuler.Enabled = true;
                    btnModifier.Enabled = false;
                    btnValider.Enabled = true;
                    btnNouveau.Enabled = false;
                    cbChoix.Visible = false;
                    lblChoix.Visible = false; 
                    break;

                case Contextes.ModificationIssue: //à l'issue du dialogue de validation si données validées ou à l'issue de l'annulation 
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtCharges.Clear() ;
                    txtDate.Clear() ;
                    txtSalaire.Clear() ;
                    lblMatricule.Visible = false;
                    txtMatricule.Visible = false;
                    GestionnaireContextes(Contextes.ModificationInitiale);
                    break;

                case Contextes.AjoutInitial: //sur clic du bouton nouveau
                    isNew = true; 
                    gbSalaries.Visible = true; 
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtCharges.Clear();
                    txtDate.Clear();
                    txtSalaire.Clear();
                    txtCommission.Clear();
                    txtChiffre.Clear();
                    txtNom.ReadOnly = true;
                    txtPrenom.ReadOnly = true;
                    txtCharges.ReadOnly = true;
                    txtDate.ReadOnly = true;
                    txtChiffre.ReadOnly = true;
                    txtCommission.ReadOnly = true;
                    txtSalaire.ReadOnly = true;
                    cbSalarie.SelectedIndex = -1; 
                    cbSalarie.Enabled = false;
                    lblMatricule.Visible = true;
                    txtMatricule.Visible = true;
                    txtMatricule.ReadOnly = true;
                    btnAnnuler.Enabled = true;
                    btnModifier.Enabled = false;
                    btnValider.Enabled = false;
                    btnNouveau.Enabled = false;
                    cbChoix.Visible = true;
                    cbChoix.Enabled = true;
                    cbChoix.SelectedIndex = -1; 
                    lblChoix.Visible = true;
                    txtChiffre.Visible = false;
                    txtCommission.Visible = false;
                    lblChiffre.Visible = false;
                    lblCommission.Visible = false;
                    cbChoix.Focus();
                    break;

                case Contextes.Ajout: //après sélection d'un type de profil dans cbchoix
                    txtNom.ReadOnly = false;
                    txtPrenom.ReadOnly = false;
                    txtCharges.ReadOnly = false;
                    txtDate.ReadOnly = false;
                    txtSalaire.ReadOnly = false;
                    txtChiffre.ReadOnly = false;
                    txtCommission.ReadOnly = false;
                    txtMatricule.ReadOnly = false;
                    btnAnnuler.Enabled = true;
                    btnModifier.Enabled = false;
                    btnValider.Enabled = true;
                    btnNouveau.Enabled = false;
                    break; 

                case Contextes.AjoutValider: //sur clic du bouton Valider si création d'un nouveau salarié. Voir si fusion AjoutValider et ModificationValider possible
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtCharges.Clear();
                    txtDate.Clear();
                    txtSalaire.Clear();
                    txtChiffre.Clear();
                    txtCommission.Clear(); 
                    lblMatricule.Visible = false;
                    txtMatricule.Visible = false;
                    GestionnaireContextes(Contextes.ModificationInitiale);
                    isNew = false; 
                    
                    break; 

                case Contextes.AjoutAnnuler: //sur clic du bouton annuler si création d'un nouveau salarié. Voir si fusion possible avec ModificationAnnuler
                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtCharges.Clear();
                    txtDate.Clear();
                    txtSalaire.Clear();
                    txtChiffre.Clear();
                    txtCommission.Clear();
                    lblMatricule.Visible = false;
                    txtMatricule.Visible = false;
                    isNew = false; 
                    GestionnaireContextes(Contextes.ModificationInitiale);
                    break; 
            }
        }
        #endregion

        #region Serialization des données
        private void ChargerSalaries()
        {
            
            salaries = new Salaries();
            ISauvegarde serializer = MonApplication.DispositifSauvegarde;
            salaries.Load(serializer, Properties.Settings.Default.AppData);

            foreach (Salarie item in salaries)
            {
               
                cbSalarie.Items.Add(item.Matricule); 
            }
        }

        private void SauvegarderSalarie()
        {
            
            ISauvegarde serializer = MonApplication.DispositifSauvegarde;
            salaries.Save(serializer, Properties.Settings.Default.AppData); 
        }

        #endregion

        #region Méthodes
        private void ChargerValeursSalaries()
        {
            txtNom.Text = salarie.Nom;
            txtPrenom.Text = salarie.Prenom;
            txtSalaire.Text = salarie.SalaireNet.ToString();
            txtCharges.Text = salarie.TauxCS.ToString();
            txtDate.Text = salarie.DateNaissance.ToString();

            
            if (salarie is Commercial)
            {
                commercial = salarie as Commercial;
                cbChoix.SelectedIndex = 1; 
                lblChiffre.Visible = true; txtChiffre.Visible = true;
                lblCommission.Visible = true; txtCommission.Visible = true;
                txtChiffre.Text = commercial.ChiffreAffaire.ToString();
                txtCommission.Text = commercial.Commission.ToString();
            }
            else
            {
                cbChoix.SelectedIndex = 0;
                lblChiffre.Visible = false; txtChiffre.Visible = false;
                lblCommission.Visible = false; txtCommission.Visible = false;
            }
        }
        
       private void ChargerValeursChamps()
        {
                
                salarie.Nom = txtNom.Text;
                salarie.Prenom = txtPrenom.Text;
                salarie.SalaireBrut = decimal.Parse(txtSalaire.Text);
                salarie.TauxCS = decimal.Parse(txtCharges.Text);
                salarie.DateNaissance = DateTime.Parse(txtDate.Text);

            if (!isNew  && salarie is Commercial)
            {
                commercial.ChiffreAffaire = decimal.Parse(txtChiffre.Text);
                commercial.Commission = decimal.Parse(txtCommission.Text);

            }  
                
            if (isNew)
            {

                salarie.Matricule = txtMatricule.Text;
               
                if (salarie is Commercial)
                {
                    commercial = salarie as Commercial;
                    commercial.ChiffreAffaire = decimal.Parse(txtChiffre.Text);
                    commercial.Commission = decimal.Parse(txtCommission.Text);
                }

            }
        }
       
        private bool ChampsValides() 
        {
            string message = " Veuillez modifier le champ concerné.";
           
            try
            {
                ChargerValeursChamps(); 
                return true; 
            }
            catch (ApplicationException ApEx)
            {
                MessageBox.Show(ApEx.Message + message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
        }

        /*private void AfficherErrorProvider()
        {
            
            if (errCharges.)
            {

            }
        }*/


        #endregion

        #region Evennements
        private void FrmSalaries_Load(object sender, EventArgs e)
        {
            ChargerSalaries();
            GestionnaireContextes(Contextes.Initial);
        }
        private void cbSalarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSalarie.SelectedIndex != -1)
            {
                salarie = salaries.ExtraireSalarie(cbSalarie.Items[cbSalarie.SelectedIndex].ToString());
                ChargerValeursSalaries();
            }
            
            GestionnaireContextes(Contextes.ModificationInitiale); 
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.Modification); 
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            if (cbSalarie.SelectedIndex < 0)
            {
                GestionnaireContextes(Contextes.Initial); 
            }
            else {
                GestionnaireContextes(Contextes.ModificationIssue);
                salarie = salaries.ExtraireSalarie(cbSalarie.Items[cbSalarie.SelectedIndex].ToString());
                ChargerValeursSalaries();
            }
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            DialogResult validation = MessageBox.Show
                               ("Etes-vous sûr.e de vouloir valider ces modifications ?", "Validation des modifications", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (validation)
            {
                case DialogResult.Yes:
                    {   
                        
                        if (ChampsValides())
                        {
                            if (isNew == true)
                            {
                                
                                if (cbChoix.SelectedIndex == 0)
                                {
                                    salaries.Add(salarie);
                                }
                                else if (cbChoix.SelectedIndex == 1)
                                {
                                    salaries.Add(commercial);
                                }
                                cbSalarie.Items.Add(salarie.Matricule);
                                cbSalarie.SelectedItem = salarie.Matricule;
                                
                            }

                            ChargerValeursSalaries();
                            SauvegarderSalarie();
                            MessageBox.Show("Les modifications ont bien été effectuées !");
                            GestionnaireContextes(Contextes.AjoutValider); 
                        }

                        else
                        {
                            if (isNew == true)
                            {
                                txtMatricule.Focus();
                            }
                            else
                            {
                                txtNom.Focus(); 
                            }
                        }

                        GestionnaireContextes(Contextes.ModificationIssue);

                        break;
                    }
                case DialogResult.No:
                    {
                        MessageBox.Show("Les modifications n'ont pas été effectuées. Retour à la modification du salarié.");
                        break;
                    }
      
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.AjoutInitial); 
        }

        private void cbChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChoix.SelectedIndex <= 0 )
            {
                txtChiffre.Visible = false;
                txtCommission.Visible = false;
                lblChiffre.Visible = false;
                lblCommission.Visible = false;
                salarie = new Salarie(); 
            }
            else
            {

                txtChiffre.Visible = true;
                txtCommission.Visible = true;
                lblChiffre.Visible = true;
                lblCommission.Visible = true;
                salarie = new Commercial() ; 
            }

            GestionnaireContextes(Contextes.Ajout); 
        }

        #endregion
        

    }
}
