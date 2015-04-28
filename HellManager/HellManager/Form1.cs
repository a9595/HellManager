using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkDAL;

namespace HellManager
{
	public partial class Form1 : Form
	{
		readonly EFModelContainer _context = new EFModelContainer();
		public Form1()
		{
			InitializeComponent();
			SinnersDataGridView.DataSource = _context.Sinners.ToList();
			comboBox1.DataSource = _context.Sins.ToList();

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ButtonSaveChanges_Click(object sender, EventArgs e)
		{
			_context.SaveChanges();
			//dataGridView1.Update();
			SinnersDataGridView.Refresh();
			comboBox1.Refresh();
		}
	}
}
