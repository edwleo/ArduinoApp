using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ArduinoApp
{
    public partial class Form2 : Form
    {

        private SerialPort serialPort;
        private Thread readThread;
        private bool keepReading;

        public Form2()
        {
            InitializeComponent();

            
        }

        private void ReadSerialData()
        {
            while (keepReading)
            {
                try
                {
                    string valor = serialPort.ReadLine();
                    UpdateUI(valor);

                }
                catch (TimeoutException) { } //Ignora si no hay datos disponibles
                catch (IOException ex) {
                    MessageBox.Show("Error de comunicación con Arduino");
                    keepReading = false;    
                }
                catch(InvalidOperationException ex)
                {
                    MessageBox.Show("El puerto se cierra inesperadamente");
                    keepReading = false;
                }
            }
        }

        private void UpdateUI(string valorLeido)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateUI), valorLeido);
                return;
            }
            txtValor.Text = valorLeido;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            keepReading = false;

            if (readThread != null && readThread.IsAlive)
            {
                readThread.Join(500); //Tiempo para finalizar
            }

            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string portName = txtPuerto.Text;

            try
            {
                serialPort = new SerialPort("COM3", 9600);
                serialPort.ReadTimeout = 500;
                serialPort.Open();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Acceso denegado al puerto serie");
                return;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al abrir el puerto serie");
                return;
            }

            keepReading = true;
            readThread = new Thread(ReadSerialData);
            readThread.IsBackground = true;
            readThread.Start();

            btnConectar.Enabled = false;
        }

        private void sendSerialData(string valorEnviar)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {
                    serialPort.WriteLine(valorEnviar);
                }
                catch { }
            }
            else
            {
                MessageBox.Show("No se aperturó la conexión");
            }
        }

        private void btnEncenderLed_Click(object sender, EventArgs e)
        {
            sendSerialData("1");
        }

        private void btnApagarLed_Click(object sender, EventArgs e)
        {
            sendSerialData("0");
        }
    }
}
