namespace Biometric_System
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.SidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.buttonAdminOverlay = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonReportOverlay = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonStaffOverlay = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonOverlayStudent = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome,";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(126, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(638, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 15;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(601, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 15;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePanel.BackgroundImage")));
            this.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.labelTime);
            this.SidePanel.Controls.Add(this.labelDate);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Controls.Add(this.PanelLeft);
            this.SidePanel.Controls.Add(this.buttonAdminOverlay);
            this.SidePanel.Controls.Add(this.buttonAdmin);
            this.SidePanel.Controls.Add(this.buttonReportOverlay);
            this.SidePanel.Controls.Add(this.buttonReport);
            this.SidePanel.Controls.Add(this.buttonStaffOverlay);
            this.SidePanel.Controls.Add(this.buttonStaff);
            this.SidePanel.Controls.Add(this.buttonOverlayStudent);
            this.SidePanel.Controls.Add(this.buttonStudent);
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(32)))), ((int)(((byte)(75)))));
            this.SidePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(220)))), ((int)(((byte)(224)))));
            this.SidePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.SidePanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Quality = 10;
            this.SidePanel.Size = new System.Drawing.Size(200, 536);
            this.SidePanel.TabIndex = 6;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.Crimson;
            this.PanelLeft.Location = new System.Drawing.Point(0, 74);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(4, 92);
            this.PanelLeft.TabIndex = 8;
            // 
            // buttonAdminOverlay
            // 
            this.buttonAdminOverlay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdminOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminOverlay.FlatAppearance.BorderSize = 0;
            this.buttonAdminOverlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonAdminOverlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdminOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminOverlay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminOverlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdminOverlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminOverlay.Image")));
            this.buttonAdminOverlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdminOverlay.Location = new System.Drawing.Point(0, 395);
            this.buttonAdminOverlay.Name = "buttonAdminOverlay";
            this.buttonAdminOverlay.Size = new System.Drawing.Size(200, 92);
            this.buttonAdminOverlay.TabIndex = 4;
            this.buttonAdminOverlay.Text = "Admin Panel";
            this.buttonAdminOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdminOverlay.UseVisualStyleBackColor = false;
            this.buttonAdminOverlay.Visible = false;
            this.buttonAdminOverlay.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdmin.Location = new System.Drawing.Point(0, 395);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(200, 92);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = "Admin Panel";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonReportOverlay
            // 
            this.buttonReportOverlay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReportOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReportOverlay.FlatAppearance.BorderSize = 0;
            this.buttonReportOverlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonReportOverlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReportOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportOverlay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportOverlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReportOverlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonReportOverlay.Image")));
            this.buttonReportOverlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonReportOverlay.Location = new System.Drawing.Point(0, 288);
            this.buttonReportOverlay.Name = "buttonReportOverlay";
            this.buttonReportOverlay.Size = new System.Drawing.Size(200, 92);
            this.buttonReportOverlay.TabIndex = 4;
            this.buttonReportOverlay.Text = "Report Panel";
            this.buttonReportOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReportOverlay.UseVisualStyleBackColor = false;
            this.buttonReportOverlay.Visible = false;
            this.buttonReportOverlay.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.Transparent;
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonReport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonReport.Image")));
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonReport.Location = new System.Drawing.Point(0, 288);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(200, 92);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report Panel";
            this.buttonReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonStaffOverlay
            // 
            this.buttonStaffOverlay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStaffOverlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStaffOverlay.FlatAppearance.BorderSize = 0;
            this.buttonStaffOverlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonStaffOverlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStaffOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaffOverlay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaffOverlay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStaffOverlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonStaffOverlay.Image")));
            this.buttonStaffOverlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStaffOverlay.Location = new System.Drawing.Point(0, 181);
            this.buttonStaffOverlay.Name = "buttonStaffOverlay";
            this.buttonStaffOverlay.Size = new System.Drawing.Size(200, 92);
            this.buttonStaffOverlay.TabIndex = 4;
            this.buttonStaffOverlay.Text = "Staff Enrollment";
            this.buttonStaffOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStaffOverlay.UseVisualStyleBackColor = false;
            this.buttonStaffOverlay.Visible = false;
            this.buttonStaffOverlay.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.Transparent;
            this.buttonStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStaff.FlatAppearance.BorderSize = 0;
            this.buttonStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonStaff.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStaff.Image = ((System.Drawing.Image)(resources.GetObject("buttonStaff.Image")));
            this.buttonStaff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStaff.Location = new System.Drawing.Point(0, 181);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(200, 92);
            this.buttonStaff.TabIndex = 4;
            this.buttonStaff.Text = "Staff Enrollment";
            this.buttonStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonOverlayStudent
            // 
            this.buttonOverlayStudent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOverlayStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOverlayStudent.FlatAppearance.BorderSize = 0;
            this.buttonOverlayStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonOverlayStudent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOverlayStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOverlayStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOverlayStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOverlayStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonOverlayStudent.Image")));
            this.buttonOverlayStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOverlayStudent.Location = new System.Drawing.Point(0, 74);
            this.buttonOverlayStudent.Name = "buttonOverlayStudent";
            this.buttonOverlayStudent.Size = new System.Drawing.Size(200, 92);
            this.buttonOverlayStudent.TabIndex = 4;
            this.buttonOverlayStudent.Text = "Student Enrollment";
            this.buttonOverlayStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOverlayStudent.UseVisualStyleBackColor = false;
            this.buttonOverlayStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.Transparent;
            this.buttonStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(97)))), ((int)(((byte)(226)))));
            this.buttonStudent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudent.Image")));
            this.buttonStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStudent.Location = new System.Drawing.Point(0, 74);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(200, 92);
            this.buttonStudent.TabIndex = 4;
            this.buttonStudent.Text = "Student Enrollment";
            this.buttonStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 33);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDate.Location = new System.Drawing.Point(57, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTime.Location = new System.Drawing.Point(57, 38);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(32, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unimaid Biometric System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuGradientPanel SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button buttonOverlayStudent;
        private System.Windows.Forms.Button buttonStaffOverlay;
        private System.Windows.Forms.Button buttonReportOverlay;
        private System.Windows.Forms.Button buttonAdminOverlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer Timer;
    }
}