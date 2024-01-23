/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 11/10/2023
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class Adivinhacao_de_Numeros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonTentar;
		private System.Windows.Forms.TextBox msktentativas;
		private System.Windows.Forms.Button bntsair;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Button bntnuivel1;
		private System.Windows.Forms.Button bntnivel2;
		private System.Windows.Forms.Button bntnivel3;
		private System.Windows.Forms.Label labelResultado;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label labeltentativasrest;
		private System.Windows.Forms.Button bntnew;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adivinhacao_de_Numeros));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonTentar = new System.Windows.Forms.Button();
			this.bntsair = new System.Windows.Forms.Button();
			this.Anter = new System.Windows.Forms.Label();
			this.bntnuivel1 = new System.Windows.Forms.Button();
			this.bntnivel2 = new System.Windows.Forms.Button();
			this.bntnivel3 = new System.Windows.Forms.Button();
			this.labelResultado = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.labeltentativasrest = new System.Windows.Forms.Label();
			this.bntnew = new System.Windows.Forms.Button();
			this.msktentativas = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(828, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bem Vindo ao Jogo de Adivinhação";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonTentar
			// 
			this.buttonTentar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTentar.BackgroundImage")));
			this.buttonTentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTentar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonTentar.Location = new System.Drawing.Point(368, 423);
			this.buttonTentar.Name = "buttonTentar";
			this.buttonTentar.Size = new System.Drawing.Size(122, 37);
			this.buttonTentar.TabIndex = 2;
			this.buttonTentar.Text = "Tentar";
			this.buttonTentar.UseVisualStyleBackColor = true;
			this.buttonTentar.Click += new System.EventHandler(this.ButtonTentarClick);
			// 
			// bntsair
			// 
			this.bntsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntsair.BackgroundImage")));
			this.bntsair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntsair.Location = new System.Drawing.Point(762, 497);
			this.bntsair.Name = "bntsair";
			this.bntsair.Size = new System.Drawing.Size(78, 30);
			this.bntsair.TabIndex = 20;
			this.bntsair.Text = "Voltar";
			this.bntsair.UseVisualStyleBackColor = true;
			this.bntsair.Click += new System.EventHandler(this.BntsairClick);
			// 
			// Anter
			// 
			this.Anter.BackColor = System.Drawing.Color.Transparent;
			this.Anter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anter.ForeColor = System.Drawing.Color.White;
			this.Anter.Location = new System.Drawing.Point(12, 12);
			this.Anter.Name = "Anter";
			this.Anter.Size = new System.Drawing.Size(23, 28);
			this.Anter.TabIndex = 19;
			this.Anter.Text = "ᐸ";
			this.Anter.Click += new System.EventHandler(this.AnterClick);
			// 
			// bntnuivel1
			// 
			this.bntnuivel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnuivel1.BackgroundImage")));
			this.bntnuivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntnuivel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnuivel1.Location = new System.Drawing.Point(150, 176);
			this.bntnuivel1.Name = "bntnuivel1";
			this.bntnuivel1.Size = new System.Drawing.Size(122, 37);
			this.bntnuivel1.TabIndex = 21;
			this.bntnuivel1.Text = "Nível 1";
			this.bntnuivel1.UseVisualStyleBackColor = true;
			this.bntnuivel1.Click += new System.EventHandler(this.Bntnuivel1Click);
			// 
			// bntnivel2
			// 
			this.bntnivel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnivel2.BackgroundImage")));
			this.bntnivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntnivel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnivel2.Location = new System.Drawing.Point(368, 176);
			this.bntnivel2.Name = "bntnivel2";
			this.bntnivel2.Size = new System.Drawing.Size(122, 37);
			this.bntnivel2.TabIndex = 22;
			this.bntnivel2.Text = "Nível 2";
			this.bntnivel2.UseVisualStyleBackColor = true;
			this.bntnivel2.Click += new System.EventHandler(this.Bntnivel2Click);
			// 
			// bntnivel3
			// 
			this.bntnivel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnivel3.BackgroundImage")));
			this.bntnivel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntnivel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnivel3.Location = new System.Drawing.Point(557, 176);
			this.bntnivel3.Name = "bntnivel3";
			this.bntnivel3.Size = new System.Drawing.Size(122, 37);
			this.bntnivel3.TabIndex = 23;
			this.bntnivel3.Text = "Nível 3";
			this.bntnivel3.UseVisualStyleBackColor = true;
			this.bntnivel3.Click += new System.EventHandler(this.Bntnivel3Click);
			// 
			// labelResultado
			// 
			this.labelResultado.BackColor = System.Drawing.Color.Transparent;
			this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelResultado.Location = new System.Drawing.Point(12, 259);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(828, 36);
			this.labelResultado.TabIndex = 24;
			this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.Transparent;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label.Location = new System.Drawing.Point(12, 103);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(828, 44);
			this.label.TabIndex = 25;
			this.label.Text = "Escolha um nível";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labeltentativasrest
			// 
			this.labeltentativasrest.BackColor = System.Drawing.Color.Transparent;
			this.labeltentativasrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltentativasrest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labeltentativasrest.Location = new System.Drawing.Point(12, 308);
			this.labeltentativasrest.Name = "labeltentativasrest";
			this.labeltentativasrest.Size = new System.Drawing.Size(166, 36);
			this.labeltentativasrest.TabIndex = 26;
			this.labeltentativasrest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bntnew
			// 
			this.bntnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntnew.BackgroundImage")));
			this.bntnew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnew.Location = new System.Drawing.Point(12, 497);
			this.bntnew.Name = "bntnew";
			this.bntnew.Size = new System.Drawing.Size(78, 30);
			this.bntnew.TabIndex = 39;
			this.bntnew.Text = "Novo";
			this.bntnew.UseVisualStyleBackColor = true;
			this.bntnew.Click += new System.EventHandler(this.BntnewClick);
			// 
			// msktentativas
			// 
			this.msktentativas.Enabled = false;
			this.msktentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msktentativas.Location = new System.Drawing.Point(319, 333);
			this.msktentativas.Name = "msktentativas";
			this.msktentativas.Size = new System.Drawing.Size(220, 26);
			this.msktentativas.TabIndex = 40;
			// 
			// Adivinhacao_de_Numeros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 538);
			this.Controls.Add(this.msktentativas);
			this.Controls.Add(this.bntnew);
			this.Controls.Add(this.labeltentativasrest);
			this.Controls.Add(this.label);
			this.Controls.Add(this.labelResultado);
			this.Controls.Add(this.bntnivel3);
			this.Controls.Add(this.bntnivel2);
			this.Controls.Add(this.bntnuivel1);
			this.Controls.Add(this.bntsair);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.buttonTentar);
			this.Controls.Add(this.label1);
			this.Name = "Adivinhacao_de_Numeros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adivinhacao_de_Numeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
