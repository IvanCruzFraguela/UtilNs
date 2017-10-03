namespace IvanCruz.Util.Forms {
	partial class CFEdicionBase {
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
			this.btnGrabar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.panelBotonera.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBotonera
			// 
			this.panelBotonera.Controls.Add(this.btnSalir);
			this.panelBotonera.Controls.Add(this.btnGrabar);
			// 
			// btnGrabar
			// 
			this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnGrabar.Location = new System.Drawing.Point(13, 65);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(75, 23);
			this.btnGrabar.TabIndex = 0;
			this.btnGrabar.Text = "Grabar";
			this.btnGrabar.UseVisualStyleBackColor = true;
			this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalir.Location = new System.Drawing.Point(467, 65);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 1;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// CFEdicionBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 443);
			this.Name = "CFEdicionBase";
			this.Text = "CFEdicionBase";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CFEdicionBase_FormClosing);
			this.panelBotonera.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGrabar;
		private System.Windows.Forms.Button btnSalir;
	}
}