
namespace WindowsFormPdvUth2021
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.IconRestaure = new System.Windows.Forms.PictureBox();
            this.IconMinimize = new System.Windows.Forms.PictureBox();
            this.IconMaximize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCashRegister = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.CancelOperation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(88, 284);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(86, 31);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(245, 281);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 38);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(245, 381);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 38);
            this.txtDescription.TabIndex = 3;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(88, 384);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(151, 31);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(245, 481);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(400, 38);
            this.txtPrice.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(88, 484);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(76, 31);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(245, 581);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(400, 38);
            this.txtBarcode.TabIndex = 7;
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barcode.Location = new System.Drawing.Point(88, 584);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(115, 31);
            this.Barcode.TabIndex = 6;
            this.Barcode.Text = "Barcode";
            // 
            // MetricUnit
            // 
            this.MetricUnit.AutoSize = true;
            this.MetricUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricUnit.Location = new System.Drawing.Point(704, 484);
            this.MetricUnit.Name = "MetricUnit";
            this.MetricUnit.Size = new System.Drawing.Size(144, 31);
            this.MetricUnit.TabIndex = 8;
            this.MetricUnit.Text = "Metric Unit";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.Location = new System.Drawing.Point(704, 284);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(86, 31);
            this.Brand.TabIndex = 10;
            this.Brand.Text = "Brand";
            // 
            // Subcategory
            // 
            this.Subcategory.AutoSize = true;
            this.Subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subcategory.Location = new System.Drawing.Point(704, 384);
            this.Subcategory.Name = "Subcategory";
            this.Subcategory.Size = new System.Drawing.Size(167, 31);
            this.Subcategory.TabIndex = 12;
            this.Subcategory.Text = "Subcategory";
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(245, 681);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(400, 38);
            this.txtImage.TabIndex = 15;
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.Location = new System.Drawing.Point(88, 684);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(89, 31);
            this.Image.TabIndex = 14;
            this.Image.Text = "Image";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(777, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 100);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBrand
            // 
            this.comboBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBrand.Location = new System.Drawing.Point(877, 281);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(400, 39);
            this.comboBrand.TabIndex = 17;
            // 
            // comboMetricUnit
            // 
            this.comboMetricUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMetricUnit.FormattingEnabled = true;
            this.comboMetricUnit.Items.AddRange(new object[] {
            "UNIDAD",
            "KILO",
            "LITRO",
            "CAJA"});
            this.comboMetricUnit.Location = new System.Drawing.Point(877, 481);
            this.comboMetricUnit.Name = "comboMetricUnit";
            this.comboMetricUnit.Size = new System.Drawing.Size(400, 39);
            this.comboMetricUnit.TabIndex = 18;
            // 
            // comboSubcategory
            // 
            this.comboSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSubcategory.FormattingEnabled = true;
            this.comboSubcategory.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboSubcategory.Location = new System.Drawing.Point(877, 381);
            this.comboSubcategory.Name = "comboSubcategory";
            this.comboSubcategory.Size = new System.Drawing.Size(400, 39);
            this.comboSubcategory.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.IconRestaure);
            this.panel1.Controls.Add(this.IconMinimize);
            this.panel1.Controls.Add(this.IconMaximize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.IconClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1424, 42);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // dateTime
            // 
            this.dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.DarkCyan;
            this.dateTime.CustomFormat = "";
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime.Location = new System.Drawing.Point(1080, 3);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(164, 31);
            this.dateTime.TabIndex = 27;
            // 
            // IconRestaure
            // 
            this.IconRestaure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconRestaure.Image = ((System.Drawing.Image)(resources.GetObject("IconRestaure.Image")));
            this.IconRestaure.Location = new System.Drawing.Point(1306, 7);
            this.IconRestaure.Name = "IconRestaure";
            this.IconRestaure.Size = new System.Drawing.Size(50, 27);
            this.IconRestaure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconRestaure.TabIndex = 28;
            this.IconRestaure.TabStop = false;
            this.IconRestaure.Visible = false;
            this.IconRestaure.Click += new System.EventHandler(this.IconRestaure_Click);
            // 
            // IconMinimize
            // 
            this.IconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimize.Image")));
            this.IconMinimize.Location = new System.Drawing.Point(1250, 7);
            this.IconMinimize.Name = "IconMinimize";
            this.IconMinimize.Size = new System.Drawing.Size(50, 27);
            this.IconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimize.TabIndex = 27;
            this.IconMinimize.TabStop = false;
            this.IconMinimize.Click += new System.EventHandler(this.IconMinimize_Click);
            // 
            // IconMaximize
            // 
            this.IconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMaximize.Image = ((System.Drawing.Image)(resources.GetObject("IconMaximize.Image")));
            this.IconMaximize.Location = new System.Drawing.Point(1306, 7);
            this.IconMaximize.Name = "IconMaximize";
            this.IconMaximize.Size = new System.Drawing.Size(50, 27);
            this.IconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMaximize.TabIndex = 27;
            this.IconMaximize.TabStop = false;
            this.IconMaximize.Click += new System.EventHandler(this.IconMaximize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IconClose
            // 
            this.IconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconClose.Image = ((System.Drawing.Image)(resources.GetObject("IconClose.Image")));
            this.IconClose.Location = new System.Drawing.Point(1362, 7);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(50, 27);
            this.IconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconClose.TabIndex = 1;
            this.IconClose.TabStop = false;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnCashRegister);
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnProducts);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.UserPicture);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1424, 65);
            this.panel2.TabIndex = 21;
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCashRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCashRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCashRegister.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnCashRegister.FlatAppearance.BorderSize = 0;
            this.btnCashRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnCashRegister.Image")));
            this.btnCashRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashRegister.Location = new System.Drawing.Point(420, 0);
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.Size = new System.Drawing.Size(182, 65);
            this.btnCashRegister.TabIndex = 28;
            this.btnCashRegister.Text = "Cash Register";
            this.btnCashRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashRegister.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventory.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(608, 0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(182, 65);
            this.btnInventory.TabIndex = 28;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsers.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(1171, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(182, 65);
            this.btnUsers.TabIndex = 28;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducts.BackColor = System.Drawing.Color.DarkCyan;
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(796, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(182, 65);
            this.btnProducts.TabIndex = 27;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSales
            // 
            this.btnSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSales.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(983, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(182, 65);
            this.btnSales.TabIndex = 28;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // UserPicture
            // 
            this.UserPicture.Location = new System.Drawing.Point(0, 0);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(65, 65);
            this.UserPicture.TabIndex = 2;
            this.UserPicture.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1359, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 65);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(738, 723);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(177, 31);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save Product";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(987, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(965, 723);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(144, 31);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear Data";
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel.BackgroundImage")));
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(1177, 619);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 100);
            this.Cancel.TabIndex = 25;
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // CancelOperation
            // 
            this.CancelOperation.AutoSize = true;
            this.CancelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOperation.Location = new System.Drawing.Point(1178, 722);
            this.CancelOperation.Name = "CancelOperation";
            this.CancelOperation.Size = new System.Drawing.Size(99, 31);
            this.CancelOperation.TabIndex = 26;
            this.CancelOperation.Text = "Cancel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.CancelOperation);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Products Catalog";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label CancelOperation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox IconMinimize;
        private System.Windows.Forms.PictureBox IconMaximize;
        private System.Windows.Forms.PictureBox IconClose;
        private System.Windows.Forms.PictureBox IconRestaure;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCashRegister;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}

