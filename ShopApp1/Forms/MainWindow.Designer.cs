namespace ShopApp1.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountGood = new System.Windows.Forms.Label();
            this.ComboSort = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameGood = new System.Windows.Forms.TextBox();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureGood = new System.Windows.Forms.PictureBox();
            this.labelNameGood = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopApp1.Properties.Resources.computer1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 129);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlueViolet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог товаров";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1137, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите наименования товара для поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите категорию";
            // 
            // labelCountGood
            // 
            this.labelCountGood.AutoSize = true;
            this.labelCountGood.Location = new System.Drawing.Point(12, 258);
            this.labelCountGood.Name = "labelCountGood";
            this.labelCountGood.Size = new System.Drawing.Size(107, 13);
            this.labelCountGood.TabIndex = 6;
            this.labelCountGood.Text = "Результат запроса:";
            // 
            // ComboSort
            // 
            this.ComboSort.FormattingEnabled = true;
            this.ComboSort.Items.AddRange(new object[] {
            "По возрастанию цены",
            "По убыванию цены"});
            this.ComboSort.Location = new System.Drawing.Point(494, 180);
            this.ComboSort.Name = "ComboSort";
            this.ComboSort.Size = new System.Drawing.Size(306, 21);
            this.ComboSort.TabIndex = 7;
            this.ComboSort.SelectedIndexChanged += new System.EventHandler(this.ComboSort_SelectedIndexChanged);
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "По возрастанию цены",
            "По убыванию цены"});
            this.comboCategory.Location = new System.Drawing.Point(150, 177);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(222, 21);
            this.comboCategory.TabIndex = 8;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сортировка по";
            // 
            // txtNameGood
            // 
            this.txtNameGood.Location = new System.Drawing.Point(243, 135);
            this.txtNameGood.Name = "txtNameGood";
            this.txtNameGood.Size = new System.Drawing.Size(245, 20);
            this.txtNameGood.TabIndex = 10;
            this.txtNameGood.TextChanged += new System.EventHandler(this.txtNameGood_TextChanged);
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Location = new System.Drawing.Point(12, 274);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.Size = new System.Drawing.Size(984, 258);
            this.dgvGoods.TabIndex = 11;
            this.dgvGoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellClick);
            this.dgvGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellContentClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripName,
            this.stripRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripName
            // 
            this.stripName.Name = "stripName";
            this.stripName.Size = new System.Drawing.Size(118, 17);
            this.stripName.Text = "toolStripStatusLabel1";
            // 
            // stripRole
            // 
            this.stripRole.Name = "stripRole";
            this.stripRole.Size = new System.Drawing.Size(118, 17);
            this.stripRole.Text = "toolStripStatusLabel1";
            // 
            // pictureGood
            // 
            this.pictureGood.Location = new System.Drawing.Point(1012, 274);
            this.pictureGood.Name = "pictureGood";
            this.pictureGood.Size = new System.Drawing.Size(233, 258);
            this.pictureGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGood.TabIndex = 13;
            this.pictureGood.TabStop = false;
            // 
            // labelNameGood
            // 
            this.labelNameGood.AutoSize = true;
            this.labelNameGood.Location = new System.Drawing.Point(1009, 535);
            this.labelNameGood.Name = "labelNameGood";
            this.labelNameGood.Size = new System.Drawing.Size(35, 13);
            this.labelNameGood.TabIndex = 14;
            this.labelNameGood.Text = "label4";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(1067, 535);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "label4";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 680);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelNameGood);
            this.Controls.Add(this.pictureGood);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvGoods);
            this.Controls.Add(this.txtNameGood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.ComboSort);
            this.Controls.Add(this.labelCountGood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountGood;
        private System.Windows.Forms.ComboBox ComboSort;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameGood;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripName;
        private System.Windows.Forms.ToolStripStatusLabel stripRole;
        private System.Windows.Forms.PictureBox pictureGood;
        private System.Windows.Forms.Label labelNameGood;
        private System.Windows.Forms.Label labelPrice;
    }
}