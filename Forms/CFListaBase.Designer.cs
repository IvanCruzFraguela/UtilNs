namespace IvanCruz.Util.Forms {
	partial class CFListaBase {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.dgv = new System.Windows.Forms.DataGridView();
			this.btnModificar = new System.Windows.Forms.Button();
			this.flpBotonera = new System.Windows.Forms.FlowLayoutPanel();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.flpDerecha = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panelPrincipal.SuspendLayout();
			this.panelBotonera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.flpBotonera.SuspendLayout();
			this.flpDerecha.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelPrincipal
			// 
			this.panelPrincipal.Controls.Add(this.dgv);
			this.panelPrincipal.Size = new System.Drawing.Size(631, 405);
			// 
			// panelBotonera
			// 
			this.panelBotonera.Controls.Add(this.flpBotonera);
			this.panelBotonera.Controls.Add(this.flpDerecha);
			this.panelBotonera.Location = new System.Drawing.Point(0, 405);
			this.panelBotonera.Size = new System.Drawing.Size(631, 30);
			// 
			// dgv
			// 
			this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(12, 12);
			this.dgv.Name = "dgv";
			this.dgv.Size = new System.Drawing.Size(607, 387);
			this.dgv.TabIndex = 0;
			this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(3, 3);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 0;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// flpBotonera
			// 
			this.flpBotonera.Controls.Add(this.btnModificar);
			this.flpBotonera.Controls.Add(this.btnEliminar);
			this.flpBotonera.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpBotonera.Location = new System.Drawing.Point(0, 0);
			this.flpBotonera.Name = "flpBotonera";
			this.flpBotonera.Size = new System.Drawing.Size(550, 30);
			this.flpBotonera.TabIndex = 1;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(84, 3);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 1;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// flpDerecha
			// 
			this.flpDerecha.AutoSize = true;
			this.flpDerecha.Controls.Add(this.btnSalir);
			this.flpDerecha.Dock = System.Windows.Forms.DockStyle.Right;
			this.flpDerecha.Location = new System.Drawing.Point(550, 0);
			this.flpDerecha.Name = "flpDerecha";
			this.flpDerecha.Size = new System.Drawing.Size(81, 30);
			this.flpDerecha.TabIndex = 2;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(3, 3);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// CFListaBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 435);
			this.Name = "CFListaBase";
			this.Text = "CFLista";
			this.panelPrincipal.ResumeLayout(false);
			this.panelBotonera.ResumeLayout(false);
			this.panelBotonera.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.flpBotonera.ResumeLayout(false);
			this.flpDerecha.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.FlowLayoutPanel flpBotonera;
		private System.Windows.Forms.FlowLayoutPanel flpDerecha;
		protected System.Windows.Forms.Button btnModificar;
		protected System.Windows.Forms.Button btnSalir;
		protected System.Windows.Forms.Button btnEliminar;
	}
}