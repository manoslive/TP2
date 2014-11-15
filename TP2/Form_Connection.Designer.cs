namespace TP2
{
    partial class Form_Connection
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
            this.BTN_Connection = new System.Windows.Forms.Button();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Username = new System.Windows.Forms.Label();
            this.LB_Password = new System.Windows.Forms.Label();
            this.LB_Etat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Connection
            // 
            this.BTN_Connection.Location = new System.Drawing.Point(225, 177);
            this.BTN_Connection.Name = "BTN_Connection";
            this.BTN_Connection.Size = new System.Drawing.Size(101, 33);
            this.BTN_Connection.TabIndex = 0;
            this.BTN_Connection.Text = "Connection";
            this.BTN_Connection.UseVisualStyleBackColor = true;
            this.BTN_Connection.Click += new System.EventHandler(this.BTN_Connection_Click);
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(127, 42);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(198, 26);
            this.TB_Username.TabIndex = 1;
            this.TB_Username.Text = "cooperch";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(127, 85);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(198, 26);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "ORACLE1";
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Location = new System.Drawing.Point(25, 45);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(83, 20);
            this.LB_Username.TabIndex = 2;
            this.LB_Username.Text = "Username";
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Location = new System.Drawing.Point(25, 91);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(78, 20);
            this.LB_Password.TabIndex = 2;
            this.LB_Password.Text = "Password";
            // 
            // LB_Etat
            // 
            this.LB_Etat.AutoSize = true;
            this.LB_Etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Etat.ForeColor = System.Drawing.Color.Red;
            this.LB_Etat.Location = new System.Drawing.Point(12, 166);
            this.LB_Etat.Name = "LB_Etat";
            this.LB_Etat.Size = new System.Drawing.Size(121, 40);
            this.LB_Etat.TabIndex = 3;
            this.LB_Etat.Text = "Offline";
            // 
            // Form_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 216);
            this.Controls.Add(this.LB_Etat);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.BTN_Connection);
            this.Name = "Form_Connection";
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Form_Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Connection;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Label LB_Etat;
    }
}