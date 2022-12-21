namespace hotel
{
    partial class faddroom
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
            this.Ten = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbRoomType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ten.Location = new System.Drawing.Point(15, 24);
            this.Ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(154, 38);
            this.Ten.TabIndex = 0;
            this.Ten.Text = "Tên Phòng:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomName.Location = new System.Drawing.Point(230, 24);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(320, 44);
            this.txtRoomName.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNote.Location = new System.Drawing.Point(230, 219);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(320, 44);
            this.txtNote.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ghi Chú:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại Phòng:";
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbRoomType.FormattingEnabled = true;
            this.cbbRoomType.Location = new System.Drawing.Point(230, 124);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(320, 46);
            this.cbbRoomType.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(385, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // faddroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbRoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.Ten);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "faddroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ten;
        private TextBox txtRoomName;
        private TextBox txtNote;
        private Label label1;
        private Label label2;
        private ComboBox cbbRoomType;
        private Button button1;
    }
}