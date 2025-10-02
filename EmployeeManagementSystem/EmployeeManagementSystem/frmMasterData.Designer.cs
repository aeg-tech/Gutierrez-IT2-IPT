namespace EmployeeManagementSystem
{
    partial class frmMasterData
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
            this.pnlChildTitle = new System.Windows.Forms.Panel();
            this.lblMasterData = new System.Windows.Forms.Label();
            this.dtgMasterData = new System.Windows.Forms.DataGridView();
            this.btnEditData = new System.Windows.Forms.Button();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.pnlChildTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChildTitle
            // 
            this.pnlChildTitle.Controls.Add(this.lblMasterData);
            this.pnlChildTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlChildTitle.Name = "pnlChildTitle";
            this.pnlChildTitle.Size = new System.Drawing.Size(748, 37);
            this.pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            this.lblMasterData.AutoSize = true;
            this.lblMasterData.Location = new System.Drawing.Point(12, 9);
            this.lblMasterData.Name = "lblMasterData";
            this.lblMasterData.Size = new System.Drawing.Size(65, 13);
            this.lblMasterData.TabIndex = 0;
            this.lblMasterData.Text = "Master Data";
            // 
            // dtgMasterData
            // 
            this.dtgMasterData.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dtgMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMasterData.Location = new System.Drawing.Point(0, 37);
            this.dtgMasterData.Name = "dtgMasterData";
            this.dtgMasterData.Size = new System.Drawing.Size(748, 286);
            this.dtgMasterData.TabIndex = 1;
            this.dtgMasterData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMasterData_RowHeaderMouseClick);
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.Location = new System.Drawing.Point(656, 337);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(75, 23);
            this.btnEditData.TabIndex = 2;
            this.btnEditData.Text = "Edit Data";
            this.btnEditData.UseVisualStyleBackColor = true;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Location = new System.Drawing.Point(25, 342);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(146, 13);
            this.lblTransactionNo.TabIndex = 3;
            this.lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 373);
            this.Controls.Add(this.lblTransactionNo);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.dtgMasterData);
            this.Controls.Add(this.pnlChildTitle);
            this.Name = "frmMasterData";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Text = "frmMasterData";
            this.Load += new System.EventHandler(this.frmMasterData_Load);
            this.pnlChildTitle.ResumeLayout(false);
            this.pnlChildTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMasterData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChildTitle;
        private System.Windows.Forms.Label lblMasterData;
        private System.Windows.Forms.DataGridView dtgMasterData;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Label lblTransactionNo;
    }
}