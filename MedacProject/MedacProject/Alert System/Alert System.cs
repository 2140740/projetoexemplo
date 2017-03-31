﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alert_System
{
    public partial class AlertSytem : Form
    {
        public AlertSytem()
        {
            InitializeComponent();
        }

        private void viewMeasurement_Click(object sender, EventArgs e)
        {
            View_Measurement FormViewMeasurement = new View_Measurement();
            DialogResult = FormViewMeasurement.ShowDialog();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Pacient FormRegistPacient = new Register_Pacient();
            DialogResult = FormRegistPacient.ShowDialog();
        }

        private void updatePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdate FormUpdatePacient = new FormUpdate();
            DialogResult = FormUpdatePacient.ShowDialog();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Equals("Register Patient"))
            {
                Register_Pacient FormRegistPacient = new Register_Pacient();
                DialogResult = FormRegistPacient.ShowDialog();
            }
            if (e.Node.Text.Equals("Update Patient"))
            {
                FormUpdate FormUpdatePacient = new FormUpdate();
                DialogResult = FormUpdatePacient.ShowDialog();
            }

            if (e.Node.Text.Equals("View Measurement"))
            {
                View_Measurement FormViewMeasurement = new View_Measurement();
                DialogResult = FormViewMeasurement.ShowDialog();
            }

        }
    }
}