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
        }

        private void AfficherTexte()
        {
            string sqlEmployes = "select Empno, nom, prenom, salaire, echelon, adresse, codeDep from Employes";

            try
            {
                OracleCommand oraCom = new OracleCommand(sqlEmployes, oracon);
                oraCom.CommandType = CommandType.Text;
                int nbligne = oraCom.ExecuteNonQuery();
                MessageBox.Show("nombre de lignes mise à jour est: " + nbligne);
                OracleDataReader OraRead = oraCom.ExecuteReader();

                TB_Empno.Text = OraRead.GetInt32(0).ToString();
                TB_Nom.Text = OraRead.GetString(1).ToString();
                TB_Prenom.Text = OraRead.GetString(2);
                TB_Salaire.Text = OraRead.GetInt32(3).ToString();
                TB_Echelon.Text = OraRead.GetInt32(4).ToString();
                TB_Adresse.Text = OraRead.GetString(5);
                TB_CodeDep.Text = OraRead.GetChar(6).ToString();
            }
            catch (Exception exsql1)
            {
                MessageBox.Show(exsql1.Message.ToString());
            }



            //test pour afficher dans les txtbox
            //try
            //{
            //    string sql = "select empno, nom, prenom, codedep, echelon, salaire, adresse from employes";
            //    OracleDataAdapter adapter2 = new OracleDataAdapter(sql, oracon);
            //    if (monDataSet.Tables.Contains("TableEmployes"))
            //    {
            //        monDataSet.Tables["TableEmployes"].Clear();
            //    }
            //    adapter2.Fill(monDataSet, "TableEmployes");
            //    adapter2.Dispose();
            //    Lier();
                
            //}
            //catch(Exception bagel)
            //{
            //    MessageBox.Show(bagel.Message.ToString());
            //}

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
            TB_Empno.Text = "";
            TB_Nom.Text = "";
            TB_Prenom.Text = "";
            TB_CodeDep.Text = "";
            TB_Echelon.Text = "";
            TB_Salaire.Text = "";
            TB_Adresse.Text = "";
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[monDataSet, "TableEmployes"].Position -= 1;
        }
    }
}
