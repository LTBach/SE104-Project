namespace hotel
{
    partial class fcatalog
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add_room = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1BindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.class1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbStatus);
            this.groupBox2.Controls.Add(this.cbbRoomType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRoomName);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(15, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(382, 539);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            ""});
            this.cbbStatus.Location = new System.Drawing.Point(35, 470);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(290, 46);
            this.cbbStatus.TabIndex = 14;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Items.AddRange(new object[] {
            ""});
            this.cbbRoomType.Location = new System.Drawing.Point(35, 225);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(290, 46);
            this.cbbRoomType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình Trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(35, 346);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(290, 44);
            this.txtPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(35, 97);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(290, 44);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_add_room);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 567);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(382, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btn_add_room
            // 
            this.btn_add_room.Location = new System.Drawing.Point(65, 59);
            this.btn_add_room.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(249, 60);
            this.btn_add_room.TabIndex = 3;
            this.btn_add_room.Text = "Thêm";
            this.btn_add_room.UseVisualStyleBackColor = true;
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 58);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(405, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1264, 849);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenphong,
            this.loaiphong,
            this.dongiaTC,
            this.ghichuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.class1BindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 799);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Phòng";
            this.tenphong.MinimumWidth = 8;
            this.tenphong.Name = "tenphong";
            this.tenphong.Width = 150;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "tenloaiphong";
            this.loaiphong.HeaderText = "Loại Phòng";
            this.loaiphong.MinimumWidth = 8;
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.Width = 200;
            // 
            // dongiaTC
            // 
            this.dongiaTC.DataPropertyName = "dongiaTC";
            this.dongiaTC.HeaderText = "Đơn Giá";
            this.dongiaTC.MinimumWidth = 8;
            this.dongiaTC.Name = "dongiaTC";
            this.dongiaTC.Width = 200;
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            this.ghichuDataGridViewTextBoxColumn.Width = 300;
            // 
            // class1BindingSource5
            // 
            this.class1BindingSource5.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource4
            // 
            this.class1BindingSource4.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource2
            // 
            this.class1BindingSource2.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource1
            // 
            this.class1BindingSource1.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // class1BindingSource3
            // 
            this.class1BindingSource3.DataSource = typeof(hotel.MDphong.Class1);
            // 
            // fcatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 884);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fcatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Phòng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private Label label2;
        private TextBox txtRoomName;
        private GroupBox groupBox3;
        private Button button3;
        private Button btn_add_room;
        private Button button2;
        private BindingSource class1BindingSource;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn sophongDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource1;
        private BindingSource class1BindingSource2;
        private DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private BindingSource class1BindingSource4;
        private BindingSource class1BindingSource3;
        private DataGridView dataGridView1;
        private BindingSource class1BindingSource5;
        private ComboBox cbbRoomType;
        private ComboBox cbbStatus;
        private DataGridViewTextBoxColumn phongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenphong;
        private DataGridViewTextBoxColumn loaiphong;
        private DataGridViewTextBoxColumn dongiaTC;
        private DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
    }
}