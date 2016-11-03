using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilns.UserControls {
    public partial class BotonesAceptarCancelar : UserControl {
        public BotonesAceptarCancelar() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if((this.Parent != null) && (this.Parent is Form)) {
                ((Form)this.Parent).DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if((this.Parent!= null) && (this.Parent is Form)) {
                ((Form)this.Parent).DialogResult = DialogResult.Cancel;
            }
        }
    }
}
