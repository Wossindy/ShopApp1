namespace ShopApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxVisible = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVisible
            // 
            this.pictureBoxVisible.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBoxVisible.Image = global::ShopApp1.Properties.Resources.computer1;
            this.pictureBoxVisible.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVisible.Name = "pictureBoxVisible";
            this.pictureBoxVisible.Size = new System.Drawing.Size(134, 128);
            this.pictureBoxVisible.TabIndex = 0;
            this.pictureBoxVisible.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(277, 54);
            this.lb1.Name = "lb1";
            this.lb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb1.Size = new System.Drawing.Size(85, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Вход в систему";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(122, 143);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(285, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(285, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 143);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Логин";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 179);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(122, 221);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.pictureBoxVisible);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 120);
            this.panel1.TabIndex = 8;
            // 
            // pB1
            // 
            this.pB1.Image = global::ShopApp1.Properties.Resources.hide_iqjah8jueuim_512;
            this.pB1.Location = new System.Drawing.Point(413, 169);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(39, 40);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB1.TabIndex = 9;
            this.pB1.TabStop = false;
            this.pB1.Click += new System.EventHandler(this.pB1_Click);
            // 
            // pB2
            // 
            this.pB2.Image = global::ShopApp1.Properties.Resources.password_fhztd74bj9tg_512;
            this.pB2.Location = new System.Drawing.Point(413, 169);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(39, 40);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB2.TabIndex = 10;
            this.pB2.TabStop = false;
            this.pB2.Visible = false;
            this.pB2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 270);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVisible;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.PictureBox pB2;
    }
}

