using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanCruz.Util.UtilBD {
	public abstract  class CTableDef {
		public abstract string TableName { get; }
		public abstract string SingularTitle { get; }
		public abstract System.Collections.Generic.IEnumerable<CFieldDef> Fields { get; }

	}
}
