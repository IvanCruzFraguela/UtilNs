using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanCruz.Util.UtilBD {
	public class BoException:Exception {
		public BoException(string message, Exception innerException) : base(message, innerException) { }
	}
}
