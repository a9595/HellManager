using EntityFrameworkDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellManager
{
	public partial class SinnerInfo : Form
	{
		private readonly EFModelContainer _context = new EFModelContainer();
		public SinnerInfo()
		{
			InitializeComponent();
		}

		private void SetDataSources()
		{
			_context.Genders.Load();			

		}
		public SinnerInfo(Sinner sinner)
		{
			InitializeComponent();
			SetDataSources();

			fullNameRadTextBox.Text = sinner.FullName;
			ageNumericUpDown.Value = (decimal) sinner.Age;
			jobTitleRadTextBox.Text = sinner.JobTitle;
			salaryNumericUpDown.Value = (decimal) sinner.Salary;

			genderComboBox.DataSource = _context.Genders.ToList();

			genderComboBox.DisplayMember = "name";

			if (sinner.Gender == null)
			{
				genderComboBox.SelectedItem = null;
			}
			else
			{

				genderComboBox.SelectedItem = sinner.Gender;
			}

			
		}

	}
}
