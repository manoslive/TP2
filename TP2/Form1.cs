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
            try
            {
                string sql = "select empno, nom, prenom, codedep, echelon, salaire, adresse from employes";
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql, oracon);
                if (monDataSet.Tables.Contains("TableEmployes"))
                {
                    monDataSet.Tables["TableEmployes"].Clear();
                }
                adapter2.Fill(monDataSet, "TableEmployes");
                adapter2.Dispose();
                Lier();

            }
            catch (Exception bagel)
            {
                MessageBox.Show(bagel.Message.ToString());
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
