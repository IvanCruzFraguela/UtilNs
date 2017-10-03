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
	public  partial class CFListaBase : CFPanelado{
		public CFListaBase() {
			InitializeComponent();
		}
		public virtual void Modificar() {
			throw new NotImplementedException("Modificar no implementado");
		}
		public virtual void Eliminar() {
			throw new NotImplementedException("Eliminar no implementado");
		}
		protected virtual void Salir() {
			this.Close();
		}

		private void btnModificar_Click(object sender, EventArgs e) {
			this.Modificar();
		}

		private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			this.Modificar();
		}

		private void btnEliminar_Click(object sender, EventArgs e) {
			this.Eliminar();
		}

		private void btnSalir_Click(object sender, EventArgs e) {
			this.Salir();
		}

	}
}
