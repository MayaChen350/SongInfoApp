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
            this.llblCredits = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.albumDisplayed)).BeginInit();
            this.SuspendLayout();
            // 
            // albumDisplayed
            // 
            this.albumDisplayed.Location = new System.Drawing.Point(78, 58);
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
            this.txtSong.Location = new System.Drawing.Point(522, 75);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(194, 20);
            this.txtSong.TabIndex = 1;
            this.txtSong.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(396, 78);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(90, 13);
            this.lblSong.TabIndex = 2;
            this.lblSong.Text = "Enter song name:";
            this.lblSong.UseWaitCursor = true;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(522, 133);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(194, 20);
            this.txtArtist.TabIndex = 5;
            this.txtArtist.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(397, 136);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(89, 13);
            this.lblArtist.TabIndex = 6;
            this.lblArtist.Text = "Enter artist name:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerate.Location = new System.Drawing.Point(544, 184);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(151, 40);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate informations";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_ClickAsync);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Sans Serif Collection", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(73, 340);
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
            this.lblError.Location = new System.Drawing.Point(493, 227);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(282, 79);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "ERROR: \r\nSong or artist doesn\'t exist or might be mispelled";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // llblCredits
            // 
            this.llblCredits.AutoSize = true;
            this.llblCredits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.llblCredits.LinkColor = System.Drawing.Color.Black;
            this.llblCredits.Location = new System.Drawing.Point(16, 424);
            this.llblCredits.Name = "llblCredits";
            this.llblCredits.Size = new System.Drawing.Size(224, 13);
            this.llblCredits.TabIndex = 12;
            this.llblCredits.TabStop = true;
            this.llblCredits.Text = "This application is powered by the Last.fm API";
            this.llblCredits.VisitedLinkColor = System.Drawing.Color.Black;
            this.llblCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCredits_LinkClicked);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llblCredits);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.albumDisplayed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Song Info App";
            ((System.ComponentModel.ISupportInitialize)(this.albumDisplayed)).EndInit();
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
        private System.Windows.Forms.LinkLabel llblCredits;
    }
}
