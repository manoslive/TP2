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
    public partial class Form_Connection : Form
    {
        private OracleConnection oracon = new OracleConnection();
        public Form_Connection()
        {
            InitializeComponent();
        }

        private void BTN_Connection_Click(object sender, EventArgs e)
        {
            string user = TB_Username.Text;
            string password = TB_Password.Text;
            try
            {
                MaConnection maBelleConnection = new MaConnection();
                if(maBelleConnection.Connect(user, password))
                {
                    this.Close();
                }
                LB_Etat.ForeColor = Color.Black;
                this.BackColor = Color.Green;
                LB_Etat.Text = "OPENED";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Form_Connection_Load(object sender, EventArgs e)
        {
            TB_Username.Focus();
        }
    }
}
