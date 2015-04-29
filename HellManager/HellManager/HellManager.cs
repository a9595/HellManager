using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EntityFrameworkDAL;
using Telerik.WinControls.UI;

namespace HellManager
{
	public partial class HellManager : Form
	{
		private readonly EFModelContainer _context = new EFModelContainer();

		public HellManager()
		{
			InitializeComponent();
			SetDataSources();

//
//			radGridView1.Columns[0].IsVisible = false;
//			radGridView1.Columns[2].IsVisible = false;
//			radGridView1.Columns[3].IsVisible = false;
//			radGridView1.Columns[4].IsVisible = false;
//			radGridView1.Columns[0].IsVisible = false;

			//addComboBoxCol();
		}

		private void addComboBoxCol()
		{
			DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
			cmb.DataSource = _context.Genders.ToList();
			cmb.DisplayMember = "Name";
			cmb.ValueMember = "Id";
			cmb.DataPropertyName = "Id";
			//sinnersDataGridView.Columns.Add(cmb);
		}
		private void toolStripButtonAddNewSinner_Click(object sender, EventArgs e)
		{

		}

		private void SetDataSources()
		{
			_context.Sinners.Load();
			_context.Sins.Load();
			_context.Punishments.Load();
			_context.Punishers.Load();


			sinnerBindingSource.DataSource = _context.Sinners.Local.ToBindingList();
			
			sinBindingSource.DataSource = _context.Sins.Local.ToBindingList();
			punishmentBindingSource.DataSource = _context.Punishments.Local.ToBindingList();

			genderBindingSource.DataSource = _context.Genders.ToList();
			radGridView1.DataSource = sinnerSinsBindingSource;
			
		}
		private void saveChangesButton_Click(object sender, EventArgs e)
		{


			//_context.SaveChanges();


			try
			{
				this.Validate();
				sinnerBindingSource.EndEdit();
				sinnersDataGridView.EndEdit();
				MessageBox.Show("Update successful");
				_context.SaveChanges();
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Update failed");
			}


		}

		private void sinnersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{

		}

		//Sinner
		private void sinnerBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			Sinner selectedSinner = sinnerBindingSource.Current as Sinner;
			if (selectedSinner == null) return;
			sinnerSinsBindingSource.DataSource = selectedSinner.Sins.ToList();
			//sinnerSinsBindingSource.ResetBindings(false); //update gv


		}


		//Punishment
		private void punishmentBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			Punishment selectedPunishment = punishmentBindingSource.Current as Punishment;
			if (selectedPunishment == null) return;
			punishmentSinsBindingSource.DataSource = selectedPunishment.Sins.ToList();
		}



		private void sinnersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void masterGridView_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
		{
		}



		private void punishmentSinsBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void HellManager_Load(object sender, EventArgs e)
		{

		}

		private void sinnerSinsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void tabPage4_Click(object sender, EventArgs e)
		{

		}

		private void sinnersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			// you can obtain current editing value like this:
			string value = null;
			var ctl = sinnersDataGridView.EditingControl as DataGridViewTextBoxEditingControl;

			if (ctl != null)
				value = ctl.Text;

			// you can obtain the current commited value
			object current = sinnersDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
			string message;
			switch (e.ColumnIndex)
			{
				case 0:
				case 1:
					// bound to integer field
					message = "the value should be a number";
					break;
				default:
					message = "Invalid data";
					break;
			}

			MessageBox.Show(message);
		}





		/*public void GetPunishmentSins()
{
var matchingSins = _context.Punishments.GroupJoin(_context.Sins, punishment => punishment.Id,
sin => sin.PunishmentId,
(punishment, availableSins) => new { punishment, sins = availableSins });
_groupSins = matchingSins.ToDictionary(x => x.punishment, y => y.sins);


punishmentBindingSource.DataSource = _groupSins.Keys;

}*/

	}



}
