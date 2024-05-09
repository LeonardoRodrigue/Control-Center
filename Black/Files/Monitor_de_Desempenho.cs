using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Central_de_Controle
{
	
	public partial class Monitor_de_Desempenho : Form
	{
		private PerformanceCounter cpuCont;
		private PerformanceCounter ramCout;
		private PerformanceCounter diskCount;
		private PerformanceCounter netCount;
		
		public Monitor_de_Desempenho()
		{
			InitializeComponent();
			
			cpuCont = new PerformanceCounter("Processor", "% Processor Time", "_Total");
			ramCout = new PerformanceCounter("Memory", "Available MBytes");
			diskCount = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
			netCount = new PerformanceCounter("Network Interface", "Bytes Total/sec", true);
			
			timer_performance.Tick += Timer_Performance_Tick;
			timer_net.Tick += Timer_Net_Tick;
			timer_net.Start();
			timer_performance.Start();
		}
		
		private void Timer_Performance_Tick(object sender, EventArgs e)
		{
			float cpuStats = 0;
    		float memoryStats = 0;
    		float diskStats = 0;
    
    		try {
       		 	cpuStats = cpuCont.NextValue();
        		memoryStats = ramCout.NextValue();
        		diskStats = diskCount.NextValue();
    		} catch (InvalidOperationException) {
        		if (MessageBox.Show("Erro ao executar!","Erro",MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.Cancel){
            		Close();
        		}
    		}
    		labelcpu.Text = "Uso da CPU: " + cpuStats;
    		labelram.Text = "Memoria disponivel: " + memoryStats + " MB";
    		labeldisk.Text = "Uso do disco: " + diskStats + " %";
		}
		
		private void Timer_Net_Tick(object sender, EventArgs e)
		{
			double netStats = 0;
			try {
				long startBytes = GetTotalBytes();
        		long endBytes = GetTotalBytes();
        
        		netStats = (endBytes - startBytes) / 5.0;
			} catch (InvalidOperationException) {
        		if (MessageBox.Show("Erro ao executar!","Erro",MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.Cancel){
            		Close();
        		}
			}
			labelnet.Text = "Velocidade da Rede: " + netStats + " B /s";
		}
		private long GetTotalBytes()
        {
            long totalBytes = 0;
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPv4InterfaceStatistics statistics = networkInterface.GetIPv4Statistics();
                totalBytes += statistics.BytesReceived + statistics.BytesSent;
            }
            return totalBytes;
        }

		//Sair
		void BNTSairClick(object sender, EventArgs e)
		{
			try{
			if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				Close();
				}
			} catch (Exception E){
				MessageBox.Show("Erro ao Sair","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		void AnterClick(object sender, EventArgs e)
		{
			Close();
		}
		void PósClick(object sender, EventArgs e)
		{
			Close();
		}
		//Hora
		void HoraTick(object sender, EventArgs e)
		{
			LBLHora.Text = DateTime.Now.ToLongTimeString();
		}
		//Data
		void DataTick(object sender, EventArgs e)
		{
			labeldata.Text = DateTime.Now.ToShortDateString();
		}
		
	}
}

// Leonardo Rodrigues Reis Lopes