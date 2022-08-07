namespace TestShopTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GiftCardsBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.ShopsBtn = new System.Windows.Forms.Button();
            this.ProductsInShopsBtn = new System.Windows.Forms.Button();
            this.GiftCardProductsBtn = new System.Windows.Forms.Button();
            this.CountCardsPeriodBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NominalSumsPeriodBtn = new System.Windows.Forms.Button();
            this.LeftSumsPeriod = new System.Windows.Forms.Button();
            this.LeftSumCardBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductsBoughtBtn = new System.Windows.Forms.Button();
            this.CountCardsUsedInShopBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 515);
            this.dataGridView1.TabIndex = 2;
            // 
            // GiftCardsBtn
            // 
            this.GiftCardsBtn.Location = new System.Drawing.Point(1134, 6);
            this.GiftCardsBtn.Name = "GiftCardsBtn";
            this.GiftCardsBtn.Size = new System.Drawing.Size(170, 23);
            this.GiftCardsBtn.TabIndex = 3;
            this.GiftCardsBtn.Text = "Подарочные карты";
            this.GiftCardsBtn.UseVisualStyleBackColor = true;
            this.GiftCardsBtn.Click += new System.EventHandler(this.GiftCardsBtn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Location = new System.Drawing.Point(1134, 35);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(170, 23);
            this.ProductsBtn.TabIndex = 4;
            this.ProductsBtn.Text = "Товары";
            this.ProductsBtn.UseVisualStyleBackColor = true;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // ShopsBtn
            // 
            this.ShopsBtn.Location = new System.Drawing.Point(1134, 64);
            this.ShopsBtn.Name = "ShopsBtn";
            this.ShopsBtn.Size = new System.Drawing.Size(170, 23);
            this.ShopsBtn.TabIndex = 5;
            this.ShopsBtn.Text = "Магазины";
            this.ShopsBtn.UseVisualStyleBackColor = true;
            this.ShopsBtn.Click += new System.EventHandler(this.ShopsBtn_Click);
            // 
            // ProductsInShopsBtn
            // 
            this.ProductsInShopsBtn.Location = new System.Drawing.Point(1134, 93);
            this.ProductsInShopsBtn.Name = "ProductsInShopsBtn";
            this.ProductsInShopsBtn.Size = new System.Drawing.Size(170, 23);
            this.ProductsInShopsBtn.TabIndex = 6;
            this.ProductsInShopsBtn.Text = "Товары в магазине";
            this.ProductsInShopsBtn.UseVisualStyleBackColor = true;
            this.ProductsInShopsBtn.Click += new System.EventHandler(this.ProductsInShopsBtn_Click);
            // 
            // GiftCardProductsBtn
            // 
            this.GiftCardProductsBtn.Location = new System.Drawing.Point(1134, 122);
            this.GiftCardProductsBtn.Name = "GiftCardProductsBtn";
            this.GiftCardProductsBtn.Size = new System.Drawing.Size(170, 40);
            this.GiftCardProductsBtn.TabIndex = 7;
            this.GiftCardProductsBtn.Text = "Товары купленные на карту(-ы)";
            this.GiftCardProductsBtn.UseVisualStyleBackColor = true;
            this.GiftCardProductsBtn.Click += new System.EventHandler(this.GiftCardProductsBtn_Click);
            // 
            // CountCardsPeriodBtn
            // 
            this.CountCardsPeriodBtn.Location = new System.Drawing.Point(1134, 225);
            this.CountCardsPeriodBtn.Name = "CountCardsPeriodBtn";
            this.CountCardsPeriodBtn.Size = new System.Drawing.Size(170, 38);
            this.CountCardsPeriodBtn.TabIndex = 8;
            this.CountCardsPeriodBtn.Text = "Количество карт за выбранный период";
            this.CountCardsPeriodBtn.UseVisualStyleBackColor = true;
            this.CountCardsPeriodBtn.Click += new System.EventHandler(this.CountCardsPeriodBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1174, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1174, 197);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1137, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1139, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "до";
            // 
            // NominalSumsPeriodBtn
            // 
            this.NominalSumsPeriodBtn.Location = new System.Drawing.Point(1134, 269);
            this.NominalSumsPeriodBtn.Name = "NominalSumsPeriodBtn";
            this.NominalSumsPeriodBtn.Size = new System.Drawing.Size(170, 39);
            this.NominalSumsPeriodBtn.TabIndex = 13;
            this.NominalSumsPeriodBtn.Text = "Номинальные суммы карт за выбранный период";
            this.NominalSumsPeriodBtn.UseVisualStyleBackColor = true;
            this.NominalSumsPeriodBtn.Click += new System.EventHandler(this.NominalSumsPeriodBtn_Click);
            // 
            // LeftSumsPeriod
            // 
            this.LeftSumsPeriod.Location = new System.Drawing.Point(1134, 314);
            this.LeftSumsPeriod.Name = "LeftSumsPeriod";
            this.LeftSumsPeriod.Size = new System.Drawing.Size(170, 41);
            this.LeftSumsPeriod.TabIndex = 14;
            this.LeftSumsPeriod.Text = "Сгоревшие суммы за период";
            this.LeftSumsPeriod.UseVisualStyleBackColor = true;
            this.LeftSumsPeriod.Click += new System.EventHandler(this.LeftSumsPeriod_Click);
            // 
            // LeftSumCardBtn
            // 
            this.LeftSumCardBtn.Location = new System.Drawing.Point(1134, 410);
            this.LeftSumCardBtn.Name = "LeftSumCardBtn";
            this.LeftSumCardBtn.Size = new System.Drawing.Size(170, 23);
            this.LeftSumCardBtn.TabIndex = 15;
            this.LeftSumCardBtn.Text = "Сгоревшая сумма по карте";
            this.LeftSumCardBtn.UseVisualStyleBackColor = true;
            this.LeftSumCardBtn.Click += new System.EventHandler(this.LeftSumCardBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1134, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1154, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Идентификатор карты";
            // 
            // ProductsBoughtBtn
            // 
            this.ProductsBoughtBtn.Location = new System.Drawing.Point(1134, 439);
            this.ProductsBoughtBtn.Name = "ProductsBoughtBtn";
            this.ProductsBoughtBtn.Size = new System.Drawing.Size(170, 23);
            this.ProductsBoughtBtn.TabIndex = 18;
            this.ProductsBoughtBtn.Text = "Товары оплаченные картой";
            this.ProductsBoughtBtn.UseVisualStyleBackColor = true;
            this.ProductsBoughtBtn.Click += new System.EventHandler(this.ProductsBoughtBtn_Click);
            // 
            // CountCardsUsedInShopBtn
            // 
            this.CountCardsUsedInShopBtn.Location = new System.Drawing.Point(1134, 468);
            this.CountCardsUsedInShopBtn.Name = "CountCardsUsedInShopBtn";
            this.CountCardsUsedInShopBtn.Size = new System.Drawing.Size(170, 53);
            this.CountCardsUsedInShopBtn.TabIndex = 18;
            this.CountCardsUsedInShopBtn.Text = "Количество использованных карт в магазине";
            this.CountCardsUsedInShopBtn.UseVisualStyleBackColor = true;
            this.CountCardsUsedInShopBtn.Click += new System.EventHandler(this.CountCardsUsedInShopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 526);
            this.Controls.Add(this.CountCardsUsedInShopBtn);
            this.Controls.Add(this.ProductsBoughtBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LeftSumCardBtn);
            this.Controls.Add(this.LeftSumsPeriod);
            this.Controls.Add(this.NominalSumsPeriodBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CountCardsPeriodBtn);
            this.Controls.Add(this.GiftCardProductsBtn);
            this.Controls.Add(this.ProductsInShopsBtn);
            this.Controls.Add(this.ShopsBtn);
            this.Controls.Add(this.ProductsBtn);
            this.Controls.Add(this.GiftCardsBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private Button GiftCardsBtn;
        private Button ProductsBtn;
        private Button ShopsBtn;
        private Button ProductsInShopsBtn;
        private Button GiftCardProductsBtn;
        private Button CountCardsPeriodBtn;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Button NominalSumsPeriodBtn;
        private Button LeftSumsPeriod;
        private Button LeftSumCardBtn;
        private TextBox textBox1;
        private Label label3;
        private Button ProductsBoughtBtn;
        private Button CountCardsUsedInShopBtn;
    }
}