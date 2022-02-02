namespace Remember
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.welcomeLable = new System.Windows.Forms.Label();
            this.throwbackLable = new System.Windows.Forms.Label();
            this.usrMainFormLable = new System.Windows.Forms.Label();
            this.pwMainFormLable = new System.Windows.Forms.Label();
            this.usrMainFormTextBox = new System.Windows.Forms.TextBox();
            this.pwMainFormTextBox = new System.Windows.Forms.TextBox();
            this.showPwMainFormCheckBox = new System.Windows.Forms.CheckBox();
            this.logInMainFormButton = new System.Windows.Forms.Button();
            this.signUpMainFormButton = new System.Windows.Forms.Button();
            this.signUpMainFormLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLable
            // 
            this.welcomeLable.AutoSize = true;
            this.welcomeLable.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLable.Font = new System.Drawing.Font("Kristen ITC", 43F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.welcomeLable.Location = new System.Drawing.Point(143, 63);
            this.welcomeLable.Name = "welcomeLable";
            this.welcomeLable.Size = new System.Drawing.Size(677, 79);
            this.welcomeLable.TabIndex = 0;
            this.welcomeLable.Text = "Welcome to Remember";
            // 
            // throwbackLable
            // 
            this.throwbackLable.AutoSize = true;
            this.throwbackLable.BackColor = System.Drawing.Color.Transparent;
            this.throwbackLable.Font = new System.Drawing.Font("Kristen ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwbackLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.throwbackLable.Location = new System.Drawing.Point(363, 132);
            this.throwbackLable.Name = "throwbackLable";
            this.throwbackLable.Size = new System.Drawing.Size(326, 36);
            this.throwbackLable.TabIndex = 1;
            this.throwbackLable.Text = "throwback to memories";
            // 
            // usrMainFormLable
            // 
            this.usrMainFormLable.AutoSize = true;
            this.usrMainFormLable.BackColor = System.Drawing.Color.Transparent;
            this.usrMainFormLable.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrMainFormLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.usrMainFormLable.Location = new System.Drawing.Point(342, 222);
            this.usrMainFormLable.Name = "usrMainFormLable";
            this.usrMainFormLable.Size = new System.Drawing.Size(100, 22);
            this.usrMainFormLable.TabIndex = 2;
            this.usrMainFormLable.Text = "username";
            // 
            // pwMainFormLable
            // 
            this.pwMainFormLable.AutoSize = true;
            this.pwMainFormLable.BackColor = System.Drawing.Color.Transparent;
            this.pwMainFormLable.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwMainFormLable.ForeColor = System.Drawing.Color.Gainsboro;
            this.pwMainFormLable.Location = new System.Drawing.Point(342, 259);
            this.pwMainFormLable.Name = "pwMainFormLable";
            this.pwMainFormLable.Size = new System.Drawing.Size(95, 22);
            this.pwMainFormLable.TabIndex = 3;
            this.pwMainFormLable.Text = "password";
            // 
            // usrMainFormTextBox
            // 
            this.usrMainFormTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usrMainFormTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usrMainFormTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrMainFormTextBox.ForeColor = System.Drawing.Color.Black;
            this.usrMainFormTextBox.Location = new System.Drawing.Point(471, 222);
            this.usrMainFormTextBox.Name = "usrMainFormTextBox";
            this.usrMainFormTextBox.Size = new System.Drawing.Size(174, 27);
            this.usrMainFormTextBox.TabIndex = 4;
            // 
            // pwMainFormTextBox
            // 
            this.pwMainFormTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pwMainFormTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwMainFormTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwMainFormTextBox.ForeColor = System.Drawing.Color.Black;
            this.pwMainFormTextBox.Location = new System.Drawing.Point(471, 256);
            this.pwMainFormTextBox.Name = "pwMainFormTextBox";
            this.pwMainFormTextBox.PasswordChar = '●';
            this.pwMainFormTextBox.Size = new System.Drawing.Size(174, 27);
            this.pwMainFormTextBox.TabIndex = 5;
            // 
            // showPwMainFormCheckBox
            // 
            this.showPwMainFormCheckBox.AutoSize = true;
            this.showPwMainFormCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showPwMainFormCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwMainFormCheckBox.Font = new System.Drawing.Font("Verdana", 7F);
            this.showPwMainFormCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPwMainFormCheckBox.Location = new System.Drawing.Point(471, 295);
            this.showPwMainFormCheckBox.Name = "showPwMainFormCheckBox";
            this.showPwMainFormCheckBox.Size = new System.Drawing.Size(104, 16);
            this.showPwMainFormCheckBox.TabIndex = 6;
            this.showPwMainFormCheckBox.Text = "Show Password";
            this.showPwMainFormCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPwMainFormCheckBox.UseVisualStyleBackColor = false;
            // 
            // logInMainFormButton
            // 
            this.logInMainFormButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logInMainFormButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInMainFormButton.Location = new System.Drawing.Point(471, 320);
            this.logInMainFormButton.Name = "logInMainFormButton";
            this.logInMainFormButton.Size = new System.Drawing.Size(75, 23);
            this.logInMainFormButton.TabIndex = 7;
            this.logInMainFormButton.Text = "Log in";
            this.logInMainFormButton.UseVisualStyleBackColor = false;
            // 
            // signUpMainFormButton
            // 
            this.signUpMainFormButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.signUpMainFormButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpMainFormButton.Location = new System.Drawing.Point(456, 447);
            this.signUpMainFormButton.Name = "signUpMainFormButton";
            this.signUpMainFormButton.Size = new System.Drawing.Size(75, 23);
            this.signUpMainFormButton.TabIndex = 8;
            this.signUpMainFormButton.Text = "Sign up";
            this.signUpMainFormButton.UseVisualStyleBackColor = false;
            // 
            // signUpMainFormLable
            // 
            this.signUpMainFormLable.AutoSize = true;
            this.signUpMainFormLable.BackColor = System.Drawing.Color.Transparent;
            this.signUpMainFormLable.Font = new System.Drawing.Font("Verdana", 8F);
            this.signUpMainFormLable.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.signUpMainFormLable.Location = new System.Drawing.Point(333, 422);
            this.signUpMainFormLable.Name = "signUpMainFormLable";
            this.signUpMainFormLable.Size = new System.Drawing.Size(320, 13);
            this.signUpMainFormLable.TabIndex = 9;
            this.signUpMainFormLable.Text = "If you don\'t have an account, you can sign up for free!";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.signUpMainFormLable);
            this.Controls.Add(this.signUpMainFormButton);
            this.Controls.Add(this.logInMainFormButton);
            this.Controls.Add(this.showPwMainFormCheckBox);
            this.Controls.Add(this.pwMainFormTextBox);
            this.Controls.Add(this.usrMainFormTextBox);
            this.Controls.Add(this.pwMainFormLable);
            this.Controls.Add(this.usrMainFormLable);
            this.Controls.Add(this.throwbackLable);
            this.Controls.Add(this.welcomeLable);
            this.Font = new System.Drawing.Font("SimSun-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remember Slideshow";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLable;
        private System.Windows.Forms.Label throwbackLable;
        private System.Windows.Forms.Label usrMainFormLable;
        private System.Windows.Forms.Label pwMainFormLable;
        private System.Windows.Forms.TextBox usrMainFormTextBox;
        private System.Windows.Forms.TextBox pwMainFormTextBox;
        private System.Windows.Forms.CheckBox showPwMainFormCheckBox;
        private System.Windows.Forms.Button logInMainFormButton;
        private System.Windows.Forms.Button signUpMainFormButton;
        private System.Windows.Forms.Label signUpMainFormLable;
    }
}

