﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkDAL;

namespace HellManager
{
	public partial class HellManager : Form
	{
		EFModelContainer _context = new EFModelContainer();
		public HellManager()
		{
			InitializeComponent();
			sinnerBindingSource.DataSource = _context.Sinners.ToList();
			sinBindingSource.DataSource = _context.Sins.ToList();

		}
	}
}
