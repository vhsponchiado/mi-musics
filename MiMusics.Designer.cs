
namespace MiMusics
{
    partial class MiMusics
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiMusics));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.listMusic = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 37);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::MiMusics.Properties.Resources.icon_cancel;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(867, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listMusic
            // 
            this.listMusic.BackColor = System.Drawing.Color.DimGray;
            this.listMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMusic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMusic.ForeColor = System.Drawing.Color.Gainsboro;
            this.listMusic.FormattingEnabled = true;
            this.listMusic.ItemHeight = 21;
            this.listMusic.Location = new System.Drawing.Point(12, 131);
            this.listMusic.Name = "listMusic";
            this.listMusic.Size = new System.Drawing.Size(876, 294);
            this.listMusic.TabIndex = 5;
            this.listMusic.SelectedIndexChanged += new System.EventHandler(this.listMusic_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("d Diam", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "MiMusics";
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(708, 492);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(169, 45);
            this.tbVolume.TabIndex = 7;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play.png");
            this.imageList1.Images.SetKeyName(1, "pause .png");
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(424, 428);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 13;
            // 
            // timerMusic
            // 
            this.timerMusic.Interval = 1000;
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::MiMusics.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(12, 493);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 42);
            this.btnStop.TabIndex = 12;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.BackgroundImage = global::MiMusics.Properties.Resources.music_player;
            this.btnRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetroceder.FlatAppearance.BorderSize = 0;
            this.btnRetroceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroceder.Location = new System.Drawing.Point(366, 492);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(39, 45);
            this.btnRetroceder.TabIndex = 11;
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackgroundImage = global::MiMusics.Properties.Resources.music_player_2;
            this.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(481, 492);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(39, 45);
            this.btnProximo.TabIndex = 10;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackgroundImage = global::MiMusics.Properties.Resources.folder;
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Location = new System.Drawing.Point(12, 78);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(43, 42);
            this.btnFolder.TabIndex = 9;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ImageKey = "play.png";
            this.btnPlay.ImageList = this.imageList1;
            this.btnPlay.Location = new System.Drawing.Point(419, 489);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 51);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MiMusics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMusic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiMusics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MiMusics_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerMusic;
    }
}

