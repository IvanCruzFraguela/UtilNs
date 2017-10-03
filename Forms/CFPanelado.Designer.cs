namespace IvanCruz.Util.Forms {
	partial class CFPanelado {
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
			this.panelPrincipal = new System.Windows.Forms.Panel();
			this.panelBotonera = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelPrincipal
			// 
			this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
			this.panelPrincipal.Name = "panelPrincipal";
			this.panelPrincipal.Size = new System.Drawing.Size(554, 343);
			this.panelPrincipal.TabIndex = 0;
			// 
			// panelBotonera
			// 
			this.panelBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBotonera.Location = new System.Drawing.Point(0, 343);
			this.panelBotonera.Name = "panelBotonera";
			this.panelBotonera.Size = new System.Drawing.Size(554, 100);
			this.panelBotonera.TabIndex = 1;
			// 
			// CFPanelado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 443);
			this.Controls.Add(this.panelPrincipal);
			this.Controls.Add(this.panelBotonera);
			this.Name = "CFPanelado";
			this.Text = "CFPanelado";
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Panel panelPrincipal;
		protected System.Windows.Forms.Panel panelBotonera;
	}
}