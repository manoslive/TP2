using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP2
{
    public partial class Form_Main : Form
    {
        private OracleConnection oracon = new OracleConnection(); //connection initialiser ici
        private DataSet monDataSet = new DataSet();
        MaConnection maBelleConnection = new MaConnection();
        private string commandeRechercher = "";
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Connection connection = new Form_Connection(oracon, maBelleConnection); // Passer en parametre le oracle connection
            connection.ShowDialog();
            FillDGVDepartement();
            TB_Empno.Select();
            AfficherTexte();
            LB_Information.Text = "Employé (" + this.BindingContext[monDataSet, "TableEmployes"].Count.ToString() + " résultats)";
            BTN_Ajouter.Enabled = false;
            BTN_Afficher.Enabled = false;
        }

        private void AfficherTexte()
        {
            string sql = "select empno, nom, prenom, codedep, echelon, salaire, adresse from employes order by empno";

            try
            {
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql, oracon);
                if (monDataSet.Tables.Contains("TableEmployes"))
                {
                    monDataSet.Tables["TableEmployes"].Clear();
                }
                adapter2.Fill(monDataSet, "TableEmployes");
                adapter2.Dispose();
                Lier();
            }
            catch (OracleException exsql2)
            {
                MessageBox.Show(exsql2.Message.ToString());
            }
        }

        private void Vider()
        {
            //Je ne suis pas certain si c'est la bonne facon de faire ceci...
            TB_Empno.DataBindings.Clear();
            TB_Nom.DataBindings.Clear();
            TB_Prenom.DataBindings.Clear();
            TB_CodeDep.DataBindings.Clear();
            TB_Echelon.DataBindings.Clear();
            TB_Salaire.DataBindings.Clear();
            TB_Adresse.DataBindings.Clear();

            //Ceci efface les données dans le binding
            TB_Empno.Text = "";
            TB_Nom.Text = "";
            TB_Prenom.Text = "";
            TB_CodeDep.Text = "";
            TB_Echelon.Text = "";
            TB_Salaire.Text = "";
            TB_Adresse.Text = "";

            //réglages de boutons
            BTN_Debut.Enabled = false;
            BTN_FIN.Enabled = false;
            BTN_Suivant.Enabled = false;
            BTN_Precedent.Enabled = false;
            BTN_Modifier.Enabled = false;
            BTN_Ajouter.Enabled = false;
            BTN_Supprimer.Enabled = false;
            BTN_Afficher.Enabled = true;   
        }

        private void Lier()
        {
            TB_Empno.DataBindings.Add("Text", monDataSet, "TableEmployes.Empno");
            TB_Nom.DataBindings.Add("Text", monDataSet, "TableEmployes.Nom");
            TB_Prenom.DataBindings.Add("Text", monDataSet, "TableEmployes.Prenom");
            TB_CodeDep.DataBindings.Add("Text", monDataSet, "TableEmployes.CodeDep");
            TB_Echelon.DataBindings.Add("Text", monDataSet, "TableEmployes.Echelon");
            TB_Salaire.DataBindings.Add("Text", monDataSet, "TableEmployes.Salaire");
            TB_Adresse.DataBindings.Add("Text", monDataSet, "TableEmployes.Adresse");
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "TableEmployes"].Position += 1;
        }


        private void BTN_Vider_Click(object sender, EventArgs e)
        {
            Vider();
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "TableEmployes"].Position -= 1;
        }

        private void BTN_FIN_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "TableEmployes"].Position = this.BindingContext[monDataSet, "TableEmployes"].Count;
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "TableEmployes"].Position = 0;
        }

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            AfficherTexte();

            //réglages de boutons
            BTN_Debut.Enabled = true;
            BTN_FIN.Enabled = true;
            BTN_Suivant.Enabled = true;
            BTN_Precedent.Enabled = true;
            BTN_Modifier.Enabled = true;
            BTN_Afficher.Enabled = false;
            BTN_Ajouter.Enabled = false;
            BTN_Supprimer.Enabled = true;
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {

            if (BTN_Debut.Enabled == false)
            {
                if (TB_Empno.Text != "" && TB_Nom.Text != "" && TB_Prenom.Text != "" && TB_Salaire.Text != "" &&
                    TB_Echelon.Text != "" && TB_CodeDep.Text != "" && TB_Adresse.Text != "")
                {
                    BTN_Ajouter.Enabled = true;
                }
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }
        }

        private void FillDGVDepartement()
        {
            DGV_Departements.Rows.Clear();
            string sql = "select d.codedep, d.nomdepartement " + ", count(e.codedep) " +
             "from employes e " +
             "right join departements d on e.codedep = d.codedep " +
             "group by d.codedep, d.nomdepartement " +
             "order by d.codedep";

            try
            {
                DGV_Departements.Rows.Clear();
                OracleCommand orcd = new OracleCommand(sql, oracon);
                orcd.CommandType = CommandType.Text;
                OracleDataReader oraRead = orcd.ExecuteReader();

                while (oraRead.Read())
                {
                    DGV_Departements.Rows.Add(
                    oraRead.GetString(0),
                    oraRead.GetString(1),
                    oraRead.GetInt32(2)
                    );
                }
                oraRead.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ReinitialiserTB()
        {
            TB_Empno.DataBindings.Clear();
            TB_Nom.DataBindings.Clear();
            TB_Prenom.DataBindings.Clear();
            TB_CodeDep.DataBindings.Clear();
            TB_Echelon.DataBindings.Clear();
            TB_Salaire.DataBindings.Clear();
            TB_Adresse.DataBindings.Clear();
        }

        private void ChoixRechercher()
        {
            BTN_Recherche.Enabled = false;

            if (RB_Tous.Checked)
            {
                BTN_Recherche.Enabled = true;
                commandeRechercher = "select * from employes";
            }
            else if (RB_UnEmploye.Checked)
            {
                if (TB_NomRecherche.Text != "")
                {
                    BTN_Recherche.Enabled = true;
                    commandeRechercher = "select * from employes where nom like '" + TB_NomRecherche.Text + "%'";
                }
            }
            else if (RB_Departement.Checked)
            {
                BTN_Recherche.Enabled = true;
                commandeRechercher = "select * from employes e inner join departements d on e.codedep = d.codedep where NomDepartement like '" + CB_Dep.Text + "'";
            }
        }

        private void RemplirTextBox(string commandeRechercher)
        {
            try
            {
                monDataSet.Clear();
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                OracleCommand commandeSql = new OracleCommand();
                dataAdapter.SelectCommand = new OracleCommand(commandeRechercher, oracon);
                monDataSet = new DataSet("Employes");
                dataAdapter.Fill(monDataSet, "Employes");
                if (this.BindingContext[monDataSet, "Employes"].Count > 0)
                {
                    LB_Information.Text = "Employé (" + this.BindingContext[monDataSet, "Employes"].Count.ToString() + " résultats)";
                    Lier();
                }
                else
                {
                    MessageBox.Show("Erreur: Pas de resultats de recherche!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            //si les texts entré par l'usager son des lettres, ou des numéros, ou bien les 2..
            if(/*TB_Adresse.Text.All(Char.IsLetterOrDigit) && <--- ça ne fonctionne pas!!! */TB_Nom.Text.All(Char.IsLetter)&& ///////// Probleme avec la vérif. de l'adresse
                TB_Prenom.Text.All(Char.IsLetter) && TB_Empno.Text.All(Char.IsDigit) && TB_Salaire.Text.All(Char.IsDigit)&&
                   TB_Echelon.Text.All(Char.IsDigit) && TB_CodeDep.Text.All(Char.IsDigit))
            {
                string sqlInsert = "Insert into Employes Values(" + TB_Empno.Text + ", '" + TB_Nom.Text + "','" + TB_Prenom.Text + "'," + TB_Salaire.Text + "," + TB_Echelon.Text + ",'" + TB_Adresse.Text + "', " + TB_CodeDep.Text + ")";

                try
                {
                    OracleCommand oraCom = new OracleCommand(sqlInsert, oracon);
                    oraCom.CommandType = CommandType.Text;
                    OracleDataReader OraRead = oraCom.ExecuteReader();
                    //réglages de boutons
                    BTN_Debut.Enabled = true;
                    BTN_FIN.Enabled = true;
                    BTN_Suivant.Enabled = true;
                    BTN_Precedent.Enabled = true;
                    BTN_Modifier.Enabled = true;
                    BTN_Afficher.Enabled = false;
                    BTN_Ajouter.Enabled = false;
                    BTN_Supprimer.Enabled = true;
                    //AfficherTexte();
                }
                catch (OracleException exsql1)
                {
                    MessageBox.Show(exsql1.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Soyez certain que les champs sont remplis avec les bons types de caractères ");
            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from employes where empno=" + TB_Empno.Text;
            OracleCommand oraCom = new OracleCommand(sqlDelete, oracon);
            try
            {
            oraCom.ExecuteNonQuery();
            oraCom.CommandType = CommandType.Text;
            }
            catch(OracleException ex) 
            { 
                MessageBox.Show(ex.Message.ToString());
            }
            TB_Empno.Clear();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void RB_UnEmploye_CheckedChanged(object sender, EventArgs e)
        {
            LB_TextRecherche.Text = "Nom de l'Employé";
            LB_TextRecherche.Visible = true;
            TB_NomRecherche.Visible = true;
            CB_Dep.Visible = false;
            ChoixRechercher();
        }

        private void BTN_Recherche_Click(object sender, EventArgs e)
        {
            ReinitialiserTB();
            monDataSet.Clear();
            RemplirTextBox(commandeRechercher);
        }

        private void RB_Tous_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Tous.Checked)
            {
                LB_TextRecherche.Text = "";
                TB_NomRecherche.Visible = false;
                CB_Dep.Visible = false;
                TB_NomRecherche.Text = "";
            }
            ChoixRechercher();
        }

        private void RB_Departement_CheckedChanged(object sender, EventArgs e)
        {
            LB_TextRecherche.Text = "Département";
            LB_TextRecherche.Visible = true;
            TB_NomRecherche.Visible = false;
            CB_Dep.Visible = true;
            TB_NomRecherche.Text = "";
            ChoixRechercher();
            CB_Dep.SelectedItem = 2; 
        }

        private void CB_Dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
