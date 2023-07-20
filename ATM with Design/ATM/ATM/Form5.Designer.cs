
namespace ATM
{
    partial class ViewBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBalance));
            this.balanceLabel = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(651, 173);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(288, 41);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "ACCOUNT BALANCE";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(778, 490);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(148, 140);
            this.returnBtn.TabIndex = 5;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.Transparent;
            this.withdrawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(629, 490);
            this.withdrawBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(148, 140);
            this.withdrawBtn.TabIndex = 6;
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.Transparent;
            this.depositBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(481, 490);
            this.depositBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(148, 140);
            this.depositBtn.TabIndex = 7;
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(169, 406);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // ViewBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1648, 880);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.balanceLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewBalance";
            this.Text = "AtTheMoment - View Balance Page";
            this.Load += new System.EventHandler(this.ViewBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}