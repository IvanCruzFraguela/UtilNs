using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilns.UserControls;

namespace IvanCruz.Utilns.Forms {
    public partial class FContrasena : Form {
        public string Contrasena {
            get {
                return this.tbContrasena.Text;
            }
            set {
                this.tbContrasena.Text = value;
            }
        }

        BotonesAceptarCancelar BotonesAceptarCancelar;

        public FContrasena() {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes() {
            this.Text = "Introduzca contraseña";
            this.BotonesAceptarCancelar = new BotonesAceptarCancelar();
            this.BotonesAceptarCancelar.Parent = this;
            this.BotonesAceptarCancelar.Dock = DockStyle.Bottom;
            this.AcceptButton = this.BotonesAceptarCancelar.btnAceptar;
            this.CancelButton = this.BotonesAceptarCancelar.btnCancelar;
        }
    }
}
