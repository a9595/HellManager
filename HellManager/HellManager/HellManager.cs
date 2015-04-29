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
			sinnerBindingSource.DataSource = _context.Sinners.Local.ToBindingList();



			//sinnerBindingSource.DataSource = _context.Sinners.ToList();
			sinBindingSource.DataSource = _context.Sins.ToList();
			punishmentBindingSource.DataSource = _context.Punishments.ToList();
			genderBindingSource.DataSource = _context.Genders.ToList();
			sinnerSinsDataGridView.DataSource = sinnerSinsBindingSource;




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
