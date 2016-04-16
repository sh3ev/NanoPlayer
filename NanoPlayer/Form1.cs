using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanoPlayer
{
    public partial class Form1 : Form
    {
        private Mp3Player _mp3Player;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_mp3Player != null)
            _mp3Player.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = "Mp3 File|*.mp3|All files (*.*)|*.*";
                dlgOpen.InitialDirectory =  Environment.SpecialFolder.MyMusic.ToString();

                if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _mp3Player = new Mp3Player(dlgOpen.FileName);
                    _mp3Player.Repeat = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _mp3Player.Stop();
        }
    }
}
