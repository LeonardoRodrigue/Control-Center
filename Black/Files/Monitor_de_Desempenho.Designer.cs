/*
 * Created by SharpDevelop.
 * User: e01desis
 * Date: 26/12/2023
 * Time: 13:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Central_de_Controle
{
	partial class Monitor_de_Desempenho
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer_performance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelcpu;
		private System.Windows.Forms.Label labelram;
		private System.Windows.Forms.Label labeldata;
		private System.Windows.Forms.Label Anter;
		private System.Windows.Forms.Label LBLHora;
		private System.Windows.Forms.Button BNTSair;
		private System.Windows.Forms.Timer Hora;
		private System.Windows.Forms.Timer Data;
		private System.Windows.Forms.Label labelnet;
		private System.Windows.Forms.Label labeldisk;
		private System.Windows.Forms.Timer timer_net;
		
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
			this.components = new System.ComponentModel.Container();
			this.timer_performance = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelcpu = new System.Windows.Forms.Label();
			this.labelram = new System.Windows.Forms.Label();
			this.labeldata = new System.Windows.Forms.Label();
			this.Anter = new System.Windows.Forms.Label();
			this.LBLHora = new System.Windows.Forms.Label();
			this.BNTSair = new System.Windows.Forms.Button();
			this.Hora = new System.Windows.Forms.Timer(this.components);
			this.Data = new System.Windows.Forms.Timer(this.components);
			this.labelnet = new System.Windows.Forms.Label();
			this.labeldisk = new System.Windows.Forms.Label();
			this.timer_net = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timer_performance
			// 
			this.timer_performance.Enabled = true;
			this.timer_performance.Interval = 500;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(828, 44);
			this.label1.TabIndex = 28;
			this.label1.Text = "Monitor de Desempenho";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(22, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(401, 44);
			this.label2.TabIndex = 29;
			this.label2.Text = "Desempenho da maquina:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelcpu
			// 
			this.labelcpu.BackColor = System.Drawing.Color.Transparent;
			this.labelcpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelcpu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelcpu.Location = new System.Drawing.Point(119, 301);
			this.labelcpu.Name = "labelcpu";
			this.labelcpu.Size = new System.Drawing.Size(280, 36);
			this.labelcpu.TabIndex = 30;
			this.labelcpu.Text = "Uso da CPU: ";
			this.labelcpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelram
			// 
			this.labelram.BackColor = System.Drawing.Color.Transparent;
			this.labelram.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelram.Location = new System.Drawing.Point(475, 301);
			this.labelram.Name = "labelram";
			this.labelram.Size = new System.Drawing.Size(302, 36);
			this.labelram.TabIndex = 31;
			this.labelram.Text = "Memoria disponivel:";
			this.labelram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labeldata
			// 
			this.labeldata.BackColor = System.Drawing.Color.Transparent;
			this.labeldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeldata.ForeColor = System.Drawing.Color.White;
			this.labeldata.Location = new System.Drawing.Point(86, 506);
			this.labeldata.Name = "labeldata";
			this.labeldata.Size = new System.Drawing.Size(95, 21);
			this.labeldata.TabIndex = 35;
			this.labeldata.Text = "00/00/0000";
			// 
			// Anter
			// 
			this.Anter.BackColor = System.Drawing.Color.Transparent;
			this.Anter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Anter.ForeColor = System.Drawing.Color.White;
			this.Anter.Location = new System.Drawing.Point(12, 14);
			this.Anter.Name = "Anter";
			this.Anter.Size = new System.Drawing.Size(23, 28);
			this.Anter.TabIndex = 34;
			this.Anter.Text = "ᐸ";
			this.Anter.Click += new System.EventHandler(this.AnterClick);
			// 
			// LBLHora
			// 
			this.LBLHora.BackColor = System.Drawing.Color.Transparent;
			this.LBLHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LBLHora.ForeColor = System.Drawing.Color.White;
			this.LBLHora.Location = new System.Drawing.Point(12, 506);
			this.LBLHora.Name = "LBLHora";
			this.LBLHora.Size = new System.Drawing.Size(68, 21);
			this.LBLHora.TabIndex = 33;
			this.LBLHora.Text = "00:00:00";
			// 
			// BNTSair
			// 
			this.BNTSair.BackColor = System.Drawing.Color.Black;
			this.BNTSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BNTSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BNTSair.Location = new System.Drawing.Point(748, 489);
			this.BNTSair.Name = "BNTSair";
			this.BNTSair.Size = new System.Drawing.Size(92, 35);
			this.BNTSair.TabIndex = 32;
			this.BNTSair.Text = "Sair";
			this.BNTSair.UseVisualStyleBackColor = false;
			this.BNTSair.Click += new System.EventHandler(this.BNTSairClick);
			// 
			// Hora
			// 
			this.Hora.Enabled = true;
			this.Hora.Interval = 1000;
			this.Hora.Tick += new System.EventHandler(this.HoraTick);
			// 
			// Data
			// 
			this.Data.Enabled = true;
			this.Data.Interval = 1000;
			this.Data.Tick += new System.EventHandler(this.DataTick);
			// 
			// labelnet
			// 
			this.labelnet.BackColor = System.Drawing.Color.Transparent;
			this.labelnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelnet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelnet.Location = new System.Drawing.Point(475, 361);
			this.labelnet.Name = "labelnet";
			this.labelnet.Size = new System.Drawing.Size(365, 36);
			this.labelnet.TabIndex = 38;
			this.labelnet.Text = "Velocidade da Rede:";
			// 
			// labeldisk
			// 
			this.labeldisk.BackColor = System.Drawing.Color.Transparent;
			this.labeldisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeldisk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.labeldisk.Location = new System.Drawing.Point(119, 366);
			this.labeldisk.Name = "labeldisk";
			this.labeldisk.Size = new System.Drawing.Size(280, 36);
			this.labeldisk.TabIndex = 37;
			this.labeldisk.Text = "Uso do disco:";
			// 
			// timer_net
			// 
			this.timer_net.Enabled = true;
			this.timer_net.Interval = 800;
			// 
			// Monitor_de_Desempenho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 538);
			this.Controls.Add(this.labelnet);
			this.Controls.Add(this.labeldisk);
			this.Controls.Add(this.labeldata);
			this.Controls.Add(this.Anter);
			this.Controls.Add(this.LBLHora);
			this.Controls.Add(this.BNTSair);
			this.Controls.Add(this.labelram);
			this.Controls.Add(this.labelcpu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Monitor_de_Desempenho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Monitor de Desempenho";
			this.ResumeLayout(false);

		}
	}
}
