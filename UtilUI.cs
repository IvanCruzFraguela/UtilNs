/*
 * Creado por SharpDevelop.
 * Usuario: ivancf
 * Fecha: 07/05/2012
 * Hora: 14:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;

namespace es.ivancruz.Utils
{
	/// <summary>
	/// Description of UtilUI.
	/// </summary>
	public static class UtilUI
	{
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
		public static void AnadirColumna(DataGridView dgv, string Campo, string Titulo) {
			AnadirColumna(dgv, Campo, Titulo, -1, true);
		}
		public static void AnadirColumna(DataGridView dgv, string Campo, string Titulo, int ancho) {
			AnadirColumna(dgv, Campo, Titulo, ancho, true);
		}
		public static void AnadirColumna(DataGridView dgv, string Campo, string Titulo, int ancho, bool Visible) {
			DataGridViewTextBoxColumn c;
			c = new DataGridViewTextBoxColumn();
			c.DataPropertyName = Campo;
			c.HeaderText = Titulo;
			if (ancho > 0) {
				c.Width = ancho;
			}
			c.ReadOnly = true;
			c.Visible = Visible;
			dgv.Columns.Add(c);
		}

	}
}
