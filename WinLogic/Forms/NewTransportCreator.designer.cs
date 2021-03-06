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
            this.tLocalizationArrival = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.tLocalizationDeparture = new Tripper.WinLogic.UserControls.LocalizationsUC();
            this.pTableInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pInfoPlane = new System.Windows.Forms.Panel();
            this.tTransporter = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.tFlightNo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label7 = new System.Windows.Forms.Label();
            this.tConfirmationNo = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pInfoPlanePublic = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lSeats = new System.Windows.Forms.Label();
            this.tTransportCost = new Tripper.WinLogic.UserControls.CurrencyTextBoxUC();
            this.tSeats = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.pInfoAll = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tAdditonalInformations = new Tripper.WinLogic.UserControls.TextBoxUC();
            this.bAdd = new System.Windows.Forms.Button();
            this.dtpArrival = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.dtpDeparture = new Tripper.WinLogic.UserControls.DateTimeUC();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lArrivalCourse = new System.Windows.Forms.Label();
            this.lDepartureCourse = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            this.pTableInfo.SuspendLayout();
            this.pInfoPlane.SuspendLayout();
            this.pInfoPlanePublic.SuspendLayout();
            this.pInfoAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLocalizationArrival
            // 
            this.tLocalizationArrival.AutoSize = true;
            this.tLocalizationArrival.BackColor = System.Drawing.Color.Transparent;
            this.tLocalizationArrival.CityMessageIfEmpty = "Miasto";
            this.tLocalizationArrival.CountryList = null;
            this.tLocalizationArrival.CountryMessageIfEmpty = "Kraj";
            this.tLocalizationArrival.Location = new System.Drawing.Point(512, 50);
            this.tLocalizationArrival.MessageVisibility = true;
            this.tLocalizationArrival.Name = "tLocalizationArrival";
            this.tLocalizationArrival.SelectedLocalization = null;
            this.tLocalizationArrival.Size = new System.Drawing.Size(231, 68);
            this.tLocalizationArrival.TabIndex = 4;
            this.tLocalizationArrival.TabStop = false;
            this.tLocalizationArrival.Tag = "3";
            // 
            // tLocalizationDeparture
            // 
            this.tLocalizationDeparture.AutoSize = true;
            this.tLocalizationDeparture.BackColor = System.Drawing.Color.Transparent;
            this.tLocalizationDeparture.CityMessageIfEmpty = "Miasto";
            this.tLocalizationDeparture.CountryList = null;
            this.tLocalizationDeparture.CountryMessageIfEmpty = "Kraj";
            this.tLocalizationDeparture.Location = new System.Drawing.Point(49, 48);
            this.tLocalizationDeparture.MessageVisibility = true;
            this.tLocalizationDeparture.Name = "tLocalizationDeparture";
            this.tLocalizationDeparture.SelectedLocalization = null;
            this.tLocalizationDeparture.Size = new System.Drawing.Size(231, 68);
            this.tLocalizationDeparture.TabIndex = 2;
            this.tLocalizationDeparture.TabStop = false;
            this.tLocalizationDeparture.Tag = "1";
            // 
            // pTableInfo
            // 
            this.pTableInfo.AutoSize = true;
            this.pTableInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pTableInfo.ColumnCount = 1;
            this.pTableInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pTableInfo.Controls.Add(this.pInfoPlane, 0, 0);
            this.pTableInfo.Controls.Add(this.pInfoPlanePublic, 0, 1);
            this.pTableInfo.Controls.Add(this.pInfoAll, 0, 2);
            this.pTableInfo.Location = new System.Drawing.Point(0, 118);
            this.pTableInfo.Name = "pTableInfo";
            this.pTableInfo.RowCount = 3;
            this.pTableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pTableInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.pTableInfo.Size = new System.Drawing.Size(1037, 213);
            this.pTableInfo.TabIndex = 2;
            // 
            // pInfoPlane
            // 
            this.pInfoPlane.AutoSize = true;
            this.pInfoPlane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pInfoPlane.Controls.Add(this.tTransporter);
            this.pInfoPlane.Controls.Add(this.tFlightNo);
            this.pInfoPlane.Controls.Add(this.label7);
            this.pInfoPlane.Controls.Add(this.tConfirmationNo);
            this.pInfoPlane.Controls.Add(this.label6);
            this.pInfoPlane.Controls.Add(this.label9);
            this.pInfoPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoPlane.Location = new System.Drawing.Point(0, 0);
            this.pInfoPlane.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoPlane.Name = "pInfoPlane";
            this.pInfoPlane.Size = new System.Drawing.Size(1037, 66);
            this.pInfoPlane.TabIndex = 0;
            // 
            // tTransporter
            // 
            this.tTransporter.AutoSize = true;
            this.tTransporter.BackColor = System.Drawing.Color.Transparent;
            this.tTransporter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTransporter.LabelMessage = "Linie lotnicze";
            this.tTransporter.Location = new System.Drawing.Point(143, 3);
            this.tTransporter.Margin = new System.Windows.Forms.Padding(0);
            this.tTransporter.MessageVisibility = false;
            this.tTransporter.Multiline = false;
            this.tTransporter.Name = "tTransporter";
            this.tTransporter.Padding = new System.Windows.Forms.Padding(3);
            this.tTransporter.ReadOnly = false;
            this.tTransporter.Size = new System.Drawing.Size(204, 29);
            this.tTransporter.TabIndex = 6;
            this.tTransporter.Tag = "5";
            // 
            // tFlightNo
            // 
            this.tFlightNo.AutoSize = true;
            this.tFlightNo.BackColor = System.Drawing.Color.Transparent;
            this.tFlightNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tFlightNo.LabelMessage = "Nr. Lotu";
            this.tFlightNo.Location = new System.Drawing.Point(143, 35);
            this.tFlightNo.Margin = new System.Windows.Forms.Padding(2);
            this.tFlightNo.MessageVisibility = false;
            this.tFlightNo.Multiline = false;
            this.tFlightNo.Name = "tFlightNo";
            this.tFlightNo.Padding = new System.Windows.Forms.Padding(3);
            this.tFlightNo.ReadOnly = false;
            this.tFlightNo.Size = new System.Drawing.Size(134, 29);
            this.tFlightNo.TabIndex = 7;
            this.tFlightNo.Tag = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(27, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 144;
            this.label7.Text = "Linie lotnicze";
            // 
            // tConfirmationNo
            // 
            this.tConfirmationNo.AutoSize = true;
            this.tConfirmationNo.BackColor = System.Drawing.Color.Transparent;
            this.tConfirmationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tConfirmationNo.LabelMessage = "Nr. Potwierdzenia";
            this.tConfirmationNo.Location = new System.Drawing.Point(607, 35);
            this.tConfirmationNo.Margin = new System.Windows.Forms.Padding(2);
            this.tConfirmationNo.MessageVisibility = false;
            this.tConfirmationNo.Multiline = false;
            this.tConfirmationNo.Name = "tConfirmationNo";
            this.tConfirmationNo.Padding = new System.Windows.Forms.Padding(3);
            this.tConfirmationNo.ReadOnly = false;
            this.tConfirmationNo.Size = new System.Drawing.Size(133, 29);
            this.tConfirmationNo.TabIndex = 8;
            this.tConfirmationNo.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(455, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 146;
            this.label6.Text = "Nr. Potwierdzenia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(67, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 147;
            this.label9.Text = "Nr. Lotu";
            // 
            // pInfoPlanePublic
            // 
            this.pInfoPlanePublic.AutoSize = true;
            this.pInfoPlanePublic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pInfoPlanePublic.Controls.Add(this.label10);
            this.pInfoPlanePublic.Controls.Add(this.lSeats);
            this.pInfoPlanePublic.Controls.Add(this.tTransportCost);
            this.pInfoPlanePublic.Controls.Add(this.tSeats);
            this.pInfoPlanePublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoPlanePublic.Location = new System.Drawing.Point(0, 66);
            this.pInfoPlanePublic.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoPlanePublic.Name = "pInfoPlanePublic";
            this.pInfoPlanePublic.Size = new System.Drawing.Size(1037, 36);
            this.pInfoPlanePublic.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(550, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Koszt";
            // 
            // lSeats
            // 
            this.lSeats.AutoSize = true;
            this.lSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSeats.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lSeats.Location = new System.Drawing.Point(71, 4);
            this.lSeats.Name = "lSeats";
            this.lSeats.Size = new System.Drawing.Size(69, 20);
            this.lSeats.TabIndex = 172;
            this.lSeats.Text = "Miejsca";
            // 
            // tTransportCost
            // 
            this.tTransportCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tTransportCost.LabelMessage = "0.00";
            this.tTransportCost.Location = new System.Drawing.Point(610, 5);
            this.tTransportCost.MessageVisibility = true;
            this.tTransportCost.Name = "tTransportCost";
            this.tTransportCost.Size = new System.Drawing.Size(127, 27);
            this.tTransportCost.TabIndex = 10;
            this.tTransportCost.Tag = "";
            // 
            // tSeats
            // 
            this.tSeats.AutoSize = true;
            this.tSeats.BackColor = System.Drawing.Color.Transparent;
            this.tSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tSeats.LabelMessage = "Miejsca";
            this.tSeats.Location = new System.Drawing.Point(143, 1);
            this.tSeats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tSeats.MessageVisibility = false;
            this.tSeats.Multiline = false;
            this.tSeats.Name = "tSeats";
            this.tSeats.Padding = new System.Windows.Forms.Padding(3);
            this.tSeats.ReadOnly = false;
            this.tSeats.Size = new System.Drawing.Size(134, 29);
            this.tSeats.TabIndex = 9;
            this.tSeats.Tag = "";
            // 
            // pInfoAll
            // 
            this.pInfoAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pInfoAll.Controls.Add(this.label8);
            this.pInfoAll.Controls.Add(this.tAdditonalInformations);
            this.pInfoAll.Controls.Add(this.bAdd);
            this.pInfoAll.Location = new System.Drawing.Point(0, 102);
            this.pInfoAll.Margin = new System.Windows.Forms.Padding(0);
            this.pInfoAll.Name = "pInfoAll";
            this.pInfoAll.Size = new System.Drawing.Size(1037, 111);
            this.pInfoAll.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(46, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Informacje dodatkowe";
            // 
            // tAdditonalInformations
            // 
            this.tAdditonalInformations.AutoScroll = true;
            this.tAdditonalInformations.AutoSize = true;
            this.tAdditonalInformations.BackColor = System.Drawing.Color.Transparent;
            this.tAdditonalInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tAdditonalInformations.LabelMessage = "Informacje dodatkowe";
            this.tAdditonalInformations.Location = new System.Drawing.Point(50, 30);
            this.tAdditonalInformations.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tAdditonalInformations.MessageVisibility = false;
            this.tAdditonalInformations.Multiline = true;
            this.tAdditonalInformations.Name = "tAdditonalInformations";
            this.tAdditonalInformations.Padding = new System.Windows.Forms.Padding(3);
            this.tAdditonalInformations.ReadOnly = false;
            this.tAdditonalInformations.Size = new System.Drawing.Size(420, 32);
            this.tAdditonalInformations.TabIndex = 11;
            this.tAdditonalInformations.Tag = "";
            this.tAdditonalInformations.Enter += new System.EventHandler(this.tAdditionalInformations_Enter);
            this.tAdditonalInformations.Leave += new System.EventHandler(this.tAdditionalInformations_Leave);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Teal;
            this.bAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bAdd.ForeColor = System.Drawing.Color.White;
            this.bAdd.Location = new System.Drawing.Point(514, 24);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(260, 38);
            this.bAdd.TabIndex = 1;
            this.bAdd.Tag = "";
            this.bAdd.Text = "Zapisz";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dtpArrival
            // 
            this.dtpArrival.BackColor = System.Drawing.Color.Transparent;
            this.dtpArrival.DatelabelMessage = "Data";
            this.dtpArrival.Enabled = false;
            this.dtpArrival.EnabledDate = true;
            this.dtpArrival.EnabledTime = false;
            this.dtpArrival.Location = new System.Drawing.Point(746, 52);
            this.dtpArrival.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Padding = new System.Windows.Forms.Padding(3);
            this.dtpArrival.Size = new System.Drawing.Size(188, 66);
            this.dtpArrival.TabIndex = 5;
            this.dtpArrival.TabStop = false;
            this.dtpArrival.Tag = "4";
            this.dtpArrival.TimeLabelMessage = "Godzina";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.BackColor = System.Drawing.Color.Transparent;
            this.dtpDeparture.DatelabelMessage = "Data";
            this.dtpDeparture.Enabled = false;
            this.dtpDeparture.EnabledDate = true;
            this.dtpDeparture.EnabledTime = false;
            this.dtpDeparture.Location = new System.Drawing.Point(283, 50);
            this.dtpDeparture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeparture.Date.ValueChanged += dtpDeparture_ValueChangedDate;
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Padding = new System.Windows.Forms.Padding(3);
            this.dtpDeparture.Size = new System.Drawing.Size(188, 68);
            this.dtpDeparture.TabIndex = 3;
            this.dtpDeparture.TabStop = false;
            this.dtpDeparture.Tag = "2";
            this.dtpDeparture.TimeLabelMessage = "Godzina";
            this.dtpDeparture.ValueChangedDate += new System.EventHandler(this.dtpDeparture_ValueChangedDate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(744, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data i godzina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(281, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data i godzina";
            // 
            // lArrivalCourse
            // 
            this.lArrivalCourse.AutoSize = true;
            this.lArrivalCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lArrivalCourse.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lArrivalCourse.Location = new System.Drawing.Point(510, 29);
            this.lArrivalCourse.Margin = new System.Windows.Forms.Padding(0);
            this.lArrivalCourse.Name = "lArrivalCourse";
            this.lArrivalCourse.Size = new System.Drawing.Size(148, 20);
            this.lArrivalCourse.TabIndex = 7;
            this.lArrivalCourse.Text = "Kierunek - przylot";
            // 
            // lDepartureCourse
            // 
            this.lDepartureCourse.AutoSize = true;
            this.lDepartureCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDepartureCourse.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lDepartureCourse.Location = new System.Drawing.Point(49, 28);
            this.lDepartureCourse.Margin = new System.Windows.Forms.Padding(0);
            this.lDepartureCourse.Name = "lDepartureCourse";
            this.lDepartureCourse.Size = new System.Drawing.Size(135, 20);
            this.lDepartureCourse.TabIndex = 8;
            this.lDepartureCourse.Text = "Kierunek - wylot";
            // 
            // lError
            // 
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lError.ForeColor = System.Drawing.Color.Firebrick;
            this.lError.Location = new System.Drawing.Point(0, 1);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(934, 20);
            this.lError.TabIndex = 187;
            this.lError.Text = "Nie wszystkie dane zostały uzupełnione poprawnie";
            this.lError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lError.Visible = false;
            // 
            // NewTransportCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1046, 336);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.tLocalizationArrival);
            this.Controls.Add(this.tLocalizationDeparture);
            this.Controls.Add(this.pTableInfo);
            this.Controls.Add(this.dtpArrival);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lArrivalCourse);
            this.Controls.Add(this.lDepartureCourse);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewTransportCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0,";
            this.pTableInfo.ResumeLayout(false);
            this.pTableInfo.PerformLayout();
            this.pInfoPlane.ResumeLayout(false);
            this.pInfoPlane.PerformLayout();
            this.pInfoPlanePublic.ResumeLayout(false);
            this.pInfoPlanePublic.PerformLayout();
            this.pInfoAll.ResumeLayout(false);
            this.pInfoAll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lSeats;
        private UserControls.TextBoxUC tSeats;
        private UserControls.CurrencyTextBoxUC tTransportCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bAdd;
        private UserControls.TextBoxUC tAdditonalInformations;
        private System.Windows.Forms.TableLayoutPanel pTableInfo;
        private System.Windows.Forms.Panel pInfoPlanePublic;
        private System.Windows.Forms.Panel pInfoAll;
        private System.Windows.Forms.Panel pInfoPlane;
        private UserControls.TextBoxUC tTransporter;
        private UserControls.TextBoxUC tFlightNo;
        private System.Windows.Forms.Label label7;
        private UserControls.TextBoxUC tConfirmationNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lDepartureCourse;
        private System.Windows.Forms.Label lArrivalCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private UserControls.DateTimeUC dtpDeparture;
        private UserControls.DateTimeUC dtpArrival;
        private UserControls.LocalizationsUC tLocalizationDeparture;
        private UserControls.LocalizationsUC tLocalizationArrival;
        private System.Windows.Forms.Label lError;
    }
}