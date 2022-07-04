using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMusics
{
    public partial class MiMusics : Form
    {
        private MusicPlayer musicplayer = new MusicPlayer();
        public MiMusics()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files | *.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    musicplayer.open(ofd.FileName);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            musicplayer.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            musicplayer.stop();
        }

        private void MiMusics_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
