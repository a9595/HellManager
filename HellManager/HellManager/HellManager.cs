using System;
using System.Linq;
using System.Windows.Forms;
using EntityFrameworkDAL;

namespace HellManager
{
	public partial class HellManager : Form
	{
		readonly EFModelContainer _context = new EFModelContainer();
		public HellManager()
		{
			InitializeComponent();
			sinnerBindingSource.DataSource = _context.Sinners.ToList();
			sinBindingSource.DataSource = _context.Sins.ToList();


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

	}
	


}
