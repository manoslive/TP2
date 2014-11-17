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
        public string empno_;
        public string nom_;
        public string prenom_;
        public string codeDep_;
        public string echelon_;
        public string salaire_;
        public string adresse_;
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

        private void BTN_Enregistrer_Click(object sender, EventArgs e)
        {
            empno_   = TB_Empno.Text;
            nom_     = TB_Nom.Text;
            prenom_  = TB_Prenom.Text;
            codeDep_ = TB_CodeDep.Text;
            echelon_ = TB_Echelon.Text;
            salaire_ = TB_Salaire.Text;
            adresse_ = TB_Adresse.Text;
        }


        private void TextBox_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touhe appuyé est différent qu'une touche numéric ou le backspace..
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }

        private void TextBox_Lettre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touhe appuyé est différent qu'une touche numéric ou le backspace..
            if (e.KeyChar != (char)8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }

        private void TB_Salaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TB_Salaire.Text.Contains('.'))
            {
                string s = TB_Salaire.Text.Substring(TB_Salaire.Text.LastIndexOf('.'), TB_Salaire.Text.Length - TB_Salaire.Text.LastIndexOf('.'));
                if (s.Length >= 3)
                {
                    if (e.KeyChar == 46 || char.IsNumber(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                if (e.KeyChar == 46)
                {
                    e.Handled = true;
                }
            }
            else
            {
                //vérifie si la touche appuyé est différent qu'une touche num ou le backspace ou point..
                if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar) && e.KeyChar != 46)
                {
                    e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
                }
            }
        }

        private void TB_Adresse_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touhe appuyé est différent qu'une touche numéric, lettre ou le backspace ou espace..
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }
    }
}
