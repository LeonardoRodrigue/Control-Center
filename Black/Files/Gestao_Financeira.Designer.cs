/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 15/03/2024
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class Gestao_Financeira
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button bntsair;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Button bntnovo;
		private System.Windows.Forms.Button bntcalcular;
		private System.Windows.Forms.TextBox totpagar;
		private System.Windows.Forms.TextBox totreceber;
		private System.Windows.Forms.TextBox dinheiro_movimentado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox lucro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox despesa;
		private System.Windows.Forms.TextBox receita;
		private System.Windows.Forms.Button bntguadar;
		
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
			this.bntsair = new System.Windows.Forms.Button();
			this.Anter = new System.Windows.Forms.Label();
			this.bntnovo = new System.Windows.Forms.Button();
			this.bntcalcular = new System.Windows.Forms.Button();
			this.totpagar = new System.Windows.Forms.TextBox();
			this.totreceber = new System.Windows.Forms.TextBox();
			this.dinheiro_movimentado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lucro = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.despesa = new System.Windows.Forms.TextBox();
			this.receita = new System.Windows.Forms.TextBox();
			this.bntguadar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bntsair
			// 
			this.bntsair.BackColor = System.Drawing.Color.Black;
			this.bntsair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntsair.Location = new System.Drawing.Point(315, 497);
			this.bntsair.Name = "bntsair";
			this.bntsair.Size = new System.Drawing.Size(78, 30);
			this.bntsair.TabIndex = 23;
			this.bntsair.Text = "Voltar";
			this.bntsair.UseVisualStyleBackColor = false;
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
			this.Anter.TabIndex = 22;
			this.Anter.Text = "ᐸ";
			this.Anter.Click += new System.EventHandler(this.AnterClick);
			// 
			// bntnovo
			// 
			this.bntnovo.BackColor = System.Drawing.Color.Black;
			this.bntnovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.bntnovo.Location = new System.Drawing.Point(12, 497);
			this.bntnovo.Name = "bntnovo";
			this.bntnovo.Size = new System.Drawing.Size(78, 30);
			this.bntnovo.TabIndex = 21;
			this.bntnovo.Text = "Novo";
			this.bntnovo.UseVisualStyleBackColor = false;
			this.bntnovo.Click += new System.EventHandler(this.BntnovoClick);
			// 
			// bntcalcular
			// 
			this.bntcalcular.BackColor = System.Drawing.Color.Black;
			this.bntcalcular.ForeColor = System.Drawing.Color.Transparent;
			this.bntcalcular.Location = new System.Drawing.Point(134, 456);
			this.bntcalcular.Name = "bntcalcular";
			this.bntcalcular.Size = new System.Drawing.Size(145, 34);
			this.bntcalcular.TabIndex = 24;
			this.bntcalcular.Text = "Calcular";
			this.bntcalcular.UseVisualStyleBackColor = false;
			this.bntcalcular.Click += new System.EventHandler(this.BntcalcularClick);
			// 
			// totpagar
			// 
			this.totpagar.Enabled = false;
			this.totpagar.Location = new System.Drawing.Point(24, 364);
			this.totpagar.Name = "totpagar";
			this.totpagar.Size = new System.Drawing.Size(106, 20);
			this.totpagar.TabIndex = 25;
			// 
			// totreceber
			// 
			this.totreceber.Enabled = false;
			this.totreceber.Location = new System.Drawing.Point(278, 364);
			this.totreceber.Name = "totreceber";
			this.totreceber.Size = new System.Drawing.Size(106, 20);
			this.totreceber.TabIndex = 26;
			// 
			// dinheiro_movimentado
			// 
			this.dinheiro_movimentado.Enabled = false;
			this.dinheiro_movimentado.Location = new System.Drawing.Point(153, 407);
			this.dinheiro_movimentado.Name = "dinheiro_movimentado";
			this.dinheiro_movimentado.Size = new System.Drawing.Size(106, 20);
			this.dinheiro_movimentado.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(32, 334);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 19);
			this.label1.TabIndex = 28;
			this.label1.Text = "Tot. Pagar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(287, 334);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 29;
			this.label2.Text = "Tot. Receber";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(132, 382);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 19);
			this.label3.TabIndex = 30;
			this.label3.Text = "Dinheiro Movimentado";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(153, 293);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 19);
			this.label4.TabIndex = 32;
			this.label4.Text = "Lucro";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lucro
			// 
			this.lucro.Enabled = false;
			this.lucro.Location = new System.Drawing.Point(153, 318);
			this.lucro.Name = "lucro";
			this.lucro.Size = new System.Drawing.Size(106, 20);
			this.lucro.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(103, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(206, 52);
			this.label5.TabIndex = 33;
			this.label5.Text = "Gestão Financeira";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(32, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 29);
			this.label6.TabIndex = 34;
			this.label6.Text = "Despesas";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(267, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 29);
			this.label7.TabIndex = 35;
			this.label7.Text = "Receitas";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// despesa
			// 
			this.despesa.Location = new System.Drawing.Point(24, 164);
			this.despesa.Name = "despesa";
			this.despesa.Size = new System.Drawing.Size(129, 20);
			this.despesa.TabIndex = 36;
			// 
			// receita
			// 
			this.receita.Location = new System.Drawing.Point(255, 164);
			this.receita.Name = "receita";
			this.receita.Size = new System.Drawing.Size(129, 20);
			this.receita.TabIndex = 37;
			// 
			// bntguadar
			// 
			this.bntguadar.BackColor = System.Drawing.Color.Black;
			this.bntguadar.ForeColor = System.Drawing.Color.Transparent;
			this.bntguadar.Location = new System.Drawing.Point(161, 210);
			this.bntguadar.Name = "bntguadar";
			this.bntguadar.Size = new System.Drawing.Size(97, 36);
			this.bntguadar.TabIndex = 38;
			this.bntguadar.Text = "Gravar";
			this.bntguadar.UseVisualStyleBackColor = false;
			this.bntguadar.Click += new System.EventHandler(this.BntguadarClick);
			// 
			// Gestao_Financeira
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(405, 538);
			this.Controls.Add(this.bntguadar);
			this.Controls.Add(this.receita);
			this.Controls.Add(this.despesa);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lucro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dinheiro_movimentado);
			this.Controls.Add(this.totreceber);
			this.Controls.Add(this.totpagar);
			this.Controls.Add(this.bntcalcular);
			this.Controls.Add(this.bntsair);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.bntnovo);
			this.Name = "Gestao_Financeira";
			this.Text = "Gestao_Financeira";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
