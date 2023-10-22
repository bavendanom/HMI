using HMI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; // Abrir los puertos COM

namespace HMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // parametros al iniciar la aplicacion 
                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
                buttonApagar.Enabled = false; // el boton de apagar este desabilitado al iniciar
                buttonEncender.Enabled = false;

                comboBoxBaud.Text = "9600";   // baud rate alque nos estamos comunicando
                
                progressBarConnection.Value = 0; // valor de la barar deprogreso de conectividad es 0

                pictureBoxLed.Image = Properties.Resources.ButtonOff; // cargar la imagen de inicio

                string[] portlist = SerialPort.GetPortNames(); // retornamos todos los puertos seriales que estan habilitados 
                comboBoxPort.Items.AddRange(portlist);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        { 
            if (serialPort1.IsOpen)
            {
                try
                {
                    // enviar codigo al arduino 
                    serialPort1.WriteLine("$On"); // instruccion para que en el arduino encienda
                    //labelLed.BackColor = Color.Lime; //cambio de coloor de la etiqueta a verde
                    //labelLed.Text = "ON";
                    buttonApagar.Enabled = true;
                    buttonEncender.Enabled = false;
                    pictureBoxLed.Image = Properties.Resources.ButtonOn;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("$Off");
                    pictureBoxLed.Image = Properties.Resources.ButtonOff;
                    serialPort1.Close();
                }
            
                catch (Exception error)
                {
                MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                // enviar codigo al arduino 
                serialPort1.WriteLine("$Off"); // instruccion para que en el arduino encienda
                //labelLed.BackColor = Color.Red; //cambio de coloor de la etiqueta a verde
                //labelLed.Text = "OFF";
                pictureBoxLed.Image = Properties.Resources.ButtonOff;
                buttonApagar.Enabled = false;
                buttonEncender.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                serialPort1.Open();

                // habilitar botones

                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                buttonApagar.Enabled = true; 
                buttonEncender.Enabled = true;

                progressBarConnection.Value = 100; // progreso de la barra 100%
                comboBoxPort.Enabled = false;
                comboBoxBaud.Enabled = false;



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Apagar el led
            serialPort1.WriteLine("$Off");
            // Cargar imagen de led apagado 
            pictureBoxLed.Image = Properties.Resources.ButtonOff;
            // Cerrar el puerto 
            serialPort1.Close();
            // Deshabilitar botones
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            buttonApagar.Enabled = false; 
            buttonEncender.Enabled = false;
            // Barra de progreso en 0
            progressBarConnection.Value = 0;
            // Puerto y Baud Rate habilitados 
            comboBoxPort.Enabled = true;
            comboBoxBaud.Enabled = true;


        }
    }
}
