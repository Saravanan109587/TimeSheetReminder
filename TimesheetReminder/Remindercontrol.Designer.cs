namespace TimesheetReminder
{
    partial class Remindercontrol
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
            this.btn_clr = new MetroFramework.Controls.MetroButton();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_taskdesc = new MetroFramework.Controls.MetroTextBox();
            this.txt_duration = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_clr.Location = new System.Drawing.Point(159, 309);
            this.btn_clr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(156, 60);
            this.btn_clr.TabIndex = 11;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseCustomBackColor = true;
            this.btn_clr.UseSelectable = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.Location = new System.Drawing.Point(724, 309);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(190, 60);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseCustomBackColor = true;
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Olive;
            this.btn_cancel.Location = new System.Drawing.Point(437, 309);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(166, 60);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Remind Later";
            this.btn_cancel.UseCustomBackColor = true;
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.metroLabel2.Location = new System.Drawing.Point(477, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(253, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Please Enter The Time Sheet";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(159, 125);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Task Details for :";
            // 
            // txt_taskdesc
            // 
            // 
            // 
            // 
            this.txt_taskdesc.CustomButton.Image = null;
            this.txt_taskdesc.CustomButton.Location = new System.Drawing.Point(646, 1);
            this.txt_taskdesc.CustomButton.Name = "";
            this.txt_taskdesc.CustomButton.Size = new System.Drawing.Size(133, 133);
            this.txt_taskdesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_taskdesc.CustomButton.TabIndex = 1;
            this.txt_taskdesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_taskdesc.CustomButton.UseSelectable = true;
            this.txt_taskdesc.CustomButton.Visible = false;
            this.txt_taskdesc.Lines = new string[0];
            this.txt_taskdesc.Location = new System.Drawing.Point(159, 159);
            this.txt_taskdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_taskdesc.MaxLength = 32767;
            this.txt_taskdesc.Multiline = true;
            this.txt_taskdesc.Name = "txt_taskdesc";
            this.txt_taskdesc.PasswordChar = '\0';
            this.txt_taskdesc.PromptText = "Task Details";
            this.txt_taskdesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_taskdesc.SelectedText = "";
            this.txt_taskdesc.SelectionLength = 0;
            this.txt_taskdesc.SelectionStart = 0;
            this.txt_taskdesc.ShortcutsEnabled = true;
            this.txt_taskdesc.Size = new System.Drawing.Size(755, 122);
            this.txt_taskdesc.TabIndex = 6;
            this.txt_taskdesc.UseSelectable = true;
            this.txt_taskdesc.WaterMark = "Task Details";
            this.txt_taskdesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_taskdesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_duration
            // 
            // 
            // 
            // 
            this.txt_duration.CustomButton.Image = null;
            this.txt_duration.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txt_duration.CustomButton.Name = "";
            this.txt_duration.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_duration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_duration.CustomButton.TabIndex = 1;
            this.txt_duration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_duration.CustomButton.UseSelectable = true;
            this.txt_duration.CustomButton.Visible = false;
            this.txt_duration.Enabled = false;
            this.txt_duration.ForeColor = System.Drawing.Color.Purple;
            this.txt_duration.Lines = new string[0];
            this.txt_duration.Location = new System.Drawing.Point(309, 125);
            this.txt_duration.MaxLength = 32767;
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.PasswordChar = '\0';
            this.txt_duration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_duration.SelectedText = "";
            this.txt_duration.SelectionLength = 0;
            this.txt_duration.SelectionStart = 0;
            this.txt_duration.ShortcutsEnabled = true;
            this.txt_duration.Size = new System.Drawing.Size(294, 23);
            this.txt_duration.TabIndex = 12;
            this.txt_duration.UseCustomForeColor = true;
            this.txt_duration.UseSelectable = true;
            this.txt_duration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_duration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Remindercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 415);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_taskdesc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Remindercontrol";
            this.Padding = new System.Windows.Forms.Padding(30, 74, 30, 25);
            this.Text = "Time Sheet Reminder";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_clr;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_taskdesc;
        private MetroFramework.Controls.MetroTextBox txt_duration;
    }
}