namespace GestionSalaraies
{
    partial class FrmSalaries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalaries));
            this.gbSalaries = new System.Windows.Forms.GroupBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.cbChoix = new System.Windows.Forms.ComboBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.lblChiffre = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCharges = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblCharges = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblSalarie = new System.Windows.Forms.Label();
            this.cbSalarie = new System.Windows.Forms.ComboBox();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.errMatricule = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSalaire = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCharges = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errChiffre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCommission = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProfil = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSalaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMatricule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChiffre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSalaries
            // 
            this.gbSalaries.BackColor = System.Drawing.Color.SlateGray;
            this.gbSalaries.Controls.Add(this.lblChoix);
            this.gbSalaries.Controls.Add(this.cbChoix);
            this.gbSalaries.Controls.Add(this.txtCommission);
            this.gbSalaries.Controls.Add(this.txtChiffre);
            this.gbSalaries.Controls.Add(this.lblCommission);
            this.gbSalaries.Controls.Add(this.lblChiffre);
            this.gbSalaries.Controls.Add(this.txtMatricule);
            this.gbSalaries.Controls.Add(this.lblMatricule);
            this.gbSalaries.Controls.Add(this.txtDate);
            this.gbSalaries.Controls.Add(this.lblDate);
            this.gbSalaries.Controls.Add(this.txtCharges);
            this.gbSalaries.Controls.Add(this.btnAnnuler);
            this.gbSalaries.Controls.Add(this.btnValider);
            this.gbSalaries.Controls.Add(this.btnModifier);
            this.gbSalaries.Controls.Add(this.txtSalaire);
            this.gbSalaries.Controls.Add(this.txtPrenom);
            this.gbSalaries.Controls.Add(this.txtNom);
            this.gbSalaries.Controls.Add(this.lblCharges);
            this.gbSalaries.Controls.Add(this.lblSalaire);
            this.gbSalaries.Controls.Add(this.lblPrenom);
            this.gbSalaries.Controls.Add(this.lblNom);
            this.gbSalaries.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalaries.ForeColor = System.Drawing.Color.DarkOrange;
            this.gbSalaries.Location = new System.Drawing.Point(443, 0);
            this.gbSalaries.Name = "gbSalaries";
            this.gbSalaries.Size = new System.Drawing.Size(249, 443);
            this.gbSalaries.TabIndex = 0;
            this.gbSalaries.TabStop = false;
            this.gbSalaries.Text = "Détails salariés";
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(5, 31);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(103, 18);
            this.lblChoix.TabIndex = 16;
            this.lblChoix.Text = "Type de profil :";
            // 
            // cbChoix
            // 
            this.cbChoix.Enabled = false;
            this.cbChoix.FormattingEnabled = true;
            this.cbChoix.Items.AddRange(new object[] {
            "Salarié",
            "Commercial"});
            this.cbChoix.Location = new System.Drawing.Point(135, 23);
            this.cbChoix.Name = "cbChoix";
            this.cbChoix.Size = new System.Drawing.Size(100, 26);
            this.cbChoix.TabIndex = 15;
            this.cbChoix.Visible = false;
            this.cbChoix.SelectedIndexChanged += new System.EventHandler(this.cbChoix_SelectedIndexChanged);
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(135, 348);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(100, 23);
            this.txtCommission.TabIndex = 14;
            this.txtCommission.Visible = false;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Location = new System.Drawing.Point(135, 309);
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(100, 23);
            this.txtChiffre.TabIndex = 13;
            this.txtChiffre.Visible = false;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(8, 355);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(89, 18);
            this.lblCommission.TabIndex = 12;
            this.lblCommission.Text = "Commission :";
            this.lblCommission.Visible = false;
            // 
            // lblChiffre
            // 
            this.lblChiffre.AutoSize = true;
            this.lblChiffre.Location = new System.Drawing.Point(7, 316);
            this.lblChiffre.Name = "lblChiffre";
            this.lblChiffre.Size = new System.Drawing.Size(116, 18);
            this.lblChiffre.TabIndex = 11;
            this.lblChiffre.Text = "Chiffre d\'affaire :";
            this.lblChiffre.Visible = false;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(135, 75);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(100, 23);
            this.txtMatricule.TabIndex = 2;
            this.txtMatricule.Visible = false;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(8, 82);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(79, 18);
            this.lblMatricule.TabIndex = 10;
            this.lblMatricule.Text = "Matricule : ";
            this.lblMatricule.Visible = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(135, 270);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(5, 277);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(131, 18);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date de naissance : ";
            // 
            // txtCharges
            // 
            this.txtCharges.Location = new System.Drawing.Point(135, 231);
            this.txtCharges.Name = "txtCharges";
            this.txtCharges.Size = new System.Drawing.Size(100, 23);
            this.txtCharges.TabIndex = 6;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnnuler.Location = new System.Drawing.Point(168, 393);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnValider.Location = new System.Drawing.Point(87, 393);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModifier.Location = new System.Drawing.Point(6, 394);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(135, 192);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(100, 23);
            this.txtSalaire.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(135, 153);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 23);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(135, 114);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 23);
            this.txtNom.TabIndex = 3;
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Location = new System.Drawing.Point(5, 238);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(121, 18);
            this.lblCharges.TabIndex = 3;
            this.lblCharges.Text = "Taux de charges : ";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(5, 199);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(94, 18);
            this.lblSalaire.TabIndex = 2;
            this.lblSalaire.Text = "Salaire brut : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(5, 160);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(68, 18);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(5, 121);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(48, 18);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // lblSalarie
            // 
            this.lblSalarie.AutoSize = true;
            this.lblSalarie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalarie.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSalarie.Location = new System.Drawing.Point(7, 202);
            this.lblSalarie.Name = "lblSalarie";
            this.lblSalarie.Size = new System.Drawing.Size(129, 18);
            this.lblSalarie.TabIndex = 2;
            this.lblSalarie.Text = "Choisir un salarié : ";
            // 
            // cbSalarie
            // 
            this.cbSalarie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbSalarie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalarie.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalarie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbSalarie.FormattingEnabled = true;
            this.cbSalarie.Location = new System.Drawing.Point(164, 194);
            this.cbSalarie.Name = "cbSalarie";
            this.cbSalarie.Size = new System.Drawing.Size(121, 26);
            this.cbSalarie.TabIndex = 0;
            this.cbSalarie.SelectedIndexChanged += new System.EventHandler(this.cbSalarie_SelectedIndexChanged);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNouveau.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNouveau.Location = new System.Drawing.Point(327, 197);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // errMatricule
            // 
            this.errMatricule.ContainerControl = this;
            // 
            // errNom
            // 
            this.errNom.ContainerControl = this;
            // 
            // errPrenom
            // 
            this.errPrenom.ContainerControl = this;
            // 
            // errSalaire
            // 
            this.errSalaire.ContainerControl = this;
            // 
            // errCharges
            // 
            this.errCharges.ContainerControl = this;
            // 
            // errDate
            // 
            this.errDate.ContainerControl = this;
            // 
            // errChiffre
            // 
            this.errChiffre.ContainerControl = this;
            // 
            // errCommission
            // 
            this.errCommission.ContainerControl = this;
            // 
            // errProfil
            // 
            this.errProfil.ContainerControl = this;
            // 
            // FrmSalaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 442);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.cbSalarie);
            this.Controls.Add(this.lblSalarie);
            this.Controls.Add(this.gbSalaries);
            this.Name = "FrmSalaries";
            this.Text = "Gestion des salariés";
            this.Load += new System.EventHandler(this.FrmSalaries_Load);
            this.gbSalaries.ResumeLayout(false);
            this.gbSalaries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMatricule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errChiffre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSalaries;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblSalarie;
        private System.Windows.Forms.ComboBox cbSalarie;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCharges;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Label lblChiffre;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtChiffre;
        private System.Windows.Forms.ErrorProvider errMatricule;
        private System.Windows.Forms.ErrorProvider errNom;
        private System.Windows.Forms.ErrorProvider errPrenom;
        private System.Windows.Forms.ErrorProvider errSalaire;
        private System.Windows.Forms.ErrorProvider errCharges;
        private System.Windows.Forms.ErrorProvider errDate;
        private System.Windows.Forms.ErrorProvider errChiffre;
        private System.Windows.Forms.ErrorProvider errCommission;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.ComboBox cbChoix;
        private System.Windows.Forms.ErrorProvider errProfil;
    }
}