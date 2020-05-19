namespace CodeFirstFormsApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshSalesButton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTargetButton = new System.Windows.Forms.Button();
            this.newAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.newDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newPersonComboBox = new System.Windows.Forms.ComboBox();
            this.newRegionComboBox = new System.Windows.Forms.ComboBox();
            this.newSaleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.DataSource = this.salesPersonBindingSource;
            this.peopleComboBox.DisplayMember = "FullName";
            this.peopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(12, 268);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(283, 24);
            this.peopleComboBox.TabIndex = 0;
            this.peopleComboBox.ValueMember = "Id";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataSource = typeof(CodeFirstFormsApp.Models.SalesPerson);
            // 
            // regionComboBox
            // 
            this.regionComboBox.DataSource = this.salesRegionBindingSource;
            this.regionComboBox.DisplayMember = "Name";
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(313, 268);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(300, 24);
            this.regionComboBox.TabIndex = 1;
            this.regionComboBox.ValueMember = "Id";
            // 
            // salesRegionBindingSource
            // 
            this.salesRegionBindingSource.DataSource = typeof(CodeFirstFormsApp.Models.SalesRegion);
            // 
            // refreshSalesButton
            // 
            this.refreshSalesButton.Location = new System.Drawing.Point(313, 308);
            this.refreshSalesButton.Name = "refreshSalesButton";
            this.refreshSalesButton.Size = new System.Drawing.Size(300, 37);
            this.refreshSalesButton.TabIndex = 2;
            this.refreshSalesButton.Text = "Refresh Data";
            this.refreshSalesButton.UseVisualStyleBackColor = true;
            this.refreshSalesButton.Click += new System.EventHandler(this.refreshSalesButton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AutoGenerateColumns = false;
            this.salesDataGridView.ColumnHeadersHeight = 29;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.UpdateBy});
            this.salesDataGridView.DataSource = this.saleBindingSource;
            this.salesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.Size = new System.Drawing.Size(601, 215);
            this.salesDataGridView.TabIndex = 3;
            this.salesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDataGridView_CellEndEdit);
            this.salesDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.salesDataGridView_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 10;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // UpdateBy
            // 
            this.UpdateBy.DataPropertyName = "UpdateBy";
            this.UpdateBy.HeaderText = "Updated By";
            this.UpdateBy.MinimumWidth = 6;
            this.UpdateBy.Name = "UpdateBy";
            this.UpdateBy.ReadOnly = true;
            this.UpdateBy.Width = 125;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(CodeFirstFormsApp.Models.Sale);
            // 
            // salesTargetButton
            // 
            this.salesTargetButton.Location = new System.Drawing.Point(12, 308);
            this.salesTargetButton.Name = "salesTargetButton";
            this.salesTargetButton.Size = new System.Drawing.Size(283, 37);
            this.salesTargetButton.TabIndex = 4;
            this.salesTargetButton.Text = "Sales Person Target";
            this.salesTargetButton.UseVisualStyleBackColor = true;
            this.salesTargetButton.Click += new System.EventHandler(this.salesTargetButton_Click);
            // 
            // newAmountNumericUpDown
            // 
            this.newAmountNumericUpDown.DecimalPlaces = 2;
            this.newAmountNumericUpDown.Location = new System.Drawing.Point(12, 437);
            this.newAmountNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newAmountNumericUpDown.Name = "newAmountNumericUpDown";
            this.newAmountNumericUpDown.Size = new System.Drawing.Size(283, 22);
            this.newAmountNumericUpDown.TabIndex = 5;
            // 
            // newDateDateTimePicker
            // 
            this.newDateDateTimePicker.Location = new System.Drawing.Point(12, 484);
            this.newDateDateTimePicker.Name = "newDateDateTimePicker";
            this.newDateDateTimePicker.Size = new System.Drawing.Size(283, 22);
            this.newDateDateTimePicker.TabIndex = 6;
            // 
            // newPersonComboBox
            // 
            this.newPersonComboBox.DataSource = this.salesPersonBindingSource;
            this.newPersonComboBox.DisplayMember = "FullName";
            this.newPersonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPersonComboBox.FormattingEnabled = true;
            this.newPersonComboBox.Location = new System.Drawing.Point(313, 437);
            this.newPersonComboBox.Name = "newPersonComboBox";
            this.newPersonComboBox.Size = new System.Drawing.Size(300, 24);
            this.newPersonComboBox.TabIndex = 7;
            this.newPersonComboBox.ValueMember = "Id";
            // 
            // newRegionComboBox
            // 
            this.newRegionComboBox.DataSource = this.salesRegionBindingSource;
            this.newRegionComboBox.DisplayMember = "Name";
            this.newRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRegionComboBox.FormattingEnabled = true;
            this.newRegionComboBox.Location = new System.Drawing.Point(313, 482);
            this.newRegionComboBox.Name = "newRegionComboBox";
            this.newRegionComboBox.Size = new System.Drawing.Size(301, 24);
            this.newRegionComboBox.TabIndex = 8;
            this.newRegionComboBox.ValueMember = "Id";
            // 
            // newSaleButton
            // 
            this.newSaleButton.Location = new System.Drawing.Point(12, 512);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(601, 35);
            this.newSaleButton.TabIndex = 9;
            this.newSaleButton.Text = "Submit New Sale";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter New Sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sales Person Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sales Person Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Region";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newSaleButton);
            this.Controls.Add(this.newRegionComboBox);
            this.Controls.Add(this.newPersonComboBox);
            this.Controls.Add(this.newDateDateTimePicker);
            this.Controls.Add(this.newAmountNumericUpDown);
            this.Controls.Add(this.salesTargetButton);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.refreshSalesButton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.peopleComboBox);
            this.Name = "Form1";
            this.Text = "Sales Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.Button refreshSalesButton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.Button salesTargetButton;
        private System.Windows.Forms.NumericUpDown newAmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker newDateDateTimePicker;
        private System.Windows.Forms.ComboBox newPersonComboBox;
        private System.Windows.Forms.ComboBox newRegionComboBox;
        private System.Windows.Forms.Button newSaleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

