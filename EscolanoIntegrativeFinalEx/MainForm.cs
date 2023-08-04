using EscolanoIntegrativeFinalEx.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolanoIntegrativeFinalEx
{
    public partial class MainForm : Form
    {
        private readonly Form _f = Application.OpenForms["Edit"];

        private static MainForm _instance;
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainForm();
                return _instance;

            }
        }


        public MainForm()
        {
            InitializeComponent();
        }
        public void ctrlrefresh()
        {
            this.BeginInvoke(new Action(() => btnrefresh.PerformClick()));
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnrefresh.PerformClick();
            lblcount.Text = dataGridView1.Rows.Count.ToString();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AppSetting.Default.TOKEN);
            var response = await client.GetAsync($"http://119.93.156.215:9000/api/Students/get");
            if (response.IsSuccessStatusCode)
            {
                string contentresponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                dataGridView1.DataSource = JsonConvert.DeserializeObject<List<Students>>(contentresponse);
                lblcount.Text = dataGridView1.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show(response.StatusCode.ToString());
                lblcount.Text = dataGridView1.Rows.Count.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Add();
            form.ShowDialog();
            form._transaction = "Save";
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var form = new Edit();
            form.txtid.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtfname.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtmname.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtlname.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtext.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            form.dtpbdate.Value = Convert.ToDateTime(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            form.txtbirthplace.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            form.cbgender.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            //  form.cbnationality.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
            //  form.cbrelegion.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtaddress.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtcontact.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
            //form.txtlandline.Text = dataGridView1[12, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtemail.Text = dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString();
            // form.cbstatus.Text = dataGridView1[14, dataGridView1.CurrentRow.Index].Value.ToString();
        

            if (DialogResult.Yes == MessageBox.Show("Do you wish to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    int i = 0;
                    var student = new Students

                    {
                      
                       sid = form.txtid.Text,
                };



                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri($"http://119.93.156.215:9000/");
                        var json = JsonConvert.SerializeObject(student);
                        HttpContent content = new StringContent(json);
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AppSetting.Default.TOKEN);
                        HttpResponseMessage response = await client.PostAsync($"api/students/DeleteStudents", content).ConfigureAwait(false);

                        if (response.IsSuccessStatusCode)
                        {
                            string contentresponse = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            i = JsonConvert.DeserializeObject<int>(contentresponse);

                            if (i > 0)
                            {
                                MessageBox.Show("Successfully Deleted!");
                                ctrlrefresh();



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
                catch (Exception ex)
                {

                    //throw;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Edit();
            form.txtid.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtfname.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtmname.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtlname.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtext.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            form.dtpbdate.Value = Convert.ToDateTime(dataGridView1[5, dataGridView1.CurrentRow.Index].Value);
            form.txtbirthplace.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            form.cbgender.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
          //  form.cbnationality.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
          //  form.cbrelegion.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtaddress.Text = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtcontact.Text = dataGridView1[9, dataGridView1.CurrentRow.Index].Value.ToString();
          //form.txtlandline.Text = dataGridView1[12, dataGridView1.CurrentRow.Index].Value.ToString();
            form.txtemail.Text = dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString();
           // form.cbstatus.Text = dataGridView1[14, dataGridView1.CurrentRow.Index].Value.ToString();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppSetting.Default.TOKEN = "NONE";
            AppSetting.Default.Save();
            AppSetting.Default.Reload();
            dataGridView1.DataSource = null;
            this.Close();
            this.Hide();
            var form = new Form1();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Point _mouseLoc;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
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
