
namespace ProjectPizaa
{
    partial class FrOrder
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
            this.groupBox_Size = new System.Windows.Forms.GroupBox();
            this.radioButton_Larg = new System.Windows.Forms.RadioButton();
            this.radioButton_Meduim = new System.Windows.Forms.RadioButton();
            this.radioButton_Small = new System.Windows.Forms.RadioButton();
            this.groupBox_CrustType = new System.Windows.Forms.GroupBox();
            this.radioButton_ThickCrust = new System.Windows.Forms.RadioButton();
            this.radioButton_ThinCrust = new System.Windows.Forms.RadioButton();
            this.groupBox_WhereToEat = new System.Windows.Forms.GroupBox();
            this.radioButton_TakeOut = new System.Windows.Forms.RadioButton();
            this.radioButton_Eatin = new System.Windows.Forms.RadioButton();
            this.groupBox_Toppins = new System.Windows.Forms.GroupBox();
            this.checkBox_Tomatoes = new System.Windows.Forms.CheckBox();
            this.checkBox_Mushrooms = new System.Windows.Forms.CheckBox();
            this.checkBox_ExtraCheese = new System.Windows.Forms.CheckBox();
            this.checkBox_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.checkBox_Olives = new System.Windows.Forms.CheckBox();
            this.checkBox_Onion = new System.Windows.Forms.CheckBox();
            this.label_Titel = new System.Windows.Forms.Label();
            this.button_ORDER = new System.Windows.Forms.Button();
            this.button_GoBack = new System.Windows.Forms.Button();
            this.label_Price = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Size.SuspendLayout();
            this.groupBox_CrustType.SuspendLayout();
            this.groupBox_WhereToEat.SuspendLayout();
            this.groupBox_Toppins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Size
            // 
            this.groupBox_Size.Controls.Add(this.radioButton_Larg);
            this.groupBox_Size.Controls.Add(this.radioButton_Meduim);
            this.groupBox_Size.Controls.Add(this.radioButton_Small);
            this.groupBox_Size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox_Size.Font = new System.Drawing.Font("Monotype Corsiva", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Size.ForeColor = System.Drawing.Color.Red;
            this.groupBox_Size.Location = new System.Drawing.Point(6, 68);
            this.groupBox_Size.Name = "groupBox_Size";
            this.groupBox_Size.Size = new System.Drawing.Size(276, 249);
            this.groupBox_Size.TabIndex = 0;
            this.groupBox_Size.TabStop = false;
            this.groupBox_Size.Text = "Size";
            this.groupBox_Size.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Size_Paint);
            // 
            // radioButton_Larg
            // 
            this.radioButton_Larg.AutoSize = true;
            this.radioButton_Larg.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Larg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_Larg.Location = new System.Drawing.Point(6, 196);
            this.radioButton_Larg.Name = "radioButton_Larg";
            this.radioButton_Larg.Size = new System.Drawing.Size(95, 44);
            this.radioButton_Larg.TabIndex = 2;
            this.radioButton_Larg.TabStop = true;
            this.radioButton_Larg.Text = "Larg";
            this.radioButton_Larg.UseVisualStyleBackColor = true;
            this.radioButton_Larg.CheckedChanged += new System.EventHandler(this.radioButton_Larg_CheckedChanged);
            // 
            // radioButton_Meduim
            // 
            this.radioButton_Meduim.AutoSize = true;
            this.radioButton_Meduim.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Meduim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_Meduim.Location = new System.Drawing.Point(6, 129);
            this.radioButton_Meduim.Name = "radioButton_Meduim";
            this.radioButton_Meduim.Size = new System.Drawing.Size(138, 44);
            this.radioButton_Meduim.TabIndex = 1;
            this.radioButton_Meduim.TabStop = true;
            this.radioButton_Meduim.Text = "Meduim";
            this.radioButton_Meduim.UseVisualStyleBackColor = true;
            this.radioButton_Meduim.CheckedChanged += new System.EventHandler(this.radioButton_Meduim_CheckedChanged);
            // 
            // radioButton_Small
            // 
            this.radioButton_Small.AutoSize = true;
            this.radioButton_Small.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Small.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_Small.Location = new System.Drawing.Point(6, 79);
            this.radioButton_Small.Name = "radioButton_Small";
            this.radioButton_Small.Size = new System.Drawing.Size(105, 44);
            this.radioButton_Small.TabIndex = 0;
            this.radioButton_Small.TabStop = true;
            this.radioButton_Small.Text = "Small";
            this.radioButton_Small.UseVisualStyleBackColor = true;
            this.radioButton_Small.CheckedChanged += new System.EventHandler(this.radioButton_Small_CheckedChanged);
            // 
            // groupBox_CrustType
            // 
            this.groupBox_CrustType.Controls.Add(this.radioButton_ThickCrust);
            this.groupBox_CrustType.Controls.Add(this.radioButton_ThinCrust);
            this.groupBox_CrustType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox_CrustType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_CrustType.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CrustType.ForeColor = System.Drawing.Color.Red;
            this.groupBox_CrustType.Location = new System.Drawing.Point(345, 135);
            this.groupBox_CrustType.Name = "groupBox_CrustType";
            this.groupBox_CrustType.Size = new System.Drawing.Size(287, 196);
            this.groupBox_CrustType.TabIndex = 0;
            this.groupBox_CrustType.TabStop = false;
            this.groupBox_CrustType.Text = "Crust Type";
            this.groupBox_CrustType.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_CrustType_Paint);
            // 
            // radioButton_ThickCrust
            // 
            this.radioButton_ThickCrust.AutoSize = true;
            this.radioButton_ThickCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_ThickCrust.Location = new System.Drawing.Point(6, 122);
            this.radioButton_ThickCrust.Name = "radioButton_ThickCrust";
            this.radioButton_ThickCrust.Size = new System.Drawing.Size(275, 68);
            this.radioButton_ThickCrust.TabIndex = 1;
            this.radioButton_ThickCrust.TabStop = true;
            this.radioButton_ThickCrust.Text = "Thick Crust";
            this.radioButton_ThickCrust.UseVisualStyleBackColor = true;
            this.radioButton_ThickCrust.CheckedChanged += new System.EventHandler(this.radioButton_ThickCrust_CheckedChanged);
            // 
            // radioButton_ThinCrust
            // 
            this.radioButton_ThinCrust.AutoSize = true;
            this.radioButton_ThinCrust.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ThinCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_ThinCrust.Location = new System.Drawing.Point(6, 62);
            this.radioButton_ThinCrust.Name = "radioButton_ThinCrust";
            this.radioButton_ThinCrust.Size = new System.Drawing.Size(257, 68);
            this.radioButton_ThinCrust.TabIndex = 0;
            this.radioButton_ThinCrust.Text = "Thin Crust";
            this.radioButton_ThinCrust.UseVisualStyleBackColor = true;
            this.radioButton_ThinCrust.CheckedChanged += new System.EventHandler(this.radioButton_ThinCrust_CheckedChanged);
            // 
            // groupBox_WhereToEat
            // 
            this.groupBox_WhereToEat.Controls.Add(this.radioButton_TakeOut);
            this.groupBox_WhereToEat.Controls.Add(this.radioButton_Eatin);
            this.groupBox_WhereToEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox_WhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_WhereToEat.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_WhereToEat.ForeColor = System.Drawing.Color.Red;
            this.groupBox_WhereToEat.Location = new System.Drawing.Point(457, 365);
            this.groupBox_WhereToEat.Name = "groupBox_WhereToEat";
            this.groupBox_WhereToEat.Size = new System.Drawing.Size(321, 277);
            this.groupBox_WhereToEat.TabIndex = 0;
            this.groupBox_WhereToEat.TabStop = false;
            this.groupBox_WhereToEat.Text = "Where To Eat";
            this.groupBox_WhereToEat.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_WhereToEat_Paint);
            // 
            // radioButton_TakeOut
            // 
            this.radioButton_TakeOut.AutoSize = true;
            this.radioButton_TakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_TakeOut.Location = new System.Drawing.Point(15, 201);
            this.radioButton_TakeOut.Name = "radioButton_TakeOut";
            this.radioButton_TakeOut.Size = new System.Drawing.Size(229, 68);
            this.radioButton_TakeOut.TabIndex = 1;
            this.radioButton_TakeOut.TabStop = true;
            this.radioButton_TakeOut.Text = "Take Out";
            this.radioButton_TakeOut.UseVisualStyleBackColor = true;
            this.radioButton_TakeOut.CheckedChanged += new System.EventHandler(this.radioButton_TakeOut_CheckedChanged);
            // 
            // radioButton_Eatin
            // 
            this.radioButton_Eatin.AutoSize = true;
            this.radioButton_Eatin.Font = new System.Drawing.Font("Monotype Corsiva", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Eatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_Eatin.Location = new System.Drawing.Point(15, 95);
            this.radioButton_Eatin.Name = "radioButton_Eatin";
            this.radioButton_Eatin.Size = new System.Drawing.Size(221, 86);
            this.radioButton_Eatin.TabIndex = 0;
            this.radioButton_Eatin.TabStop = true;
            this.radioButton_Eatin.Text = "Eat In";
            this.radioButton_Eatin.UseVisualStyleBackColor = true;
            this.radioButton_Eatin.CheckedChanged += new System.EventHandler(this.radioButton_Eatin_CheckedChanged);
            // 
            // groupBox_Toppins
            // 
            this.groupBox_Toppins.Controls.Add(this.checkBox_Tomatoes);
            this.groupBox_Toppins.Controls.Add(this.checkBox_Mushrooms);
            this.groupBox_Toppins.Controls.Add(this.checkBox_ExtraCheese);
            this.groupBox_Toppins.Controls.Add(this.checkBox_GreenPeppers);
            this.groupBox_Toppins.Controls.Add(this.checkBox_Olives);
            this.groupBox_Toppins.Controls.Add(this.checkBox_Onion);
            this.groupBox_Toppins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox_Toppins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_Toppins.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Toppins.ForeColor = System.Drawing.Color.Red;
            this.groupBox_Toppins.Location = new System.Drawing.Point(6, 345);
            this.groupBox_Toppins.Name = "groupBox_Toppins";
            this.groupBox_Toppins.Size = new System.Drawing.Size(432, 307);
            this.groupBox_Toppins.TabIndex = 0;
            this.groupBox_Toppins.TabStop = false;
            this.groupBox_Toppins.Text = "Toppins";
            this.groupBox_Toppins.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Toppins_Paint);
            // 
            // checkBox_Tomatoes
            // 
            this.checkBox_Tomatoes.AutoSize = true;
            this.checkBox_Tomatoes.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Tomatoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_Tomatoes.Location = new System.Drawing.Point(6, 223);
            this.checkBox_Tomatoes.Name = "checkBox_Tomatoes";
            this.checkBox_Tomatoes.Size = new System.Drawing.Size(154, 44);
            this.checkBox_Tomatoes.TabIndex = 5;
            this.checkBox_Tomatoes.Text = "Tomatoes";
            this.checkBox_Tomatoes.UseVisualStyleBackColor = true;
            this.checkBox_Tomatoes.CheckedChanged += new System.EventHandler(this.checkBox_Tomatoes_CheckedChanged);
            // 
            // checkBox_Mushrooms
            // 
            this.checkBox_Mushrooms.AutoSize = true;
            this.checkBox_Mushrooms.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mushrooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_Mushrooms.Location = new System.Drawing.Point(11, 146);
            this.checkBox_Mushrooms.Name = "checkBox_Mushrooms";
            this.checkBox_Mushrooms.Size = new System.Drawing.Size(181, 44);
            this.checkBox_Mushrooms.TabIndex = 4;
            this.checkBox_Mushrooms.Text = "Mushrooms";
            this.checkBox_Mushrooms.UseVisualStyleBackColor = true;
            this.checkBox_Mushrooms.CheckedChanged += new System.EventHandler(this.checkBox_Mushrooms_CheckedChanged);
            // 
            // checkBox_ExtraCheese
            // 
            this.checkBox_ExtraCheese.AutoSize = true;
            this.checkBox_ExtraCheese.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ExtraCheese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_ExtraCheese.Location = new System.Drawing.Point(11, 72);
            this.checkBox_ExtraCheese.Name = "checkBox_ExtraCheese";
            this.checkBox_ExtraCheese.Size = new System.Drawing.Size(200, 44);
            this.checkBox_ExtraCheese.TabIndex = 3;
            this.checkBox_ExtraCheese.Text = "Extra Cheese";
            this.checkBox_ExtraCheese.UseVisualStyleBackColor = true;
            this.checkBox_ExtraCheese.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox_GreenPeppers
            // 
            this.checkBox_GreenPeppers.AutoSize = true;
            this.checkBox_GreenPeppers.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_GreenPeppers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_GreenPeppers.Location = new System.Drawing.Point(219, 223);
            this.checkBox_GreenPeppers.Name = "checkBox_GreenPeppers";
            this.checkBox_GreenPeppers.Size = new System.Drawing.Size(214, 44);
            this.checkBox_GreenPeppers.TabIndex = 2;
            this.checkBox_GreenPeppers.Text = "Green Peppers";
            this.checkBox_GreenPeppers.UseVisualStyleBackColor = true;
            this.checkBox_GreenPeppers.CheckedChanged += new System.EventHandler(this.checkBox_GreenPeppers_CheckedChanged);
            // 
            // checkBox_Olives
            // 
            this.checkBox_Olives.AutoSize = true;
            this.checkBox_Olives.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Olives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_Olives.Location = new System.Drawing.Point(219, 146);
            this.checkBox_Olives.Name = "checkBox_Olives";
            this.checkBox_Olives.Size = new System.Drawing.Size(115, 44);
            this.checkBox_Olives.TabIndex = 1;
            this.checkBox_Olives.Text = "Olives";
            this.checkBox_Olives.UseVisualStyleBackColor = true;
            this.checkBox_Olives.CheckedChanged += new System.EventHandler(this.checkBox_Olives_CheckedChanged);
            // 
            // checkBox_Onion
            // 
            this.checkBox_Onion.AutoSize = true;
            this.checkBox_Onion.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Onion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_Onion.Location = new System.Drawing.Point(219, 72);
            this.checkBox_Onion.Name = "checkBox_Onion";
            this.checkBox_Onion.Size = new System.Drawing.Size(112, 44);
            this.checkBox_Onion.TabIndex = 0;
            this.checkBox_Onion.Text = "Onion";
            this.checkBox_Onion.UseVisualStyleBackColor = true;
            this.checkBox_Onion.CheckedChanged += new System.EventHandler(this.checkBox_Onion_CheckedChanged);
            // 
            // label_Titel
            // 
            this.label_Titel.AutoSize = true;
            this.label_Titel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Titel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Titel.Font = new System.Drawing.Font("Papyrus", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titel.ForeColor = System.Drawing.Color.Fuchsia;
            this.label_Titel.Location = new System.Drawing.Point(226, 9);
            this.label_Titel.Name = "label_Titel";
            this.label_Titel.Size = new System.Drawing.Size(435, 84);
            this.label_Titel.TabIndex = 1;
            this.label_Titel.Text = "Make Your Pizza";
            // 
            // button_ORDER
            // 
            this.button_ORDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_ORDER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ORDER.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ORDER.ForeColor = System.Drawing.Color.Blue;
            this.button_ORDER.Location = new System.Drawing.Point(837, 365);
            this.button_ORDER.Name = "button_ORDER";
            this.button_ORDER.Size = new System.Drawing.Size(167, 57);
            this.button_ORDER.TabIndex = 3;
            this.button_ORDER.Text = "ORDER";
            this.button_ORDER.UseVisualStyleBackColor = false;
            this.button_ORDER.Click += new System.EventHandler(this.button_ORDER_Click);
            // 
            // button_GoBack
            // 
            this.button_GoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_GoBack.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoBack.ForeColor = System.Drawing.Color.Blue;
            this.button_GoBack.Location = new System.Drawing.Point(837, 535);
            this.button_GoBack.Name = "button_GoBack";
            this.button_GoBack.Size = new System.Drawing.Size(167, 57);
            this.button_GoBack.TabIndex = 4;
            this.button_GoBack.Text = "Go Back";
            this.button_GoBack.UseVisualStyleBackColor = false;
            this.button_GoBack.Click += new System.EventHandler(this.button_GoBack_Click);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Price.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_Price.Location = new System.Drawing.Point(848, 238);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(49, 40);
            this.label_Price.TabIndex = 5;
            this.label_Price.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectPizaa.Properties.Resources.images__3__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(915, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1041, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.button_GoBack);
            this.Controls.Add(this.button_ORDER);
            this.Controls.Add(this.label_Titel);
            this.Controls.Add(this.groupBox_CrustType);
            this.Controls.Add(this.groupBox_WhereToEat);
            this.Controls.Add(this.groupBox_Toppins);
            this.Controls.Add(this.groupBox_Size);
            this.Name = "FrOrder";
            this.Text = "FrOrder";
            this.Load += new System.EventHandler(this.FrOrder_Load);
            this.groupBox_Size.ResumeLayout(false);
            this.groupBox_Size.PerformLayout();
            this.groupBox_CrustType.ResumeLayout(false);
            this.groupBox_CrustType.PerformLayout();
            this.groupBox_WhereToEat.ResumeLayout(false);
            this.groupBox_WhereToEat.PerformLayout();
            this.groupBox_Toppins.ResumeLayout(false);
            this.groupBox_Toppins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Size;
        private System.Windows.Forms.RadioButton radioButton_Larg;
        private System.Windows.Forms.RadioButton radioButton_Meduim;
        private System.Windows.Forms.RadioButton radioButton_Small;
        private System.Windows.Forms.GroupBox groupBox_CrustType;
        private System.Windows.Forms.RadioButton radioButton_ThickCrust;
        private System.Windows.Forms.RadioButton radioButton_ThinCrust;
        private System.Windows.Forms.GroupBox groupBox_WhereToEat;
        private System.Windows.Forms.RadioButton radioButton_TakeOut;
        private System.Windows.Forms.RadioButton radioButton_Eatin;
        private System.Windows.Forms.GroupBox groupBox_Toppins;
        private System.Windows.Forms.CheckBox checkBox_Tomatoes;
        private System.Windows.Forms.CheckBox checkBox_Mushrooms;
        private System.Windows.Forms.CheckBox checkBox_ExtraCheese;
        private System.Windows.Forms.CheckBox checkBox_GreenPeppers;
        private System.Windows.Forms.CheckBox checkBox_Olives;
        private System.Windows.Forms.CheckBox checkBox_Onion;
        private System.Windows.Forms.Label label_Titel;
        private System.Windows.Forms.Button button_ORDER;
        private System.Windows.Forms.Button button_GoBack;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}