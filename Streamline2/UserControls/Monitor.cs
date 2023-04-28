using System;
using System.Management;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace Streamline2.UserControls
{
    public partial class Monitor : UserControl
    {
        public Monitor()
        {
            InitializeComponent();
        }


        private void Monitor_Load(object sender, EventArgs e)
        {
            //GetCpuInfo();
            //GetGpuInfo();
            //GetRamInfo();
            //test(sender, e);
            test2();
        }
        public void GetCpuInfo()
        {
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            Console.WriteLine("CPU Temperature: " + sensor.Value + "°C");
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            Console.WriteLine("CPU Usage: " + sensor.Value + "%");
                        }
                        else if (sensor.SensorType == SensorType.Power && sensor.Name == "CPU Package")
                        {
                            Console.WriteLine("CPU Power: " + sensor.Value + "W");
                        }
                        else if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("CPU Core"))
                        {
                            Console.WriteLine("CPU Frequency: " + sensor.Value + "MHz");
                        }
                    }
                }
            }
            computer.Close();
        }
        public void GetGpuInfo()
        {
            Computer computer = new Computer();
            computer.Open();
            computer.GPUEnabled = true;

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU Core"))
                        {
                            Console.WriteLine("GPU Temperature: " + sensor.Value + "°C");
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            Console.WriteLine("GPU Usage: " + sensor.Value + "%");
                        }
                        else if (sensor.SensorType == SensorType.Power && sensor.Name == "GPU Core")
                        {
                            Console.WriteLine("GPU Power: " + sensor.Value + "W");
                        }
                        else if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("GPU Core"))
                        {
                            Console.WriteLine("GPU Frequency: " + sensor.Value + "MHz");
                        }
                    }
                }
            }
            computer.Close();
        }

        public void GetRamInfo()
        {
            Computer computer = new Computer();
            computer.Open();
            computer.RAMEnabled = true;

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.RAM)
                {
                    hardware.Update();

                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            Console.WriteLine($"RAM Temperature: {sensor.Value} °C");
                        }
                        else if (sensor.SensorType == SensorType.Data && sensor.Name == "Max Bandwidth")
                        {
                            Console.WriteLine($"RAM Max Bandwidth: {sensor.Value} MB/s");
                        }
                        else if (sensor.SensorType == SensorType.Load && sensor.Name == "Memory")
                        {
                            Console.WriteLine($"RAM Usage: {sensor.Value} %");
                        }
                    }
                }
            }
            computer.Close();
        }
        private void info_Click(object sender, EventArgs e)
        {

        }



        private void test(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name='_Total'");
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfRawData_Tcpip_NetworkInterface");
            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject obj in searcher.Get())
            {
                string cpuName = obj["Name"].ToString();
                double cpuTemp = 0;
                //double.TryParse(obj["Temperature"].ToString(), out cpuTemp);
                double cpuUsage = 0;
                double.TryParse(obj["PercentProcessorTime"].ToString(), out cpuUsage);

                // Convert the CPU temperature to celsius degrees
                cpuTemp = (cpuTemp - 2732) / 10.0;

                //cpuname_label.Text = cpuName;
                Console.WriteLine(cpuName);
                //cputemp_label.Text = string.Format("{0:0.00} °C", cpuTemp);
                Console.WriteLine(string.Format("{0:0.00} °C", cpuTemp));
                //cpuusage_label.Text = string.Format("{0:0.00} %", cpuUsage);
                Console.WriteLine(string.Format("{0:0.00} %", cpuUsage));
            }

            foreach (ManagementObject obj in searcher2.Get())
            {
                double ramUsage = 0;
                //double.TryParse(obj["PercentMemoryUsed"].ToString(), out ramUsage);

                //ramusage_label.Text = string.Format("{0:0.00} %", ramUsage);
                Console.WriteLine(string.Format("{0:0.00} %", ramUsage));
            }

            foreach (ManagementObject obj in searcher4.Get())
            {
                string gpuName = obj["Name"].ToString();
                double gpuTemp = 0;
                //double.TryParse(obj["CurrentTemperature"].ToString(), out gpuTemp);
                double gpuUsage = 0;
                //double.TryParse(obj["GPUUsage"].ToString(), out gpuUsage);

                // Convert the GPU temperature to celsius degrees
                gpuTemp = gpuTemp / 10.0;

                //gpuname_label.Text = gpuName;
                Console.WriteLine(gpuName);
                //putemp_label.Text = string.Format("{0:0.00} °C", gpuTemp);
                Console.WriteLine(string.Format("{0:0.00} °C", gpuTemp));
                //gpuusage_label.Text = string.Format("{0:0.00} %", gpuUsage);
                Console.WriteLine(string.Format("{0:0.00} %", gpuUsage));
            }
        }

        private void test2()
        {
            Process process = Process.GetCurrentProcess();

            float cpuUsage = process.TotalProcessorTime.Ticks / (float)Stopwatch.Frequency / Environment.ProcessorCount * 100;
            float memUsage = process.WorkingSet64 / (1024 * 1024); // in MB

            Console.WriteLine("CPU Usage: {0:F2}%", cpuUsage);
            Console.WriteLine("Memory Usage: {0:F2} MB", memUsage);
        }
    }
}