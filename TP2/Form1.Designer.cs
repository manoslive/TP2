﻿namespace TP2
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_Empno = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.TB_CodeDep = new System.Windows.Forms.TextBox();
            this.TB_Echelon = new System.Windows.Forms.TextBox();
            this.TB_Salaire = new System.Windows.Forms.TextBox();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.BTN_Precedent = new System.Windows.Forms.Button();
            this.LB_Echelon = new System.Windows.Forms.Label();
            this.LB_Salaire = new System.Windows.Forms.Label();
            this.LB_Adresse = new System.Windows.Forms.Label();
            this.LB_NumEmploye = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.LB_CodeDep = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Vider = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_FIN = new System.Windows.Forms.Button();
            this.BTN_Afficher = new System.Windows.Forms.Button();
            this.LBL_Departements = new System.Windows.Forms.Label();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.RB_Tous = new System.Windows.Forms.RadioButton();
            this.RB_UnEmploye = new System.Windows.Forms.RadioButton();
            this.RB_Departement = new System.Windows.Forms.RadioButton();
            this.LB_Recherche = new System.Windows.Forms.Label();
            this.DGV_Departements = new System.Windows.Forms.DataGridView();
            this.codedep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbr_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Information = new System.Windows.Forms.Label();
            this.BTN_Recherche = new System.Windows.Forms.Button();
            this.LB_TextRecherche = new System.Windows.Forms.Label();
            this.TB_NomRecherche = new System.Windows.Forms.TextBox();
            this.CB_Dep = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Departements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Empno
            // 
            this.TB_Empno.Enabled = false;
            this.TB_Empno.Location = new System.Drawing.Point(96, 27);
            this.TB_Empno.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Empno.MaxLength = 6;
            this.TB_Empno.Name = "TB_Empno";
            this.TB_Empno.Size = new System.Drawing.Size(160, 20);
            this.TB_Empno.TabIndex = 0;
            this.toolTip.SetToolTip(this.TB_Empno, "Entrez un numero non existant !");
            this.TB_Empno.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_Empno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Enabled = false;
            this.TB_Nom.Location = new System.Drawing.Point(96, 47);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Nom.MaxLength = 30;
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(160, 20);
            this.TB_Nom.TabIndex = 1;
            this.TB_Nom.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Lettre_KeyPress);
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Enabled = false;
            this.TB_Prenom.Location = new System.Drawing.Point(96, 68);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Prenom.MaxLength = 30;
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(160, 20);
            this.TB_Prenom.TabIndex = 2;
            this.TB_Prenom.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Lettre_KeyPress);
            // 
            // TB_CodeDep
            // 
            this.TB_CodeDep.Enabled = false;
            this.TB_CodeDep.Location = new System.Drawing.Point(96, 89);
            this.TB_CodeDep.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CodeDep.MaxLength = 4;
            this.TB_CodeDep.Name = "TB_CodeDep";
            this.TB_CodeDep.Size = new System.Drawing.Size(160, 20);
            this.TB_CodeDep.TabIndex = 3;
            this.toolTip.SetToolTip(this.TB_CodeDep, "Entrez un code dep existant !");
            this.TB_CodeDep.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_CodeDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // TB_Echelon
            // 
            this.TB_Echelon.Enabled = false;
            this.TB_Echelon.Location = new System.Drawing.Point(96, 110);
            this.TB_Echelon.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Echelon.MaxLength = 2;
            this.TB_Echelon.Name = "TB_Echelon";
            this.TB_Echelon.Size = new System.Drawing.Size(160, 20);
            this.TB_Echelon.TabIndex = 4;
            this.toolTip.SetToolTip(this.TB_Echelon, "Entrez un nombre positif !");
            this.TB_Echelon.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_Echelon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // TB_Salaire
            // 
            this.TB_Salaire.Enabled = false;
            this.TB_Salaire.Location = new System.Drawing.Point(96, 131);
            this.TB_Salaire.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Salaire.MaxLength = 8;
            this.TB_Salaire.Name = "TB_Salaire";
            this.TB_Salaire.Size = new System.Drawing.Size(160, 20);
            this.TB_Salaire.TabIndex = 5;
            this.toolTip.SetToolTip(this.TB_Salaire, "Entre 25000 et 100000 ");
            this.TB_Salaire.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_Salaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Salaire_KeyPress);
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Enabled = false;
            this.TB_Adresse.Location = new System.Drawing.Point(96, 151);
            this.TB_Adresse.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Adresse.MaxLength = 60;
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(160, 20);
            this.TB_Adresse.TabIndex = 6;
            this.TB_Adresse.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.TB_Adresse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Adresse_KeyPress);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Suivant.Location = new System.Drawing.Point(93, 211);
            this.BTN_Suivant.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(67, 22);
            this.BTN_Suivant.TabIndex = 0;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Precedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Precedent.Location = new System.Drawing.Point(22, 211);
            this.BTN_Precedent.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(67, 22);
            this.BTN_Precedent.TabIndex = 0;
            this.BTN_Precedent.Text = "Précédent";
            this.BTN_Precedent.UseVisualStyleBackColor = true;
            this.BTN_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // LB_Echelon
            // 
            this.LB_Echelon.AutoSize = true;
            this.LB_Echelon.Location = new System.Drawing.Point(19, 112);
            this.LB_Echelon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Echelon.Name = "LB_Echelon";
            this.LB_Echelon.Size = new System.Drawing.Size(46, 13);
            this.LB_Echelon.TabIndex = 2;
            this.LB_Echelon.Text = "Échelon";
            // 
            // LB_Salaire
            // 
            this.LB_Salaire.AutoSize = true;
            this.LB_Salaire.Location = new System.Drawing.Point(19, 133);
            this.LB_Salaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Salaire.Name = "LB_Salaire";
            this.LB_Salaire.Size = new System.Drawing.Size(39, 13);
            this.LB_Salaire.TabIndex = 2;
            this.LB_Salaire.Text = "Salaire";
            // 
            // LB_Adresse
            // 
            this.LB_Adresse.AutoSize = true;
            this.LB_Adresse.Location = new System.Drawing.Point(19, 153);
            this.LB_Adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Adresse.Name = "LB_Adresse";
            this.LB_Adresse.Size = new System.Drawing.Size(45, 13);
            this.LB_Adresse.TabIndex = 2;
            this.LB_Adresse.Text = "Adresse";
            // 
            // LB_NumEmploye
            // 
            this.LB_NumEmploye.AutoSize = true;
            this.LB_NumEmploye.Location = new System.Drawing.Point(19, 29);
            this.LB_NumEmploye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NumEmploye.Name = "LB_NumEmploye";
            this.LB_NumEmploye.Size = new System.Drawing.Size(74, 13);
            this.LB_NumEmploye.TabIndex = 2;
            this.LB_NumEmploye.Text = "Num. employé";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(19, 49);
            this.LB_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(29, 13);
            this.LB_Nom.TabIndex = 2;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(19, 70);
            this.LB_Prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(43, 13);
            this.LB_Prenom.TabIndex = 2;
            this.LB_Prenom.Text = "Prénom";
            // 
            // LB_CodeDep
            // 
            this.LB_CodeDep.AutoSize = true;
            this.LB_CodeDep.Location = new System.Drawing.Point(19, 91);
            this.LB_CodeDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_CodeDep.Name = "LB_CodeDep";
            this.LB_CodeDep.Size = new System.Drawing.Size(70, 13);
            this.LB_CodeDep.TabIndex = 2;
            this.LB_CodeDep.Text = "Code Départ.";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(163, 185);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(67, 22);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Vider
            // 
            this.BTN_Vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Vider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Vider.Location = new System.Drawing.Point(234, 185);
            this.BTN_Vider.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Vider.Name = "BTN_Vider";
            this.BTN_Vider.Size = new System.Drawing.Size(67, 22);
            this.BTN_Vider.TabIndex = 0;
            this.BTN_Vider.Text = "Vider";
            this.BTN_Vider.UseVisualStyleBackColor = true;
            this.BTN_Vider.Click += new System.EventHandler(this.BTN_Vider_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modifier.Location = new System.Drawing.Point(163, 211);
            this.BTN_Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(67, 22);
            this.BTN_Modifier.TabIndex = 0;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Debut.Location = new System.Drawing.Point(22, 185);
            this.BTN_Debut.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(67, 22);
            this.BTN_Debut.TabIndex = 0;
            this.BTN_Debut.Text = "Début";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_FIN
            // 
            this.BTN_FIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FIN.Location = new System.Drawing.Point(93, 185);
            this.BTN_FIN.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_FIN.Name = "BTN_FIN";
            this.BTN_FIN.Size = new System.Drawing.Size(67, 22);
            this.BTN_FIN.TabIndex = 0;
            this.BTN_FIN.Text = "Fin";
            this.BTN_FIN.UseVisualStyleBackColor = true;
            this.BTN_FIN.Click += new System.EventHandler(this.BTN_FIN_Click);
            // 
            // BTN_Afficher
            // 
            this.BTN_Afficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Afficher.Location = new System.Drawing.Point(234, 211);
            this.BTN_Afficher.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Afficher.Name = "BTN_Afficher";
            this.BTN_Afficher.Size = new System.Drawing.Size(67, 22);
            this.BTN_Afficher.TabIndex = 0;
            this.BTN_Afficher.Text = "Afficher";
            this.BTN_Afficher.UseVisualStyleBackColor = true;
            this.BTN_Afficher.Click += new System.EventHandler(this.BTN_Afficher_Click);
            // 
            // LBL_Departements
            // 
            this.LBL_Departements.AutoSize = true;
            this.LBL_Departements.Location = new System.Drawing.Point(284, 8);
            this.LBL_Departements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Departements.Name = "LBL_Departements";
            this.LBL_Departements.Size = new System.Drawing.Size(116, 13);
            this.LBL_Departements.TabIndex = 9;
            this.LBL_Departements.Text = "Liste des départements";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supprimer.Location = new System.Drawing.Point(163, 237);
            this.BTN_Supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(67, 22);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // RB_Tous
            // 
            this.RB_Tous.AutoSize = true;
            this.RB_Tous.Location = new System.Drawing.Point(333, 186);
            this.RB_Tous.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Tous.Name = "RB_Tous";
            this.RB_Tous.Size = new System.Drawing.Size(112, 17);
            this.RB_Tous.TabIndex = 11;
            this.RB_Tous.TabStop = true;
            this.RB_Tous.Text = "Tous les employés";
            this.RB_Tous.UseVisualStyleBackColor = true;
            this.RB_Tous.CheckedChanged += new System.EventHandler(this.RB_Tous_CheckedChanged);
            // 
            // RB_UnEmploye
            // 
            this.RB_UnEmploye.AutoSize = true;
            this.RB_UnEmploye.Location = new System.Drawing.Point(333, 205);
            this.RB_UnEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.RB_UnEmploye.Name = "RB_UnEmploye";
            this.RB_UnEmploye.Size = new System.Drawing.Size(97, 17);
            this.RB_UnEmploye.TabIndex = 11;
            this.RB_UnEmploye.TabStop = true;
            this.RB_UnEmploye.Text = "Nom d\'employé";
            this.RB_UnEmploye.UseVisualStyleBackColor = true;
            this.RB_UnEmploye.CheckedChanged += new System.EventHandler(this.RB_UnEmploye_CheckedChanged);
            // 
            // RB_Departement
            // 
            this.RB_Departement.AutoSize = true;
            this.RB_Departement.Location = new System.Drawing.Point(333, 225);
            this.RB_Departement.Margin = new System.Windows.Forms.Padding(2);
            this.RB_Departement.Name = "RB_Departement";
            this.RB_Departement.Size = new System.Drawing.Size(86, 17);
            this.RB_Departement.TabIndex = 11;
            this.RB_Departement.TabStop = true;
            this.RB_Departement.Text = "Département";
            this.RB_Departement.UseVisualStyleBackColor = true;
            this.RB_Departement.CheckedChanged += new System.EventHandler(this.RB_Departement_CheckedChanged);
            // 
            // LB_Recherche
            // 
            this.LB_Recherche.AutoSize = true;
            this.LB_Recherche.Location = new System.Drawing.Point(330, 163);
            this.LB_Recherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Recherche.Name = "LB_Recherche";
            this.LB_Recherche.Size = new System.Drawing.Size(60, 13);
            this.LB_Recherche.TabIndex = 9;
            this.LB_Recherche.Text = "Recherche";
            // 
            // DGV_Departements
            // 
            this.DGV_Departements.AllowUserToAddRows = false;
            this.DGV_Departements.AllowUserToDeleteRows = false;
            this.DGV_Departements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Departements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codedep,
            this.departement,
            this.nbr_emp});
            this.DGV_Departements.Location = new System.Drawing.Point(287, 27);
            this.DGV_Departements.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Departements.Name = "DGV_Departements";
            this.DGV_Departements.ReadOnly = true;
            this.DGV_Departements.RowTemplate.Height = 28;
            this.DGV_Departements.Size = new System.Drawing.Size(413, 119);
            this.DGV_Departements.TabIndex = 12;
            // 
            // codedep
            // 
            this.codedep.HeaderText = "Code";
            this.codedep.Name = "codedep";
            this.codedep.ReadOnly = true;
            this.codedep.Width = 70;
            // 
            // departement
            // 
            this.departement.HeaderText = "Nom dép.";
            this.departement.Name = "departement";
            this.departement.ReadOnly = true;
            this.departement.Width = 200;
            // 
            // nbr_emp
            // 
            this.nbr_emp.HeaderText = "Nbr_Emp";
            this.nbr_emp.Name = "nbr_emp";
            this.nbr_emp.ReadOnly = true;
            this.nbr_emp.Width = 80;
            // 
            // LB_Information
            // 
            this.LB_Information.AutoSize = true;
            this.LB_Information.Location = new System.Drawing.Point(19, 8);
            this.LB_Information.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Information.Name = "LB_Information";
            this.LB_Information.Size = new System.Drawing.Size(120, 13);
            this.LB_Information.TabIndex = 9;
            this.LB_Information.Text = "Information de l\'employé";
            // 
            // BTN_Recherche
            // 
            this.BTN_Recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Recherche.Location = new System.Drawing.Point(333, 260);
            this.BTN_Recherche.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Recherche.Name = "BTN_Recherche";
            this.BTN_Recherche.Size = new System.Drawing.Size(85, 22);
            this.BTN_Recherche.TabIndex = 0;
            this.BTN_Recherche.Text = "Rechercher";
            this.BTN_Recherche.UseVisualStyleBackColor = true;
            this.BTN_Recherche.Click += new System.EventHandler(this.BTN_Recherche_Click);
            // 
            // LB_TextRecherche
            // 
            this.LB_TextRecherche.AutoSize = true;
            this.LB_TextRecherche.Location = new System.Drawing.Point(476, 163);
            this.LB_TextRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_TextRecherche.Name = "LB_TextRecherche";
            this.LB_TextRecherche.Size = new System.Drawing.Size(35, 13);
            this.LB_TextRecherche.TabIndex = 13;
            this.LB_TextRecherche.Text = "TEXT";
            this.LB_TextRecherche.Visible = false;
            // 
            // TB_NomRecherche
            // 
            this.TB_NomRecherche.Location = new System.Drawing.Point(479, 187);
            this.TB_NomRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NomRecherche.Name = "TB_NomRecherche";
            this.TB_NomRecherche.Size = new System.Drawing.Size(106, 20);
            this.TB_NomRecherche.TabIndex = 14;
            this.TB_NomRecherche.Visible = false;
            this.TB_NomRecherche.TextChanged += new System.EventHandler(this.TB_NomRecherche_TextChanged);
            // 
            // CB_Dep
            // 
            this.CB_Dep.FormattingEnabled = true;
            this.CB_Dep.Items.AddRange(new object[] {
            "410 - Administration",
            "420 - Informatique",
            "430 - Electrique",
            "440 - Robotique",
            "450 - Logistique"});
            this.CB_Dep.Location = new System.Drawing.Point(479, 188);
            this.CB_Dep.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Dep.Name = "CB_Dep";
            this.CB_Dep.Size = new System.Drawing.Size(152, 21);
            this.CB_Dep.TabIndex = 15;
            this.CB_Dep.Visible = false;
            this.CB_Dep.SelectedIndexChanged += new System.EventHandler(this.CB_Dep_SelectedIndexChanged);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Enabled = false;
            this.BTN_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Annuler.Location = new System.Drawing.Point(422, 260);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(85, 22);
            this.BTN_Annuler.TabIndex = 0;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP2.Properties.Resources._9720142;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(636, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 93);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CB_Dep);
            this.Controls.Add(this.TB_NomRecherche);
            this.Controls.Add(this.LB_TextRecherche);
            this.Controls.Add(this.DGV_Departements);
            this.Controls.Add(this.RB_Departement);
            this.Controls.Add(this.RB_UnEmploye);
            this.Controls.Add(this.RB_Tous);
            this.Controls.Add(this.LB_Recherche);
            this.Controls.Add(this.LB_Information);
            this.Controls.Add(this.LBL_Departements);
            this.Controls.Add(this.BTN_Afficher);
            this.Controls.Add(this.BTN_FIN);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.LB_CodeDep);
            this.Controls.Add(this.LB_Prenom);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.LB_Adresse);
            this.Controls.Add(this.LB_NumEmploye);
            this.Controls.Add(this.LB_Salaire);
            this.Controls.Add(this.LB_Echelon);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Recherche);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Vider);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.BTN_Precedent);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.TB_CodeDep);
            this.Controls.Add(this.TB_Salaire);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.TB_Echelon);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.TB_Empno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Main";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Departements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Empno;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.TextBox TB_CodeDep;
        private System.Windows.Forms.TextBox TB_Echelon;
        private System.Windows.Forms.TextBox TB_Salaire;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Button BTN_Precedent;
        private System.Windows.Forms.Label LB_Echelon;
        private System.Windows.Forms.Label LB_Salaire;
        private System.Windows.Forms.Label LB_Adresse;
        private System.Windows.Forms.Label LB_NumEmploye;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.Label LB_CodeDep;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Vider;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_FIN;
        private System.Windows.Forms.Button BTN_Afficher;
        private System.Windows.Forms.Label LBL_Departements;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.RadioButton RB_Tous;
        private System.Windows.Forms.RadioButton RB_UnEmploye;
        private System.Windows.Forms.RadioButton RB_Departement;
        private System.Windows.Forms.Label LB_Recherche;
        private System.Windows.Forms.DataGridView DGV_Departements;
        private System.Windows.Forms.Label LB_Information;
        private System.Windows.Forms.Button BTN_Recherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedep;
        private System.Windows.Forms.DataGridViewTextBoxColumn departement;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbr_emp;
        private System.Windows.Forms.Label LB_TextRecherche;
        private System.Windows.Forms.TextBox TB_NomRecherche;
        private System.Windows.Forms.ComboBox CB_Dep;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}

