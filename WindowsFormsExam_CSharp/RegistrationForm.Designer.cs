namespace WindowsFormsExam_CSharp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.ToLoginButton = new System.Windows.Forms.LinkLabel();
            this.Registration_button = new System.Windows.Forms.Button();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Button_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SubmitCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ToLoginButton
            // 
            this.ToLoginButton.ActiveLinkColor = System.Drawing.Color.Black;
            this.ToLoginButton.AutoSize = true;
            this.ToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToLoginButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLoginButton.Location = new System.Drawing.Point(201, 422);
            this.ToLoginButton.Name = "ToLoginButton";
            this.ToLoginButton.Size = new System.Drawing.Size(140, 19);
            this.ToLoginButton.TabIndex = 17;
            this.ToLoginButton.TabStop = true;
            this.ToLoginButton.Text = "Ви вже зараєстровані?";
            this.ToLoginButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToLoginButton_LinkClicked);
            // 
            // Registration_button
            // 
            this.Registration_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Registration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_button.FlatAppearance.BorderSize = 0;
            this.Registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_button.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Registration_button.Location = new System.Drawing.Point(146, 347);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(258, 48);
            this.Registration_button.TabIndex = 16;
            this.Registration_button.Text = "Зареєструватися";
            this.Registration_button.UseVisualStyleBackColor = false;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTextBox.Location = new System.Drawing.Point(129, 246);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(298, 44);
            this.PassTextBox.TabIndex = 15;
            this.PassTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassTextBox_MouseClick);
            this.PassTextBox.Leave += new System.EventHandler(this.PassTextBox_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(116, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Форма Реєстрації";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(129, 146);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(298, 44);
            this.EmailTextBox.TabIndex = 20;
            this.EmailTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmailTextBox_MouseClick);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(129, 96);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(298, 44);
            this.NameTextBox.TabIndex = 22;
            this.NameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameTextBox_MouseClick);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsExam_CSharp.Properties.Resources.icons8_name_100;
            this.pictureBox5.Location = new System.Drawing.Point(75, 96);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsExam_CSharp.Properties.Resources.icons8_email_sign_96;
            this.pictureBox4.Location = new System.Drawing.Point(75, 146);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Button_Exit.Image")));
            this.Button_Exit.Location = new System.Drawing.Point(504, 1);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(24, 24);
            this.Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Button_Exit.TabIndex = 19;
            this.Button_Exit.TabStop = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(75, 246);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // SubmitCheckBox
            // 
            this.SubmitCheckBox.AutoSize = true;
            this.SubmitCheckBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitCheckBox.Location = new System.Drawing.Point(129, 296);
            this.SubmitCheckBox.Name = "SubmitCheckBox";
            this.SubmitCheckBox.Size = new System.Drawing.Size(142, 32);
            this.SubmitCheckBox.TabIndex = 25;
            this.SubmitCheckBox.Text = "Підтвердити";
            this.SubmitCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(129, 196);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(298, 44);
            this.LoginTextBox.TabIndex = 26;
            this.LoginTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginTextBox_MouseClick);
            this.LoginTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.SubmitCheckBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.ToLoginButton);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ToLoginButton;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Button_Exit;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox SubmitCheckBox;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}