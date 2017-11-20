/*
 * Creado por SharpDevelop.
 * Usuario: ivancf
 * Fecha: 07/05/2012
 * Hora: 14:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using IvanCruz.Util.UtilBD;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util.Controls;
using static System.Windows.Forms.Control;

namespace IvanCruz.Util {
    /// <summary>
    /// Description of UtilUI.
    /// </summary>
    public static class SUtilUI {
        public const float ProporcionAurea = 1.618F;
        public static void FormInit(Form form, string text) {
            form.Width = Convert.ToInt32(Math.Round(form.Height * ProporcionAurea));
            form.ShowInTaskbar = false;
            form.Text = text;
            form.Padding = new Padding(3);
        }
        public static void FormInitPrincipal(Form form,string text) {
            form.Width = Convert.ToInt32(Math.Round(form.Height * ProporcionAurea));
            form.Text = text;
        }

		public static void DGVInit(DataGridView dgv, object DataSource) {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = DataSource;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
        }

        public static int MaxWidth(params Control[] aControl) {
            int result = 0;
            foreach (var item in aControl) {
                if (item.Width > result) {
                    result = item.Width;
                }
            }
            return result;
        }
        public static int MaxWidth(ControlCollection aControl) {
            int result = 0;
            foreach (Control item in aControl) {
                if (item.Visible) {
                    if (item.Width > result) {
                        result = item.Width;
                    }
                }
            }
            return result;
        }
        public static int MaxWidthAndMargin(ControlCollection aControl) {
            int result = 0;
            foreach (Control item in aControl) {
                if (item.Visible) {
                    int ancho = item.Width + item.Margin.Left + item.Margin.Right;
                    if (ancho > result) {
                        result = ancho;
                    }
                }
            }
            return result;
        }


        public static DataGridViewTextBoxColumn AnadirColumna(DataGridView dgv, string Campo, string Titulo) {
            return SUtilUI.AnadirColumna(dgv, Campo, Titulo, -1, true);
        }
        public static DataGridViewTextBoxColumn AnadirColumna(DataGridView dgv, string Campo, string Titulo, int ancho, bool Visible = true) {
            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.DataPropertyName = Campo;
            c.HeaderText = Titulo;
            if (ancho > 0) {
                c.Width = ancho;
            }
            c.ReadOnly = true;
            c.Visible = Visible;
            dgv.Columns.Add(c);
            return c;
        }
		public static DataGridViewTextBoxColumn AnadirColumna(DataGridView dgv, CFieldDef f) {
			return SUtilUI.AnadirColumna(dgv,f.Name, f.Title, f.WidthInGrid, f.VisibleInGrid);
		}
        public static DataGridViewCheckBoxColumn AnadirColumnaCheck(DataGridView dgv, string Campo, string Titulo, int ancho, bool Visible = true) {
            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.DataPropertyName = Campo;
            c.SortMode = DataGridViewColumnSortMode.Automatic;
            c.HeaderText = Titulo;
            if (ancho > 0) {
                c.Width = ancho;
            }
            c.ReadOnly = true;
            c.Visible = Visible;
            c.FlatStyle = FlatStyle.Flat;// Para que de la sensación de no poder modificarse. Sería quitarle el 3D.
            dgv.Columns.Add(c);
            return c;
        }
        public static bool PedirContrasena(ref string contrasena) {
            bool result = false;
            using (Forms.FContrasena f = new Forms.FContrasena()) {
                if (f.ShowDialog() == DialogResult.OK) {
                    result = true;
                    contrasena = f.Contrasena;
                }
            }
            return result;
        }
        public static void TrimText(params Control[] aControl) {
            foreach (Control item in aControl) {
                item.Text = item.Text.Trim();
            }
        }
        public static void SetVisible(bool visible, params Control[] aControl) {
            foreach (Control item in aControl) {
                item.Visible = visible;
            }
        }
		public static Label CreateLabel(Control parent, int x, int y, string text) {
			Label item = new Label();
			item.AutoSize = true;
			item.Left = x;
			item.Top = y;
			item.Text = text;
			item.Parent = parent;
			return item;
		}
		public static TextBox CreateTextBox(Control parent, int x, int y, int width,string initialText,int maxLength) {
			TextBox item = new TextBox();
			item.Parent = parent;
			item.Left = x;
			item.Top = y;
			item.Width = width;
			item.Text = initialText;
			item.MaxLength = maxLength;
			return item;
		}
		public static CCombo CreateComboBox(Control parent, int x, int y, int width) {
			CCombo item = new CCombo();
			item.Parent = parent;
			item.Left = x;
			item.Top = y;
			item.Width = width;
			return item;
		}
    }
}
