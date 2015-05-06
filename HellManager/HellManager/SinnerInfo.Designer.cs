namespace HellManager
{
	partial class SinnerInfo
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
			System.Windows.Forms.Label ageLabel;
			System.Windows.Forms.Label fullNameLabel;
			System.Windows.Forms.Label jobTitleLabel;
			System.Windows.Forms.Label salaryLabel;
			System.Windows.Forms.Label genderLabel;
			this.sinnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.fullNameRadTextBox = new Telerik.WinControls.UI.RadTextBox();
			this.jobTitleRadTextBox = new Telerik.WinControls.UI.RadTextBox();
			this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.genderComboBox = new System.Windows.Forms.ComboBox();
			ageLabel = new System.Windows.Forms.Label();
			fullNameLabel = new System.Windows.Forms.Label();
			jobTitleLabel = new System.Windows.Forms.Label();
			salaryLabel = new System.Windows.Forms.Label();
			genderLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fullNameRadTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jobTitleRadTextBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// sinnerBindingSource
			// 
			this.sinnerBindingSource.DataSource = typeof(EntityFrameworkDAL.Sinner);
			// 
			// ageLabel
			// 
			ageLabel.AutoSize = true;
			ageLabel.Location = new System.Drawing.Point(27, 38);
			ageLabel.Name = "ageLabel";
			ageLabel.Size = new System.Drawing.Size(29, 13);
			ageLabel.TabIndex = 1;
			ageLabel.Text = "Age:";
			// 
			// ageNumericUpDown
			// 
			this.ageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinnerBindingSource, "Age", true));
			this.ageNumericUpDown.Location = new System.Drawing.Point(90, 38);
			this.ageNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.ageNumericUpDown.Name = "ageNumericUpDown";
			this.ageNumericUpDown.Size = new System.Drawing.Size(280, 20);
			this.ageNumericUpDown.TabIndex = 2;
			// 
			// fullNameLabel
			// 
			fullNameLabel.AutoSize = true;
			fullNameLabel.Location = new System.Drawing.Point(27, 64);
			fullNameLabel.Name = "fullNameLabel";
			fullNameLabel.Size = new System.Drawing.Size(57, 13);
			fullNameLabel.TabIndex = 3;
			fullNameLabel.Text = "Full Name:";
			// 
			// fullNameRadTextBox
			// 
			this.fullNameRadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinnerBindingSource, "FullName", true));
			this.fullNameRadTextBox.Location = new System.Drawing.Point(90, 64);
			this.fullNameRadTextBox.Name = "fullNameRadTextBox";
			this.fullNameRadTextBox.Size = new System.Drawing.Size(280, 20);
			this.fullNameRadTextBox.TabIndex = 4;
			// 
			// jobTitleLabel
			// 
			jobTitleLabel.AutoSize = true;
			jobTitleLabel.Location = new System.Drawing.Point(27, 90);
			jobTitleLabel.Name = "jobTitleLabel";
			jobTitleLabel.Size = new System.Drawing.Size(50, 13);
			jobTitleLabel.TabIndex = 5;
			jobTitleLabel.Text = "Job Title:";
			// 
			// jobTitleRadTextBox
			// 
			this.jobTitleRadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinnerBindingSource, "JobTitle", true));
			this.jobTitleRadTextBox.Location = new System.Drawing.Point(90, 90);
			this.jobTitleRadTextBox.Name = "jobTitleRadTextBox";
			this.jobTitleRadTextBox.Size = new System.Drawing.Size(280, 20);
			this.jobTitleRadTextBox.TabIndex = 6;
			// 
			// salaryLabel
			// 
			salaryLabel.AutoSize = true;
			salaryLabel.Location = new System.Drawing.Point(27, 116);
			salaryLabel.Name = "salaryLabel";
			salaryLabel.Size = new System.Drawing.Size(39, 13);
			salaryLabel.TabIndex = 7;
			salaryLabel.Text = "Salary:";
			// 
			// salaryNumericUpDown
			// 
			this.salaryNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sinnerBindingSource, "Salary", true));
			this.salaryNumericUpDown.Location = new System.Drawing.Point(90, 116);
			this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
			this.salaryNumericUpDown.Name = "salaryNumericUpDown";
			this.salaryNumericUpDown.Size = new System.Drawing.Size(280, 20);
			this.salaryNumericUpDown.TabIndex = 8;
			// 
			// genderLabel
			// 
			genderLabel.AutoSize = true;
			genderLabel.Location = new System.Drawing.Point(28, 145);
			genderLabel.Name = "genderLabel";
			genderLabel.Size = new System.Drawing.Size(45, 13);
			genderLabel.TabIndex = 9;
			genderLabel.Text = "Gender:";
			// 
			// genderComboBox
			// 
			this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinnerBindingSource, "Gender", true));
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Location = new System.Drawing.Point(90, 142);
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(281, 21);
			this.genderComboBox.TabIndex = 10;
			this.genderComboBox.ValueMember = "Id";
			// 
			// SinnerInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 271);
			this.Controls.Add(genderLabel);
			this.Controls.Add(this.genderComboBox);
			this.Controls.Add(ageLabel);
			this.Controls.Add(this.ageNumericUpDown);
			this.Controls.Add(fullNameLabel);
			this.Controls.Add(this.fullNameRadTextBox);
			this.Controls.Add(jobTitleLabel);
			this.Controls.Add(this.jobTitleRadTextBox);
			this.Controls.Add(salaryLabel);
			this.Controls.Add(this.salaryNumericUpDown);
			this.Name = "SinnerInfo";
			this.Text = "SinnerInfo";
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fullNameRadTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jobTitleRadTextBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource sinnerBindingSource;
		private System.Windows.Forms.NumericUpDown ageNumericUpDown;
		private Telerik.WinControls.UI.RadTextBox fullNameRadTextBox;
		private Telerik.WinControls.UI.RadTextBox jobTitleRadTextBox;
		private System.Windows.Forms.NumericUpDown salaryNumericUpDown;
		private System.Windows.Forms.ComboBox genderComboBox;
	}
}