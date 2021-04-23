using LibPdvUth2021.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormPdvUth2021
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            Product prod = new Product();
            if (prod.create(txtName.Text, txtDescription.Text, double.Parse(txtPrice.Text), txtBarcode.Text, int.Parse(comboBrand.SelectedItem.ToString()), int.Parse(comboSubcategory.SelectedItem.ToString()), comboMetricUnit.SelectedItem.ToString()))
                MessageBox.Show("Se registró el producto");

            if (prod.create(txtName.Text="", txtDescription.Text = "", double.Parse(txtPrice.Text = ""), txtBarcode.Text = "", int.Parse(comboBrand.SelectedItem.ToString()), int.Parse(comboSubcategory.SelectedItem.ToString()), comboMetricUnit.SelectedItem.ToString()))
                MessageBox.Show("SIN REGISTRO");

            else
                MessageBox.Show(">ERROR<\n No se pudieron guardar los datos.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para cualquier aclaración o necesidad de cambio en el comportamiento del programa llamar al administrador");
        }

        public void IconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaure.Visible = true;
            IconMaximize.Visible = false;
        }

        private void IconRestaure_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaure.Visible = false;
            IconMaximize.Visible = true;
        }

        private void IconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void UserPicture_Click(object sender, EventArgs e) //Hay que cambiar la imagen automaticamente dependiendo el usuario
        {
            //UserPicture.Image = ;
        }

        //private void OpenFormInPanel(object Fromhijo) 
        //{
        //    if (this.panel1.Controls.Count > 0)
        //        this.panelContenedor.Controls.RemoveAt(0);
        //    Form fh = panelContenedor as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panel
        //}
        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
