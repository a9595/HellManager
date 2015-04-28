namespace HellManager
{
	partial class HellManager
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.sinnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(848, 650);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(840, 624);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Sinners";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(840, 624);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Sinns";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.genderIdDataGridViewTextBoxColumn,
            this.sinsDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.sinnerBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(828, 247);
			this.dataGridView1.TabIndex = 0;
			// 
			// sinnerBindingSource
			// 
			this.sinnerBindingSource.DataSource = typeof(EntityFrameworkDAL.Sinner);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			// 
			// ageDataGridViewTextBoxColumn
			// 
			this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
			this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
			this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
			// 
			// jobTitleDataGridViewTextBoxColumn
			// 
			this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
			this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
			this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
			// 
			// salaryDataGridViewTextBoxColumn
			// 
			this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
			this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
			this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
			// 
			// genderIdDataGridViewTextBoxColumn
			// 
			this.genderIdDataGridViewTextBoxColumn.DataPropertyName = "GenderId";
			this.genderIdDataGridViewTextBoxColumn.HeaderText = "GenderId";
			this.genderIdDataGridViewTextBoxColumn.Name = "genderIdDataGridViewTextBoxColumn";
			// 
			// sinsDataGridViewTextBoxColumn
			// 
			this.sinsDataGridViewTextBoxColumn.DataPropertyName = "Sins";
			this.sinsDataGridViewTextBoxColumn.HeaderText = "Sins";
			this.sinsDataGridViewTextBoxColumn.Name = "sinsDataGridViewTextBoxColumn";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// HellManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(872, 674);
			this.Controls.Add(this.tabControl1);
			this.Name = "HellManager";
			this.Text = "HellManager";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sinsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource sinnerBindingSource;
	}
}