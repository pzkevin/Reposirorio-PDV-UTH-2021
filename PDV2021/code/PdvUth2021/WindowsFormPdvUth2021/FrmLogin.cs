using LibPdvUth2021.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPdvUth2021
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        public static string nombre, tipo, correo;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.Login(emailInput.Text, passwordInput.Text)) 
            {
                MessageBox.Show("Bienvenido");
            }
            else 
            {
                MessageBox.Show("El correo o contraseña no es valido");
            }


        }
    }
}
