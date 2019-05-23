namespace WindowsForm
{
    partial class PrintPaymentForm
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
            this.actualQuota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.chooseUidUsername = new System.Windows.Forms.ComboBox();
            this.validate = new System.Windows.Forms.Button();
            this.l_quota = new System.Windows.Forms.Label();
            this.quota = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // actualQuota
            // 
            this.actualQuota.Location = new System.Drawing.Point(159, 167);
            this.actualQuota.Name = "actualQuota";
            this.actualQuota.Size = new System.Drawing.Size(80, 17);
            this.actualQuota.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "actual quota:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(164, 224);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 27);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // chooseUidUsername
            // 
            this.chooseUidUsername.FormattingEnabled = true;
            this.chooseUidUsername.Items.AddRange(new object[] {
            "Username",
            "UserUID"});
            this.chooseUidUsername.Location = new System.Drawing.Point(67, 110);
            this.chooseUidUsername.Name = "chooseUidUsername";
            this.chooseUidUsername.Size = new System.Drawing.Size(97, 24);
            this.chooseUidUsername.TabIndex = 6;
            this.chooseUidUsername.SelectedIndexChanged += new System.EventHandler(this.chooseUidUsername_SelectedIndexChanged);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(256, 224);
            this.validate.Margin = new System.Windows.Forms.Padding(4);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(100, 27);
            this.validate.TabIndex = 0;
            this.validate.Text = "add credit";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // l_quota
            // 
            this.l_quota.AutoSize = true;
            this.l_quota.Location = new System.Drawing.Point(252, 167);
            this.l_quota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_quota.Name = "l_quota";
            this.l_quota.Size = new System.Drawing.Size(49, 17);
            this.l_quota.TabIndex = 4;
            this.l_quota.Text = "Credit:";
            // 
            // quota
            // 
            this.quota.Location = new System.Drawing.Point(305, 164);
            this.quota.Margin = new System.Windows.Forms.Padding(4);
            this.quota.Name = "quota";
            this.quota.Size = new System.Drawing.Size(51, 22);
            this.quota.TabIndex = 2;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(174, 110);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(182, 22);
            this.user.TabIndex = 1;
            this.user.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForm.Properties.Resources.téléchargement;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PrintPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(388, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actualQuota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.chooseUidUsername);
            this.Controls.Add(this.l_quota);
            this.Controls.Add(this.quota);
            this.Controls.Add(this.user);
            this.Controls.Add(this.validate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintPaymentForm";
            this.Text = "Print Payment with REST";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actualQuota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.ComboBox chooseUidUsername;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Label l_quota;
        private System.Windows.Forms.TextBox quota;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

