using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtAnswer.Enabled = false;

        }

        private bool checkRong()
        {
            if (txtNum1.Text == "")
            {
                txtNum1.Focus();
                MessageBox.Show("Vui Lòng Nhập Number1", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNum2.Text == "")
            {
                txtNum2.Focus();
                MessageBox.Show("Vui Lòng Nhập Number2", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checkPare()
        {
            float num1, num2;
            bool result1 = float.TryParse(txtNum1.Text, out num1);
            if (!result1)
            {
                MessageBox.Show("Bạn đã nhập Number1 sai kiểu dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            bool result2 = float.TryParse(txtNum2.Text, out num2);
            if (!result2)
            {
                MessageBox.Show("Bạn đã nhập Number2 sai kiểu dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                txtAnswer.Text = (num1 - num2).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                txtAnswer.Text = (num1 * num2).ToString();
            }
        }

        private void btnChia_Click_1(object sender, EventArgs e)
        {
            if (checkRong() && checkPare())
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Vui lòng nhập số bị chia khác 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtAnswer.Text = (num1 / num2).ToString();
                }

            }
        }
    }
}
