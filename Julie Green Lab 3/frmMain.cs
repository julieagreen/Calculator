using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Project: Calculator
    Programmer: Julie Green
    Date: Apr 16, 2016
    Purpose: Performs simple calculations and math operations with two number inputs.
*/

namespace Julie_Green_Lab_3
{
    public partial class frmMain : Form
    {
        private const string c_sCOPYRIGHT = "Copyright 2016 by Julie Green";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                dFirstNumber = double.Parse(txtFirstNumber.Text);
                dSecondNumber = double.Parse(txtSecondNumber.Text);
                dResult = dFirstNumber + dSecondNumber;

                txtResult.Text = dResult.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                dFirstNumber = double.Parse(txtFirstNumber.Text);
                dSecondNumber = double.Parse(txtSecondNumber.Text);
                dResult = dFirstNumber - dSecondNumber;

                txtResult.Text = dResult.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                dFirstNumber = double.Parse(txtFirstNumber.Text);
                dSecondNumber = double.Parse(txtSecondNumber.Text);
                dResult = dFirstNumber * dSecondNumber;

                txtResult.Text = dResult.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                dFirstNumber = double.Parse(txtFirstNumber.Text);
                dSecondNumber = double.Parse(txtSecondNumber.Text);
                dResult = dFirstNumber / dSecondNumber;

                txtResult.Text = dResult.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                dFirstNumber = double.Parse(txtFirstNumber.Text);
                dSecondNumber = double.Parse(txtSecondNumber.Text);
                dResult = Math.Max(dFirstNumber, dSecondNumber);

                txtResult.Text = dResult.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                double dFirstNumber;
                double dSecondNumber;
                double dResult;

                dFirstNumber = double.Parse(txtFirstNumber.Text);
                dSecondNumber = double.Parse(txtSecondNumber.Text);
                dResult = Math.Min(dFirstNumber, dSecondNumber);

                txtResult.Text = dResult.ToString("n1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblCopyright.Text = c_sCOPYRIGHT;
        }
    }
}
