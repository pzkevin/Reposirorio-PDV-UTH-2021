
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Label();
            this.MetricUnit = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Subcategory = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.comboMetricUnit = new System.Windows.Forms.ComboBox();
            this.comboSubcategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(44, 128);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(35, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 154);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(44, 154);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(110, 180);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 20);
            this.txtPrice.TabIndex = 5;
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
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(110, 206);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(156, 20);
            this.txtBarcode.TabIndex = 7;
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
            // MetricUnit
            // 
            this.MetricUnit.AutoSize = true;
            this.MetricUnit.Location = new System.Drawing.Point(314, 183);
            this.MetricUnit.Name = "MetricUnit";
            this.MetricUnit.Size = new System.Drawing.Size(58, 13);
            this.MetricUnit.TabIndex = 8;
            this.MetricUnit.Text = "Metric Unit";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(337, 128);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(35, 13);
            this.Brand.TabIndex = 10;
            this.Brand.Text = "Brand";
            // 
            // Subcategory
            // 
            this.Subcategory.AutoSize = true;
            this.Subcategory.Location = new System.Drawing.Point(314, 157);
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.Size = new System.Drawing.Size(67, 13);
            this.Subcategory.TabIndex = 12;
            this.Subcategory.Text = "Subcategory";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(110, 235);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(156, 20);
            this.txtImage.TabIndex = 15;
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Location = new System.Drawing.Point(44, 235);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(36, 13);
            this.Image.TabIndex = 14;
            this.Image.Text = "Image";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 127);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Product";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBrand
            // 
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBrand.Location = new System.Drawing.Point(378, 128);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBrand.TabIndex = 17;
            // 
            // comboMetricUnit
            // 
            this.comboMetricUnit.FormattingEnabled = true;
            this.comboMetricUnit.Items.AddRange(new object[] {
            "UNIDAD",
            "KILO",
            "LITRO",
            "CAJA"});
            this.comboMetricUnit.Location = new System.Drawing.Point(378, 179);
            this.comboMetricUnit.Name = "comboMetricUnit";
            this.comboMetricUnit.Size = new System.Drawing.Size(121, 21);
            this.comboMetricUnit.TabIndex = 18;
            // 
            // comboSubcategory
            // 
            this.comboSubcategory.FormattingEnabled = true;
            this.comboSubcategory.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboSubcategory.Location = new System.Drawing.Point(378, 153);
            this.comboSubcategory.Name = "comboSubcategory";
            this.comboSubcategory.Size = new System.Drawing.Size(121, 21);
            this.comboSubcategory.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.comboSubcategory);
            this.Controls.Add(this.comboMetricUnit);
            this.Controls.Add(this.comboBrand);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Subcategory);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.MetricUnit);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Products Catalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.Label MetricUnit;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Subcategory;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label Image;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.ComboBox comboMetricUnit;
        private System.Windows.Forms.ComboBox comboSubcategory;
    }
}

