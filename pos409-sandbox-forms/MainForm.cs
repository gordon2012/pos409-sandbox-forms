﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos409_sandbox_forms
{
    public partial class MainForm : Form
    {
        private void OpenModal(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        public MainForm()
        {
            InitializeComponent();
            OpenModal(new OverdraftForm());
        }

        private void btnOverdraft_Click(object sender, EventArgs e)
        {
            OpenModal(new OverdraftForm());
        }
    }
}