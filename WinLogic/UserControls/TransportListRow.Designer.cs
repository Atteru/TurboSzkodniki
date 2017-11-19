﻿namespace Tripper.WinLogic.UserControls
{
    partial class TransportListRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTop = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.TicketPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pTop.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.DarkCyan;
            this.pTop.Controls.Add(this.flowLayoutPanel);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTop.Location = new System.Drawing.Point(3, 3);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(969, 49);
            this.pTop.TabIndex = 3;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.bEdit);
            this.flowLayoutPanel.Controls.Add(this.bDelete);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel.Location = new System.Drawing.Point(763, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(206, 49);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Teal;
            this.bEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bEdit.FlatAppearance.BorderSize = 2;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bEdit.ForeColor = System.Drawing.Color.White;
            this.bEdit.Location = new System.Drawing.Point(5, 5);
            this.bEdit.Margin = new System.Windows.Forms.Padding(5);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(92, 40);
            this.bEdit.TabIndex = 161;
            this.bEdit.Text = "Edytuj";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Teal;
            this.bDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bDelete.FlatAppearance.BorderSize = 2;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDelete.ForeColor = System.Drawing.Color.White;
            this.bDelete.Location = new System.Drawing.Point(107, 5);
            this.bDelete.Margin = new System.Windows.Forms.Padding(5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(92, 40);
            this.bDelete.TabIndex = 162;
            this.bDelete.Text = "Usuń";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // TicketPanel
            // 
            this.TicketPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.TicketPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketPanel.Location = new System.Drawing.Point(3, 58);
            this.TicketPanel.Name = "TicketPanel";
            this.TicketPanel.Size = new System.Drawing.Size(969, 210);
            this.TicketPanel.TabIndex = 2;
            this.TicketPanel.Visible = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.TicketPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pTop, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(975, 271);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // TransportListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TransportListRow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(981, 277);
            this.pTop.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Panel TicketPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
