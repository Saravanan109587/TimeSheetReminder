namespace TimesheetReminder
{
    partial class Starter
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_starterOk = new MetroFramework.Controls.MetroButton();
            this.btn_starterCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(220, 145);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(365, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Time Sheet Reminder Application Started";
            // 
            // btn_starterOk
            // 
            this.btn_starterOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_starterOk.Location = new System.Drawing.Point(435, 250);
            this.btn_starterOk.Name = "btn_starterOk";
            this.btn_starterOk.Size = new System.Drawing.Size(150, 49);
            this.btn_starterOk.TabIndex = 2;
            this.btn_starterOk.Text = "OK";
            this.btn_starterOk.UseCustomBackColor = true;
            this.btn_starterOk.UseCustomForeColor = true;
            this.btn_starterOk.UseSelectable = true;
            this.btn_starterOk.Click += new System.EventHandler(this.btn_starterOk_Click);
            // 
            // btn_starterCancel
            // 
            this.btn_starterCancel.BackColor = System.Drawing.Color.Red;
            this.btn_starterCancel.Location = new System.Drawing.Point(220, 250);
            this.btn_starterCancel.Name = "btn_starterCancel";
            this.btn_starterCancel.Size = new System.Drawing.Size(150, 49);
            this.btn_starterCancel.TabIndex = 3;
            this.btn_starterCancel.Text = "Stop";
            this.btn_starterCancel.UseCustomBackColor = true;
            this.btn_starterCancel.UseCustomForeColor = true;
            this.btn_starterCancel.UseSelectable = true;
            this.btn_starterCancel.Click += new System.EventHandler(this.btn_starterCancel_Click);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 377);
            this.Controls.Add(this.btn_starterCancel);
            this.Controls.Add(this.btn_starterOk);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Starter";
            this.Text = "Time Sheet Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_starterOk;
        private MetroFramework.Controls.MetroButton btn_starterCancel;
    }
}