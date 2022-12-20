namespace hotel
{
    partial class fsearch
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.class1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(321, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 679);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphongDataGridViewTextBoxColumn,
            this.phongDataGridViewTextBoxColumn,
            this.loaiphongDataGridViewTextBoxColumn,
            this.dongiaDataGridViewTextBoxColumn,
            this.tinhtrangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.class1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(923, 639);
            this.dataGridView1.TabIndex = 0;
            // 
            // maphongDataGridViewTextBoxColumn
            // 
            this.maphongDataGridViewTextBoxColumn.DataPropertyName = "maphong";
            this.maphongDataGridViewTextBoxColumn.HeaderText = "Mã Phòng";
            this.maphongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maphongDataGridViewTextBoxColumn.Name = "maphongDataGridViewTextBoxColumn";
            this.maphongDataGridViewTextBoxColumn.Width = 150;
            // 
            // phongDataGridViewTextBoxColumn
            // 
            this.phongDataGridViewTextBoxColumn.DataPropertyName = "phong";
            this.phongDataGridViewTextBoxColumn.HeaderText = "Phòng";
            this.phongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phongDataGridViewTextBoxColumn.Name = "phongDataGridViewTextBoxColumn";
            this.phongDataGridViewTextBoxColumn.Width = 150;
            // 
            // loaiphongDataGridViewTextBoxColumn
            // 
            this.loaiphongDataGridViewTextBoxColumn.DataPropertyName = "loaiphong";
            this.loaiphongDataGridViewTextBoxColumn.HeaderText = "Loại Phòng";
            this.loaiphongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiphongDataGridViewTextBoxColumn.Name = "loaiphongDataGridViewTextBoxColumn";
            this.loaiphongDataGridViewTextBoxColumn.Width = 200;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            this.dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            this.dongiaDataGridViewTextBoxColumn.HeaderText = "Đơn Giá";
            this.dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            this.dongiaDataGridViewTextBoxColumn.Width = 200;
            // 
            // tinhtrangDataGridViewTextBoxColumn
            // 
            this.tinhtrangDataGridViewTextBoxColumn.DataPropertyName = "tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.HeaderText = "Tình Trạng";
            this.tinhtrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhtrangDataGridViewTextBoxColumn.Name = "tinhtrangDataGridViewTextBoxColumn";
            this.tinhtrangDataGridViewTextBoxColumn.Width = 170;
            // 
            // class1BindingSource2
            // 
            this.class1BindingSource2.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btn_reserve);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(9, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 201);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Phòng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 38);
            this.textBox1.TabIndex = 4;
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(40, 134);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(199, 48);
            this.btn_reserve.TabIndex = 3;
            this.btn_reserve.Text = "Đặt Phòng";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 472);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tìm Kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 356);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 35);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "có người";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 356);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 35);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Trống";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 39);
            this.comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình Trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 38);
            this.textBox4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 38);
            this.textBox2.TabIndex = 2;
            // 
            // class1BindingSource1
            // 
            this.class1BindingSource1.DataSource = typeof(hotel.TraCuuPhong.Class1);
            // 
            // fsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "fsearch";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox textBox1;
        private Button btn_reserve;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private BindingSource class1BindingSource;
        private DataGridView dataGridView1;
        private BindingSource class1BindingSource2;
        private BindingSource class1BindingSource1;
        private Button button1;
        private DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
    }
}