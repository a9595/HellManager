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
			dataGridView1.DataSource = _context.Sinners.ToList();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
