﻿namespace SW_APIS_CLIENT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetInvoiceByUuidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetInvoiceByUuidButton
            // 
            this.GetInvoiceByUuidButton.Location = new System.Drawing.Point(281, 160);
            this.GetInvoiceByUuidButton.Name = "GetInvoiceByUuidButton";
            this.GetInvoiceByUuidButton.Size = new System.Drawing.Size(143, 49);
            this.GetInvoiceByUuidButton.TabIndex = 0;
            this.GetInvoiceByUuidButton.Text = "GetInvoiceByUuid";
            this.GetInvoiceByUuidButton.UseVisualStyleBackColor = true;
            this.GetInvoiceByUuidButton.Click += new System.EventHandler(this.GetInvoiceByUuidButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetInvoiceByUuidButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button GetInvoiceByUuidButton;
    }
}