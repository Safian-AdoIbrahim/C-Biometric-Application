using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometric_System
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username)
        
        {
            InitializeComponent();
            Timer.Start();
            label1.Text = username;
            PanelLeft.Height = buttonStudent.Height;
            PanelLeft.Top = buttonStudent.Top;
            buttonOverlayStudent.Visible = true;
            buttonStaffOverlay.Visible = false;
            buttonReportOverlay.Visible = false;
            buttonAdminOverlay.Visible = false;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            PanelLeft.Height = buttonStudent.Height;
            PanelLeft.Top = buttonStudent.Top;
            buttonOverlayStudent.Visible = true;
            buttonStaffOverlay.Visible = false;
            buttonReportOverlay.Visible = false;
            buttonAdminOverlay.Visible = false;
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            PanelLeft.Height = buttonStaff.Height;
            PanelLeft.Top = buttonStaff.Top;
            buttonOverlayStudent.Visible = false;
            buttonStaffOverlay.Visible = true;
            buttonReportOverlay.Visible = false;
            buttonAdminOverlay.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            PanelLeft.Height = buttonReport.Height;
            PanelLeft.Top = buttonReport.Top;
            buttonOverlayStudent.Visible = false;
            buttonStaffOverlay.Visible = false;
            buttonReportOverlay.Visible = true;
            buttonAdminOverlay.Visible = false;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            PanelLeft.Height = buttonAdmin.Height;
            PanelLeft.Top = buttonAdmin.Top;
            buttonOverlayStudent.Visible = false;
            buttonStaffOverlay.Visible = false;
            buttonReportOverlay.Visible = false;
            buttonAdminOverlay.Visible = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime DateAndTime = DateTime.Now;
            labelDate.Text = DateAndTime.ToLongDateString();
            labelTime.Text = DateAndTime.ToLongTimeString();
        }
    }
}
