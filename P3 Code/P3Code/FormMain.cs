﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3Code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Hide();
            AppUser person = new AppUser();
            FormLogin login_form = new FormLogin();
            while(!person.IsAuthenticated && login_form.ShowDialog() == DialogResult.OK)
            {
                person.IsAuthenticated = login_form.Authenticated;
                if (!person.IsAuthenticated)
                {
                    login_form.ShowDialog();
                }
                
            }
            this.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
