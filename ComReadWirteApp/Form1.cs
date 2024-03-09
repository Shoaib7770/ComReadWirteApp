using System.IO.Ports;

namespace ComReadWirteApp
{
    public partial class Form1 : Form
    {
        private SerialPort _port1;
        private SerialPort _port2;
        bool inUse = false;
        public Form1()
        {
            InitializeComponent();
            _port1 = new SerialPort();
            _port2 = new SerialPort();
           

        }

        public void GetAllPorts()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                cBoxComPort.Items.AddRange(ports);
                cBoxPort2.Items.AddRange(ports);

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Error opening ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllPorts();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (_port1.IsOpen )
                {
                    _port1.Close();
                }
                else if (_port2.IsOpen)
                {
                    _port2.Close();
                }
                else if (_port1.IsOpen && _port2.IsOpen)
                {

                    _port1.Close();
                    _port2.Close();

                }
                if (cBoxComPort.Text.Trim()!=string.Empty && cBoxPort2.Text.Trim()==string.Empty)
                {
                    _port1.PortName = cBoxComPort.Text;
                   
                    _port1.BaudRate  = cBoxBaudRate.Text != string.Empty ? Convert.ToInt32(cBoxBaudRate.Text) : 0;
                    _port1.DataBits = cBoxDataBits.Text != string.Empty ? Convert.ToInt32(cBoxDataBits.Text) : 0;
                    _port1.StopBits   = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                    _port1.Parity  = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);
                    _port1.RtsEnable = true;
                    _port1.DtrEnable = true;
                   // _port2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    _port1.Open();
                    //_port1.DiscardOutBuffer();
                    //_port1.DiscardInBuffer();
                   
                   
                    progressBar1.Value = 100;
                    lblMsg.Text = cBoxComPort.Text +" is opened now";

                }
              else if (cBoxPort2.Text.Trim() != string.Empty && cBoxComPort.Text.Trim()==string.Empty)
                {
                    _port2.PortName = cBoxPort2.Text;
                    _port2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    _port2.BaudRate = cBoxBaudRate.Text != string.Empty ? Convert.ToInt32(cBoxBaudRate.Text) : 0;
                    _port2.DataBits = cBoxDataBits.Text != string.Empty ? Convert.ToInt32(cBoxDataBits.Text) : 0;
                    _port2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                    _port2.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);
                    _port2.RtsEnable = true;
                    _port2.Open();
                    progressBar1.Value = 100;
                    lblMsg.Text =  cBoxPort2.Text + " is opened now";

                }
               else if (cBoxComPort.Text.Trim() != string.Empty && cBoxPort2.Text.Trim() != string.Empty)
                {
                    _port1.PortName = cBoxComPort.Text;
                    _port2.PortName = cBoxPort2.Text;
                    _port1.BaudRate = _port2.BaudRate = cBoxBaudRate.Text != string.Empty ? Convert.ToInt32(cBoxBaudRate.Text) : 0;
                    _port1.DataBits = _port2.DataBits = cBoxDataBits.Text != string.Empty ? Convert.ToInt32(cBoxDataBits.Text) : 0;
                    _port1.StopBits = _port2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                    _port1.Parity = _port2.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);
                    _port1.RtsEnable=_port2.RtsEnable = true;
                    _port1.Open();
                    _port2.Open();
                    progressBar1.Value = 100;
                    lblMsg.Text = cBoxComPort.Text + " and " + cBoxPort2.Text + " is opened now";
                }
                else
                {
                    MessageBox.Show("Please choose at least one port to continue", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
              

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Error opening ports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_port1.IsOpen && _port2.IsOpen)
            {
                tBoxDataOut.Text = "";
                tBoxRead.Text = "";
                _port1.Close();
                _port2.Close();
                progressBar1.Value = 0;
                lblMsg.Text = cBoxComPort.Text + " and " + cBoxPort2.Text + " is closed now";
            }
         
        }
        // <summary>
        // Reads data from the specified serial port and displays it on the screen.
        // </summary>
        //private void ReadData(SerialPort port)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            string data = port.ReadLine();
        //            DisplayData(data);
        //        }
        //        catch (TimeoutException ex)
        //        {
        //            MessageBox.Show($"Timeout reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void ReadData(SerialPort port)
        {
            while (true)
            {
                try
                {

                    if (port.IsOpen)
                    {
                        
                        string data = port.ReadLine();

                        //  MessageBox.Show($"Data received from {port.PortName}: {data}");
                        DisplayData($"Data received from {port.PortName}: {data}");
                    }
                }
                catch (TimeoutException ex)
                {
                    MessageBox.Show($"Timeout reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                { 
                
                    if (port.IsOpen)
                {

                    MessageBox.Show($"Error reading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            }
        }

        // <summary>
        // Displays the data on the screen.
        // </summary>
        private void DisplayData(string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(DisplayData), data);
            }
            else
            {
                tBoxRead.AppendText(data + Environment.NewLine);
            }
        }
        private  void DataReceivedHandler(
                       object sender,
                       SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[_port2.BytesToRead];
            _port2.Read(data, 0, data.Length);
            MessageBox.Show(System.Text.Encoding.UTF8.GetString(data));
           // SerialPort sp = (SerialPort)sender;
            string indata = _port2.ReadExisting();
            // Console.WriteLine("Data Received:");
            DisplayData(indata);
        }


        // <summary>
        // Writes data to the specified serial port.
        // </summary>
        private void WriteData(SerialPort port, string data)
        {
            try
            {
                if (port.IsOpen)
                {

                    port.WriteLine($"Data sent to {port.PortName}: {data}");
                    //  MessageBox.Show($"Data sent to {port.PortName}: {data}");
                }

            }
            catch (TimeoutException ex)
            {
                MessageBox.Show($"Timeout writing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSendData_Click(object sender, EventArgs e)
        {
            //WriteData(_port1, tBoxDataOut.Text);
            //ReadData(_port1);
            await ReadWriteDataInParallel();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public async Task ReadWriteDataInParallel()
        {
            if (_port1.IsOpen && !_port2.IsOpen)
            {
              
                await Task.WhenAll(
               // Task.Run(() => ReadData(_port1)),
               Task.Run(() =>WriteData(_port1, tBoxDataOut.Text))
              


           );
            }
            else if (_port2.IsOpen && !_port1.IsOpen)
            {
                await Task.WhenAll(
               
                Task.Run(() => ReadData(_port2)),
                Task.Run(() => WriteData(_port1, tBoxDataOut.Text))
               
            );
            }
            else if (_port1.IsOpen && _port2.IsOpen)
            {
                await Task.WhenAll(
                                 Task.Run(() => ReadData(_port1)),
                                Task.Run(() => ReadData(_port2)),
                                Task.Run(() => WriteData(_port1, tBoxDataOut.Text)),
                                Task.Run(() => WriteData(_port2, tBoxDataOut.Text))
                            );
            }
            else
            {
                MessageBox.Show("Please open at least one port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
    }
}
