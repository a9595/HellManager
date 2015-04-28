namespace HellManager
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
			this.SinnersDataGridView = new System.Windows.Forms.DataGridView();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabSinns = new System.Windows.Forms.TabPage();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tabPageSinners = new System.Windows.Forms.TabPage();
			this.sinnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ButtonSaveChanges = new Telerik.WinControls.UI.RadButton();
			this.tabPanishments = new System.Windows.Forms.TabPage();
			this.tabPanishers = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.SinnersDataGridView)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPageSinners.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSaveChanges)).BeginInit();
			this.SuspendLayout();
			// 
			// SinnersDataGridView
			// 
			this.SinnersDataGridView.AutoGenerateColumns = false;
			this.SinnersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SinnersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
			this.SinnersDataGridView.DataSource = this.sinnerBindingSource;
			this.SinnersDataGridView.Location = new System.Drawing.Point(6, 6);
			this.SinnersDataGridView.Name = "SinnersDataGridView";
			this.SinnersDataGridView.Size = new System.Drawing.Size(339, 546);
			this.SinnersDataGridView.TabIndex = 0;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageSinners);
			this.tabControl.Controls.Add(this.tabSinns);
			this.tabControl.Controls.Add(this.tabPanishments);
			this.tabControl.Controls.Add(this.tabPanishers);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1034, 715);
			this.tabControl.TabIndex = 1;
			// 
			// tabSinns
			// 
			this.tabSinns.Location = new System.Drawing.Point(4, 22);
			this.tabSinns.Name = "tabSinns";
			this.tabSinns.Padding = new System.Windows.Forms.Padding(3);
			this.tabSinns.Size = new System.Drawing.Size(1026, 689);
			this.tabSinns.TabIndex = 1;
			this.tabSinns.Text = "Sins";
			this.tabSinns.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinnerBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sinnerBindingSource, "Id", true));
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.sinnerBindingSource, "Name", true));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(454, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// tabPageSinners
			// 
			this.tabPageSinners.Controls.Add(this.ButtonSaveChanges);
			this.tabPageSinners.Controls.Add(this.comboBox1);
			this.tabPageSinners.Controls.Add(this.SinnersDataGridView);
			this.tabPageSinners.Location = new System.Drawing.Point(4, 22);
			this.tabPageSinners.Name = "tabPageSinners";
			this.tabPageSinners.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSinners.Size = new System.Drawing.Size(1026, 689);
			this.tabPageSinners.TabIndex = 0;
			this.tabPageSinners.Text = "Sinners";
			this.tabPageSinners.UseVisualStyleBackColor = true;
			// 
			// sinnerBindingSource
			// 
			this.sinnerBindingSource.DataSource = typeof(EntityFrameworkDAL.Sinner);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// ButtonSaveChanges
			// 
			this.ButtonSaveChanges.Location = new System.Drawing.Point(6, 558);
			this.ButtonSaveChanges.Name = "ButtonSaveChanges";
			this.ButtonSaveChanges.Size = new System.Drawing.Size(339, 49);
			this.ButtonSaveChanges.TabIndex = 4;
			this.ButtonSaveChanges.Text = "Save changes";
			this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
			// 
			// tabPanishments
			// 
			this.tabPanishments.Location = new System.Drawing.Point(4, 22);
			this.tabPanishments.Name = "tabPanishments";
			this.tabPanishments.Size = new System.Drawing.Size(1026, 689);
			this.tabPanishments.TabIndex = 2;
			this.tabPanishments.Text = "Panishments";
			this.tabPanishments.UseVisualStyleBackColor = true;
			// 
			// tabPanishers
			// 
			this.tabPanishers.Location = new System.Drawing.Point(4, 22);
			this.tabPanishers.Name = "tabPanishers";
			this.tabPanishers.Size = new System.Drawing.Size(1026, 689);
			this.tabPanishers.TabIndex = 3;
			this.tabPanishers.Text = "Panishers";
			this.tabPanishers.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 739);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "HellManager";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.SinnersDataGridView)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPageSinners.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sinnerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonSaveChanges)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView SinnersDataGridView;
		private System.Windows.Forms.BindingSource sinnerBindingSource;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabSinns;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabPage tabPageSinners;
		private Telerik.WinControls.UI.RadButton ButtonSaveChanges;
		private System.Windows.Forms.TabPage tabPanishments;
		private System.Windows.Forms.TabPage tabPanishers;
	}
}

