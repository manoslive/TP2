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
            this.BTN_Inserer = new System.Windows.Forms.Button();
            this.BTN_Vider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Empno
            // 
            this.TB_Empno.Location = new System.Drawing.Point(95, 27);
            this.TB_Empno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Empno.Name = "TB_Empno";
            this.TB_Empno.Size = new System.Drawing.Size(160, 20);
            this.TB_Empno.TabIndex = 0;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(95, 65);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(160, 20);
            this.TB_Nom.TabIndex = 0;
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(95, 102);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(160, 20);
            this.TB_Prenom.TabIndex = 0;
            // 
            // TB_CodeDep
            // 
            this.TB_CodeDep.Location = new System.Drawing.Point(95, 137);
            this.TB_CodeDep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_CodeDep.Name = "TB_CodeDep";
            this.TB_CodeDep.Size = new System.Drawing.Size(160, 20);
            this.TB_CodeDep.TabIndex = 0;
            // 
            // TB_Echelon
            // 
            this.TB_Echelon.Location = new System.Drawing.Point(353, 27);
            this.TB_Echelon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Echelon.Name = "TB_Echelon";
            this.TB_Echelon.Size = new System.Drawing.Size(160, 20);
            this.TB_Echelon.TabIndex = 0;
            // 
            // TB_Salaire
            // 
            this.TB_Salaire.Location = new System.Drawing.Point(353, 65);
            this.TB_Salaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Salaire.Name = "TB_Salaire";
            this.TB_Salaire.Size = new System.Drawing.Size(160, 20);
            this.TB_Salaire.TabIndex = 0;
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(353, 102);
            this.TB_Adresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(160, 20);
            this.TB_Adresse.TabIndex = 0;
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BTN_Suivant.Location = new System.Drawing.Point(279, 202);
            this.BTN_Suivant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(106, 32);
            this.BTN_Suivant.TabIndex = 1;
            this.BTN_Suivant.Text = ">>";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BTN_Precedent.Location = new System.Drawing.Point(21, 202);
            this.BTN_Precedent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(105, 32);
            this.BTN_Precedent.TabIndex = 1;
            this.BTN_Precedent.Text = "<<";
            this.BTN_Precedent.UseVisualStyleBackColor = true;
            this.BTN_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // LB_Echelon
            // 
            this.LB_Echelon.AutoSize = true;
            this.LB_Echelon.Location = new System.Drawing.Point(302, 27);
            this.LB_Echelon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Echelon.Name = "LB_Echelon";
            this.LB_Echelon.Size = new System.Drawing.Size(46, 13);
            this.LB_Echelon.TabIndex = 2;
            this.LB_Echelon.Text = "Échelon";
            // 
            // LB_Salaire
            // 
            this.LB_Salaire.AutoSize = true;
            this.LB_Salaire.Location = new System.Drawing.Point(302, 67);
            this.LB_Salaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Salaire.Name = "LB_Salaire";
            this.LB_Salaire.Size = new System.Drawing.Size(39, 13);
            this.LB_Salaire.TabIndex = 2;
            this.LB_Salaire.Text = "Salaire";
            // 
            // LB_Adresse
            // 
            this.LB_Adresse.AutoSize = true;
            this.LB_Adresse.Location = new System.Drawing.Point(302, 104);
            this.LB_Adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Adresse.Name = "LB_Adresse";
            this.LB_Adresse.Size = new System.Drawing.Size(45, 13);
            this.LB_Adresse.TabIndex = 2;
            this.LB_Adresse.Text = "Adresse";
            // 
            // LB_NumEmploye
            // 
            this.LB_NumEmploye.AutoSize = true;
            this.LB_NumEmploye.Location = new System.Drawing.Point(18, 27);
            this.LB_NumEmploye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NumEmploye.Name = "LB_NumEmploye";
            this.LB_NumEmploye.Size = new System.Drawing.Size(74, 13);
            this.LB_NumEmploye.TabIndex = 2;
            this.LB_NumEmploye.Text = "Num. employé";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(18, 67);
            this.LB_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(29, 13);
            this.LB_Nom.TabIndex = 2;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(18, 104);
            this.LB_Prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(43, 13);
            this.LB_Prenom.TabIndex = 2;
            this.LB_Prenom.Text = "Prénom";
            // 
            // LB_CodeDep
            // 
            this.LB_CodeDep.AutoSize = true;
            this.LB_CodeDep.Location = new System.Drawing.Point(18, 139);
            this.LB_CodeDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_CodeDep.Name = "LB_CodeDep";
            this.LB_CodeDep.Size = new System.Drawing.Size(70, 13);
            this.LB_CodeDep.TabIndex = 2;
            this.LB_CodeDep.Text = "Code Départ.";
            // 
            // BTN_Inserer
            // 
            this.BTN_Inserer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BTN_Inserer.Location = new System.Drawing.Point(150, 202);
            this.BTN_Inserer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Inserer.Name = "BTN_Inserer";
            this.BTN_Inserer.Size = new System.Drawing.Size(105, 32);
            this.BTN_Inserer.TabIndex = 1;
            this.BTN_Inserer.Text = "Ajouter";
            this.BTN_Inserer.UseVisualStyleBackColor = true;
            // 
            // BTN_Vider
            // 
            this.BTN_Vider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BTN_Vider.Location = new System.Drawing.Point(407, 137);
            this.BTN_Vider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Vider.Name = "BTN_Vider";
            this.BTN_Vider.Size = new System.Drawing.Size(105, 32);
            this.BTN_Vider.TabIndex = 1;
            this.BTN_Vider.Text = "Vider";
            this.BTN_Vider.UseVisualStyleBackColor = true;
            this.BTN_Vider.Click += new System.EventHandler(this.BTN_Vider_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 245);
            this.Controls.Add(this.LB_CodeDep);
            this.Controls.Add(this.LB_Prenom);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.LB_Adresse);
            this.Controls.Add(this.LB_NumEmploye);
            this.Controls.Add(this.LB_Salaire);
            this.Controls.Add(this.LB_Echelon);
            this.Controls.Add(this.BTN_Vider);
            this.Controls.Add(this.BTN_Inserer);
            this.Controls.Add(this.BTN_Precedent);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.TB_CodeDep);
            this.Controls.Add(this.TB_Salaire);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.TB_Echelon);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.TB_Empno);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Main";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.Form_Main_Load);
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
        private System.Windows.Forms.Button BTN_Inserer;
        private System.Windows.Forms.Button BTN_Vider;
    }
}
