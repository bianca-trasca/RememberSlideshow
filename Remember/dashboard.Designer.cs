namespace Remember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.browseBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEdit);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEdit
            // 
            this.tabEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabEdit.BackgroundImage")));
            this.tabEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEdit.Controls.Add(this.treeView1);
            this.tabEdit.Controls.Add(this.panel);
            this.tabEdit.Controls.Add(this.browseBtn);
            this.tabEdit.Controls.Add(this.saveBtn);
            this.tabEdit.Controls.Add(this.label1);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(928, 515);
            this.tabEdit.TabIndex = 0;
            this.tabEdit.Text = "Edit Photo";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(22, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(231, 453);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel
            // 
            this.panel.ColumnCount = 8;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.Location = new System.Drawing.Point(274, 19);
            this.panel.Name = "panel";
            this.panel.RowCount = 5;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel.Size = new System.Drawing.Size(635, 453);
            this.panel.TabIndex = 6;
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.Silver;
            this.browseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(145)))), ((int)(((byte)(142)))));
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.Location = new System.Drawing.Point(178, 484);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Silver;
            this.saveBtn.Location = new System.Drawing.Point(773, 484);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save image";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFile";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.TreeView treeView1;
    }
}