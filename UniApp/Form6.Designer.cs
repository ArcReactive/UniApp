namespace UniApp
{
    partial class ChooseForm
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
            this.passform = new System.Windows.Forms.Button();
            this.restoreform = new System.Windows.Forms.Button();
            this.backupform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.homeButt = new System.Windows.Forms.Button();
            this.newuserform = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passform
            // 
            this.passform.BackgroundImage = global::UniApp.Properties.Resources.Power___Lockicon;
            this.passform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passform.Location = new System.Drawing.Point(32, 25);
            this.passform.Name = "passform";
            this.passform.Size = new System.Drawing.Size(121, 118);
            this.passform.TabIndex = 1;
            this.passform.UseVisualStyleBackColor = true;
            this.passform.Click += new System.EventHandler(this.passform_Click);
            // 
            // restoreform
            // 
            this.restoreform.BackgroundImage = global::UniApp.Properties.Resources.Power___Restart;
            this.restoreform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restoreform.Location = new System.Drawing.Point(32, 194);
            this.restoreform.Name = "restoreform";
            this.restoreform.Size = new System.Drawing.Size(121, 118);
            this.restoreform.TabIndex = 2;
            this.restoreform.UseVisualStyleBackColor = true;
            // 
            // backupform
            // 
            this.backupform.BackgroundImage = global::UniApp.Properties.Resources.ZIP_Archive;
            this.backupform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backupform.Location = new System.Drawing.Point(471, 194);
            this.backupform.Name = "backupform";
            this.backupform.Size = new System.Drawing.Size(121, 118);
            this.backupform.TabIndex = 3;
            this.backupform.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(159, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password Changing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(159, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Retore Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(352, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Backup Data";
            // 
            // homeButt
            // 
            this.homeButt.BackgroundImage = global::UniApp.Properties.Resources.Home;
            this.homeButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButt.Location = new System.Drawing.Point(294, 281);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(51, 47);
            this.homeButt.TabIndex = 7;
            this.homeButt.UseVisualStyleBackColor = true;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // newuserform
            // 
            this.newuserform.BackgroundImage = global::UniApp.Properties.Resources.Graduation;
            this.newuserform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newuserform.Location = new System.Drawing.Point(471, 25);
            this.newuserform.Name = "newuserform";
            this.newuserform.Size = new System.Drawing.Size(121, 118);
            this.newuserform.TabIndex = 8;
            this.newuserform.UseVisualStyleBackColor = true;
            this.newuserform.Click += new System.EventHandler(this.newuserform_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(379, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "New User";
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniApp.Properties.Resources.nature_full_hd_wallpapers_1920x1080_free_download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 350);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newuserform);
            this.Controls.Add(this.homeButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backupform);
            this.Controls.Add(this.restoreform);
            this.Controls.Add(this.passform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseForm";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.ChooseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passform;
        private System.Windows.Forms.Button restoreform;
        private System.Windows.Forms.Button backupform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button homeButt;
        private System.Windows.Forms.Button newuserform;
        private System.Windows.Forms.Label label4;
    }
}