/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 15/01/2024
 * Time: 13:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class Navegador
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button bntconfirma;
		private System.Windows.Forms.Button bntnovaguia;
		private System.Windows.Forms.Button bntretorna;
		private System.Windows.Forms.Button bntavanca;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button bntreload;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.bntconfirma = new System.Windows.Forms.Button();
			this.bntnovaguia = new System.Windows.Forms.Button();
			this.bntretorna = new System.Windows.Forms.Button();
			this.bntavanca = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.bntreload = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(144, 34);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(715, 20);
			this.txtUrl.TabIndex = 2;
			// 
			// bntconfirma
			// 
			this.bntconfirma.BackColor = System.Drawing.Color.Black;
			this.bntconfirma.ForeColor = System.Drawing.Color.White;
			this.bntconfirma.Location = new System.Drawing.Point(870, 29);
			this.bntconfirma.Name = "bntconfirma";
			this.bntconfirma.Size = new System.Drawing.Size(29, 27);
			this.bntconfirma.TabIndex = 3;
			this.bntconfirma.Text = "🔍";
			this.bntconfirma.UseVisualStyleBackColor = false;
			this.bntconfirma.Click += new System.EventHandler(this.BntconfirmaClick);
			// 
			// bntnovaguia
			// 
			this.bntnovaguia.BackColor = System.Drawing.Color.Black;
			this.bntnovaguia.ForeColor = System.Drawing.Color.White;
			this.bntnovaguia.Location = new System.Drawing.Point(905, 29);
			this.bntnovaguia.Name = "bntnovaguia";
			this.bntnovaguia.Size = new System.Drawing.Size(91, 27);
			this.bntnovaguia.TabIndex = 4;
			this.bntnovaguia.Text = "Nova Guia";
			this.bntnovaguia.UseVisualStyleBackColor = false;
			this.bntnovaguia.Click += new System.EventHandler(this.BntnovaguiaClick);
			// 
			// bntretorna
			// 
			this.bntretorna.BackColor = System.Drawing.Color.Black;
			this.bntretorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntretorna.ForeColor = System.Drawing.Color.White;
			this.bntretorna.Location = new System.Drawing.Point(12, 29);
			this.bntretorna.Name = "bntretorna";
			this.bntretorna.Size = new System.Drawing.Size(38, 27);
			this.bntretorna.TabIndex = 5;
			this.bntretorna.Text = "<";
			this.bntretorna.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bntretorna.UseVisualStyleBackColor = false;
			this.bntretorna.Click += new System.EventHandler(this.BntretornaClick);
			// 
			// bntavanca
			// 
			this.bntavanca.BackColor = System.Drawing.Color.Black;
			this.bntavanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntavanca.ForeColor = System.Drawing.Color.White;
			this.bntavanca.Location = new System.Drawing.Point(56, 29);
			this.bntavanca.Name = "bntavanca";
			this.bntavanca.Size = new System.Drawing.Size(38, 27);
			this.bntavanca.TabIndex = 6;
			this.bntavanca.Text = ">";
			this.bntavanca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bntavanca.UseVisualStyleBackColor = false;
			this.bntavanca.Click += new System.EventHandler(this.BntavancaClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Location = new System.Drawing.Point(13, 65);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(983, 652);
			this.tabControl1.TabIndex = 7;
			// 
			// bntreload
			// 
			this.bntreload.BackColor = System.Drawing.Color.Black;
			this.bntreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntreload.ForeColor = System.Drawing.Color.White;
			this.bntreload.Image = ((System.Drawing.Image)(resources.GetObject("bntreload.Image")));
			this.bntreload.Location = new System.Drawing.Point(100, 29);
			this.bntreload.Name = "bntreload";
			this.bntreload.Size = new System.Drawing.Size(38, 27);
			this.bntreload.TabIndex = 8;
			this.bntreload.Text = "↺";
			this.bntreload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bntreload.UseVisualStyleBackColor = false;
			this.bntreload.Click += new System.EventHandler(this.Button1Click);
			// 
			// Navegador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.bntreload);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.bntavanca);
			this.Controls.Add(this.bntretorna);
			this.Controls.Add(this.bntnovaguia);
			this.Controls.Add(this.bntconfirma);
			this.Controls.Add(this.txtUrl);
			this.Name = "Navegador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Navegador";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
