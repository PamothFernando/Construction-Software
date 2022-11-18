
namespace SaegisProject
{
    partial class FrmRegister
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.CheckBoxShowPass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 607);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Back to LOGIN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(139, 555);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Already Have an Account";
            // 
            // BtnClear
            // 
            this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(24, 482);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(473, 49);
            this.BtnClear.TabIndex = 73;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(20, 396);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(476, 49);
            this.BtnRegister.TabIndex = 72;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // CheckBoxShowPass
            // 
            this.CheckBoxShowPass.AutoSize = true;
            this.CheckBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShowPass.Location = new System.Drawing.Point(319, 335);
            this.CheckBoxShowPass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CheckBoxShowPass.Name = "CheckBoxShowPass";
            this.CheckBoxShowPass.Size = new System.Drawing.Size(167, 28);
            this.CheckBoxShowPass.TabIndex = 71;
            this.CheckBoxShowPass.Text = "Show Password";
            this.CheckBoxShowPass.UseVisualStyleBackColor = false;
            this.CheckBoxShowPass.CheckedChanged += new System.EventHandler(this.CheckBoxShowPass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 32);
            this.label3.TabIndex = 70;
            this.label3.Text = "Confirm Password:";
            // 
            // TxtCPassword
            // 
            this.TxtCPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCPassword.Location = new System.Drawing.Point(24, 279);
            this.TxtCPassword.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TxtCPassword.Name = "TxtCPassword";
            this.TxtCPassword.PasswordChar = '*';
            this.TxtCPassword.Size = new System.Drawing.Size(472, 38);
            this.TxtCPassword.TabIndex = 69;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(24, 171);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(472, 38);
            this.TxtPassword.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "Password:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(27, 70);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(472, 38);
            this.TxtUsername.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 65;
            this.label1.Text = "Username:";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaegisProject.Properties.Resources.nethmal_background_cover_02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 752);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.CheckBoxShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.CheckBox CheckBoxShowPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
    }
}

