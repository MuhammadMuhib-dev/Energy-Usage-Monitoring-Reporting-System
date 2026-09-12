namespace LCP
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnManageFuels = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEntry
            // 
            this.grpEntry.Controls.Add(this.lblFuel);
            this.grpEntry.Controls.Add(this.cmbFuel);
            this.grpEntry.Controls.Add(this.lblMonth);
            this.grpEntry.Controls.Add(this.cmbMonth);
            this.grpEntry.Controls.Add(this.lblYear);
            this.grpEntry.Controls.Add(this.nudYear);
            this.grpEntry.Controls.Add(this.lblPrice);
            this.grpEntry.Controls.Add(this.txtPrice);
            this.grpEntry.Controls.Add(this.btnSave);
            this.grpEntry.Controls.Add(this.btnUpdate);
            this.grpEntry.Controls.Add(this.btnClear);
            this.grpEntry.Controls.Add(this.btnManageFuels);
            this.grpEntry.Location = new System.Drawing.Point(15, 15);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Size = new System.Drawing.Size(700, 140);
            this.grpEntry.TabIndex = 0;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "Entry";
            this.grpEntry.Enter += new System.EventHandler(this.grpEntry_Enter);
            // 
            // lblFuel
            // 
            this.lblFuel.Location = new System.Drawing.Point(15, 30);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(60, 20);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel:";
            // 
            // cmbFuel
            // 
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.Location = new System.Drawing.Point(15, 50);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(160, 28);
            this.cmbFuel.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(190, 30);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(60, 20);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month:";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Location = new System.Drawing.Point(190, 50);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(140, 28);
            this.cmbMonth.TabIndex = 3;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(345, 30);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 20);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(345, 50);
            this.nudYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(100, 26);
            this.nudYear.TabIndex = 5;
            this.nudYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(460, 30);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price per Unit:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(460, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(235, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnManageFuels
            // 
            this.btnManageFuels.Location = new System.Drawing.Point(560, 90);
            this.btnManageFuels.Name = "btnManageFuels";
            this.btnManageFuels.Size = new System.Drawing.Size(120, 30);
            this.btnManageFuels.TabIndex = 11;
            this.btnManageFuels.Text = "Manage Fuels";
            this.btnManageFuels.UseVisualStyleBackColor = true;
            this.btnManageFuels.Click += new System.EventHandler(this.btnManageFuels_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 380);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(732, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpEntry);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Prices Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEntry.ResumeLayout(false);
            this.grpEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnManageFuels;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}