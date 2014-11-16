using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form_Modification : Form
    {
        string empno_;
        string nom_;
        string prenom_;
        string codeDep_;
        string echelon_; 
        string salaire_; 
        string adresse_;
        public Form_Modification(string empno, string nom, string prenom, string codeDep, 
                                    string echelon, string salaire, string adresse)
        {
            InitializeComponent();
            empno_ = empno;
            nom_ = nom;
            prenom_ = prenom;
            codeDep_ = codeDep;
            echelon_ = echelon;
            salaire_ = salaire;
            adresse_ = adresse;
        }

        private void Form_Modification_Load(object sender, EventArgs e)
        {
            TB_Empno.Text = empno_;
            TB_Nom.Text =  nom_;
            TB_Prenom.Text = prenom_;
            TB_CodeDep.Text = codeDep_;
            TB_Echelon.Text = echelon_;
            TB_Salaire.Text = salaire_;
            TB_Adresse.Text = adresse_;
        }
    }
}
