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
	public partial class CFPrincipalBase : Form {
		public CFPrincipalBase() {
			InitializeComponent();
			InicializarComponentes();
		}

		private void InicializarComponentes() {
			InicializarTbMensajes();
		}

		private void InicializarTbMensajes() {
			this.tbMensajes.Parent = this;
			this.tbMensajes.Multiline = true;
			this.tbMensajes.Dock = DockStyle.Bottom;
			this.tbMensajes.Height = this.ClientSize.Height - 300;
			this.tbMensajes.ReadOnly = true;
			this.tbMensajes.TabStop = false;
		}

		public TextBox TbMensajes {
			get {
				return this.tbMensajes;
			}
		}
	}
}
