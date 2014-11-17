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

        private string TableEmployes = "TableEmployes";
        private string Employes = "Employes";
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
            AfficherTexte(0);
            LB_Information.Text = "Employé (" + this.BindingContext[monDataSet, "TableEmployes"].Count.ToString() + " résultats)";
            BTN_Ajouter.Enabled = false;
            BTN_Afficher.Enabled = false;
        }

        private void AfficherTexte(int position)
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
                Lier(position);
            }
            catch (OracleException exsql2)
            {
                MessageBox.Show(exsql2.Message.ToString());
            }
        }

        private void Vider()
        {
            ReinitialiserTB();

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

        private void Lier(int position)
        {
            TB_Empno.DataBindings.Add("Text", monDataSet, "TableEmployes.Empno");
            TB_Nom.DataBindings.Add("Text", monDataSet, "TableEmployes.Nom");
            TB_Prenom.DataBindings.Add("Text", monDataSet, "TableEmployes.Prenom");
            TB_CodeDep.DataBindings.Add("Text", monDataSet, "TableEmployes.CodeDep");
            TB_Echelon.DataBindings.Add("Text", monDataSet, "TableEmployes.Echelon");
            TB_Salaire.DataBindings.Add("Text", monDataSet, "TableEmployes.Salaire");
            TB_Adresse.DataBindings.Add("Text", monDataSet, "TableEmployes.Adresse");
            TB_Empno.BindingContext[monDataSet, "TableEmployes"].Position = position;
        }
        private void Lier(int position, string Table)
        {
            TB_Empno.DataBindings.Add("Text", monDataSet, Table + ".Empno");
            TB_Nom.DataBindings.Add("Text", monDataSet, Table + ".Nom");
            TB_Prenom.DataBindings.Add("Text", monDataSet, Table + ".Prenom");
            TB_CodeDep.DataBindings.Add("Text", monDataSet, Table + ".CodeDep");
            TB_Echelon.DataBindings.Add("Text", monDataSet, Table + ".Echelon");
            TB_Salaire.DataBindings.Add("Text", monDataSet, Table + ".Salaire");
            TB_Adresse.DataBindings.Add("Text", monDataSet, Table + ".Adresse");
            TB_Empno.BindingContext[monDataSet, Table].Position = position;
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            if(RB_Departement.Checked == true || RB_Tous.Checked == true || RB_UnEmploye.Checked == true)
                this.BindingContext[monDataSet, Employes].Position += 1;
            else
                this.BindingContext[monDataSet, TableEmployes].Position += 1;
        }


        private void BTN_Vider_Click(object sender, EventArgs e)
        {
            Vider();
            TB_Empno.Enabled = true;
            TB_Nom.Enabled = true;
            TB_Prenom.Enabled = true;
            TB_Salaire.Enabled = true;
            TB_Echelon.Enabled = true;
            TB_CodeDep.Enabled = true;
            TB_Adresse.Enabled = true;

            RB_UnEmploye.Checked = false;
            RB_Departement.Checked = false;
            RB_Tous.Checked = false;
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            if (RB_Departement.Checked == true || RB_Tous.Checked == true || RB_UnEmploye.Checked == true)
                this.BindingContext[monDataSet,Employes ].Position -= 1;
            else
                this.BindingContext[monDataSet, TableEmployes].Position -= 1;
        }

        private void BTN_FIN_Click(object sender, EventArgs e)
        {
            if (RB_Departement.Checked == true || RB_Tous.Checked == true || RB_UnEmploye.Checked == true)
                this.BindingContext[monDataSet, Employes].Position = this.BindingContext[monDataSet, Employes].Count;
            else
                this.BindingContext[monDataSet, TableEmployes].Position = this.BindingContext[monDataSet, TableEmployes].Count;
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            if (RB_Departement.Checked == true || RB_Tous.Checked == true || RB_UnEmploye.Checked == true)
                this.BindingContext[monDataSet, Employes].Position = 0;
            else
                this.BindingContext[monDataSet, TableEmployes].Position = 0;
        }

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            AfficherTexte(0);
            LB_Information.Text = "Employé (" + this.BindingContext[monDataSet, "TableEmployes"].Count.ToString() + " résultats)";

            //réglages de boutons
            BTN_Debut.Enabled = true;
            BTN_FIN.Enabled = true;
            BTN_Suivant.Enabled = true;
            BTN_Precedent.Enabled = true;
            BTN_Modifier.Enabled = true;
            BTN_Afficher.Enabled = false;
            BTN_Ajouter.Enabled = false;
            BTN_Supprimer.Enabled = true;

            //réglages des txtbox
            TB_Empno.Enabled = false;
            TB_Nom.Enabled = false;
            TB_Prenom.Enabled = false;
            TB_Salaire.Enabled = false;
            TB_Echelon.Enabled = false;
            TB_CodeDep.Enabled = false;
            TB_Adresse.Enabled = false;

            RB_UnEmploye.Checked = false;
            RB_Departement.Checked = false;
            RB_Tous.Checked = false;
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
                DataGridViewRow rangee1 = this.DGV_Departements.RowTemplate;
                rangee1.Height = 19;
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
                commandeRechercher = "select * from employes order by empno";
            }
            else if (RB_UnEmploye.Checked)
            {
                if (TB_NomRecherche.Text != "")
                {
                    BTN_Recherche.Enabled = true;
                    commandeRechercher = "select * from employes where nom like '" + TB_NomRecherche.Text + "%' order by empno";
                }
            }
            else if (CB_Dep.SelectedItem != null && RB_Departement.Checked)
            {
                BTN_Recherche.Enabled = true;
                commandeRechercher = "select * from employes e inner join departements d on e.codedep = d.codedep where d.NomDepartement like '" + CB_Dep.SelectedItem.ToString().Remove(0, 6) + "' order by empno";
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
                    Lier(0, "Employes");
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
            if (TB_CodeDep.Text != "410" && TB_CodeDep.Text != "420" && TB_CodeDep.Text != "430" && TB_CodeDep.Text != "440" && TB_CodeDep.Text != "450" && TB_CodeDep.Text != "")
            {
                MessageBox.Show("Erreur: Code de departement invalide." +
                                "\n 410 - Administration" +
                                "\n 420 - Informatique" +
                                "\n 430 - Électrique" +
                                "\n 440 - Robotique" +
                                "\n 450 - Logistique");
                TB_CodeDep.Text = "";
            }
            else if (Convert.ToInt32(TB_Salaire.Text) < 25000 || Convert.ToInt32(TB_Salaire.Text) > 100000)
            {
                MessageBox.Show("Erreur: Veuillez entrer un salaire entre 25000 et 100000!");
                TB_Salaire.Text = "";
            }
            else
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

                    //réglages des txtbox
                    TB_Empno.Enabled = false;
                    TB_Nom.Enabled = false;
                    TB_Prenom.Enabled = false;
                    TB_Salaire.Enabled = false;
                    TB_Echelon.Enabled = false;
                    TB_CodeDep.Enabled = false;
                    TB_Adresse.Enabled = false;

                    //Affichage des informations
                    AfficherTexte(0); //il faut appeller cette fonction pour permettre au suivant,prec.,début et fin de marcher

                    //ajuster les informations du dgv et l'info
                    LB_Information.Text = "Employé (" + this.BindingContext[monDataSet, "TableEmployes"].Count.ToString() + " résultats)";
                    FillDGVDepartement();
                }
                catch (OracleException exsql1)
                {
                    MessageBox.Show(exsql1.Message.ToString());
                }
            }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous certain que vous voulez supprimer cet employé ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlDelete = "delete from employes where empno=" + TB_Empno.Text;
                OracleCommand oraCom = new OracleCommand(sqlDelete, oracon);
                try
                {
                    oraCom.ExecuteNonQuery();
                    oraCom.CommandType = CommandType.Text;
                    Vider();
                    //ajuster le dgv et l'information
                    LB_Information.Text = "Employé (" + this.BindingContext[monDataSet, "TableEmployes"].Count.ToString() + " résultats)";
                    FillDGVDepartement();
                }
                catch(OracleException ex) 
                { 
                    MessageBox.Show(ex.Message.ToString());
                }
                TB_Empno.Clear();
            }

        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Form_Modification modifier = new Form_Modification(TB_Empno.Text,TB_Nom.Text,TB_Prenom.Text, TB_CodeDep.Text, TB_Echelon.Text, TB_Salaire.Text, TB_Adresse.Text);
            modifier.ShowDialog();
            if (modifier.DialogResult == DialogResult.OK) //Enregistrer
            {
                try
                {
                    string sqlUpdate = "Update Employes Set Empno=" + modifier.empno_ + ", nom='" + modifier.nom_ + "', prenom='" + modifier.prenom_ + "', salaire=" + modifier.salaire_ + ", echelon =" + modifier.echelon_ + ", adresse='" + modifier.adresse_ + "', codedep= " + modifier.codeDep_ + " where empno =" + TB_Empno.Text;

                    ReinitialiserTB();
                    OracleCommand oraCom = new OracleCommand(sqlUpdate, oracon);
                    oraCom.CommandType = CommandType.Text;
                    OracleDataReader OraRead = oraCom.ExecuteReader();

                    //Affichage des informations
                    AfficherTexte(this.BindingContext[monDataSet, "TableEmployes"].Position); 
                }
                catch (OracleException exsql1)
                {
                    MessageBox.Show(exsql1.Message.ToString());
                }
            }
            else //annuler la modifcation
            {
                modifier.Close();
            }
        }

        private void RB_UnEmploye_CheckedChanged(object sender, EventArgs e)
        {
            LB_TextRecherche.Text = "Nom de l'Employé";
            LB_TextRecherche.Visible = true;
            TB_NomRecherche.Visible = true;
            CB_Dep.Visible = false;
            TB_NomRecherche.Text = "";
            //ChoixRechercher();
        }

        private void BTN_Recherche_Click(object sender, EventArgs e)
        {

            ChoixRechercher();
            ReinitialiserTB();
            monDataSet.Clear();
            RemplirTextBox(commandeRechercher);

            BTN_Debut.Enabled = true;
            BTN_FIN.Enabled = true;
            BTN_Suivant.Enabled = true;
            BTN_Precedent.Enabled = true;
            BTN_Modifier.Enabled = true;
            BTN_Ajouter.Enabled = true;
            BTN_Supprimer.Enabled = true;
            BTN_Afficher.Enabled = false;  
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
        }

        private void RB_Departement_CheckedChanged(object sender, EventArgs e)
        {
            LB_TextRecherche.Text = "Département";
            LB_TextRecherche.Visible = true;
            TB_NomRecherche.Visible = false;
            CB_Dep.Visible = true;
            TB_NomRecherche.Text = "";
            //ChoixRechercher();
            CB_Dep.SelectedItem = 2; 
        }

        private void CB_Dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TB_NomRecherche_TextChanged(object sender, EventArgs e)
        {
            BTN_Recherche.Enabled = true;
        }

        private void TextBox_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touche appuyé est différent qu'une touche numéric ou le backspace..
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }

        private void TextBox_Lettre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touche appuyé est différent qu'une touche numéric ou le backspace..
            if (e.KeyChar != (char)8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }

        private void RB_Click(object sender, EventArgs e)
        {
            BTN_Debut.Enabled = false;
            BTN_FIN.Enabled = false;
            BTN_Suivant.Enabled = false;
            BTN_Precedent.Enabled = false;
            BTN_Modifier.Enabled = false;
            BTN_Ajouter.Enabled = false;
            BTN_Supprimer.Enabled = false;
            BTN_Afficher.Enabled = true;  
        }

        private void TB_Adresse_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touhe appuyé est différent qu'une touche numéric, lettre ou le backspace ou espace..
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }

        private void TB_Salaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            //vérifie si la touche appuyé est différent qu'une touche lettre ou le backspace ou point..
            if (e.KeyChar != (char)8 && !char.IsLetter(e.KeyChar) && e.KeyChar == Char.Parse(","))
            {
                e.Handled = true;//set event handled à true pour "canceller"(rien faire) lorsque le KeyPress est activé
            }
        }
    }
}
