using Fclp;
using System;
using System.Windows.Forms;

namespace AlertOnTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var p = new FluentCommandLineParser();
            p.Setup<string>('m', "message")
                .Callback(message => textBox1.Text = message)
                .Required();

            var args = Environment.GetCommandLineArgs();
            p.Parse(args);
        }
    }
}
