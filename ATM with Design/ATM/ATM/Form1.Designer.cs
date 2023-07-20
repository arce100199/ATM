namespace ATM
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.movingPicture1 = new System.Windows.Forms.PictureBox();
            this.login = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.movingPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movingPicture1
            // 
            this.movingPicture1.BackColor = System.Drawing.Color.Transparent;
            this.movingPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.movingPicture1.Image = ((System.Drawing.Image)(resources.GetObject("movingPicture1.Image")));
            this.movingPicture1.InitialImage = null;
            this.movingPicture1.Location = new System.Drawing.Point(544, 123);
            this.movingPicture1.Margin = new System.Windows.Forms.Padding(4);
            this.movingPicture1.Name = "movingPicture1";
            this.movingPicture1.Size = new System.Drawing.Size(421, 122);
            this.movingPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.movingPicture1.TabIndex = 5;
            this.movingPicture1.TabStop = false;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Transparent;
            this.login.Location = new System.Drawing.Point(493, 462);
            this.login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(194, 185);
            this.login.TabIndex = 2;
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.exit.Location = new System.Drawing.Point(719, 462);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(195, 185);
            this.exit.TabIndex = 4;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(167, 476);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1648, 880);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movingPicture1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AtTheMoment - Home Page";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movingPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox movingPicture1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

