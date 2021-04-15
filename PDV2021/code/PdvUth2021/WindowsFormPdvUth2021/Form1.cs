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

namespace WindowsFormPdvUth2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            if (prod.create(txtName.Text, txtDescription.Text, double.Parse(txtPrice.Text), txtBarcode.Text, int.Parse(comboBrand.SelectedItem.ToString()), int.Parse(comboSubcategory.SelectedItem.ToString()), comboMetricUnit.SelectedItem.ToString()))
                MessageBox.Show("Se registró el producto");
            else
                MessageBox.Show(">ERROR<\n No se pudieron guardar los datos.");
        }
    }
}
