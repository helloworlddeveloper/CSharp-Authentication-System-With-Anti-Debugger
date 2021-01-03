using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLEye_v1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Alert(string msg, frmAlert.alertTypeEnum type)
        {
            frmAlert f = new frmAlert();
            f.setAlert(msg, type);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            gunaTransition2.Show(pnlRegister);
            pnlRegister.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (API.Register(Rusername.Text, RPassword.Text, REmail.Text, License.Text))
            {
                MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoginnow_Click(object sender, EventArgs e)
        {
            pnlRegister.Hide();
            gunaTransition2.Show(pnlLogin);
            pnlLogin.BringToFront();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (API.Login(username.Text, password.Text))
            {
                this.Alert("Success message", frmAlert.alertTypeEnum.Success);

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Remember.Checked == true)
                {
                    Properties.Settings.Default.dusername = username.Text;
                    Properties.Settings.Default.dpassword = password.Text;
                    Properties.Settings.Default.Save();


                }
                this.Hide();

                Main f = new Main();
                f.Show();
            }
        }

        public void Login_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.dusername = "";
            Properties.Settings.Default.dpassword = "";

            //if (Properties.Settings.Default.dusername != "")
            //{
            //    if (API.Login(Properties.Settings.Default.dusername, Properties.Settings.Default.dpassword))
            //    {
            //        //MessageBox.Show("Qetu kena mrri");
            //        Main main = new Main();
            //        main.ShowDialog();
            //    }


            //}

            //else
            //{

            //    Properties.Settings.Default.dusername = "";
            //    Properties.Settings.Default.dpassword = "";
            //    Login l = new Login();
            //    l.Show();

            //}

        }


        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
