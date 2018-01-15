using Parser.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class Form1 : Form
    {

        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                        new Soccer24Parser()
                        );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData; 
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listBox1.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All work done!");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //parser.Settings = new HabraSettings((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            parser.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
