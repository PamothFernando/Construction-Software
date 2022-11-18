
namespace SaegisProject
{
    partial class FrmLogin
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
            this.CheckBoxShowPass = new System.Windows.Forms.CheckBox();
            this.BtnLClear = new System.Windows.Forms.Button();
            this.BtnLLogin = new System.Windows.Forms.Button();
            this.TxtLPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = " Create Account";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(113, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 74;
            this.label4.Text = "Don\'t Have an Account";
            // 
            // CheckBoxShowPass
            // 
            this.CheckBoxShowPass.AutoSize = true;
            this.CheckBoxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShowPass.Location = new System.Drawing.Point(246, 210);
            this.CheckBoxShowPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxShowPass.Name = "CheckBoxShowPass";
            this.CheckBoxShowPass.Size = new System.Drawing.Size(136, 22);
            this.CheckBoxShowPass.TabIndex = 73;
            this.CheckBoxShowPass.Text = "Show Password";
            this.CheckBoxShowPass.UseVisualStyleBackColor = false;
            this.CheckBoxShowPass.CheckedChanged += new System.EventHandler(this.CheckBoxShowPass_CheckedChanged);
            // 
            // BtnLClear
            // 
            this.BtnLClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnLClear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLClear.Location = new System.Drawing.Point(20, 340);
            this.BtnLClear.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.BtnLClear.Name = "BtnLClear";
            this.BtnLClear.Size = new System.Drawing.Size(351, 42);
            this.BtnLClear.TabIndex = 72;
            this.BtnLClear.Text = "Clear";
            this.BtnLClear.UseVisualStyleBackColor = true;
            this.BtnLClear.Click += new System.EventHandler(this.BtnLClear_Click);
            // 
            // BtnLLogin
            // 
            this.BtnLLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLLogin.Location = new System.Drawing.Point(20, 275);
            this.BtnLLogin.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.BtnLLogin.Name = "BtnLLogin";
            this.BtnLLogin.Size = new System.Drawing.Size(351, 37);
            this.BtnLLogin.TabIndex = 71;
            this.BtnLLogin.Text = "Login";
            this.BtnLLogin.UseVisualStyleBackColor = true;
            this.BtnLLogin.Click += new System.EventHandler(this.BtnLLogin_Click);
            // 
            // TxtLPassword
            // 
            this.TxtLPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLPassword.Location = new System.Drawing.Point(20, 166);
            this.TxtLPassword.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxtLPassword.Name = "TxtLPassword";
            this.TxtLPassword.PasswordChar = '*';
            this.TxtLPassword.Size = new System.Drawing.Size(352, 32);
            this.TxtLPassword.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Password:";
            // 
            // TxtLUsername
            // 
            this.TxtLUsername.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLUsername.Location = new System.Drawing.Point(20, 52);
            this.TxtLUsername.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.TxtLUsername.Name = "TxtLUsername";
            this.TxtLUsername.Size = new System.Drawing.Size(352, 32);
            this.TxtLUsername.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Username:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SaegisProject.Properties.Resources.nethmal_background_cover_02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBoxShowPass);
            this.Controls.Add(this.BtnLClear);
            this.Controls.Add(this.BtnLLogin);
            this.Controls.Add(this.TxtLPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLUsername);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxShowPass;
        private System.Windows.Forms.Button BtnLClear;
        private System.Windows.Forms.Button BtnLLogin;
        private System.Windows.Forms.TextBox TxtLPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLUsername;
        private System.Windows.Forms.Label label1;
    }
}