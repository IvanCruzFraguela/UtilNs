namespace IvanCruz.Util.Forms {
	partial class CFPrincipalBase {
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
			this.tbMensajes = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tbMensajes
			// 
			this.tbMensajes.Location = new System.Drawing.Point(114, 369);
			this.tbMensajes.Name = "tbMensajes";
			this.tbMensajes.Size = new System.Drawing.Size(100, 20);
			this.tbMensajes.TabIndex = 0;
			// 
			// CFPrincipalBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 521);
			this.Controls.Add(this.tbMensajes);
			this.Name = "CFPrincipalBase";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Text = "CFPrincipal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbMensajes;
	}
}