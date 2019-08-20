using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwaggerCommentsMaker
{
    public partial class MainForm : Form
    {
        private readonly string _defaultPhrase;
        public string SpacesPhrase { get; set; }
        public MainForm()
        {
            InitializeComponent();
            _defaultPhrase = "/// ";
        }


        private void TransferButton_Click(object sender, EventArgs e)
        {
            var count = InputTextBox.Text.Count(Char.IsDigit);
            string[] TextToTransfer = new string[count];

            OutputTextBox.Clear();

            using (StringReader reader = new StringReader(InputTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Do something with the line
                    line = _defaultPhrase + SpacesPhrase + line;

                    if (!string.IsNullOrWhiteSpace(OutputTextBox.Text))
                    {
                        OutputTextBox.AppendText("\r\n" + line);
                    }
                    else
                    {
                        OutputTextBox.AppendText(line);
                    }                     
                    OutputTextBox.ScrollToCaret();
                }
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();
        }

        private void AcceptAddPhrButton_Click(object sender, EventArgs e)
        {
            SpacesPhrase = PhraseTextBox.Text;
        }

        private void PhraseTextBox_TextChanged(object sender, EventArgs e)
        {
            PhrPreviewLabel.Text = "\"///" + PhraseTextBox.Text + "\"";
        }
    }
}
