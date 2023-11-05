namespace Lab2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNewGoodid = new System.Windows.Forms.Label();
            this.labelGoodsAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addGoodBtn = new System.Windows.Forms.Button();
            this.findGoodsAmountBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.goodsGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new Lab2.shopDataSet();
            this.shopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsGroupsTableAdapter = new Lab2.shopDataSetTableAdapters.GoodsGroupsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(20, 311);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(349, 52);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Обновить каталог продуктов";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(512, 543);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(382, 28);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(512, 73);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 416);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Molot", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(507, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Catalog of available products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewGoodid
            // 
            this.labelNewGoodid.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewGoodid.Location = new System.Drawing.Point(13, 429);
            this.labelNewGoodid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewGoodid.Name = "labelNewGoodid";
            this.labelNewGoodid.Size = new System.Drawing.Size(276, 46);
            this.labelNewGoodid.TabIndex = 4;
            this.labelNewGoodid.Text = "Новому товару присвоен  ID: ";
            this.labelNewGoodid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGoodsAmount
            // 
            this.labelGoodsAmount.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGoodsAmount.Location = new System.Drawing.Point(13, 475);
            this.labelGoodsAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoodsAmount.Name = "labelGoodsAmount";
            this.labelGoodsAmount.Size = new System.Drawing.Size(218, 29);
            this.labelGoodsAmount.TabIndex = 5;
            this.labelGoodsAmount.Text = "Количество товаров: ";
            this.labelGoodsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование товара:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Категория товара:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addGoodBtn
            // 
            this.addGoodBtn.Location = new System.Drawing.Point(20, 267);
            this.addGoodBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addGoodBtn.Name = "addGoodBtn";
            this.addGoodBtn.Size = new System.Drawing.Size(349, 36);
            this.addGoodBtn.TabIndex = 10;
            this.addGoodBtn.Text = "Добавить";
            this.addGoodBtn.UseVisualStyleBackColor = true;
            this.addGoodBtn.Click += new System.EventHandler(this.addGoodBtn_Click);
            // 
            // findGoodsAmountBtn
            // 
            this.findGoodsAmountBtn.Location = new System.Drawing.Point(512, 504);
            this.findGoodsAmountBtn.Margin = new System.Windows.Forms.Padding(4);
            this.findGoodsAmountBtn.Name = "findGoodsAmountBtn";
            this.findGoodsAmountBtn.Size = new System.Drawing.Size(382, 30);
            this.findGoodsAmountBtn.TabIndex = 11;
            this.findGoodsAmountBtn.Text = "Определить количество товаров";
            this.findGoodsAmountBtn.UseVisualStyleBackColor = true;
            this.findGoodsAmountBtn.Click += new System.EventHandler(this.findGoodsAmountBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(20, 513);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(211, 48);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Удалить выбранный элемент";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 221);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 13;
            // 
            // goodsGroupsBindingSource
            // 
            this.goodsGroupsBindingSource.DataMember = "GoodsGroups";
            this.goodsGroupsBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopDataSetBindingSource
            // 
            this.shopDataSetBindingSource.DataSource = this.shopDataSet;
            this.shopDataSetBindingSource.Position = 0;
            // 
            // goodsGroupsTableAdapter
            // 
            this.goodsGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 58);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сhanges section";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Information";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(168)))));
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 49);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grey_Store";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(168)))));
            this.button1.Location = new System.Drawing.Point(197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(168)))));
            this.button2.Location = new System.Drawing.Point(197, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Войти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 715);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 26);
            this.button3.TabIndex = 19;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(52, 719);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Строка поиска";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(197, 719);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch.TabIndex = 21;
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(150)))), ((int)(((byte)(186)))));
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.ItemHeight = 16;
            this.listBoxSearchResults.Location = new System.Drawing.Point(502, 637);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.Size = new System.Drawing.Size(403, 180);
            this.listBoxSearchResults.TabIndex = 22;
            this.listBoxSearchResults.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchResults_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(375, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 60);
            this.label8.TabIndex = 23;
            this.label8.Text = "1.Отечественные  2. Импортные ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(375, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "*категории";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(962, 827);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxSearchResults);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.findGoodsAmountBtn);
            this.Controls.Add(this.addGoodBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGoodsAmount);
            this.Controls.Add(this.labelNewGoodid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(25, 25);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Grey_Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNewGoodid;
        private System.Windows.Forms.Label labelGoodsAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addGoodBtn;
        private System.Windows.Forms.Button findGoodsAmountBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource shopDataSetBindingSource;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource goodsGroupsBindingSource;
        private shopDataSetTableAdapters.GoodsGroupsTableAdapter goodsGroupsTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

