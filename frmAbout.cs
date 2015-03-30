﻿using System;
using System.Windows.Forms;

namespace Capture
{
    public partial class frmAbout : Form
    {
        private const string MAIL = "Asaf.Amnony@gmail.com";
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
            else
            {
                System.Diagnostics.Process.Start("mailto:" + MAIL + "?subject=Capture");
            }
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
            lblEmail.Text = MAIL;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(MAIL);
        }
    }
}