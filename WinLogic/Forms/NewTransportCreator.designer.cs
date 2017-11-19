﻿namespace Tripper.WinLogic.Forms
{
    partial class NewTransportCreator
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeUC2 = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.dateTimeUC1 = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.localizationsUC3 = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.localizationsUC1 = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.textBoxUC3 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.textBoxUC2 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.textBoxUC1 = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.currencyTextBoxUC1 = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 148;
            this.label3.Text = "Kierunek - wylot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(493, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Kierunek - wylot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 150;
            this.label2.Text = "Data i godzina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(708, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 151;
            this.label4.Text = "Data i godzina";
            // 
            // dateTimeUC2
            // 
            this.dateTimeUC2.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeUC2.DatelabelMessage = "Data";
            this.dateTimeUC2.Location = new System.Drawing.Point(712, 65);
            this.dateTimeUC2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeUC2.Name = "dateTimeUC2";
            this.dateTimeUC2.Size = new System.Drawing.Size(188, 60);
            this.dateTimeUC2.TabIndex = 153;
            this.dateTimeUC2.TimeLabelMessage = "Godzina";
            // 
            // dateTimeUC1
            // 
            this.dateTimeUC1.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeUC1.DatelabelMessage = "Data";
            this.dateTimeUC1.Location = new System.Drawing.Point(265, 65);
            this.dateTimeUC1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeUC1.Name = "dateTimeUC1";
            this.dateTimeUC1.Size = new System.Drawing.Size(188, 60);
            this.dateTimeUC1.TabIndex = 152;
            this.dateTimeUC1.TimeLabelMessage = "Godzina";
            // 
            // localizationsUC3
            // 
            this.localizationsUC3.AutoSize = true;
            this.localizationsUC3.BackColor = System.Drawing.Color.Transparent;
            this.localizationsUC3.CityMessageIfEmpty = "Miasto";
            this.localizationsUC3.CountryMessageIfEmpty = "Kraj";
            this.localizationsUC3.Location = new System.Drawing.Point(497, 65);
            this.localizationsUC3.MessageVisibility = true;
            this.localizationsUC3.Name = "localizationsUC3";
            this.localizationsUC3.Size = new System.Drawing.Size(217, 68);
            this.localizationsUC3.TabIndex = 142;
            // 
            // localizationsUC1
            // 
            this.localizationsUC1.AutoSize = true;
            this.localizationsUC1.BackColor = System.Drawing.Color.Transparent;
            this.localizationsUC1.CityMessageIfEmpty = "Miasto";
            this.localizationsUC1.CountryMessageIfEmpty = "Kraj";
            this.localizationsUC1.Location = new System.Drawing.Point(50, 65);
            this.localizationsUC1.MessageVisibility = true;
            this.localizationsUC1.Name = "localizationsUC1";
            this.localizationsUC1.Size = new System.Drawing.Size(218, 68);
            this.localizationsUC1.TabIndex = 140;
            // 
            // textBoxUC3
            // 
            this.textBoxUC3.AutoSize = true;
            this.textBoxUC3.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC3.LabelMessage = "Miejsca";
            this.textBoxUC3.Location = new System.Drawing.Point(50, 189);
            this.textBoxUC3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC3.MessageVisibility = true;
            this.textBoxUC3.Multiline = false;
            this.textBoxUC3.Name = "textBoxUC3";
            this.textBoxUC3.Size = new System.Drawing.Size(112, 29);
            this.textBoxUC3.TabIndex = 145;
            // 
            // textBoxUC2
            // 
            this.textBoxUC2.AutoSize = true;
            this.textBoxUC2.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC2.LabelMessage = "Nr. Potwierdzenia";
            this.textBoxUC2.Location = new System.Drawing.Point(497, 189);
            this.textBoxUC2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC2.MessageVisibility = true;
            this.textBoxUC2.Multiline = false;
            this.textBoxUC2.Name = "textBoxUC2";
            this.textBoxUC2.Size = new System.Drawing.Size(162, 29);
            this.textBoxUC2.TabIndex = 144;
            // 
            // textBoxUC1
            // 
            this.textBoxUC1.AutoSize = true;
            this.textBoxUC1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUC1.LabelMessage = "Nr. Lotu";
            this.textBoxUC1.Location = new System.Drawing.Point(50, 151);
            this.textBoxUC1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxUC1.MessageVisibility = true;
            this.textBoxUC1.Multiline = false;
            this.textBoxUC1.Name = "textBoxUC1";
            this.textBoxUC1.Size = new System.Drawing.Size(176, 29);
            this.textBoxUC1.TabIndex = 143;
            // 
            // currencyTextBoxUC1
            // 
            this.currencyTextBoxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currencyTextBoxUC1.LabelMessage = "Cena biletu";
            this.currencyTextBoxUC1.Location = new System.Drawing.Point(497, 153);
            this.currencyTextBoxUC1.MessageVisibility = true;
            this.currencyTextBoxUC1.Name = "currencyTextBoxUC1";
            this.currencyTextBoxUC1.Size = new System.Drawing.Size(162, 27);
            this.currencyTextBoxUC1.TabIndex = 146;
            // 
            // NewTransportCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1470, 273);
            this.Controls.Add(this.dateTimeUC2);
            this.Controls.Add(this.dateTimeUC1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localizationsUC3);
            this.Controls.Add(this.localizationsUC1);
            this.Controls.Add(this.textBoxUC3);
            this.Controls.Add(this.textBoxUC2);
            this.Controls.Add(this.textBoxUC1);
            this.Controls.Add(this.currencyTextBoxUC1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTransportCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTransportCreator";
            this.Load += new System.EventHandler(this.NewTransportCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.LocalizationsUC localizationsUC1;
        private UserControls.LocalizationsUC localizationsUC3;
        private UserControls.TextBoxUC textBoxUC1;
        private UserControls.TextBoxUC textBoxUC2;
        private UserControls.TextBoxUC textBoxUC3;
        private UserControls.CurrencyTextBoxUC currencyTextBoxUC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private UserControls.DateTimeUC dateTimeUC1;
        private UserControls.DateTimeUC dateTimeUC2;
    }
}