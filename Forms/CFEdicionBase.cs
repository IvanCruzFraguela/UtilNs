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
	public partial class CFEdicionBase : IvanCruz.Util.Forms.CFPanelado {

		public CFEdicionBase() {
			InitializeComponent();
		}
		protected bool QuiereGrabar;
		protected EOperation Operation;
		public virtual void Grabar() {
			this.QuiereGrabar = true;
			this.Close();
		}
		public virtual void Salir() {
			this.QuiereGrabar = false;
			this.Close();
		}
		protected virtual void CerrandoFormulario(object sender, FormClosingEventArgs e) {
			MessageBox.Show("Sin implementar");
		}
		private void btnSalir_Click(object sender, EventArgs e) {
			this.Salir();
		}
		private void btnGrabar_Click(object sender, EventArgs e) {
			this.Grabar();
		}
		private void CFEdicionBase_FormClosing(object sender, FormClosingEventArgs e) {
			CerrandoFormulario(sender, e);
		}
		protected virtual bool EsValido() {
			return true;
		}
		protected virtual void GestionarExcepcion(Exception ex, ILog log) {
			MessageBox.Show(ex.Message);
			log.Error(ex.Message);
#if DEBUG
			log.Error(ex.StackTrace);
#endif
		}
	}
}
