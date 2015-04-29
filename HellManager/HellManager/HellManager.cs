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
		readonly EFModelContainer _context = new EFModelContainer();
		private Dictionary<Punishment, IEnumerable<Sin>> _groupSins;

		public HellManager()
		{
			InitializeComponent();
			sinnerBindingSource.DataSource = _context.Sinners.ToList();
			sinBindingSource.DataSource = _context.Sins.ToList();

			GetPunishmentSins();
			//Sinner sinner = _context.Sinners.First();
			//sinnerSinsBindingSource.DataSource = sinner.Sins;

			/*IQueryable<SinsDTO> dtos = from sinner in _context.Sinners
					   from sin in sinner.Sins
					   select new SinsDTO()
					   {
						   Sinner = sinner.FullName,
						   Sins = sin.Name
					   };*/


		}

		private void HellManager_Load(object sender, EventArgs e)
		{
			sinnerSinsBindingSource.DataSource = sinnerBindingSource;
			sinnerSinsBindingSource.DataMember = "Sins";
		}

		private void sinnersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (sinnersDataGridView.SelectedRows.Count != 0)
			{
				DataGridViewRow row = this.sinnersDataGridView.SelectedRows[0];
				String clickRez = row.Cells["Name"].Value.ToString();
				MessageBox.Show(clickRez);
			}
			//			var ids = sinnersDataGridView.SelectedRows. GetSelectedFieldValues("id");
			//			foreach (var id in ids)
		}

		private void masterGridView_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
		{
			//			if (e.CurrentRow != null && e.CurrentRow is GridViewDataRowInfo)
			//			{
			//				this.detailGridView.DataSource = ((_context.Punishments)((DataRowView)e.CurrentRow.DataBoundItem).Row).
			//			}
		}

		public void GetPunishmentSins()
		{
			var matchingSins = _context.Punishments.GroupJoin(_context.Sins, punishment => punishment.Id,
				sin => sin.PunishmentId,
				(punishment, availableSins) => new { punishment, sins = availableSins });
			_groupSins = matchingSins.ToDictionary(x => x.punishment, y => y.sins);


			punishmentBindingSource.DataSource = _groupSins.Keys;

		}

		private void punishmentSinsBindingSource_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void punishmentBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			punishmentSinsBindingSource.DataSource = _groupSins[(Punishment)punishmentBindingSource.Current];
		}
	}



}
