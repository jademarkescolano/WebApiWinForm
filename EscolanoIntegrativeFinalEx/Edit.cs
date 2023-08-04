using EscolanoIntegrativeFinalEx.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolanoIntegrativeFinalEx
{
   

    public partial class Edit : Form

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



        private readonly Form _f = Application.OpenForms["Mainform"];

        private static Edit _instance;
        public static Edit Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Edit();
                return _instance;

            }
        }
        public Edit()
        {
            //InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
          
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            var student = new Students
            {
                sid = txtid.Text,
                // dateentry = DateTime.Now,
                fname = txtfname.Text.Trim(),
                mname = txtmname.Text.Trim(),
                lname = txtlname.Text.Trim(),
                Ext = txtext.Text.Trim(),
                birthdate = dtpbdate.Value,
                birthplace = txtbirthplace.Text.Trim(),
                gender = cbgender.Text,
                //   nationality = cbnationality.Text.Trim(),
                //  religion = cbrelegion.Text.Trim(),
                address = txtaddress.Text.Trim(),
                cpno = txtcontact.Text.Trim(),
                //  landlineno = txtlandline.Text.Trim(),
                email = txtemail.Text.Trim(),
                //  status = cbstatus.Text.Trim()
            };



            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri($"http://119.93.156.215:9000/");
                var json = JsonConvert.SerializeObject(student);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AppSetting.Default.TOKEN);
                HttpResponseMessage response = await client.PostAsync($"api/students/UpdateStudents", content).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string contentresponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    i = JsonConvert.DeserializeObject<int>(contentresponse);

                    if (i > 0)
                    {
                        MessageBox.Show("Successfully Updated!");
                        ((MainForm)_f).ctrlrefresh();

                    }
                    else
                    {
                        MessageBox.Show("Invalid!");
                    }
                }
                else
                {
                    MessageBox.Show("Transaction Cancelled!");
                }
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Point _mouseLoc;
        private void Edit_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void Edit_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void Edit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
