namespace TP2
{
    partial class Form_Modification
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
            this.LB_CodeDep = new System.Windows.Forms.Label();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Adresse = new System.Windows.Forms.Label();
            this.LB_NumEmploye = new System.Windows.Forms.Label();
            this.LB_Salaire = new System.Windows.Forms.Label();
            this.LB_Echelon = new System.Windows.Forms.Label();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TB_CodeDep = new System.Windows.Forms.TextBox();
            this.TB_Salaire = new System.Windows.Forms.TextBox();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.TB_Echelon = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Empno = new System.Windows.Forms.TextBox();
            this.BTN_Enregistrer = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_CodeDep
            // 
            this.LB_CodeDep.AutoSize = true;
            this.LB_CodeDep.Location = new System.Drawing.Point(25, 81);
            this.LB_CodeDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_CodeDep.Name = "LB_CodeDep";
            this.LB_CodeDep.Size = new System.Drawing.Size(70, 13);
            this.LB_CodeDep.TabIndex = 9;
            this.LB_CodeDep.Text = "Code Départ.";
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(25, 60);
            this.LB_Prenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(43, 13);
            this.LB_Prenom.TabIndex = 10;
            this.LB_Prenom.Text = "Prénom";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(25, 39);
            this.LB_Nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(29, 13);
            this.LB_Nom.TabIndex = 11;
            this.LB_Nom.Text = "Nom";
            // 
            // LB_Adresse
            // 
            this.LB_Adresse.AutoSize = true;
            this.LB_Adresse.Location = new System.Drawing.Point(25, 143);
            this.LB_Adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Adresse.Name = "LB_Adresse";
            this.LB_Adresse.Size = new System.Drawing.Size(45, 13);
            this.LB_Adresse.TabIndex = 12;
            this.LB_Adresse.Text = "Adresse";
            // 
            // LB_NumEmploye
            // 
            this.LB_NumEmploye.AutoSize = true;
            this.LB_NumEmploye.Location = new System.Drawing.Point(25, 19);
            this.LB_NumEmploye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NumEmploye.Name = "LB_NumEmploye";
            this.LB_NumEmploye.Size = new System.Drawing.Size(74, 13);
            this.LB_NumEmploye.TabIndex = 13;
            this.LB_NumEmploye.Text = "Num. employé";
            // 
            // LB_Salaire
            // 
            this.LB_Salaire.AutoSize = true;
            this.LB_Salaire.Location = new System.Drawing.Point(25, 123);
            this.LB_Salaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Salaire.Name = "LB_Salaire";
            this.LB_Salaire.Size = new System.Drawing.Size(39, 13);
            this.LB_Salaire.TabIndex = 14;
            this.LB_Salaire.Text = "Salaire";
            // 
            // LB_Echelon
            // 
            this.LB_Echelon.AutoSize = true;
            this.LB_Echelon.Location = new System.Drawing.Point(25, 102);
            this.LB_Echelon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Echelon.Name = "LB_Echelon";
            this.LB_Echelon.Size = new System.Drawing.Size(46, 13);
            this.LB_Echelon.TabIndex = 15;
            this.LB_Echelon.Text = "Échelon";
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(102, 141);
            this.TB_Adresse.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(160, 20);
            this.TB_Adresse.TabIndex = 20;
            this.TB_Adresse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Lettre_KeyPress);
            // 
            // TB_CodeDep
            // 
            this.TB_CodeDep.Location = new System.Drawing.Point(102, 79);
            this.TB_CodeDep.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CodeDep.Name = "TB_CodeDep";
            this.TB_CodeDep.Size = new System.Drawing.Size(160, 20);
            this.TB_CodeDep.TabIndex = 17;
            this.TB_CodeDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // TB_Salaire
            // 
            this.TB_Salaire.Location = new System.Drawing.Point(102, 121);
            this.TB_Salaire.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Salaire.Name = "TB_Salaire";
            this.TB_Salaire.Size = new System.Drawing.Size(160, 20);
            this.TB_Salaire.TabIndex = 19;
            this.TB_Salaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(102, 58);
            this.TB_Prenom.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(160, 20);
            this.TB_Prenom.TabIndex = 16;
            this.TB_Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Lettre_KeyPress);
            // 
            // TB_Echelon
            // 
            this.TB_Echelon.Location = new System.Drawing.Point(102, 100);
            this.TB_Echelon.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Echelon.Name = "TB_Echelon";
            this.TB_Echelon.Size = new System.Drawing.Size(160, 20);
            this.TB_Echelon.TabIndex = 18;
            this.TB_Echelon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(102, 37);
            this.TB_Nom.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(160, 20);
            this.TB_Nom.TabIndex = 8;
            this.TB_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Lettre_KeyPress);
            // 
            // TB_Empno
            // 
            this.TB_Empno.Location = new System.Drawing.Point(102, 17);
            this.TB_Empno.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Empno.Name = "TB_Empno";
            this.TB_Empno.Size = new System.Drawing.Size(160, 20);
            this.TB_Empno.TabIndex = 7;
            this.TB_Empno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Num_KeyPress);
            // 
            // BTN_Enregistrer
            // 
            this.BTN_Enregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Enregistrer.Location = new System.Drawing.Point(51, 178);
            this.BTN_Enregistrer.Name = "BTN_Enregistrer";
            this.BTN_Enregistrer.Size = new System.Drawing.Size(88, 32);
            this.BTN_Enregistrer.TabIndex = 21;
            this.BTN_Enregistrer.Text = "Enregistrer";
            this.BTN_Enregistrer.UseVisualStyleBackColor = true;
            this.BTN_Enregistrer.Click += new System.EventHandler(this.BTN_Enregistrer_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Annuler.Location = new System.Drawing.Point(145, 178);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(88, 32);
            this.BTN_Annuler.TabIndex = 22;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // Form_Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Enregistrer);
            this.Controls.Add(this.LB_CodeDep);
            this.Controls.Add(this.LB_Prenom);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.LB_Adresse);
            this.Controls.Add(this.LB_NumEmploye);
            this.Controls.Add(this.LB_Salaire);
            this.Controls.Add(this.LB_Echelon);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.TB_CodeDep);
            this.Controls.Add(this.TB_Salaire);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.TB_Echelon);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.TB_Empno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Modification";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.Form_Modification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_CodeDep;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Adresse;
        private System.Windows.Forms.Label LB_NumEmploye;
        private System.Windows.Forms.Label LB_Salaire;
        private System.Windows.Forms.Label LB_Echelon;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.TextBox TB_CodeDep;
        private System.Windows.Forms.TextBox TB_Salaire;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.TextBox TB_Echelon;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Empno;
        private System.Windows.Forms.Button BTN_Enregistrer;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}