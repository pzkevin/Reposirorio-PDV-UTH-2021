
namespace WindowsFormPdvUth2021
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.MetricUnit = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Subcategory = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(44, 128);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(44, 154);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            this.Description.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(44, 180);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(44, 206);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(47, 13);
            this.Barcode.TabIndex = 6;
            this.Barcode.Text = "Barcode";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 232);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 20);
            this.textBox5.TabIndex = 9;
            // 
            // MetricUnit
            // 
            this.MetricUnit.AutoSize = true;
            this.MetricUnit.Location = new System.Drawing.Point(44, 232);
            this.MetricUnit.Name = "MetricUnit";
            this.MetricUnit.Size = new System.Drawing.Size(58, 13);
            this.MetricUnit.TabIndex = 8;
            this.MetricUnit.Text = "Metric Unit";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(110, 258);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 20);
            this.textBox6.TabIndex = 11;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(44, 258);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(35, 13);
            this.Brand.TabIndex = 10;
            this.Brand.Text = "Brand";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(110, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(156, 20);
            this.textBox7.TabIndex = 13;
            // 
            // Subcategory
            // 
            this.Subcategory.AutoSize = true;
            this.Subcategory.Location = new System.Drawing.Point(44, 284);
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.Size = new System.Drawing.Size(67, 13);
            this.Subcategory.TabIndex = 12;
            this.Subcategory.Text = "Subcategory";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(110, 310);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(156, 20);
            this.textBox8.TabIndex = 15;
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Location = new System.Drawing.Point(44, 310);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(36, 13);
            this.Image.TabIndex = 14;
            this.Image.Text = "Image";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 202);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Subcategory);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.MetricUnit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Products Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label MetricUnit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Subcategory;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label Image;
        private System.Windows.Forms.Button btnSave;
    }
}

