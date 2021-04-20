
namespace WindowsFormPdvUth2021
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoHeaderLogin = new System.Windows.Forms.PictureBox();
            this.headerText = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoHeaderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.logoHeaderLogin);
            this.panel1.Controls.Add(this.headerText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 100);
            this.panel1.TabIndex = 0;
            // 
            // logoHeaderLogin
            // 
            this.logoHeaderLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoHeaderLogin.Image = ((System.Drawing.Image)(resources.GetObject("logoHeaderLogin.Image")));
            this.logoHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.logoHeaderLogin.Name = "logoHeaderLogin";
            this.logoHeaderLogin.Size = new System.Drawing.Size(100, 100);
            this.logoHeaderLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoHeaderLogin.TabIndex = 2;
            this.logoHeaderLogin.TabStop = false;
            // 
            // headerText
            // 
            this.headerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerText.AutoSize = true;
            this.headerText.CausesValidation = false;
            this.headerText.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(190, 23);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(127, 44);
            this.headerText.TabIndex = 1;
            this.headerText.Text = "LOGIN";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(50, 180);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(400, 20);
            this.emailInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(50, 328);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(400, 20);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // loginText
            // 
            this.loginText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginText.AutoSize = true;
            this.loginText.CausesValidation = false;
            this.loginText.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.Location = new System.Drawing.Point(190, 133);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(112, 44);
            this.loginText.TabIndex = 3;
            this.loginText.Text = "Email";
            this.loginText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordText.AutoSize = true;
            this.passwordText.CausesValidation = false;
            this.passwordText.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(158, 281);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(177, 44);
            this.passwordText.TabIndex = 4;
            this.passwordText.Text = "Password";
            this.passwordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(108, 444);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 70);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmLogin
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoHeaderLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.PictureBox logoHeaderLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}