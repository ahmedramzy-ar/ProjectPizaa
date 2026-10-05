
namespace ProjectPizaa
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_OrderNow = new System.Windows.Forms.Button();
            this.pictureBox_Start = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Modern No. 20", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Exit.Location = new System.Drawing.Point(556, 486);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(346, 56);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_OrderNow
            // 
            this.button_OrderNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_OrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OrderNow.Font = new System.Drawing.Font("Modern No. 20", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OrderNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_OrderNow.Location = new System.Drawing.Point(556, 387);
            this.button_OrderNow.Name = "button_OrderNow";
            this.button_OrderNow.Size = new System.Drawing.Size(346, 62);
            this.button_OrderNow.TabIndex = 2;
            this.button_OrderNow.Text = "Order Now";
            this.button_OrderNow.UseVisualStyleBackColor = false;
            this.button_OrderNow.Click += new System.EventHandler(this.button_OrderNow_Click);
            // 
            // pictureBox_Start
            // 
            this.pictureBox_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Start.Image = global::ProjectPizaa.Properties.Resources.images__13_;
            this.pictureBox_Start.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Start.Name = "pictureBox_Start";
            this.pictureBox_Start.Size = new System.Drawing.Size(902, 554);
            this.pictureBox_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Start.TabIndex = 0;
            this.pictureBox_Start.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.textBox1.Location = new System.Drawing.Point(556, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 358);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_OrderNow);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.pictureBox_Start);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FrmMain";
            this.Text = "PIZAA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Start;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_OrderNow;
        private System.Windows.Forms.TextBox textBox1;
    }
}

