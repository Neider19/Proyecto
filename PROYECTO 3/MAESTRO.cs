﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_3
{
    public partial class MAESTRO : Form
    {
        public MAESTRO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MANTENIMIENTO mANTENIMIENTO = new MANTENIMIENTO();
            mANTENIMIENTO.Show();
            this.Hide();
        }
    }
}
