using Virulence.Extensions;

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
            this.btnLogPrevPage = new System.Windows.Forms.Button();
            this.btnLogNextPage = new System.Windows.Forms.Button();
            this.lblLogPageNumber = new System.Windows.Forms.Label();
            this.lblScavengerDisplayPageNumber = new System.Windows.Forms.Label();
            this.btnScavengerDisplayNextPage = new System.Windows.Forms.Button();
            this.btnScavengerDisplayPrevPage = new System.Windows.Forms.Button();
            this.grpScavengers = new System.Windows.Forms.GroupBox();
            this.grpScavenger6 = new System.Windows.Forms.GroupBox();
            this.lblManualScavenger6 = new System.Windows.Forms.Label();
            this.lblCoordinatesScavenger6 = new System.Windows.Forms.Label();
            this.lblLocationScavenger6 = new System.Windows.Forms.Label();
            this.prgrsScavenger6 = new System.Windows.Forms.ProgressBar();
            this.lblCreditsScavenger6 = new System.Windows.Forms.Label();
            this.grpScavenger5 = new System.Windows.Forms.GroupBox();
            this.lblManualScavenger5 = new System.Windows.Forms.Label();
            this.lblCoordinatesScavenger5 = new System.Windows.Forms.Label();
            this.lblLocationScavenger5 = new System.Windows.Forms.Label();
            this.prgrsScavenger5 = new System.Windows.Forms.ProgressBar();
            this.lblCreditsScavenger5 = new System.Windows.Forms.Label();
            this.grpScavenger4 = new System.Windows.Forms.GroupBox();
            this.lblManualScavenger4 = new System.Windows.Forms.Label();
            this.lblCoordinatesScavenger4 = new System.Windows.Forms.Label();
            this.lblLocationScavenger4 = new System.Windows.Forms.Label();
            this.prgrsScavenger4 = new System.Windows.Forms.ProgressBar();
            this.lblCreditsScavenger4 = new System.Windows.Forms.Label();
            this.grpScavenger3 = new System.Windows.Forms.GroupBox();
            this.lblManualScavenger3 = new System.Windows.Forms.Label();
            this.lblCoordinatesScavenger3 = new System.Windows.Forms.Label();
            this.lblLocationScavenger3 = new System.Windows.Forms.Label();
            this.prgrsScavenger3 = new System.Windows.Forms.ProgressBar();
            this.lblCreditsScavenger3 = new System.Windows.Forms.Label();
            this.grpScavenger2 = new System.Windows.Forms.GroupBox();
            this.lblManualScavenger2 = new System.Windows.Forms.Label();
            this.lblCoordinatesScavenger2 = new System.Windows.Forms.Label();
            this.lblLocationScavenger2 = new System.Windows.Forms.Label();
            this.prgrsScavenger2 = new System.Windows.Forms.ProgressBar();
            this.lblCreditsScavenger2 = new System.Windows.Forms.Label();
            this.grpScavenger1 = new System.Windows.Forms.GroupBox();
            this.lblManualScavenger1 = new System.Windows.Forms.Label();
            this.lblCoordinatesScavenger1 = new System.Windows.Forms.Label();
            this.lblLocationScavenger1 = new System.Windows.Forms.Label();
            this.prgrsScavenger1 = new System.Windows.Forms.ProgressBar();
            this.lblCreditsScavenger1 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtOtherCurrencies = new System.Windows.Forms.TextBox();
            this.dpadScavengerMovement = new Virulence.Controls.Dpad();
            this.btnNextScavenger = new System.Windows.Forms.Button();
            this.btnPrevScavenger = new System.Windows.Forms.Button();
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
            this.txtGameLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameLog.BackColor = System.Drawing.Color.Black;
            this.txtGameLog.ForeColor = System.Drawing.Color.White;
            this.txtGameLog.Location = new System.Drawing.Point(1576, 6);
            this.txtGameLog.Multiline = true;
            this.txtGameLog.Name = "txtGameLog";
            this.txtGameLog.ReadOnly = true;
            this.txtGameLog.Size = new System.Drawing.Size(322, 406);
            this.txtGameLog.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1817, 1006);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogPrevPage
            // 
            this.btnLogPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogPrevPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnLogPrevPage.Location = new System.Drawing.Point(1576, 418);
            this.btnLogPrevPage.Name = "btnLogPrevPage";
            this.btnLogPrevPage.Size = new System.Drawing.Size(22, 23);
            this.btnLogPrevPage.TabIndex = 2;
            this.btnLogPrevPage.Text = "<";
            this.btnLogPrevPage.UseVisualStyleBackColor = true;
            this.btnLogPrevPage.Click += new System.EventHandler(this.btnLogPrevPage_Click);
            // 
            // btnLogNextPage
            // 
            this.btnLogNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogNextPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogNextPage.ForeColor = System.Drawing.Color.White;
            this.btnLogNextPage.Location = new System.Drawing.Point(1876, 418);
            this.btnLogNextPage.Name = "btnLogNextPage";
            this.btnLogNextPage.Size = new System.Drawing.Size(22, 23);
            this.btnLogNextPage.TabIndex = 3;
            this.btnLogNextPage.Text = ">";
            this.btnLogNextPage.UseVisualStyleBackColor = true;
            this.btnLogNextPage.Click += new System.EventHandler(this.btnLogNextPage_Click);
            // 
            // lblLogPageNumber
            // 
            this.lblLogPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogPageNumber.AutoSize = true;
            this.lblLogPageNumber.ForeColor = System.Drawing.Color.White;
            this.lblLogPageNumber.Location = new System.Drawing.Point(1726, 422);
            this.lblLogPageNumber.Name = "lblLogPageNumber";
            this.lblLogPageNumber.Size = new System.Drawing.Size(24, 15);
            this.lblLogPageNumber.TabIndex = 4;
            this.lblLogPageNumber.Text = "0/0";
            this.lblLogPageNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScavengerDisplayPageNumber
            // 
            this.lblScavengerDisplayPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScavengerDisplayPageNumber.AutoSize = true;
            this.lblScavengerDisplayPageNumber.ForeColor = System.Drawing.Color.White;
            this.lblScavengerDisplayPageNumber.Location = new System.Drawing.Point(1267, 422);
            this.lblScavengerDisplayPageNumber.Name = "lblScavengerDisplayPageNumber";
            this.lblScavengerDisplayPageNumber.Size = new System.Drawing.Size(24, 15);
            this.lblScavengerDisplayPageNumber.TabIndex = 8;
            this.lblScavengerDisplayPageNumber.Text = "0/0";
            this.lblScavengerDisplayPageNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnScavengerDisplayNextPage
            // 
            this.btnScavengerDisplayNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScavengerDisplayNextPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScavengerDisplayNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScavengerDisplayNextPage.ForeColor = System.Drawing.Color.White;
            this.btnScavengerDisplayNextPage.Location = new System.Drawing.Point(1548, 418);
            this.btnScavengerDisplayNextPage.Name = "btnScavengerDisplayNextPage";
            this.btnScavengerDisplayNextPage.Size = new System.Drawing.Size(22, 23);
            this.btnScavengerDisplayNextPage.TabIndex = 7;
            this.btnScavengerDisplayNextPage.Text = ">";
            this.btnScavengerDisplayNextPage.UseVisualStyleBackColor = true;
            this.btnScavengerDisplayNextPage.Click += new System.EventHandler(this.btnScavengerDisplayNextPage_Click);
            // 
            // btnScavengerDisplayPrevPage
            // 
            this.btnScavengerDisplayPrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScavengerDisplayPrevPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScavengerDisplayPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScavengerDisplayPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnScavengerDisplayPrevPage.Location = new System.Drawing.Point(987, 418);
            this.btnScavengerDisplayPrevPage.Name = "btnScavengerDisplayPrevPage";
            this.btnScavengerDisplayPrevPage.Size = new System.Drawing.Size(22, 23);
            this.btnScavengerDisplayPrevPage.TabIndex = 6;
            this.btnScavengerDisplayPrevPage.Text = "<";
            this.btnScavengerDisplayPrevPage.UseVisualStyleBackColor = true;
            this.btnScavengerDisplayPrevPage.Click += new System.EventHandler(this.btnScavengerDisplayPrevPage_Click);
            // 
            // grpScavengers
            // 
            this.grpScavengers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpScavengers.Controls.Add(this.grpScavenger6);
            this.grpScavengers.Controls.Add(this.grpScavenger5);
            this.grpScavengers.Controls.Add(this.grpScavenger4);
            this.grpScavengers.Controls.Add(this.grpScavenger3);
            this.grpScavengers.Controls.Add(this.grpScavenger2);
            this.grpScavengers.Controls.Add(this.grpScavenger1);
            this.grpScavengers.ForeColor = System.Drawing.Color.White;
            this.grpScavengers.Location = new System.Drawing.Point(987, 6);
            this.grpScavengers.Name = "grpScavengers";
            this.grpScavengers.Size = new System.Drawing.Size(583, 406);
            this.grpScavengers.TabIndex = 9;
            this.grpScavengers.TabStop = false;
            this.grpScavengers.Text = "Scavengers";
            // 
            // grpScavenger6
            // 
            this.grpScavenger6.Controls.Add(this.lblManualScavenger6);
            this.grpScavenger6.Controls.Add(this.lblCoordinatesScavenger6);
            this.grpScavenger6.Controls.Add(this.lblLocationScavenger6);
            this.grpScavenger6.Controls.Add(this.prgrsScavenger6);
            this.grpScavenger6.Controls.Add(this.lblCreditsScavenger6);
            this.grpScavenger6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger6.ForeColor = System.Drawing.Color.White;
            this.grpScavenger6.Location = new System.Drawing.Point(402, 225);
            this.grpScavenger6.Name = "grpScavenger6";
            this.grpScavenger6.Size = new System.Drawing.Size(175, 175);
            this.grpScavenger6.TabIndex = 15;
            this.grpScavenger6.TabStop = false;
            this.grpScavenger6.Text = "name";
            // 
            // lblManualScavenger6
            // 
            this.lblManualScavenger6.AutoSize = true;
            this.lblManualScavenger6.Location = new System.Drawing.Point(6, 79);
            this.lblManualScavenger6.Name = "lblManualScavenger6";
            this.lblManualScavenger6.Size = new System.Drawing.Size(47, 15);
            this.lblManualScavenger6.TabIndex = 9;
            this.lblManualScavenger6.Text = "manual";
            // 
            // lblCoordinatesScavenger6
            // 
            this.lblCoordinatesScavenger6.AutoSize = true;
            this.lblCoordinatesScavenger6.Location = new System.Drawing.Point(6, 59);
            this.lblCoordinatesScavenger6.Name = "lblCoordinatesScavenger6";
            this.lblCoordinatesScavenger6.Size = new System.Drawing.Size(69, 15);
            this.lblCoordinatesScavenger6.TabIndex = 8;
            this.lblCoordinatesScavenger6.Text = "coordinates";
            // 
            // lblLocationScavenger6
            // 
            this.lblLocationScavenger6.AutoSize = true;
            this.lblLocationScavenger6.Location = new System.Drawing.Point(6, 39);
            this.lblLocationScavenger6.Name = "lblLocationScavenger6";
            this.lblLocationScavenger6.Size = new System.Drawing.Size(50, 15);
            this.lblLocationScavenger6.TabIndex = 7;
            this.lblLocationScavenger6.Text = "location";
            // 
            // prgrsScavenger6
            // 
            this.prgrsScavenger6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrsScavenger6.Location = new System.Drawing.Point(6, 159);
            this.prgrsScavenger6.Name = "prgrsScavenger6";
            this.prgrsScavenger6.Size = new System.Drawing.Size(163, 10);
            this.prgrsScavenger6.TabIndex = 6;
            // 
            // lblCreditsScavenger6
            // 
            this.lblCreditsScavenger6.AutoSize = true;
            this.lblCreditsScavenger6.Location = new System.Drawing.Point(6, 19);
            this.lblCreditsScavenger6.Name = "lblCreditsScavenger6";
            this.lblCreditsScavenger6.Size = new System.Drawing.Size(25, 15);
            this.lblCreditsScavenger6.TabIndex = 5;
            this.lblCreditsScavenger6.Text = "C/s";
            // 
            // grpScavenger5
            // 
            this.grpScavenger5.Controls.Add(this.lblManualScavenger5);
            this.grpScavenger5.Controls.Add(this.lblCoordinatesScavenger5);
            this.grpScavenger5.Controls.Add(this.lblLocationScavenger5);
            this.grpScavenger5.Controls.Add(this.prgrsScavenger5);
            this.grpScavenger5.Controls.Add(this.lblCreditsScavenger5);
            this.grpScavenger5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger5.ForeColor = System.Drawing.Color.White;
            this.grpScavenger5.Location = new System.Drawing.Point(204, 225);
            this.grpScavenger5.Name = "grpScavenger5";
            this.grpScavenger5.Size = new System.Drawing.Size(175, 175);
            this.grpScavenger5.TabIndex = 14;
            this.grpScavenger5.TabStop = false;
            this.grpScavenger5.Text = "name";
            // 
            // lblManualScavenger5
            // 
            this.lblManualScavenger5.AutoSize = true;
            this.lblManualScavenger5.Location = new System.Drawing.Point(6, 79);
            this.lblManualScavenger5.Name = "lblManualScavenger5";
            this.lblManualScavenger5.Size = new System.Drawing.Size(47, 15);
            this.lblManualScavenger5.TabIndex = 8;
            this.lblManualScavenger5.Text = "manual";
            // 
            // lblCoordinatesScavenger5
            // 
            this.lblCoordinatesScavenger5.AutoSize = true;
            this.lblCoordinatesScavenger5.Location = new System.Drawing.Point(6, 59);
            this.lblCoordinatesScavenger5.Name = "lblCoordinatesScavenger5";
            this.lblCoordinatesScavenger5.Size = new System.Drawing.Size(69, 15);
            this.lblCoordinatesScavenger5.TabIndex = 7;
            this.lblCoordinatesScavenger5.Text = "coordinates";
            // 
            // lblLocationScavenger5
            // 
            this.lblLocationScavenger5.AutoSize = true;
            this.lblLocationScavenger5.Location = new System.Drawing.Point(6, 39);
            this.lblLocationScavenger5.Name = "lblLocationScavenger5";
            this.lblLocationScavenger5.Size = new System.Drawing.Size(50, 15);
            this.lblLocationScavenger5.TabIndex = 6;
            this.lblLocationScavenger5.Text = "location";
            // 
            // prgrsScavenger5
            // 
            this.prgrsScavenger5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrsScavenger5.Location = new System.Drawing.Point(6, 159);
            this.prgrsScavenger5.Name = "prgrsScavenger5";
            this.prgrsScavenger5.Size = new System.Drawing.Size(163, 10);
            this.prgrsScavenger5.TabIndex = 5;
            // 
            // lblCreditsScavenger5
            // 
            this.lblCreditsScavenger5.AutoSize = true;
            this.lblCreditsScavenger5.Location = new System.Drawing.Point(6, 19);
            this.lblCreditsScavenger5.Name = "lblCreditsScavenger5";
            this.lblCreditsScavenger5.Size = new System.Drawing.Size(25, 15);
            this.lblCreditsScavenger5.TabIndex = 4;
            this.lblCreditsScavenger5.Text = "C/s";
            // 
            // grpScavenger4
            // 
            this.grpScavenger4.Controls.Add(this.lblManualScavenger4);
            this.grpScavenger4.Controls.Add(this.lblCoordinatesScavenger4);
            this.grpScavenger4.Controls.Add(this.lblLocationScavenger4);
            this.grpScavenger4.Controls.Add(this.prgrsScavenger4);
            this.grpScavenger4.Controls.Add(this.lblCreditsScavenger4);
            this.grpScavenger4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger4.ForeColor = System.Drawing.Color.White;
            this.grpScavenger4.Location = new System.Drawing.Point(6, 225);
            this.grpScavenger4.Name = "grpScavenger4";
            this.grpScavenger4.Size = new System.Drawing.Size(175, 175);
            this.grpScavenger4.TabIndex = 13;
            this.grpScavenger4.TabStop = false;
            this.grpScavenger4.Text = "name";
            // 
            // lblManualScavenger4
            // 
            this.lblManualScavenger4.AutoSize = true;
            this.lblManualScavenger4.Location = new System.Drawing.Point(6, 79);
            this.lblManualScavenger4.Name = "lblManualScavenger4";
            this.lblManualScavenger4.Size = new System.Drawing.Size(47, 15);
            this.lblManualScavenger4.TabIndex = 7;
            this.lblManualScavenger4.Text = "manual";
            // 
            // lblCoordinatesScavenger4
            // 
            this.lblCoordinatesScavenger4.AutoSize = true;
            this.lblCoordinatesScavenger4.Location = new System.Drawing.Point(6, 59);
            this.lblCoordinatesScavenger4.Name = "lblCoordinatesScavenger4";
            this.lblCoordinatesScavenger4.Size = new System.Drawing.Size(69, 15);
            this.lblCoordinatesScavenger4.TabIndex = 6;
            this.lblCoordinatesScavenger4.Text = "coordinates";
            // 
            // lblLocationScavenger4
            // 
            this.lblLocationScavenger4.AutoSize = true;
            this.lblLocationScavenger4.Location = new System.Drawing.Point(6, 39);
            this.lblLocationScavenger4.Name = "lblLocationScavenger4";
            this.lblLocationScavenger4.Size = new System.Drawing.Size(50, 15);
            this.lblLocationScavenger4.TabIndex = 5;
            this.lblLocationScavenger4.Text = "location";
            // 
            // prgrsScavenger4
            // 
            this.prgrsScavenger4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrsScavenger4.Location = new System.Drawing.Point(6, 159);
            this.prgrsScavenger4.Name = "prgrsScavenger4";
            this.prgrsScavenger4.Size = new System.Drawing.Size(163, 10);
            this.prgrsScavenger4.TabIndex = 4;
            // 
            // lblCreditsScavenger4
            // 
            this.lblCreditsScavenger4.AutoSize = true;
            this.lblCreditsScavenger4.Location = new System.Drawing.Point(6, 19);
            this.lblCreditsScavenger4.Name = "lblCreditsScavenger4";
            this.lblCreditsScavenger4.Size = new System.Drawing.Size(25, 15);
            this.lblCreditsScavenger4.TabIndex = 3;
            this.lblCreditsScavenger4.Text = "C/s";
            // 
            // grpScavenger3
            // 
            this.grpScavenger3.Controls.Add(this.lblManualScavenger3);
            this.grpScavenger3.Controls.Add(this.lblCoordinatesScavenger3);
            this.grpScavenger3.Controls.Add(this.lblLocationScavenger3);
            this.grpScavenger3.Controls.Add(this.prgrsScavenger3);
            this.grpScavenger3.Controls.Add(this.lblCreditsScavenger3);
            this.grpScavenger3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger3.ForeColor = System.Drawing.Color.White;
            this.grpScavenger3.Location = new System.Drawing.Point(402, 22);
            this.grpScavenger3.Name = "grpScavenger3";
            this.grpScavenger3.Size = new System.Drawing.Size(175, 175);
            this.grpScavenger3.TabIndex = 12;
            this.grpScavenger3.TabStop = false;
            this.grpScavenger3.Text = "name";
            // 
            // lblManualScavenger3
            // 
            this.lblManualScavenger3.AutoSize = true;
            this.lblManualScavenger3.Location = new System.Drawing.Point(6, 79);
            this.lblManualScavenger3.Name = "lblManualScavenger3";
            this.lblManualScavenger3.Size = new System.Drawing.Size(47, 15);
            this.lblManualScavenger3.TabIndex = 6;
            this.lblManualScavenger3.Text = "manual";
            // 
            // lblCoordinatesScavenger3
            // 
            this.lblCoordinatesScavenger3.AutoSize = true;
            this.lblCoordinatesScavenger3.Location = new System.Drawing.Point(6, 59);
            this.lblCoordinatesScavenger3.Name = "lblCoordinatesScavenger3";
            this.lblCoordinatesScavenger3.Size = new System.Drawing.Size(69, 15);
            this.lblCoordinatesScavenger3.TabIndex = 5;
            this.lblCoordinatesScavenger3.Text = "coordinates";
            // 
            // lblLocationScavenger3
            // 
            this.lblLocationScavenger3.AutoSize = true;
            this.lblLocationScavenger3.Location = new System.Drawing.Point(6, 39);
            this.lblLocationScavenger3.Name = "lblLocationScavenger3";
            this.lblLocationScavenger3.Size = new System.Drawing.Size(50, 15);
            this.lblLocationScavenger3.TabIndex = 4;
            this.lblLocationScavenger3.Text = "location";
            // 
            // prgrsScavenger3
            // 
            this.prgrsScavenger3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrsScavenger3.Location = new System.Drawing.Point(6, 159);
            this.prgrsScavenger3.Name = "prgrsScavenger3";
            this.prgrsScavenger3.Size = new System.Drawing.Size(163, 10);
            this.prgrsScavenger3.TabIndex = 3;
            // 
            // lblCreditsScavenger3
            // 
            this.lblCreditsScavenger3.AutoSize = true;
            this.lblCreditsScavenger3.Location = new System.Drawing.Point(6, 19);
            this.lblCreditsScavenger3.Name = "lblCreditsScavenger3";
            this.lblCreditsScavenger3.Size = new System.Drawing.Size(25, 15);
            this.lblCreditsScavenger3.TabIndex = 2;
            this.lblCreditsScavenger3.Text = "C/s";
            // 
            // grpScavenger2
            // 
            this.grpScavenger2.Controls.Add(this.lblManualScavenger2);
            this.grpScavenger2.Controls.Add(this.lblCoordinatesScavenger2);
            this.grpScavenger2.Controls.Add(this.lblLocationScavenger2);
            this.grpScavenger2.Controls.Add(this.prgrsScavenger2);
            this.grpScavenger2.Controls.Add(this.lblCreditsScavenger2);
            this.grpScavenger2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger2.ForeColor = System.Drawing.Color.White;
            this.grpScavenger2.Location = new System.Drawing.Point(204, 22);
            this.grpScavenger2.Name = "grpScavenger2";
            this.grpScavenger2.Size = new System.Drawing.Size(175, 175);
            this.grpScavenger2.TabIndex = 11;
            this.grpScavenger2.TabStop = false;
            this.grpScavenger2.Text = "name";
            // 
            // lblManualScavenger2
            // 
            this.lblManualScavenger2.AutoSize = true;
            this.lblManualScavenger2.Location = new System.Drawing.Point(6, 79);
            this.lblManualScavenger2.Name = "lblManualScavenger2";
            this.lblManualScavenger2.Size = new System.Drawing.Size(47, 15);
            this.lblManualScavenger2.TabIndex = 5;
            this.lblManualScavenger2.Text = "manual";
            // 
            // lblCoordinatesScavenger2
            // 
            this.lblCoordinatesScavenger2.AutoSize = true;
            this.lblCoordinatesScavenger2.Location = new System.Drawing.Point(6, 59);
            this.lblCoordinatesScavenger2.Name = "lblCoordinatesScavenger2";
            this.lblCoordinatesScavenger2.Size = new System.Drawing.Size(69, 15);
            this.lblCoordinatesScavenger2.TabIndex = 4;
            this.lblCoordinatesScavenger2.Text = "coordinates";
            // 
            // lblLocationScavenger2
            // 
            this.lblLocationScavenger2.AutoSize = true;
            this.lblLocationScavenger2.Location = new System.Drawing.Point(6, 39);
            this.lblLocationScavenger2.Name = "lblLocationScavenger2";
            this.lblLocationScavenger2.Size = new System.Drawing.Size(50, 15);
            this.lblLocationScavenger2.TabIndex = 3;
            this.lblLocationScavenger2.Text = "location";
            // 
            // prgrsScavenger2
            // 
            this.prgrsScavenger2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrsScavenger2.Location = new System.Drawing.Point(6, 159);
            this.prgrsScavenger2.Name = "prgrsScavenger2";
            this.prgrsScavenger2.Size = new System.Drawing.Size(163, 10);
            this.prgrsScavenger2.TabIndex = 2;
            // 
            // lblCreditsScavenger2
            // 
            this.lblCreditsScavenger2.AutoSize = true;
            this.lblCreditsScavenger2.Location = new System.Drawing.Point(6, 19);
            this.lblCreditsScavenger2.Name = "lblCreditsScavenger2";
            this.lblCreditsScavenger2.Size = new System.Drawing.Size(25, 15);
            this.lblCreditsScavenger2.TabIndex = 1;
            this.lblCreditsScavenger2.Text = "C/s";
            // 
            // grpScavenger1
            // 
            this.grpScavenger1.Controls.Add(this.lblManualScavenger1);
            this.grpScavenger1.Controls.Add(this.lblCoordinatesScavenger1);
            this.grpScavenger1.Controls.Add(this.lblLocationScavenger1);
            this.grpScavenger1.Controls.Add(this.prgrsScavenger1);
            this.grpScavenger1.Controls.Add(this.lblCreditsScavenger1);
            this.grpScavenger1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpScavenger1.ForeColor = System.Drawing.Color.White;
            this.grpScavenger1.Location = new System.Drawing.Point(6, 22);
            this.grpScavenger1.Name = "grpScavenger1";
            this.grpScavenger1.Size = new System.Drawing.Size(175, 175);
            this.grpScavenger1.TabIndex = 10;
            this.grpScavenger1.TabStop = false;
            this.grpScavenger1.Text = "name";
            // 
            // lblManualScavenger1
            // 
            this.lblManualScavenger1.AutoSize = true;
            this.lblManualScavenger1.Location = new System.Drawing.Point(6, 79);
            this.lblManualScavenger1.Name = "lblManualScavenger1";
            this.lblManualScavenger1.Size = new System.Drawing.Size(47, 15);
            this.lblManualScavenger1.TabIndex = 4;
            this.lblManualScavenger1.Text = "manual";
            // 
            // lblCoordinatesScavenger1
            // 
            this.lblCoordinatesScavenger1.AutoSize = true;
            this.lblCoordinatesScavenger1.Location = new System.Drawing.Point(6, 59);
            this.lblCoordinatesScavenger1.Name = "lblCoordinatesScavenger1";
            this.lblCoordinatesScavenger1.Size = new System.Drawing.Size(69, 15);
            this.lblCoordinatesScavenger1.TabIndex = 3;
            this.lblCoordinatesScavenger1.Text = "coordinates";
            // 
            // lblLocationScavenger1
            // 
            this.lblLocationScavenger1.AutoSize = true;
            this.lblLocationScavenger1.Location = new System.Drawing.Point(6, 39);
            this.lblLocationScavenger1.Name = "lblLocationScavenger1";
            this.lblLocationScavenger1.Size = new System.Drawing.Size(50, 15);
            this.lblLocationScavenger1.TabIndex = 2;
            this.lblLocationScavenger1.Text = "location";
            // 
            // prgrsScavenger1
            // 
            this.prgrsScavenger1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrsScavenger1.Location = new System.Drawing.Point(6, 159);
            this.prgrsScavenger1.Name = "prgrsScavenger1";
            this.prgrsScavenger1.Size = new System.Drawing.Size(163, 10);
            this.prgrsScavenger1.TabIndex = 1;
            // 
            // lblCreditsScavenger1
            // 
            this.lblCreditsScavenger1.AutoSize = true;
            this.lblCreditsScavenger1.Location = new System.Drawing.Point(6, 19);
            this.lblCreditsScavenger1.Name = "lblCreditsScavenger1";
            this.lblCreditsScavenger1.Size = new System.Drawing.Size(25, 15);
            this.lblCreditsScavenger1.TabIndex = 0;
            this.lblCreditsScavenger1.Text = "C/s";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCredits.ForeColor = System.Drawing.Color.White;
            this.lblCredits.Location = new System.Drawing.Point(12, 9);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(177, 35);
            this.lblCredits.TabIndex = 10;
            this.lblCredits.Text = "Credits: ";
            // 
            // txtOtherCurrencies
            // 
            this.txtOtherCurrencies.BackColor = System.Drawing.Color.Black;
            this.txtOtherCurrencies.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOtherCurrencies.ForeColor = System.Drawing.Color.White;
            this.txtOtherCurrencies.Location = new System.Drawing.Point(12, 47);
            this.txtOtherCurrencies.Multiline = true;
            this.txtOtherCurrencies.Name = "txtOtherCurrencies";
            this.txtOtherCurrencies.ReadOnly = true;
            this.txtOtherCurrencies.Size = new System.Drawing.Size(322, 406);
            this.txtOtherCurrencies.TabIndex = 11;
            // 
            // dpadScavengerMovement
            // 
            this.dpadScavengerMovement.BackColor = System.Drawing.Color.Black;
            this.dpadScavengerMovement.ForeColor = System.Drawing.Color.White;
            this.dpadScavengerMovement.Location = new System.Drawing.Point(859, 38);
            this.dpadScavengerMovement.Name = "dpadScavengerMovement";
            this.dpadScavengerMovement.Size = new System.Drawing.Size(122, 122);
            this.dpadScavengerMovement.TabIndex = 12;
            // 
            // btnNextScavenger
            // 
            this.btnNextScavenger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextScavenger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNextScavenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextScavenger.ForeColor = System.Drawing.Color.White;
            this.btnNextScavenger.Location = new System.Drawing.Point(959, 166);
            this.btnNextScavenger.Name = "btnNextScavenger";
            this.btnNextScavenger.Size = new System.Drawing.Size(22, 23);
            this.btnNextScavenger.TabIndex = 14;
            this.btnNextScavenger.Text = ">";
            this.btnNextScavenger.UseVisualStyleBackColor = true;
            this.btnNextScavenger.Click += new System.EventHandler(this.btnNextScavenger_Click);
            // 
            // btnPrevScavenger
            // 
            this.btnPrevScavenger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevScavenger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrevScavenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevScavenger.ForeColor = System.Drawing.Color.White;
            this.btnPrevScavenger.Location = new System.Drawing.Point(859, 166);
            this.btnPrevScavenger.Name = "btnPrevScavenger";
            this.btnPrevScavenger.Size = new System.Drawing.Size(22, 23);
            this.btnPrevScavenger.TabIndex = 13;
            this.btnPrevScavenger.Text = "<";
            this.btnPrevScavenger.UseVisualStyleBackColor = true;
            this.btnPrevScavenger.Click += new System.EventHandler(this.btnPrevScavenger_Click);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.btnNextScavenger);
            this.Controls.Add(this.btnPrevScavenger);
            this.Controls.Add(this.dpadScavengerMovement);
            this.Controls.Add(this.txtOtherCurrencies);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.grpScavengers);
            this.Controls.Add(this.lblScavengerDisplayPageNumber);
            this.Controls.Add(this.btnScavengerDisplayNextPage);
            this.Controls.Add(this.btnScavengerDisplayPrevPage);
            this.Controls.Add(this.lblLogPageNumber);
            this.Controls.Add(this.btnLogNextPage);
            this.Controls.Add(this.btnLogPrevPage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGameLog);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
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
    private Button btnLogPrevPage;
    private Button btnLogNextPage;
    private Label lblLogPageNumber;
    private Label lblScavengerDisplayPageNumber;
    private Button btnScavengerDisplayNextPage;
    private Button btnScavengerDisplayPrevPage;
    private GroupBox grpScavengers;
    private GroupBox grpScavenger1;
    private GroupBox grpScavenger2;
    private GroupBox grpScavenger6;
    private GroupBox grpScavenger5;
    private GroupBox grpScavenger4;
    private GroupBox grpScavenger3;
    private Label lblCreditsScavenger6;
    private Label lblCreditsScavenger5;
    private Label lblCreditsScavenger4;
    private Label lblCreditsScavenger3;
    private Label lblCreditsScavenger2;
    private Label lblCreditsScavenger1;
    private Label lblCredits;
    private TextBox txtOtherCurrencies;
    private ProgressBar prgrsScavenger6;
    private ProgressBar prgrsScavenger5;
    private ProgressBar prgrsScavenger4;
    private ProgressBar prgrsScavenger3;
    private ProgressBar prgrsScavenger2;
    private ProgressBar prgrsScavenger1;
    private Label lblCoordinatesScavenger6;
    private Label lblLocationScavenger6;
    private Label lblCoordinatesScavenger5;
    private Label lblLocationScavenger5;
    private Label lblCoordinatesScavenger4;
    private Label lblLocationScavenger4;
    private Label lblCoordinatesScavenger3;
    private Label lblLocationScavenger3;
    private Label lblCoordinatesScavenger2;
    private Label lblLocationScavenger2;
    private Label lblCoordinatesScavenger1;
    private Label lblLocationScavenger1;
    private Label lblManualScavenger6;
    private Label lblManualScavenger5;
    private Label lblManualScavenger4;
    private Label lblManualScavenger3;
    private Label lblManualScavenger2;
    private Label lblManualScavenger1;
    private Controls.Dpad dpadScavengerMovement;
    private Button btnNextScavenger;
    private Button btnPrevScavenger;
}
