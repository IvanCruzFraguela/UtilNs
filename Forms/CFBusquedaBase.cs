using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvanCruz.Util.Forms {
	public partial class CFBusquedaBase : CFPanelado {

		public CFBusquedaBase() {
			InitializeComponent();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnBuscar_Click(object sender, EventArgs e) {
			this.Buscar();
		}

		protected virtual void Buscar() {
			MessageBox.Show("Sin implementar");
		}
		protected string AddPercentages(string cad) {
			return "%" + cad + "%";
		}
	}
}
