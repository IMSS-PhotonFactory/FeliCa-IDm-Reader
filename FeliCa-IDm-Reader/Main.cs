using PCSC;
using PCSC.Exceptions;
using PCSC.Iso7816;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace FeliCa_IDm_Reader
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            SearchDevices();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (textBoxIDm.Text != "")
            {
                Clipboard.SetText(textBoxIDm.Text);
                toolStripStatusLabel1.Text = "Copied to clipboard.";
            }
        }

        private void SearchDevices()
        {
            comboBoxDevice.Items.Clear();
            comboBoxDevice.Text = "";

            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                var devicename = context.GetReaders();

                if (devicename.Length == 0)
                {
                    toolStripStatusLabel1.Text = "No device found.";
                    System.Media.SystemSounds.Beep.Play();
                    buttonRead.Enabled = false;
                    return;
                }

                foreach (var item in devicename)
                {
                    comboBoxDevice.Items.Add(item);
                }

                toolStripStatusLabel1.Text = $"{devicename.Length} device(s) found.";
                comboBoxDevice.SelectedIndex = 0;
            }

            buttonRead.Enabled = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SearchDevices();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                try
                {
                    using (var reader = context.ConnectReader(comboBoxDevice.SelectedItem.ToString(), SCardShareMode.Shared, SCardProtocol.Any))
                    {
                        var apduCommand = new CommandApdu(IsoCase.Case2Short, reader.Protocol);
                        apduCommand.CLA = 0xFF;
                        apduCommand.Instruction = InstructionCode.GetData;
                        apduCommand.P1 = 0x00;
                        apduCommand.P2 = 0x00;
                        apduCommand.Le = 0;

                        using (reader.Transaction(SCardReaderDisposition.Leave))
                        {
                            var receiveBuffer = new byte[256];

                            var bytesReceived = reader.Transmit(
                                SCardPCI.GetPci(reader.Protocol),
                                apduCommand.ToArray(),
                                apduCommand.ToArray().Length,
                                new SCardPCI(),
                                receiveBuffer,
                                receiveBuffer.Length);

                            var responseApdu = new ResponseApdu(receiveBuffer, bytesReceived, IsoCase.Case2Short, reader.Protocol);
                            
                            if (responseApdu.HasData)
                            {
                                textBoxIDm.Text = BitConverter.ToString(responseApdu.GetData()).Replace("-","");
                                toolStripStatusLabel1.Text = "Faild to get IDm.";
                                System.Media.SystemSounds.Asterisk.Play();
                            }
                            else
                            {
                                toolStripStatusLabel1.Text = "Faild to get IDm.";
                                System.Media.SystemSounds.Hand.Play();
                            }
                        }
                    }
                }
                catch (RemovedCardException)
                {
                    toolStripStatusLabel1.Text = "FeliCa card was removed.";
                    System.Media.SystemSounds.Beep.Play();
                }
                catch (PCSCException ex)
                {
                    toolStripStatusLabel1.Text = $"FeliCa card error. {ex}";
                    System.Media.SystemSounds.Hand.Play();
                }
            }
        }
    }
}
