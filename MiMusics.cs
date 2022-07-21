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
using WMPLib;

namespace MiMusics
{
    public partial class MiMusics : Form
    {
        WindowsMediaPlayer musica;
        List<Musica> listaMusicas = new List<Musica>();
        string arquivoMp3 = "";
        public MiMusics()
        {
            InitializeComponent();
            musica = new WindowsMediaPlayer();
            musica.settings.volume = 50;
            tbVolume.Value = 5;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play(arquivoMp3); 
        }

        private void Play(string arquivoMp3)
        {


            if (musica.playState == WMPPlayState.wmppsUndefined || musica.playState == WMPPlayState.wmppsStopped)
            {
                musica.URL = arquivoMp3;
                musica.controls.play();
                btnPlay.ImageIndex = 1;
                timerMusic.Start();

            }

            else if (musica.playState == WMPPlayState.wmppsPlaying)
            {
                musica.controls.pause();
                btnPlay.ImageIndex = 0;
                timerMusic.Start();
            }

            else if( musica.playState == WMPPlayState.wmppsPaused)
            {
                musica.controls.play();
                btnPlay.ImageIndex = 1;
                timerMusic.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            musica.controls.stop();
            btnPlay.ImageIndex = 0;
            timerMusic.Enabled = false;
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            musica.settings.volume = tbVolume.Value * 10;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Músicas MP3 |*.mp3";
            open.Multiselect = true;
            open.ShowDialog();


            foreach (var arquivo in open.FileNames)
                listaMusicas.Add(new Musica(arquivo));
                listMusic.Items.Clear();

            foreach (var item in listaMusicas)
                listMusic.Items.Add(Path.GetFileName(item.Arquivo));
        }

        private void listMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            arquivoMp3 = listaMusicas[listMusic.SelectedIndex].Arquivo;
            Play2(arquivoMp3);
        }

        private void Play2(string arquivoMp3)
        {
            musica.URL = arquivoMp3;
            musica.controls.play();
            btnPlay.ImageIndex = 1;
            timerMusic.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiMusics_Load(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if(musica.playState == WMPPlayState.wmppsPlaying)
            {
                if (musica.controls.currentItem.duration >= musica.controls.currentPosition + 5)
                    musica.controls.currentPosition += 5;

                else
                    musica.controls.currentPosition = musica.controls.currentItem.duration;
                    lblStatus.Text = musica.controls.currentPositionString;
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (musica.playState == WMPPlayState.wmppsPlaying)
            {
                if (musica.controls.currentItem.duration - 5 > 0)
                    musica.controls.currentPosition -= 5;

                else
                    musica.controls.currentPosition = musica.controls.currentItem.duration;
                lblStatus.Text = musica.controls.currentPositionString;
            }
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = musica.controls.currentPositionString;
        }
    }
    }


public class Musica
{
    public string Arquivo { get; set; }

    public Musica() { }

    public Musica(string arquivo)
    {
        Arquivo = arquivo;
    }
}