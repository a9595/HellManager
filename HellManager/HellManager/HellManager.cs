﻿using System;
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


		}


		public void GetPunishmentSins()
		{
			var matchingSins = _context.Punishments.GroupJoin(_context.Sins, punishment => punishment.Id,
				sin => sin.PunishmentId,
				(punishment, availableSins) => new { punishment, sins = availableSins });
			_groupSins = matchingSins.ToDictionary(x => x.punishment, y => y.sins);


			punishmentBindingSource.DataSource = _groupSins.Keys;

		}

		/*public void GetSinnerSins()
		{
			var matchingSins = _context.Sinners.GroupJoin(_context.Sins, sinner => sinner.Id,
				sin => sin.PunishmentId,
				(punishment, availableSins) => new { punishment, sins = availableSins });
			_groupSins = matchingSins.ToDictionary(x => x.punishment, y => y.sins);


			punishmentBindingSource.DataSource = _groupSins.Keys;

		}*/
		private void punishmentBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			Punishment currentPunishment = punishmentBindingSource.Current as Punishment;
			//if (currentPunishment != null) punishmentSinsBindingSource.DataSource = currentPunishment.Sins.ToList();

			punishmentSinsBindingSource.DataSource = _groupSins[(Punishment)punishmentBindingSource.Current];
		}

		private void sinnerBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			Sinner sinner = sinnerBindingSource.Current as Sinner;
			if (sinner == null) return;
			sinnerSinsBindingSource.DataSource = sinner.Sins.ToList();


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

	}



}
