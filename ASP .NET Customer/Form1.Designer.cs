namespace ASP.NET_Customer
{
    partial class Form1
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblPanNo = new System.Windows.Forms.Label();
            this.lblAadharNo = new System.Windows.Forms.Label();
            this.txtPanNo = new System.Windows.Forms.TextBox();
            this.txtAadharNo = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(96, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Customer Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email-Id";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 152);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(89, 20);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact No";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 187);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 26);
            this.txtId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(197, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 26);
            this.txtAddress.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(197, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(197, 152);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(176, 26);
            this.txtContact.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 26);
            this.txtPassword.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 347);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(197, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(413, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 34);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(528, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(497, 244);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(615, 291);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(345, 35);
            this.btnShowAll.TabIndex = 18;
            this.btnShowAll.Text = "Show all customers";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblPanNo
            // 
            this.lblPanNo.AutoSize = true;
            this.lblPanNo.Location = new System.Drawing.Point(12, 227);
            this.lblPanNo.Name = "lblPanNo";
            this.lblPanNo.Size = new System.Drawing.Size(61, 20);
            this.lblPanNo.TabIndex = 19;
            this.lblPanNo.Text = "Pan No";
            // 
            // lblAadharNo
            // 
            this.lblAadharNo.AutoSize = true;
            this.lblAadharNo.Location = new System.Drawing.Point(12, 266);
            this.lblAadharNo.Name = "lblAadharNo";
            this.lblAadharNo.Size = new System.Drawing.Size(85, 20);
            this.lblAadharNo.TabIndex = 20;
            this.lblAadharNo.Text = "Aadhar No";
            // 
            // txtPanNo
            // 
            this.txtPanNo.Location = new System.Drawing.Point(197, 227);
            this.txtPanNo.Name = "txtPanNo";
            this.txtPanNo.Size = new System.Drawing.Size(176, 26);
            this.txtPanNo.TabIndex = 21;
            // 
            // txtAadharNo
            // 
            this.txtAadharNo.Location = new System.Drawing.Point(197, 266);
            this.txtAadharNo.Name = "txtAadharNo";
            this.txtAadharNo.Size = new System.Drawing.Size(176, 26);
            this.txtAadharNo.TabIndex = 22;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(12, 306);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 20);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(197, 306);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(176, 26);
            this.txtRole.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtAadharNo);
            this.Controls.Add(this.txtPanNo);
            this.Controls.Add(this.lblAadharNo);
            this.Controls.Add(this.lblPanNo);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Customer Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblPanNo;
        private System.Windows.Forms.Label lblAadharNo;
        private System.Windows.Forms.TextBox txtPanNo;
        private System.Windows.Forms.TextBox txtAadharNo;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
    }
}

