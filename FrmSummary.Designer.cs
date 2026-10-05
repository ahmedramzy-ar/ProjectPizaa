
namespace ProjectPizaa
{
    partial class FrmSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummary));
            this.textBox_Su = new System.Windows.Forms.TextBox();
            this.label_DateAndTime = new System.Windows.Forms.Label();
            this.label_ShowTime = new System.Windows.Forms.Label();
            this.label_NumberClient = new System.Windows.Forms.Label();
            this.label_ShowNumberClient = new System.Windows.Forms.Label();
            this.button_goback = new System.Windows.Forms.Button();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_ShowSize = new System.Windows.Forms.Label();
            this.label_ShowCrustType = new System.Windows.Forms.Label();
            this.label_ShowCrust = new System.Windows.Forms.Label();
            this.label_Where = new System.Windows.Forms.Label();
            this.label_ShowWhareEat = new System.Windows.Forms.Label();
            this.label_Toppins = new System.Windows.Forms.Label();
            this.label_ShowTopins = new System.Windows.Forms.Label();
            this.label_ShowTitel = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_ShowTotal = new System.Windows.Forms.Label();
            this.button_SureOrder = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox_ImageSu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Su
            // 
            this.textBox_Su.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox_Su.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_Su.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Su.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox_Su.Location = new System.Drawing.Point(0, 0);
            this.textBox_Su.Multiline = true;
            this.textBox_Su.Name = "textBox_Su";
            this.textBox_Su.ReadOnly = true;
            this.textBox_Su.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Su.Size = new System.Drawing.Size(956, 666);
            this.textBox_Su.TabIndex = 0;
            this.textBox_Su.TextChanged += new System.EventHandler(this.textBox_Su_TextChanged);
            // 
            // label_DateAndTime
            // 
            this.label_DateAndTime.AutoSize = true;
            this.label_DateAndTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_DateAndTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_DateAndTime.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateAndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_DateAndTime.Location = new System.Drawing.Point(12, 101);
            this.label_DateAndTime.Name = "label_DateAndTime";
            this.label_DateAndTime.Size = new System.Drawing.Size(219, 40);
            this.label_DateAndTime.TabIndex = 1;
            this.label_DateAndTime.Text = "Date And Time:";
            // 
            // label_ShowTime
            // 
            this.label_ShowTime.AutoSize = true;
            this.label_ShowTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowTime.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowTime.Location = new System.Drawing.Point(264, 101);
            this.label_ShowTime.Name = "label_ShowTime";
            this.label_ShowTime.Size = new System.Drawing.Size(65, 40);
            this.label_ShowTime.TabIndex = 2;
            this.label_ShowTime.Text = "000";
            // 
            // label_NumberClient
            // 
            this.label_NumberClient.AutoSize = true;
            this.label_NumberClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_NumberClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_NumberClient.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_NumberClient.Location = new System.Drawing.Point(12, 174);
            this.label_NumberClient.Name = "label_NumberClient";
            this.label_NumberClient.Size = new System.Drawing.Size(200, 40);
            this.label_NumberClient.TabIndex = 3;
            this.label_NumberClient.Text = "Number Client";
            // 
            // label_ShowNumberClient
            // 
            this.label_ShowNumberClient.AutoSize = true;
            this.label_ShowNumberClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowNumberClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowNumberClient.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowNumberClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowNumberClient.Location = new System.Drawing.Point(264, 174);
            this.label_ShowNumberClient.Name = "label_ShowNumberClient";
            this.label_ShowNumberClient.Size = new System.Drawing.Size(81, 40);
            this.label_ShowNumberClient.TabIndex = 4;
            this.label_ShowNumberClient.Text = "0000";
            // 
            // button_goback
            // 
            this.button_goback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_goback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_goback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_goback.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_goback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_goback.Location = new System.Drawing.Point(640, 547);
            this.button_goback.Name = "button_goback";
            this.button_goback.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_goback.Size = new System.Drawing.Size(228, 59);
            this.button_goback.TabIndex = 5;
            this.button_goback.Text = "Go Back";
            this.button_goback.UseVisualStyleBackColor = false;
            this.button_goback.Click += new System.EventHandler(this.button_goback_Click);
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Size.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Size.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Size.Location = new System.Drawing.Point(12, 240);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(80, 40);
            this.label_Size.TabIndex = 6;
            this.label_Size.Text = "Size:";
            // 
            // label_ShowSize
            // 
            this.label_ShowSize.AutoSize = true;
            this.label_ShowSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowSize.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowSize.Location = new System.Drawing.Point(264, 240);
            this.label_ShowSize.Name = "label_ShowSize";
            this.label_ShowSize.Size = new System.Drawing.Size(57, 40);
            this.label_ShowSize.TabIndex = 7;
            this.label_ShowSize.Text = "----";
            // 
            // label_ShowCrustType
            // 
            this.label_ShowCrustType.AutoSize = true;
            this.label_ShowCrustType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowCrustType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowCrustType.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowCrustType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowCrustType.Location = new System.Drawing.Point(12, 314);
            this.label_ShowCrustType.Name = "label_ShowCrustType";
            this.label_ShowCrustType.Size = new System.Drawing.Size(164, 40);
            this.label_ShowCrustType.TabIndex = 8;
            this.label_ShowCrustType.Text = "Crust Type:";
            // 
            // label_ShowCrust
            // 
            this.label_ShowCrust.AutoSize = true;
            this.label_ShowCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowCrust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowCrust.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowCrust.Location = new System.Drawing.Point(264, 314);
            this.label_ShowCrust.Name = "label_ShowCrust";
            this.label_ShowCrust.Size = new System.Drawing.Size(57, 40);
            this.label_ShowCrust.TabIndex = 9;
            this.label_ShowCrust.Text = "----";
            // 
            // label_Where
            // 
            this.label_Where.AutoSize = true;
            this.label_Where.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Where.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Where.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Where.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Where.Location = new System.Drawing.Point(12, 392);
            this.label_Where.Name = "label_Where";
            this.label_Where.Size = new System.Drawing.Size(204, 40);
            this.label_Where.TabIndex = 10;
            this.label_Where.Text = "Where To Eat:";
            // 
            // label_ShowWhareEat
            // 
            this.label_ShowWhareEat.AutoSize = true;
            this.label_ShowWhareEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowWhareEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowWhareEat.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowWhareEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowWhareEat.Location = new System.Drawing.Point(264, 392);
            this.label_ShowWhareEat.Name = "label_ShowWhareEat";
            this.label_ShowWhareEat.Size = new System.Drawing.Size(57, 40);
            this.label_ShowWhareEat.TabIndex = 11;
            this.label_ShowWhareEat.Text = "----";
            // 
            // label_Toppins
            // 
            this.label_Toppins.AutoSize = true;
            this.label_Toppins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Toppins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Toppins.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Toppins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Toppins.Location = new System.Drawing.Point(8, 466);
            this.label_Toppins.Name = "label_Toppins";
            this.label_Toppins.Size = new System.Drawing.Size(128, 40);
            this.label_Toppins.TabIndex = 12;
            this.label_Toppins.Text = "Toppins:";
            // 
            // label_ShowTopins
            // 
            this.label_ShowTopins.AutoSize = true;
            this.label_ShowTopins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowTopins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowTopins.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTopins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowTopins.Location = new System.Drawing.Point(264, 466);
            this.label_ShowTopins.Name = "label_ShowTopins";
            this.label_ShowTopins.Size = new System.Drawing.Size(57, 40);
            this.label_ShowTopins.TabIndex = 13;
            this.label_ShowTopins.Text = "----";
            // 
            // label_ShowTitel
            // 
            this.label_ShowTitel.AutoSize = true;
            this.label_ShowTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowTitel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowTitel.Font = new System.Drawing.Font("Pristina", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowTitel.Location = new System.Drawing.Point(256, 0);
            this.label_ShowTitel.Name = "label_ShowTitel";
            this.label_ShowTitel.Size = new System.Drawing.Size(415, 88);
            this.label_ShowTitel.TabIndex = 14;
            this.label_ShowTitel.Text = "Order Summary";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_Total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Total.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Total.Location = new System.Drawing.Point(12, 585);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(85, 40);
            this.label_Total.TabIndex = 15;
            this.label_Total.Text = "Total";
            // 
            // label_ShowTotal
            // 
            this.label_ShowTotal.AutoSize = true;
            this.label_ShowTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_ShowTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ShowTotal.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ShowTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_ShowTotal.Location = new System.Drawing.Point(264, 585);
            this.label_ShowTotal.Name = "label_ShowTotal";
            this.label_ShowTotal.Size = new System.Drawing.Size(57, 40);
            this.label_ShowTotal.TabIndex = 16;
            this.label_ShowTotal.Text = "----";
            // 
            // button_SureOrder
            // 
            this.button_SureOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_SureOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SureOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SureOrder.Font = new System.Drawing.Font("Monotype Corsiva", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SureOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_SureOrder.Location = new System.Drawing.Point(640, 466);
            this.button_SureOrder.Name = "button_SureOrder";
            this.button_SureOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_SureOrder.Size = new System.Drawing.Size(228, 64);
            this.button_SureOrder.TabIndex = 17;
            this.button_SureOrder.Text = "ConFirm Order";
            this.button_SureOrder.UseVisualStyleBackColor = false;
            this.button_SureOrder.Click += new System.EventHandler(this.button_SureOrder_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox_ImageSu
            // 
            this.pictureBox_ImageSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox_ImageSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_ImageSu.Image = global::ProjectPizaa.Properties.Resources.images__16__removebg_preview;
            this.pictureBox_ImageSu.Location = new System.Drawing.Point(505, 101);
            this.pictureBox_ImageSu.Name = "pictureBox_ImageSu";
            this.pictureBox_ImageSu.Size = new System.Drawing.Size(414, 331);
            this.pictureBox_ImageSu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ImageSu.TabIndex = 18;
            this.pictureBox_ImageSu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = global::ProjectPizaa.Properties.Resources.images__3__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(347, 576);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_ImageSu);
            this.Controls.Add(this.button_SureOrder);
            this.Controls.Add(this.label_ShowTotal);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_ShowTitel);
            this.Controls.Add(this.label_ShowTopins);
            this.Controls.Add(this.label_Toppins);
            this.Controls.Add(this.label_ShowWhareEat);
            this.Controls.Add(this.label_Where);
            this.Controls.Add(this.label_ShowCrust);
            this.Controls.Add(this.label_ShowCrustType);
            this.Controls.Add(this.label_ShowSize);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.button_goback);
            this.Controls.Add(this.label_ShowNumberClient);
            this.Controls.Add(this.label_NumberClient);
            this.Controls.Add(this.label_ShowTime);
            this.Controls.Add(this.label_DateAndTime);
            this.Controls.Add(this.textBox_Su);
            this.Name = "FrmSummary";
            this.Text = "FrmSummary";
            this.Load += new System.EventHandler(this.FrmSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Su;
        private System.Windows.Forms.Label label_DateAndTime;
        private System.Windows.Forms.Label label_ShowTime;
        private System.Windows.Forms.Label label_NumberClient;
        private System.Windows.Forms.Label label_ShowNumberClient;
        private System.Windows.Forms.Button button_goback;
        private System.Windows.Forms.Label label_Size;
        public System.Windows.Forms.Label label_ShowSize;
        private System.Windows.Forms.Label label_ShowCrustType;
        public System.Windows.Forms.Label label_ShowCrust;
        private System.Windows.Forms.Label label_Where;
        public System.Windows.Forms.Label label_ShowWhareEat;
        private System.Windows.Forms.Label label_Toppins;
        public System.Windows.Forms.Label label_ShowTopins;
        private System.Windows.Forms.Label label_ShowTitel;
        private System.Windows.Forms.Label label_Total;
        public System.Windows.Forms.Label label_ShowTotal;
        private System.Windows.Forms.Button button_SureOrder;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox_ImageSu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}