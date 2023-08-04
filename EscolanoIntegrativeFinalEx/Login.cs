using EscolanoIntegrativeFinalEx.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolanoIntegrativeFinalEx
{
    public partial class Login : Form
    {


       // [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
       // private static extern IntPtr CreateRoundRectRgn
       //(
       //    int nLeftRect,
       //    int nTopRect,
       //    int nRightRect,
       //    int nBottomRect,
       //    int nWidthEllipse,
       //    int nHeightEllipse
       //);




        public Login()
        {


            //InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            InitializeComponent();
        }


        private Point _mouseLoc;
        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync($"http://119.93.156.215:9000/api/useraccount/UserLogin?user={txtusername.Text}&password={txtpassword.Text}");
            var accountlist = JsonConvert.DeserializeObject<List<UserAccounts>>(json);

            if (accountlist[0].token != "NONE")
            {
                AppSetting.Default.TOKEN = accountlist[0].token;
                AppSetting.Default.Save();
                AppSetting.Default.Reload();
                MessageBox.Show("Successfully Login", $"Welcome {accountlist[0].accounttype.ToString()}");
                

            }
            else
            {
                MessageBox.Show("ERROR! Wrong Username or Password");
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnlogin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
           // _mouseLoc = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    int dx = e.Location.X - _mouseLoc.X;
            //    int dy = e.Location.Y - _mouseLoc.Y;
            //    this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            //}
        }
    }
}
