namespace Tudien1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTrove = new System.Windows.Forms.Button();
            this.dictionnalDataSet = new Tudien1.dictionnalDataSet();
            this.dictionnalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.enTermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnMeanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tudienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionnalDataSet1 = new Tudien1.dictionnalDataSet1();
            this.tudienTableAdapter = new Tudien1.dictionnalDataSet1TableAdapters.TudienTableAdapter();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtViet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictionnalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionnalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tudienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionnalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(25, 35);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(196, 35);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cập Nhật Từ Điển";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(69, 16);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(35, 13);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Location = new System.Drawing.Point(491, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 37);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADMIN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTrove);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(449, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 134);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tuỳ chọn";
            // 
            // btnTrove
            // 
            this.btnTrove.Image = ((System.Drawing.Image)(resources.GetObject("btnTrove.Image")));
            this.btnTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrove.Location = new System.Drawing.Point(112, 89);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(115, 29);
            this.btnTrove.TabIndex = 2;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // dictionnalDataSet
            // 
            this.dictionnalDataSet.DataSetName = "dictionnalDataSet";
            this.dictionnalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dictionnalDataSetBindingSource
            // 
            this.dictionnalDataSetBindingSource.DataSource = this.dictionnalDataSet;
            this.dictionnalDataSetBindingSource.Position = 0;
            // 
            // dtgList
            // 
            this.dtgList.AutoGenerateColumns = false;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enTermDataGridViewTextBoxColumn,
            this.vnMeanDataGridViewTextBoxColumn});
            this.dtgList.DataSource = this.tudienBindingSource;
            this.dtgList.Location = new System.Drawing.Point(17, 98);
            this.dtgList.Name = "dtgList";
            this.dtgList.Size = new System.Drawing.Size(379, 231);
            this.dtgList.TabIndex = 9;
            this.dtgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgList_CellClick);
            this.dtgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgList_KeyDown);
            this.dtgList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtgList_KeyUp);
            // 
            // enTermDataGridViewTextBoxColumn
            // 
            this.enTermDataGridViewTextBoxColumn.DataPropertyName = "EnTerm";
            this.enTermDataGridViewTextBoxColumn.HeaderText = "EnTerm";
            this.enTermDataGridViewTextBoxColumn.Name = "enTermDataGridViewTextBoxColumn";
            this.enTermDataGridViewTextBoxColumn.Width = 120;
            // 
            // vnMeanDataGridViewTextBoxColumn
            // 
            this.vnMeanDataGridViewTextBoxColumn.DataPropertyName = "VnMean";
            this.vnMeanDataGridViewTextBoxColumn.HeaderText = "VnMean";
            this.vnMeanDataGridViewTextBoxColumn.Name = "vnMeanDataGridViewTextBoxColumn";
            this.vnMeanDataGridViewTextBoxColumn.Width = 300;
            // 
            // tudienBindingSource
            // 
            this.tudienBindingSource.DataMember = "Tudien";
            this.tudienBindingSource.DataSource = this.dictionnalDataSet1;
            // 
            // dictionnalDataSet1
            // 
            this.dictionnalDataSet1.DataSetName = "dictionnalDataSet1";
            this.dictionnalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tudienTableAdapter
            // 
            this.tudienTableAdapter.ClearBeforeFill = true;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEng.Location = new System.Drawing.Point(491, 98);
            this.txtEng.Multiline = true;
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(311, 33);
            this.txtEng.TabIndex = 10;
            // 
            // txtViet
            // 
            this.txtViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViet.Location = new System.Drawing.Point(491, 165);
            this.txtViet.Multiline = true;
            this.txtViet.Name = "txtViet";
            this.txtViet.Size = new System.Drawing.Size(311, 35);
            this.txtViet.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "EnTerm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "VnMean";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtViet);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dictionnalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionnalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tudienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionnalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource dictionnalDataSetBindingSource;
        private dictionnalDataSet dictionnalDataSet;
        private System.Windows.Forms.DataGridView dtgList;
        private dictionnalDataSet1 dictionnalDataSet1;
        private System.Windows.Forms.BindingSource tudienBindingSource;
        private dictionnalDataSet1TableAdapters.TudienTableAdapter tudienTableAdapter;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtViet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.DataGridViewTextBoxColumn enTermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnMeanDataGridViewTextBoxColumn;
    }
}