﻿using Virulence.Extensions;

namespace Virulence;

partial class Screen
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
            this.txtGameLog = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblLogPageNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpScavengers = new System.Windows.Forms.GroupBox();
            this.grpScavenger6 = new System.Windows.Forms.GroupBox();
            this.lblScavengerAge6 = new System.Windows.Forms.Label();
            this.grpScavenger5 = new System.Windows.Forms.GroupBox();
            this.lblScavengerAge5 = new System.Windows.Forms.Label();
            this.grpScavenger4 = new System.Windows.Forms.GroupBox();
            this.lblScavengerAge4 = new System.Windows.Forms.Label();
            this.grpScavenger3 = new System.Windows.Forms.GroupBox();
            this.lblScavengerAge3 = new System.Windows.Forms.Label();
            this.grpScavenger2 = new System.Windows.Forms.GroupBox();
            this.lblScavengerAge2 = new System.Windows.Forms.Label();
            this.grpScavenger1 = new System.Windows.Forms.GroupBox();
            this.lblScavengerAge1 = new System.Windows.Forms.Label();
            this.lblFunds = new System.Windows.Forms.Label();
            this.grpScavengers.SuspendLayout();
            this.grpScavenger6.SuspendLayout();
            this.grpScavenger5.SuspendLayout();
            this.grpScavenger4.SuspendLayout();
            this.grpScavenger3.SuspendLayout();
            this.grpScavenger2.SuspendLayout();
            this.grpScavenger1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGameLog
            // 
            this.txtGameLog.BackColor = System.Drawing.Color.Black;
            this.txtGameLog.ForeColor = System.Drawing.Color.White;
            this.txtGameLog.Location = new System.Drawing.Point(1022, 6);
            this.txtGameLog.Multiline = true;
            this.txtGameLog.Name = "txtGameLog";
            this.txtGameLog.ReadOnly = true;
            this.txtGameLog.Size = new System.Drawing.Size(322, 406);
            this.txtGameLog.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1263, 694);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(1022, 418);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(22, 23);
            this.btnPrevPage.TabIndex = 2;
            this.btnPrevPage.Text = "<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(1322, 418);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(22, 23);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblLogPageNumber
            // 
            this.lblLogPageNumber.AutoSize = true;
            this.lblLogPageNumber.ForeColor = System.Drawing.Color.White;
            this.lblLogPageNumber.Location = new System.Drawing.Point(1172, 422);
            this.lblLogPageNumber.Name = "lblLogPageNumber";
            this.lblLogPageNumber.Size = new System.Drawing.Size(24, 15);
            this.lblLogPageNumber.TabIndex = 4;
            this.lblLogPageNumber.Text = "0/0";
            this.lblLogPageNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(844, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "0/0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(994, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(694, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpScavengers
            // 
            this.grpScavengers.Controls.Add(this.grpScavenger6);
            this.grpScavengers.Controls.Add(this.grpScavenger5);
            this.grpScavengers.Controls.Add(this.grpScavenger4);
            this.grpScavengers.Controls.Add(this.grpScavenger3);
            this.grpScavengers.Controls.Add(this.grpScavenger2);
            this.grpScavengers.Controls.Add(this.grpScavenger1);
            this.grpScavengers.ForeColor = System.Drawing.Color.White;
            this.grpScavengers.Location = new System.Drawing.Point(694, 6);
            this.grpScavengers.Name = "grpScavengers";
            this.grpScavengers.Size = new System.Drawing.Size(322, 232);
            this.grpScavengers.TabIndex = 9;
            this.grpScavengers.TabStop = false;
            this.grpScavengers.Text = "Scavengers";
            // 
            // grpScavenger6
            // 
            this.grpScavenger6.Controls.Add(this.lblScavengerAge6);
            this.grpScavenger6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger6.ForeColor = System.Drawing.Color.White;
            this.grpScavenger6.Location = new System.Drawing.Point(214, 115);
            this.grpScavenger6.Name = "grpScavenger6";
            this.grpScavenger6.Size = new System.Drawing.Size(93, 93);
            this.grpScavenger6.TabIndex = 15;
            this.grpScavenger6.TabStop = false;
            this.grpScavenger6.Text = "name1";
            // 
            // lblScavengerAge6
            // 
            this.lblScavengerAge6.AutoSize = true;
            this.lblScavengerAge6.Location = new System.Drawing.Point(6, 19);
            this.lblScavengerAge6.Name = "lblScavengerAge6";
            this.lblScavengerAge6.Size = new System.Drawing.Size(38, 15);
            this.lblScavengerAge6.TabIndex = 5;
            this.lblScavengerAge6.Text = "label7";
            // 
            // grpScavenger5
            // 
            this.grpScavenger5.Controls.Add(this.lblScavengerAge5);
            this.grpScavenger5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger5.ForeColor = System.Drawing.Color.White;
            this.grpScavenger5.Location = new System.Drawing.Point(115, 115);
            this.grpScavenger5.Name = "grpScavenger5";
            this.grpScavenger5.Size = new System.Drawing.Size(93, 93);
            this.grpScavenger5.TabIndex = 14;
            this.grpScavenger5.TabStop = false;
            this.grpScavenger5.Text = "name1";
            // 
            // lblScavengerAge5
            // 
            this.lblScavengerAge5.AutoSize = true;
            this.lblScavengerAge5.Location = new System.Drawing.Point(6, 19);
            this.lblScavengerAge5.Name = "lblScavengerAge5";
            this.lblScavengerAge5.Size = new System.Drawing.Size(38, 15);
            this.lblScavengerAge5.TabIndex = 4;
            this.lblScavengerAge5.Text = "label6";
            // 
            // grpScavenger4
            // 
            this.grpScavenger4.Controls.Add(this.lblScavengerAge4);
            this.grpScavenger4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger4.ForeColor = System.Drawing.Color.White;
            this.grpScavenger4.Location = new System.Drawing.Point(16, 115);
            this.grpScavenger4.Name = "grpScavenger4";
            this.grpScavenger4.Size = new System.Drawing.Size(93, 93);
            this.grpScavenger4.TabIndex = 13;
            this.grpScavenger4.TabStop = false;
            this.grpScavenger4.Text = "name1";
            // 
            // lblScavengerAge4
            // 
            this.lblScavengerAge4.AutoSize = true;
            this.lblScavengerAge4.Location = new System.Drawing.Point(6, 19);
            this.lblScavengerAge4.Name = "lblScavengerAge4";
            this.lblScavengerAge4.Size = new System.Drawing.Size(38, 15);
            this.lblScavengerAge4.TabIndex = 3;
            this.lblScavengerAge4.Text = "label5";
            // 
            // grpScavenger3
            // 
            this.grpScavenger3.Controls.Add(this.lblScavengerAge3);
            this.grpScavenger3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger3.ForeColor = System.Drawing.Color.White;
            this.grpScavenger3.Location = new System.Drawing.Point(213, 22);
            this.grpScavenger3.Name = "grpScavenger3";
            this.grpScavenger3.Size = new System.Drawing.Size(93, 93);
            this.grpScavenger3.TabIndex = 12;
            this.grpScavenger3.TabStop = false;
            this.grpScavenger3.Text = "name1";
            // 
            // lblScavengerAge3
            // 
            this.lblScavengerAge3.AutoSize = true;
            this.lblScavengerAge3.Location = new System.Drawing.Point(6, 19);
            this.lblScavengerAge3.Name = "lblScavengerAge3";
            this.lblScavengerAge3.Size = new System.Drawing.Size(38, 15);
            this.lblScavengerAge3.TabIndex = 2;
            this.lblScavengerAge3.Text = "label4";
            // 
            // grpScavenger2
            // 
            this.grpScavenger2.Controls.Add(this.lblScavengerAge2);
            this.grpScavenger2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger2.ForeColor = System.Drawing.Color.White;
            this.grpScavenger2.Location = new System.Drawing.Point(114, 22);
            this.grpScavenger2.Name = "grpScavenger2";
            this.grpScavenger2.Size = new System.Drawing.Size(93, 93);
            this.grpScavenger2.TabIndex = 11;
            this.grpScavenger2.TabStop = false;
            this.grpScavenger2.Text = "name1";
            // 
            // lblScavengerAge2
            // 
            this.lblScavengerAge2.AutoSize = true;
            this.lblScavengerAge2.Location = new System.Drawing.Point(6, 19);
            this.lblScavengerAge2.Name = "lblScavengerAge2";
            this.lblScavengerAge2.Size = new System.Drawing.Size(38, 15);
            this.lblScavengerAge2.TabIndex = 1;
            this.lblScavengerAge2.Text = "label3";
            // 
            // grpScavenger1
            // 
            this.grpScavenger1.Controls.Add(this.lblScavengerAge1);
            this.grpScavenger1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger1.ForeColor = System.Drawing.Color.White;
            this.grpScavenger1.Location = new System.Drawing.Point(15, 22);
            this.grpScavenger1.Name = "grpScavenger1";
            this.grpScavenger1.Size = new System.Drawing.Size(93, 93);
            this.grpScavenger1.TabIndex = 10;
            this.grpScavenger1.TabStop = false;
            this.grpScavenger1.Text = "name1";
            // 
            // lblScavengerAge1
            // 
            this.lblScavengerAge1.AutoSize = true;
            this.lblScavengerAge1.Location = new System.Drawing.Point(6, 19);
            this.lblScavengerAge1.Name = "lblScavengerAge1";
            this.lblScavengerAge1.Size = new System.Drawing.Size(38, 15);
            this.lblScavengerAge1.TabIndex = 0;
            this.lblScavengerAge1.Text = "label2";
            // 
            // lblFunds
            // 
            this.lblFunds.AutoSize = true;
            this.lblFunds.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFunds.ForeColor = System.Drawing.Color.White;
            this.lblFunds.Location = new System.Drawing.Point(12, 9);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(141, 35);
            this.lblFunds.TabIndex = 10;
            this.lblFunds.Text = "Funds: ";
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.lblFunds);
            this.Controls.Add(this.grpScavengers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLogPageNumber);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGameLog);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Screen";
            this.Text = "Virulence";
            this.Shown += new System.EventHandler(this.Form1_Show);
            this.grpScavengers.ResumeLayout(false);
            this.grpScavenger6.ResumeLayout(false);
            this.grpScavenger6.PerformLayout();
            this.grpScavenger5.ResumeLayout(false);
            this.grpScavenger5.PerformLayout();
            this.grpScavenger4.ResumeLayout(false);
            this.grpScavenger4.PerformLayout();
            this.grpScavenger3.ResumeLayout(false);
            this.grpScavenger3.PerformLayout();
            this.grpScavenger2.ResumeLayout(false);
            this.grpScavenger2.PerformLayout();
            this.grpScavenger1.ResumeLayout(false);
            this.grpScavenger1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtGameLog;
    private System.Windows.Forms.Button btnExit;
    private Button btnPrevPage;
    private Button btnNextPage;
    private Label lblLogPageNumber;
    private Label label1;
    private Button button1;
    private Button button2;
    private GroupBox grpScavengers;
    private GroupBox grpScavenger1;
    private GroupBox grpScavenger2;
    private GroupBox grpScavenger6;
    private GroupBox grpScavenger5;
    private GroupBox grpScavenger4;
    private GroupBox grpScavenger3;
    private Label lblScavengerAge6;
    private Label lblScavengerAge5;
    private Label lblScavengerAge4;
    private Label lblScavengerAge3;
    private Label lblScavengerAge2;
    private Label lblScavengerAge1;
    private Label lblFunds;
}
