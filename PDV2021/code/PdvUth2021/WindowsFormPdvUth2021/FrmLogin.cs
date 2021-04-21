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


        public static User usuarioLogeado;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = user.Login(emailInput.Text, passwordInput.Text);
            if (user!=null&&user.Email!="") 
            {
                MessageBox.Show($"Bienvenido {user.Name} {user.Lastname}");
                FrmLogin.usuarioLogeado = user;
                if (FrmLogin.usuarioLogeado.Type == UserType.ADMIN)
                {
                    //Mostrar Dashboard Administrador
                    Form1 agregarProductos = new Form1();
                    this.Hide();
                    agregarProductos.ShowDialog(); //solo permite un Form funcionando
                    this.Show();
                }
                else 
                {
                    //Mostrar caja
                }
            }
            else 
            {
                MessageBox.Show("El correo o contraseña no es valido");
            }


        }
    }
}
