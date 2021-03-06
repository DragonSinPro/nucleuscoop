﻿namespace Nucleus.Gaming.Forms
{
    partial class CustomPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPrompt));
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.txt_UserInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.Location = new System.Drawing.Point(12, 9);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(386, 115);
            this.lbl_Desc.TabIndex = 0;
            this.lbl_Desc.Text = "Message";
            this.lbl_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(167, 153);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // txt_UserInput
            // 
            this.txt_UserInput.Location = new System.Drawing.Point(15, 127);
            this.txt_UserInput.Name = "txt_UserInput";
            this.txt_UserInput.Size = new System.Drawing.Size(383, 20);
            this.txt_UserInput.TabIndex = 2;
            // 
            // CustomPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 188);
            this.Controls.Add(this.txt_UserInput);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_Desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NucleusCoop - Custom Prompt";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox txt_UserInput;
    }
}