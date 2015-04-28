using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDAL
{
	public class DBInitializer : DropCreateDatabaseAlways<EFModelContainer>
	{
		private readonly List<Sinner> _sinners = new List<Sinner>(); 
		public DBInitializer()
		{
			_sinners.Add(new Sinner("Bob"));
			_sinners.Add(new Sinner("Bob"));
			_sinners.Add(new Sinner("Bob"));
			_sinners.Add(new Sinner("Bob"));
			_sinners.Add(new Sinner("Bob"));
			_sinners.Add(new Sinner("Bob"));
			_sinners.Add(new Sinner("Bob"));
		}

		protected override void Seed(EFModelContainer context)
		{
			foreach (Sinner s in _sinners)
			{
				context.Sinners.Add(s);
			}
			context.SaveChanges();
			base.Seed(context);
		}
	}

}
