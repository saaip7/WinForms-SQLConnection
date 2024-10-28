namespace modul8
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
            lblTitle = new Label();
            lblNama = new Label();
            lblAlamat = new Label();
            lblNoHandphone = new Label();
            txtName = new TextBox();
            txtAlamat = new TextBox();
            txtNo_handphone = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoadData = new Button();
            btn_qr = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(325, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Data Users";
            lblTitle.Click += label1_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNama.Location = new Point(22, 67);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(52, 21);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama";
            lblNama.Click += label1_Click_1;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlamat.Location = new Point(22, 99);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(59, 21);
            lblAlamat.TabIndex = 2;
            lblAlamat.Text = "Alamat";
            // 
            // lblNoHandphone
            // 
            lblNoHandphone.AutoSize = true;
            lblNoHandphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoHandphone.Location = new Point(22, 131);
            lblNoHandphone.Name = "lblNoHandphone";
            lblNoHandphone.Size = new Size(116, 21);
            lblNoHandphone.TabIndex = 3;
            lblNoHandphone.Text = "No Handphone";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(186, 23);
            txtName.TabIndex = 4;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(163, 101);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(186, 23);
            txtAlamat.TabIndex = 5;
            // 
            // txtNo_handphone
            // 
            txtNo_handphone.Location = new Point(163, 133);
            txtNo_handphone.Name = "txtNo_handphone";
            txtNo_handphone.Size = new Size(186, 23);
            txtNo_handphone.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(367, 67);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(92, 87);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(465, 67);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 87);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 87);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(22, 176);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(727, 259);
            dgvData.TabIndex = 10;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(620, 454);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(129, 39);
            btnLoadData.TabIndex = 11;
            btnLoadData.Text = "LoadData";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btn_qr
            // 
            btn_qr.Location = new Point(661, 69);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(88, 83);
            btn_qr.TabIndex = 12;
            btn_qr.Text = "Generate QR";
            btn_qr.UseVisualStyleBackColor = true;
            btn_qr.Click += btn_qr_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 505);
            Controls.Add(btn_qr);
            Controls.Add(btnLoadData);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtNo_handphone);
            Controls.Add(txtAlamat);
            Controls.Add(txtName);
            Controls.Add(lblNoHandphone);
            Controls.Add(lblAlamat);
            Controls.Add(lblNama);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNama;
        private Label lblAlamat;
        private Label lblNoHandphone;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoadData;
        private Button btn_qr;
        public TextBox txtName;
        public TextBox txtAlamat;
        public TextBox txtNo_handphone;
    }
}