using EscolanoIntegrativeFinalEx.Class;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace EscolanoIntegrativeFinalEx
{
    public partial class Form1 : Form
    {
      //  [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
      //  private static extern IntPtr CreateRoundRectRgn
      //(
      //    int nLeftRect,
      //    int nTopRect,
      //    int nRightRect,
      //    int nBottomRect,
      //    int nWidthEllipse,
      //    int nHeightEllipse
      //);



        private readonly Form _f = Application.OpenForms["MainForm"];

        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;

            }
        
    }
        public Form1()
        {

            //InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeComponent();
        }
       
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
                this.Hide();
                var form = new MainForm();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sorry! Wrong Username or Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Point _mouseLoc;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
  
}