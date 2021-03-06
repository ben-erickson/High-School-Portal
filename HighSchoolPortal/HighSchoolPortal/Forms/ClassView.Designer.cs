
namespace HighSchoolPortal.Forms
{
    partial class ClassView
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
            this.comboClasses = new System.Windows.Forms.ComboBox();
            this.panelClassInfo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.btnConfirmCombo = new System.Windows.Forms.Button();
            this.panelClassInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboClasses
            // 
            this.comboClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboClasses.FormattingEnabled = true;
            this.comboClasses.Location = new System.Drawing.Point(12, 23);
            this.comboClasses.Name = "comboClasses";
            this.comboClasses.Size = new System.Drawing.Size(645, 21);
            this.comboClasses.TabIndex = 0;
            // 
            // panelClassInfo
            // 
            this.panelClassInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClassInfo.Controls.Add(this.lblTeacherName);
            this.panelClassInfo.Controls.Add(this.lblClassName);
            this.panelClassInfo.Location = new System.Drawing.Point(12, 50);
            this.panelClassInfo.Name = "panelClassInfo";
            this.panelClassInfo.Size = new System.Drawing.Size(776, 348);
            this.panelClassInfo.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(662, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(23, 47);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(0, 13);
            this.lblClassName.TabIndex = 0;
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(26, 107);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(0, 13);
            this.lblTeacherName.TabIndex = 1;
            // 
            // btnConfirmCombo
            // 
            this.btnConfirmCombo.Location = new System.Drawing.Point(663, 23);
            this.btnConfirmCombo.Name = "btnConfirmCombo";
            this.btnConfirmCombo.Size = new System.Drawing.Size(125, 21);
            this.btnConfirmCombo.TabIndex = 3;
            this.btnConfirmCombo.Text = "Confirm";
            this.btnConfirmCombo.UseVisualStyleBackColor = true;
            // 
            // ClassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmCombo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelClassInfo);
            this.Controls.Add(this.comboClasses);
            this.Name = "ClassView";
            this.Text = "ClassView";
            this.panelClassInfo.ResumeLayout(false);
            this.panelClassInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClasses;
        private System.Windows.Forms.Panel panelClassInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnConfirmCombo;
    }
}