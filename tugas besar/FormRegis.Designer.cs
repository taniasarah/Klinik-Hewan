namespace tugas_besar
{
    partial class FormRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegis));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NamaRgs = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsernameRgs = new System.Windows.Forms.TextBox();
            this.PassRgs = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OkRgs = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(186, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Location = new System.Drawing.Point(125, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 3);
            this.panel1.TabIndex = 9;
            // 
            // NamaRgs
            // 
            this.NamaRgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NamaRgs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaRgs.HideSelection = false;
            this.NamaRgs.Location = new System.Drawing.Point(125, 193);
            this.NamaRgs.Name = "NamaRgs";
            this.NamaRgs.Size = new System.Drawing.Size(255, 20);
            this.NamaRgs.TabIndex = 8;
            this.NamaRgs.TabStop = false;
            this.NamaRgs.Text = "Nama";
            this.NamaRgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NamaRgs.TextChanged += new System.EventHandler(this.NamaRgs_TextChanged);
            this.NamaRgs.Enter += new System.EventHandler(this.NamaRgs_Enter);
            this.NamaRgs.Leave += new System.EventHandler(this.NamaRgs_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Location = new System.Drawing.Point(123, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 3);
            this.panel2.TabIndex = 29;
            // 
            // UsernameRgs
            // 
            this.UsernameRgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameRgs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameRgs.HideSelection = false;
            this.UsernameRgs.Location = new System.Drawing.Point(123, 247);
            this.UsernameRgs.Name = "UsernameRgs";
            this.UsernameRgs.Size = new System.Drawing.Size(255, 20);
            this.UsernameRgs.TabIndex = 28;
            this.UsernameRgs.TabStop = false;
            this.UsernameRgs.Text = "Username";
            this.UsernameRgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameRgs.TextChanged += new System.EventHandler(this.UsernameRgs_TextChanged);
            this.UsernameRgs.Enter += new System.EventHandler(this.UsernameRgs_Enter);
            this.UsernameRgs.Leave += new System.EventHandler(this.UsernameRgs_Leave);
            // 
            // PassRgs
            // 
            this.PassRgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassRgs.Font = new System.Drawing.Font("Arial", 10.2F);
            this.PassRgs.Location = new System.Drawing.Point(123, 309);
            this.PassRgs.Name = "PassRgs";
            this.PassRgs.Size = new System.Drawing.Size(255, 20);
            this.PassRgs.TabIndex = 30;
            this.PassRgs.Text = "Password";
            this.PassRgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassRgs.TextChanged += new System.EventHandler(this.PassRgs_TextChanged);
            this.PassRgs.Enter += new System.EventHandler(this.PassRgs_Enter);
            this.PassRgs.Leave += new System.EventHandler(this.PassRgs_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GreenYellow;
            this.panel3.Location = new System.Drawing.Point(123, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 3);
            this.panel3.TabIndex = 31;
            // 
            // OkRgs
            // 
            this.OkRgs.BackColor = System.Drawing.Color.Black;
            this.OkRgs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OkRgs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OkRgs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.OkRgs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkRgs.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.OkRgs.ForeColor = System.Drawing.Color.YellowGreen;
            this.OkRgs.Location = new System.Drawing.Point(186, 378);
            this.OkRgs.Name = "OkRgs";
            this.OkRgs.Size = new System.Drawing.Size(123, 32);
            this.OkRgs.TabIndex = 32;
            this.OkRgs.Text = "🐾OK🐾";
            this.OkRgs.UseVisualStyleBackColor = false;
            this.OkRgs.Click += new System.EventHandler(this.OkRgs_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.GreenYellow;
            this.linkLabel1.Location = new System.Drawing.Point(391, 608);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 19);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "🐾Kembali";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(184, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "PAWSPITAL";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.YellowGreen;
            this.button3.Location = new System.Drawing.Point(402, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 30);
            this.button3.TabIndex = 41;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(430, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 30);
            this.button2.TabIndex = 40;
            this.button2.Text = "☐";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(457, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 30);
            this.button4.TabIndex = 39;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.OkRgs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PassRgs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsernameRgs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NamaRgs);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegis";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormRegis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NamaRgs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox UsernameRgs;
        private System.Windows.Forms.TextBox PassRgs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OkRgs;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}