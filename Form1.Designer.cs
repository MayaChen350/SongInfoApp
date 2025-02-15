﻿namespace SongInfoTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.albumDisplayed = new System.Windows.Forms.PictureBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblAlbumNotFound = new System.Windows.Forms.Label();
            this.ytLogo = new System.Windows.Forms.PictureBox();
            this.spotifyLogo = new System.Windows.Forms.PictureBox();
            this.amLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.albumDisplayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // albumDisplayed
            // 
            this.albumDisplayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.albumDisplayed.Location = new System.Drawing.Point(105, 80);
            this.albumDisplayed.Name = "albumDisplayed";
            this.albumDisplayed.Size = new System.Drawing.Size(275, 275);
            this.albumDisplayed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumDisplayed.TabIndex = 0;
            this.albumDisplayed.TabStop = false;
            // 
            // txtSong
            // 
            this.txtSong.AcceptsReturn = true;
            this.txtSong.AcceptsTab = true;
            this.txtSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSong.Location = new System.Drawing.Point(463, 156);
            this.txtSong.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtSong.Multiline = true;
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(237, 30);
            this.txtSong.TabIndex = 1;
            this.txtSong.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // lblSong
            // 
            this.lblSong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.Location = new System.Drawing.Point(460, 137);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(106, 13);
            this.lblSong.TabIndex = 2;
            this.lblSong.Text = "Enter song name:";
            this.lblSong.UseWaitCursor = true;
            // 
            // txtArtist
            // 
            this.txtArtist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(463, 214);
            this.txtArtist.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtArtist.Multiline = true;
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(237, 30);
            this.txtArtist.TabIndex = 5;
            this.txtArtist.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(460, 196);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(107, 13);
            this.lblArtist.TabIndex = 6;
            this.lblArtist.Text = "Enter artist name:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerate.Location = new System.Drawing.Point(463, 265);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(237, 40);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate informations";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_ClickAsync);
            // 
            // lblTag
            // 
            this.lblTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(100, 362);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(117, 27);
            this.lblTag.TabIndex = 9;
            this.lblTag.Text = "Song genre:";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Brown;
            this.lblError.Location = new System.Drawing.Point(450, 308);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(282, 79);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "ERROR: \r\nSong or artist doesn\'t exist or might be mispelled";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblAlbumNotFound
            // 
            this.lblAlbumNotFound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlbumNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumNotFound.ForeColor = System.Drawing.Color.Black;
            this.lblAlbumNotFound.Location = new System.Drawing.Point(119, 110);
            this.lblAlbumNotFound.Name = "lblAlbumNotFound";
            this.lblAlbumNotFound.Size = new System.Drawing.Size(246, 231);
            this.lblAlbumNotFound.TabIndex = 13;
            this.lblAlbumNotFound.Text = "Album cover\r\nnot found\r\n";
            this.lblAlbumNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlbumNotFound.Visible = false;
            // 
            // ytLogo
            // 
            this.ytLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ytLogo.BackColor = System.Drawing.Color.Transparent;
            this.ytLogo.Image = global::SongInfoApp.Properties.Resources.yt;
            this.ytLogo.Location = new System.Drawing.Point(56, 194);
            this.ytLogo.Name = "ytLogo";
            this.ytLogo.Size = new System.Drawing.Size(43, 43);
            this.ytLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ytLogo.TabIndex = 14;
            this.ytLogo.TabStop = false;
            this.ytLogo.Visible = false;
            // 
            // spotifyLogo
            // 
            this.spotifyLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spotifyLogo.BackColor = System.Drawing.Color.Transparent;
            this.spotifyLogo.Image = global::SongInfoApp.Properties.Resources.spotify;
            this.spotifyLogo.Location = new System.Drawing.Point(56, 145);
            this.spotifyLogo.Name = "spotifyLogo";
            this.spotifyLogo.Size = new System.Drawing.Size(43, 43);
            this.spotifyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spotifyLogo.TabIndex = 15;
            this.spotifyLogo.TabStop = false;
            this.spotifyLogo.Visible = false;
            this.spotifyLogo.Click += new System.EventHandler(this.spotifyLogo_Click);
            // 
            // amLogo
            // 
            this.amLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amLogo.BackColor = System.Drawing.Color.Transparent;
            this.amLogo.Image = global::SongInfoApp.Properties.Resources.applemusic;
            this.amLogo.Location = new System.Drawing.Point(56, 243);
            this.amLogo.Name = "amLogo";
            this.amLogo.Size = new System.Drawing.Size(43, 43);
            this.amLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.amLogo.TabIndex = 16;
            this.amLogo.TabStop = false;
            this.amLogo.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amLogo);
            this.Controls.Add(this.spotifyLogo);
            this.Controls.Add(this.ytLogo);
            this.Controls.Add(this.lblAlbumNotFound);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.albumDisplayed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Song Info App";
            ((System.ComponentModel.ISupportInitialize)(this.albumDisplayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spotifyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox albumDisplayed;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAlbumNotFound;
        private System.Windows.Forms.PictureBox ytLogo;
        private System.Windows.Forms.PictureBox spotifyLogo;
        private System.Windows.Forms.PictureBox amLogo;
    }
}

