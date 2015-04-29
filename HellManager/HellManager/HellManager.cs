using System;
using System.Collections.Generic;
using System.Data;
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

			DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
			cmb.DataSource = _context.Genders.ToList();
			cmb.DisplayMember = "Name";
			cmb.ValueMember = "Id";
			cmb.DataPropertyName = "Id";
			//sinnersDataGridView.Columns.Add(cmb);


		}

		private void SetDataSources()
		{
			sinnerBindingSource.DataSource = _context.Sinners.ToList();
			sinBindingSource.DataSource = _context.Sins.ToList();
			punishmentBindingSource.DataSource = _context.Punishments.ToList();
			genderBindingSource.DataSource = _context.Genders.ToList();

		}
		private void saveChangesButton_Click(object sender, EventArgs e)
		{

			Sinner sinner = new Sinner()
			{
				FullName = "Ania"

			};
			_context.Sinners.Add(sinner);
			_context.SaveChanges();


//			if (sinnersDataGridView.IsCurrentCellDirty || sinnersDataGridView.IsCurrentRowDirty)
//			{
//				sinnersDataGridView.CurrentRow?.DataGridView.EndEdit();
//				sinnersDataGridView.EndEdit();
//
//				CurrencyManager cm = (CurrencyManager)sinnersDataGridView.BindingContext[sinnersDataGridView.DataSource, sinnersDataGridView.DataMember];
//				cm.EndCurrentEdit();
//
//			}
//			_context.SaveChanges();


		}

		//Sinner
		private void sinnerBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			Sinner selectedSinner = sinnerBindingSource.Current as Sinner;
			if (selectedSinner == null) return;
			sinnerSinsBindingSource.DataSource = selectedSinner.Sins.ToList();


			sinnerSinsDataGridView.DataSource = sinnerSinsBindingSource;
			sinnerSinsBindingSource.ResetBindings(false); //update gv

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
