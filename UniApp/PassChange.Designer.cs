namespace UniApp
{
    partial class PasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentpassText = new System.Windows.Forms.TextBox();
            this.newpassText = new System.Windows.Forms.TextBox();
            this.conpassText = new System.Windows.Forms.TextBox();
            this.savepassButt = new System.Windows.Forms.Button();
            this.exitButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.homeButt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(111, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(137, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(118, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Pasword";
            // 
            // currentpassText
            // 
            this.currentpassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpassText.Location = new System.Drawing.Point(295, 160);
            this.currentpassText.Name = "currentpassText";
            this.currentpassText.Size = new System.Drawing.Size(311, 24);
            this.currentpassText.TabIndex = 3;
            // 
            // newpassText
            // 
            this.newpassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpassText.Location = new System.Drawing.Point(295, 223);
            this.newpassText.Name = "newpassText";
            this.newpassText.Size = new System.Drawing.Size(311, 24);
            this.newpassText.TabIndex = 4;
            // 
            // conpassText
            // 
            this.conpassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conpassText.Location = new System.Drawing.Point(295, 269);
            this.conpassText.Name = "conpassText";
            this.conpassText.Size = new System.Drawing.Size(311, 24);
            this.conpassText.TabIndex = 5;
            // 
            // savepassButt
            // 
            this.savepassButt.BackgroundImage = global::UniApp.Properties.Resources.Tasks;
            this.savepassButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savepassButt.Location = new System.Drawing.Point(383, 313);
            this.savepassButt.Name = "savepassButt";
            this.savepassButt.Size = new System.Drawing.Size(57, 53);
            this.savepassButt.TabIndex = 6;
            this.savepassButt.UseVisualStyleBackColor = true;
            this.savepassButt.Click += new System.EventHandler(this.savepassButt_Click);
            // 
            // exitButt
            // 
            this.exitButt.BackgroundImage = global::UniApp.Properties.Resources.Power___Standby;
            this.exitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButt.Location = new System.Drawing.Point(737, 391);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(51, 47);
            this.exitButt.TabIndex = 7;
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(37, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password Changing";
            // 
            // homeButt
            // 
            this.homeButt.BackgroundImage = global::UniApp.Properties.Resources.Home;
            this.homeButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButt.Location = new System.Drawing.Point(12, 389);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(51, 47);
            this.homeButt.TabIndex = 9;
            this.homeButt.UseVisualStyleBackColor = true;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Home";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(394, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Done";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(751, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Exit";
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(295, 115);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(311, 24);
            this.usernameText.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(164, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "User Name";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniApp.Properties.Resources.FBTzk6E;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.homeButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButt);
            this.Controls.Add(this.savepassButt);
            this.Controls.Add(this.conpassText);
            this.Controls.Add(this.newpassText);
            this.Controls.Add(this.currentpassText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordForm";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentpassText;
        private System.Windows.Forms.TextBox newpassText;
        private System.Windows.Forms.TextBox conpassText;
        private System.Windows.Forms.Button savepassButt;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button homeButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label8;
    }
}