using Parser.Core;
using Parser.Core.Habra;
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
                        new HabraParser()
                        );
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new HabraSettings((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            parser.Start();
        }
    }
}
