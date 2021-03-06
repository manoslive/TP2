﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

//connection Oracle 
//beloinem
//cooperch
namespace TP2
{
    public partial class Form_Connection : Form
    {
        private OracleConnection oracon;
        private MaConnection maBelleConnection;
        public Form_Connection(OracleConnection connection, MaConnection maBelleConnection) //recoit la connection en parametre
        {
            InitializeComponent();
            SetOracleConnection(connection); //set la connection dans l'attribut
            SetMaConnection(maBelleConnection);
        }
        public void SetMaConnection(MaConnection laConnection)
        {
            maBelleConnection = laConnection;
        }
        public void SetOracleConnection(OracleConnection connection)
        {
            oracon = connection;
        }
        private OracleConnection GetOracleConnection()
        {
            return oracon;
        }
        private void BTN_Connection_Click(object sender, EventArgs e)
        {
            string user = TB_Username.Text;
            string password = TB_Password.Text;
            try
            {
                //MaConnection maBelleConnection = new MaConnection(); // replacé dans la form1 pour etre envoyer ici
                if(maBelleConnection.Connect(user, password, GetOracleConnection())) //envoi les info à la classe pour effectuer la connection
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
