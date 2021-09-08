
namespace HighSchoolPortal.Forms
{
    partial class MainForm
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
            this.btnOpenClass = new System.Windows.Forms.Button();
            this.btnOpenSchedule = new System.Windows.Forms.Button();
            this.panelGreeting = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenClass
            // 
            this.btnOpenClass.Location = new System.Drawing.Point(148, 385);
            this.btnOpenClass.Name = "btnOpenClass";
            this.btnOpenClass.Size = new System.Drawing.Size(130, 53);
            this.btnOpenClass.TabIndex = 7;
            this.btnOpenClass.Text = "ClassViewer";
            this.btnOpenClass.UseVisualStyleBackColor = true;
            // 
            // btnOpenSchedule
            // 
            this.btnOpenSchedule.Location = new System.Drawing.Point(12, 385);
            this.btnOpenSchedule.Name = "btnOpenSchedule";
            this.btnOpenSchedule.Size = new System.Drawing.Size(130, 53);
            this.btnOpenSchedule.TabIndex = 6;
            this.btnOpenSchedule.Text = "Schedule Viewer";
            this.btnOpenSchedule.UseVisualStyleBackColor = true;
            // 
            // panelGreeting
            // 
            this.panelGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreeting.Location = new System.Drawing.Point(12, 12);
            this.panelGreeting.Name = "panelGreeting";
            this.panelGreeting.Size = new System.Drawing.Size(637, 367);
            this.panelGreeting.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(655, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(133, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenClass);
            this.Controls.Add(this.btnOpenSchedule);
            this.Controls.Add(this.panelGreeting);
            this.Controls.Add(this.btnLogOut);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenClass;
        private System.Windows.Forms.Button btnOpenSchedule;
        private System.Windows.Forms.Panel panelGreeting;
        private System.Windows.Forms.Button btnLogOut;
    }
}

