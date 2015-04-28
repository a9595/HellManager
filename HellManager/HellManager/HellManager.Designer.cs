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
			this.sinnersDataGridView = new System.Windows.Forms.DataGridView();
			this.sinnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinsDataGridView = new System.Windows.Forms.DataGridView();
			this.sinBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.punishmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.punisherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinDegreeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinnersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.punishmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.punisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sinnerSinsDataGridView = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinnersDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinnerSinsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1123, 650);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.sinnerSinsDataGridView);
			this.tabPage1.Controls.Add(this.sinnersDataGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1115, 624);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Sinners";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.sinsDataGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1115, 624);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Sinns";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// sinnersDataGridView
			// 
			this.sinnersDataGridView.AutoGenerateColumns = false;
			this.sinnersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sinnersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
			this.sinnersDataGridView.DataSource = this.sinnerBindingSource;
			this.sinnersDataGridView.Location = new System.Drawing.Point(6, 6);
			this.sinnersDataGridView.Name = "sinnersDataGridView";
			this.sinnersDataGridView.Size = new System.Drawing.Size(570, 247);
			this.sinnersDataGridView.TabIndex = 0;
			// 
			// sinnerBindingSource
			// 
			this.sinnerBindingSource.DataSource = typeof(EntityFrameworkDAL.Sinner);
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
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// sinsDataGridView
			// 
			this.sinsDataGridView.AutoGenerateColumns = false;
			this.sinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sinsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.punishmentIdDataGridViewTextBoxColumn,
            this.punisherIdDataGridViewTextBoxColumn,
            this.sinDegreeIdDataGridViewTextBoxColumn,
            this.sinnersDataGridViewTextBoxColumn,
            this.punishmentDataGridViewTextBoxColumn,
            this.punisherDataGridViewTextBoxColumn,
            this.sinDegreeDataGridViewTextBoxColumn});
			this.sinsDataGridView.DataSource = this.sinBindingSource;
			this.sinsDataGridView.Location = new System.Drawing.Point(6, 6);
			this.sinsDataGridView.Name = "sinsDataGridView";
			this.sinsDataGridView.Size = new System.Drawing.Size(810, 294);
			this.sinsDataGridView.TabIndex = 0;
			// 
			// sinBindingSource
			// 
			this.sinBindingSource.DataSource = typeof(EntityFrameworkDAL.Sin);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// punishmentIdDataGridViewTextBoxColumn
			// 
			this.punishmentIdDataGridViewTextBoxColumn.DataPropertyName = "PunishmentId";
			this.punishmentIdDataGridViewTextBoxColumn.HeaderText = "PunishmentId";
			this.punishmentIdDataGridViewTextBoxColumn.Name = "punishmentIdDataGridViewTextBoxColumn";
			// 
			// punisherIdDataGridViewTextBoxColumn
			// 
			this.punisherIdDataGridViewTextBoxColumn.DataPropertyName = "PunisherId";
			this.punisherIdDataGridViewTextBoxColumn.HeaderText = "PunisherId";
			this.punisherIdDataGridViewTextBoxColumn.Name = "punisherIdDataGridViewTextBoxColumn";
			// 
			// sinDegreeIdDataGridViewTextBoxColumn
			// 
			this.sinDegreeIdDataGridViewTextBoxColumn.DataPropertyName = "SinDegreeId";
			this.sinDegreeIdDataGridViewTextBoxColumn.HeaderText = "SinDegreeId";
			this.sinDegreeIdDataGridViewTextBoxColumn.Name = "sinDegreeIdDataGridViewTextBoxColumn";
			// 
			// sinnersDataGridViewTextBoxColumn
			// 
			this.sinnersDataGridViewTextBoxColumn.DataPropertyName = "Sinners";
			this.sinnersDataGridViewTextBoxColumn.HeaderText = "Sinners";
			this.sinnersDataGridViewTextBoxColumn.Name = "sinnersDataGridViewTextBoxColumn";
			// 
			// punishmentDataGridViewTextBoxColumn
			// 
			this.punishmentDataGridViewTextBoxColumn.DataPropertyName = "Punishment";
			this.punishmentDataGridViewTextBoxColumn.HeaderText = "Punishment";
			this.punishmentDataGridViewTextBoxColumn.Name = "punishmentDataGridViewTextBoxColumn";
			// 
			// punisherDataGridViewTextBoxColumn
			// 
			this.punisherDataGridViewTextBoxColumn.DataPropertyName = "Punisher";
			this.punisherDataGridViewTextBoxColumn.HeaderText = "Punisher";
			this.punisherDataGridViewTextBoxColumn.Name = "punisherDataGridViewTextBoxColumn";
			// 
			// sinDegreeDataGridViewTextBoxColumn
			// 
			this.sinDegreeDataGridViewTextBoxColumn.DataPropertyName = "SinDegree";
			this.sinDegreeDataGridViewTextBoxColumn.HeaderText = "SinDegree";
			this.sinDegreeDataGridViewTextBoxColumn.Name = "sinDegreeDataGridViewTextBoxColumn";
			// 
			// sinnerSinsDataGridView
			// 
			this.sinnerSinsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sinnerSinsDataGridView.Location = new System.Drawing.Point(275, 348);
			this.sinnerSinsDataGridView.Name = "sinnerSinsDataGridView";
			this.sinnerSinsDataGridView.Size = new System.Drawing.Size(530, 163);
			this.sinnerSinsDataGridView.TabIndex = 1;
			// 
			// HellManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1147, 674);
			this.Controls.Add(this.tabControl1);
			this.Name = "HellManager";
			this.Text = "HellManager";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sinnersDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinnerSinsDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView sinnersDataGridView;
		private System.Windows.Forms.BindingSource sinnerBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView sinsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn punishmentIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn punisherIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sinDegreeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sinnersDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn punishmentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn punisherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sinDegreeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource sinBindingSource;
		private System.Windows.Forms.DataGridView sinnerSinsDataGridView;
	}
}