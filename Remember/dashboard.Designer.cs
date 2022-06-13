﻿namespace Remember
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.createSL = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.closeMusicBtn = new System.Windows.Forms.Button();
            this.openSlideshowBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.musicLbl = new System.Windows.Forms.Label();
            this.informationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFile";
            // 
            // createSL
            // 
            this.createSL.Location = new System.Drawing.Point(765, 419);
            this.createSL.Name = "createSL";
            this.createSL.Size = new System.Drawing.Size(105, 23);
            this.createSL.TabIndex = 1;
            this.createSL.Text = "Create SlideShow";
            this.createSL.UseVisualStyleBackColor = true;
            this.createSL.Click += new System.EventHandler(this.createSL_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(134, 419);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(60, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.toolTip1.SetToolTip(this.browseBtn, "Click to browse photos");
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(182, 392);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(73, 419);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(60, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear list";
            this.toolTip1.SetToolTip(this.clearBtn, "Click to clear all photos");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 419);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(60, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.toolTip1.SetToolTip(this.deleteBtn, "Click to delete the selected photo");
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(199, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(700, 392);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // closeMusicBtn
            // 
            this.closeMusicBtn.BackColor = System.Drawing.Color.IndianRed;
            this.closeMusicBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.closeMusicBtn.FlatAppearance.BorderSize = 0;
            this.closeMusicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeMusicBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeMusicBtn.Location = new System.Drawing.Point(285, 421);
            this.closeMusicBtn.Name = "closeMusicBtn";
            this.closeMusicBtn.Size = new System.Drawing.Size(20, 20);
            this.closeMusicBtn.TabIndex = 14;
            this.closeMusicBtn.Text = "X";
            this.toolTip1.SetToolTip(this.closeMusicBtn, "Click to remove selected music");
            this.closeMusicBtn.UseVisualStyleBackColor = false;
            this.closeMusicBtn.Click += new System.EventHandler(this.closeMusicBtn_Click);
            // 
            // openSlideshowBtn
            // 
            this.openSlideshowBtn.Location = new System.Drawing.Point(652, 419);
            this.openSlideshowBtn.Name = "openSlideshowBtn";
            this.openSlideshowBtn.Size = new System.Drawing.Size(105, 23);
            this.openSlideshowBtn.TabIndex = 11;
            this.openSlideshowBtn.Text = "Open SlideShow";
            this.openSlideshowBtn.UseVisualStyleBackColor = true;
            this.openSlideshowBtn.Click += new System.EventHandler(this.openSlideshowBtn_Click);
            // 
            // musicBtn
            // 
            this.musicBtn.Location = new System.Drawing.Point(199, 419);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(83, 23);
            this.musicBtn.TabIndex = 12;
            this.musicBtn.Text = "Add music";
            this.toolTip1.SetToolTip(this.musicBtn, "Click to browse music");
            this.musicBtn.UseVisualStyleBackColor = true;
            this.musicBtn.Click += new System.EventHandler(this.musicBtn_Click);
            // 
            // musicLbl
            // 
            this.musicLbl.AutoSize = true;
            this.musicLbl.BackColor = System.Drawing.Color.Transparent;
            this.musicLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicLbl.Location = new System.Drawing.Point(308, 423);
            this.musicLbl.Name = "musicLbl";
            this.musicLbl.Size = new System.Drawing.Size(0, 13);
            this.musicLbl.TabIndex = 13;
            // 
            // informationButton
            // 
            this.informationButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.informationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.informationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.informationButton.Location = new System.Drawing.Point(876, 420);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(20, 20);
            this.informationButton.TabIndex = 15;
            this.informationButton.Text = "i";
            this.toolTip1.SetToolTip(this.informationButton, "While slideshow runs, you can click on buttons from 1 to 5 to\r\nchange the number " +
        "of seconds for transitions between photos.");
            this.informationButton.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 452);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.closeMusicBtn);
            this.Controls.Add(this.musicLbl);
            this.Controls.Add(this.musicBtn);
            this.Controls.Add(this.openSlideshowBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.createSL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button createSL;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button openSlideshowBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Label musicLbl;
        private System.Windows.Forms.Button closeMusicBtn;
        private System.Windows.Forms.Button informationButton;
    }
}