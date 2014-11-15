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
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Connection connection = new Form_Connection(oracon, maBelleConnection); // Passer en parametre le oracle connection
            if(connection.ShowDialog() == DialogResult.Cancel)
            {
                //Application.Exit();
            }
            TB_Empno.Select();
            AfficherTexte();

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

                //insertion de chaque rangé dans le DataGridView
                InsertionDataGridView();
            }
            catch (Exception bagel)
            {
                MessageBox.Show(bagel.Message.ToString());
            }

        }
        private void InsertionDataGridView()
        {
            int nbRangees = 0;
            while (monDataSet.Tables["TableEmployes"].Rows.Count > nbRangees)
            {
                dataGridView.DataSource = monDataSet.Tables[nbRangees];
                nbRangees++;
            }
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
            BTN_Afficher.Enabled = true;        
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
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {
            if(BTN_Debut.Enabled == false)
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
    }
}
