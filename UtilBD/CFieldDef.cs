using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanCruz.Util.UtilBD {
	public class CFieldDef {
		public string Name;
		public string Title;
		public int WidthInGrid = 100;
		public bool VisibleInGrid = true;
		public CFieldDef(string name) {
			this.Name = name;
			this.Title = name;
		}
		public CFieldDef(string name, string title) {
			this.Name = name;
			this.Title = title;
		}
	}
}
