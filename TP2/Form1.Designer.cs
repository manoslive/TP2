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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_FIN = new System.Windows.Forms.Button();
            this.BTN_Afficher = new System.Windows.Forms.Button();
            this.LBL_Departements = new System.Windows.Forms.Label();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.RB_Tous = new System.Windows.Forms.RadioButton();
            this.RB_UnEmploye = new System.Windows.Forms.RadioButton();
            this.RB_Departement = new System.Windows.Forms.RadioButton();
            this.LB_Recherche = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LB_Information = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Empno
            // 
            this.TB_Empno.Location = new System.Drawing.Point(144, 41);
            this.TB_Empno.Name = "TB_Empno";
            this.TB_Empno.Size = new System.Drawing.Size(238, 26);
            this.TB_Empno.TabIndex = 0;
            this.TB_Empno.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(144, 73);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(238, 26);
            this.TB_Nom.TabIndex = 1;
            this.TB_Nom.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(144, 105);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(238, 26);
            this.TB_Prenom.TabIndex = 2;
            this.TB_Prenom.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TB_CodeDep
            // 
            this.TB_CodeDep.Location = new System.Drawing.Point(144, 137);
            this.TB_CodeDep.Name = "TB_CodeDep";
            this.TB_CodeDep.Size = new System.Drawing.Size(238, 26);
            this.TB_CodeDep.TabIndex = 3;
            this.TB_CodeDep.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TB_Echelon
            // 
            this.TB_Echelon.Location = new System.Drawing.Point(144, 169);
            this.TB_Echelon.Name = "TB_Echelon";
            this.TB_Echelon.Size = new System.Drawing.Size(238, 26);
            this.TB_Echelon.TabIndex = 4;
            this.TB_Echelon.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TB_Salaire
            // 
            this.TB_Salaire.Location = new System.Drawing.Point(144, 201);
            this.TB_Salaire.Name = "TB_Salaire";
            this.TB_Salaire.Size = new System.Drawing.Size(238, 26);
            this.TB_Salaire.TabIndex = 5;
            this.TB_Salaire.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(144, 233);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(238, 26);
            this.TB_Adresse.TabIndex = 6;
            this.TB_Adresse.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Suivant.Location = new System.Drawing.Point(33, 324);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(100, 34);
            this.BTN_Suivant.TabIndex = 0;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Precedent.Location = new System.Drawing.Point(139, 324);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(100, 34);
            this.BTN_Precedent.TabIndex = 0;
            this.BTN_Precedent.Text = "Précédent";
            this.BTN_Precedent.UseVisualStyleBackColor = true;
            this.BTN_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // LB_Echelon
            // 
            this.LB_Echelon.AutoSize = true;
            this.LB_Echelon.Location = new System.Drawing.Point(29, 172);
            this.LB_Echelon.Name = "LB_Echelon";
            this.LB_Echelon.Size = new System.Drawing.Size(67, 20);
            this.LB_Echelon.TabIndex = 2;
            this.LB_Echelon.Text = "Échelon";
            // 
            // LB_Salaire
            // 
            this.LB_Salaire.AutoSize = true;
            this.LB_Salaire.Location = new System.Drawing.Point(29, 204);
            this.LB_Salaire.Name = "LB_Salaire";
            this.LB_Salaire.Size = new System.Drawing.Size(58, 20);
            this.LB_Salaire.TabIndex = 2;
            this.LB_Salaire.Text = "Salaire";
            // 
            // LB_Adresse
            // 
            this.LB_Adresse.AutoSize = true;
            this.LB_Adresse.Location = new System.Drawing.Point(29, 236);
            this.LB_Adresse.Name = "LB_Adresse";
            this.LB_Adresse.Size = new System.Drawing.Size(68, 20);
            this.LB_Adresse.TabIndex = 2;
            this.LB_Adresse.Text = "Adresse";
            // 
            // LB_NumEmploye
            // 
            this.LB_NumEmploye.AutoSize = true;
            this.LB_NumEmploye.Location = new System.Drawing.Point(29, 44);
            this.LB_NumEmploye.Name = "LB_NumEmploye";
            this.LB_NumEmploye.Size = new System.Drawing.Size(109, 20);
            this.LB_NumEmploye.TabIndex = 2;
            this.LB_NumEmploye.Text = "Num. employé";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(29, 76);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(42, 20);
            this.LB_Nom.TabIndex = 2;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(29, 108);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(64, 20);
            this.LB_Prenom.TabIndex = 2;
            this.LB_Prenom.Text = "Prénom";
            // 
            // LB_CodeDep
            // 
            this.LB_CodeDep.AutoSize = true;
            this.LB_CodeDep.Location = new System.Drawing.Point(29, 140);
            this.LB_CodeDep.Name = "LB_CodeDep";
            this.LB_CodeDep.Size = new System.Drawing.Size(104, 20);
            this.LB_CodeDep.TabIndex = 2;
            this.LB_CodeDep.Text = "Code Départ.";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(245, 284);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(100, 34);
            this.BTN_Ajouter.TabIndex = 0;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Vider
            // 
            this.BTN_Vider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Vider.Location = new System.Drawing.Point(351, 284);
            this.BTN_Vider.Name = "BTN_Vider";
            this.BTN_Vider.Size = new System.Drawing.Size(100, 34);
            this.BTN_Vider.TabIndex = 0;
            this.BTN_Vider.Text = "Vider";
            this.BTN_Vider.UseVisualStyleBackColor = true;
            this.BTN_Vider.Click += new System.EventHandler(this.BTN_Vider_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 412);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(919, 192);
            this.dataGridView.TabIndex = 0;
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modifier.Location = new System.Drawing.Point(245, 364);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(100, 34);
            this.BTN_Modifier.TabIndex = 0;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Debut.Location = new System.Drawing.Point(33, 284);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(100, 34);
            this.BTN_Debut.TabIndex = 0;
            this.BTN_Debut.Text = "Début";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_FIN
            // 
            this.BTN_FIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FIN.Location = new System.Drawing.Point(139, 284);
            this.BTN_FIN.Name = "BTN_FIN";
            this.BTN_FIN.Size = new System.Drawing.Size(100, 34);
            this.BTN_FIN.TabIndex = 0;
            this.BTN_FIN.Text = "Fin";
            this.BTN_FIN.UseVisualStyleBackColor = true;
            this.BTN_FIN.Click += new System.EventHandler(this.BTN_FIN_Click);
            // 
            // BTN_Afficher
            // 
            this.BTN_Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Afficher.Location = new System.Drawing.Point(351, 324);
            this.BTN_Afficher.Name = "BTN_Afficher";
            this.BTN_Afficher.Size = new System.Drawing.Size(100, 34);
            this.BTN_Afficher.TabIndex = 0;
            this.BTN_Afficher.Text = "Afficher";
            this.BTN_Afficher.UseVisualStyleBackColor = true;
            this.BTN_Afficher.Click += new System.EventHandler(this.BTN_Afficher_Click);
            // 
            // LBL_Departements
            // 
            this.LBL_Departements.AutoSize = true;
            this.LBL_Departements.Location = new System.Drawing.Point(426, 12);
            this.LBL_Departements.Name = "LBL_Departements";
            this.LBL_Departements.Size = new System.Drawing.Size(176, 20);
            this.LBL_Departements.TabIndex = 9;
            this.LBL_Departements.Text = "Liste des départements";
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supprimer.Location = new System.Drawing.Point(245, 324);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(100, 34);
            this.BTN_Supprimer.TabIndex = 0;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Rechercher.Location = new System.Drawing.Point(745, 171);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(100, 34);
            this.BTN_Rechercher.TabIndex = 0;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            // 
            // RB_Tous
            // 
            this.RB_Tous.AutoSize = true;
            this.RB_Tous.Location = new System.Drawing.Point(745, 44);
            this.RB_Tous.Name = "RB_Tous";
            this.RB_Tous.Size = new System.Drawing.Size(164, 24);
            this.RB_Tous.TabIndex = 11;
            this.RB_Tous.TabStop = true;
            this.RB_Tous.Text = "Tous les employés";
            this.RB_Tous.UseVisualStyleBackColor = true;
            // 
            // RB_UnEmploye
            // 
            this.RB_UnEmploye.AutoSize = true;
            this.RB_UnEmploye.Location = new System.Drawing.Point(745, 74);
            this.RB_UnEmploye.Name = "RB_UnEmploye";
            this.RB_UnEmploye.Size = new System.Drawing.Size(142, 24);
            this.RB_UnEmploye.TabIndex = 11;
            this.RB_UnEmploye.TabStop = true;
            this.RB_UnEmploye.Text = "Nom d\'employé";
            this.RB_UnEmploye.UseVisualStyleBackColor = true;
            // 
            // RB_Departement
            // 
            this.RB_Departement.AutoSize = true;
            this.RB_Departement.Location = new System.Drawing.Point(745, 104);
            this.RB_Departement.Name = "RB_Departement";
            this.RB_Departement.Size = new System.Drawing.Size(128, 24);
            this.RB_Departement.TabIndex = 11;
            this.RB_Departement.TabStop = true;
            this.RB_Departement.Text = "Département";
            this.RB_Departement.UseVisualStyleBackColor = true;
            // 
            // LB_Recherche
            // 
            this.LB_Recherche.AutoSize = true;
            this.LB_Recherche.Location = new System.Drawing.Point(741, 9);
            this.LB_Recherche.Name = "LB_Recherche";
            this.LB_Recherche.Size = new System.Drawing.Size(87, 20);
            this.LB_Recherche.TabIndex = 9;
            this.LB_Recherche.Text = "Recherche";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(300, 183);
            this.dataGridView1.TabIndex = 12;
            // 
            // LB_Information
            // 
            this.LB_Information.AutoSize = true;
            this.LB_Information.Location = new System.Drawing.Point(29, 12);
            this.LB_Information.Name = "LB_Information";
            this.LB_Information.Size = new System.Drawing.Size(181, 20);
            this.LB_Information.TabIndex = 9;
            this.LB_Information.Text = "Information de l\'employé";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 622);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RB_Departement);
            this.Controls.Add(this.RB_UnEmploye);
            this.Controls.Add(this.RB_Tous);
            this.Controls.Add(this.LB_Recherche);
            this.Controls.Add(this.LB_Information);
            this.Controls.Add(this.LBL_Departements);
            this.Controls.Add(this.BTN_Afficher);
            this.Controls.Add(this.BTN_FIN);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.LB_CodeDep);
            this.Controls.Add(this.LB_Prenom);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.LB_Adresse);
            this.Controls.Add(this.LB_NumEmploye);
            this.Controls.Add(this.LB_Salaire);
            this.Controls.Add(this.LB_Echelon);
            this.Controls.Add(this.BTN_Rechercher);
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
            this.Name = "Form_Main";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_FIN;
        private System.Windows.Forms.Button BTN_Afficher;
        private System.Windows.Forms.Label LBL_Departements;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.RadioButton RB_Tous;
        private System.Windows.Forms.RadioButton RB_UnEmploye;
        private System.Windows.Forms.RadioButton RB_Departement;
        private System.Windows.Forms.Label LB_Recherche;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LB_Information;
    }
}

