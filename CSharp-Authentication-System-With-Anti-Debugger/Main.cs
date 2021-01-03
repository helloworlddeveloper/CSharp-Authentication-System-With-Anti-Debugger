using System;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace SQLEye_v1
{
    public partial class Main : Form
    {
        public Main()
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }
        private Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper vScrollHelper;
        void Alert(string msg, frmAlert.alertTypeEnum type)
        {
            frmAlert f = new frmAlert();
            f.setAlert(msg, type);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(exploiterTable, gunaVScrollBar1, true);
            Random r = new Random();
            for (int i = 0; i <= 40; i++)
            {
                exploiterTable.Rows.Add(new object[] { i, r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000), r.Next(200000, 500000) });
            }
            vScrollHelper.UpdateScrollBar();
            exploiterTable.Rows.Add(
             new object[]
             {
                 "text",
                 500,
                 "test"

             }
             );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
      new object[]
      {
                 "text",
                 500,
                 "test"

      }
      );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
      new object[]
      {
                 "text",
                 500,
                 "test"

      }
      );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );
            exploiterTable.Rows.Add(
           new object[]
           {
                 "text",
                 500,
                 "test"

           }
           );

            this.Alert("Welcome to SQLEye " + User.Username, frmAlert.alertTypeEnum.Info);

        }

        private void TopPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Dashboard;

        }

        private void NewsTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = News;

        }

        private void DumperTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Dumper;

        }

        private void ScannerTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Scanner;

        }

        private void MainTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Exploiter;


        }

        private void AdminFinderTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AdminFinder;

        }

        private void DehasherTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Dehasher;

        }

        private void DorkGenTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = DorkGen;


        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Settings;

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }

        //private void GunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{

        //}

        //private void TopPanel1_Paint_1(object sender, PaintEventArgs e)
        //{

        //}

        //private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        //{
        //    SettingsControl.SelectedTab = Profile;

        //}

        //private void gunaAdvenceButton12_Click(object sender, EventArgs e)
        //{
        //    SettingsControl.SelectedTab = DumperSettings;

        //}

        //private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        //{
        //    SettingsControl.SelectedTab = ScanerSettings;

        //}

        //private void gunaAdvenceButton14_Click(object sender, EventArgs e)
        //{
        //    SettingsControl.SelectedTab = ExploiterSettings;

        //}

        //private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        //{
        //    SettingsControl.SelectedTab = AdminFinderSettings;

        //}

        //private void MainLoadCombosBtn_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog _openFiledlg = new OpenFileDialog();
        //    bool flag = _openFiledlg.ShowDialog() == DialogResult.OK;
        //    if (flag)
        //    {
        //        this._base = new Queue<string>(File.ReadAllLines(_openFiledlg.FileName));
        //        this.label8.Text = Convert.ToString(this._base.Count);
        //        //this.TextBox2.Text = Convert.ToString(this._base.Items);
        //    }
        //}

        //private void MainStartBtn_Click(object sender, EventArgs e)
        //{
        //    Main._threadlist = new List<Thread>();
        //    int i = 0;
        //    while (i < this.numericUpDown1.Value)
        //    {
        //        Thread.Sleep(Convert.ToInt32(this.numericUpDown1.Value));
        //        Thread _thread = new Thread(new ThreadStart(this.potok));
        //        _thread.IsBackground = true;
        //        Main._threadlist.Add(_thread);
        //        Main._threadlist[i].Start();
        //        i++;
        //    }
        //}

        //private void MainStopBtn_Click(object sender, EventArgs e)
        //{
        //    foreach (Thread t in Main._threadlist)
        //    {
        //        t.Abort();
        //    }
        //    for (int i = 0; i < Main._threadlist.Count; i++)
        //    {
        //        Main._threadlist.RemoveAt(i);
        //    }
        //    Main._threadlist.Clear();
        //    MessageBox.Show("Sucessfuly stopped");
        //}
        //private void potok()
        //{
        //    for (; ; )
        //    {
        //        string url = "";
        //        using (HttpRequest Request = new HttpRequest())
        //        {
        //            Request.UserAgent = "Mozilla/5.0 (Windows NT 6.0; rv:22.0) Gecko/20130405 Firefox/22.0";
        //            try
        //            {
        //                try
        //                {
        //                    url = this._base.Dequeue();
        //                }
        //                catch
        //                {
        //                    break;
        //                }
        //                string end_slesh = url.Substring(url.Length - 1, 1);
        //                bool flag = end_slesh == "/";
        //                if (flag)
        //                {
        //                    url = url.Substring(0, url.Length - 1);
        //                }
        //                bool flag2 = end_slesh == "&";
        //                if (flag2)
        //                {
        //                    url = url.Substring(0, url.Length - 1);
        //                }
        //                List<string> urlcontainer = new List<string>();
        //                bool flag3 = url.Contains("&");
        //                if (flag3)
        //                {
        //                    string[] param = url.Split(new char[]
        //                    {
        //                        '&'
        //                    });
        //                    for (int i = 0; i < param.Length; i++)
        //                    {
        //                        string req = "";
        //                        param[i] += "'";
        //                        foreach (string item2 in param)
        //                        {
        //                            req = req + item2 + "&";
        //                        }
        //                        urlcontainer.Add(req);
        //                        param[i] = param[i].Replace("'", "");
        //                    }
        //                    using (List<string>.Enumerator enumerator = urlcontainer.GetEnumerator())
        //                    {
        //                        while (enumerator.MoveNext())
        //                        {
        //                            string item = enumerator.Current;
        //                            string request = Request.Get(item, null).ToString();
        //                            bool flag4 = request.Contains("mysql") || request.Contains("Mysql") || request.Contains("MySQL") || request.Contains("sql syntax") || request.Contains("SQL syntax") || request.Contains("mssql") || request.Contains("Mssql") || request.Contains("MSSQL");
        //                            if (flag4)
        //                            {
        //                                object locker = Main.Locker;
        //                                lock (locker)
        //                                {
        //                                    File.AppendAllText("Exploitable.txt", item.Replace("'", "") + "\n");
        //                                }
        //                                Control control = this.label2;
        //                                int num = this.expl;
        //                                this.expl = num + 1;
        //                                control.Text = num.ToString();
        //                                string rank = Request.Get("http://data.alexa.com/data?cli=10&dat=snbamz&url=" + item, null).ToString();
        //                                bool flag6 = rank.Contains("REACH RANK");
        //                                if (flag6)
        //                                {
        //                                    base.Invoke(new Action(delegate ()
        //                                    {
        //                                        this.exploiterTableContainer.Rows.Add(new object[]
        //                                        {
        //                                            item,
        //                                            Convert.ToInt32(rank.Substrings("REACH RANK=\"", "\"/>", 0, StringComparison.Ordinal)[0])
        //                                        });
        //                                    }));
        //                                }
        //                                else
        //                                {
        //                                    Action method;

        //                                }
        //                                this.label8.Text = this._base.Count.ToString();
        //                            }
        //                            else
        //                            {
        //                                object locker2 = Main.Locker;
        //                                lock (locker2)
        //                                {
        //                                    File.AppendAllText("Bad.txt", item.Replace("'", "") + "\n");
        //                                }
        //                                Control control2 = this.label4;
        //                                int num = this.bad;
        //                                this.bad = num + 1;
        //                                control2.Text = num.ToString();
        //                                this.label8.Text = this._base.Count.ToString();
        //                            }
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    string request2 = Request.Get(url + "'", null).ToString();
        //                    bool flag8 = request2.Contains("mysql") || request2.Contains("Mysql") || request2.Contains("MySQL") || request2.Contains("sql syntax") || request2.Contains("SQL syntax") || request2.Contains("mssql") || request2.Contains("Mssql") || request2.Contains("MSSQL");
        //                    if (flag8)
        //                    {
        //                        object locker3 = Main.Locker;
        //                        lock (locker3)
        //                        {
        //                            File.AppendAllText("Exploitable.txt", url + "\n");
        //                        }
        //                        Control control3 = this.label2;
        //                        int num = this.expl;
        //                        this.expl = num + 1;
        //                        control3.Text = num.ToString();
        //                        string rank = Request.Get("http://data.alexa.com/data?cli=10&dat=snbamz&url=" + url, null).ToString();
        //                        bool flag10 = rank.Contains("REACH RANK");
        //                        if (flag10)
        //                        {
        //                            base.Invoke(new Action(delegate ()
        //                            {
        //                                this.exploiterTableContainer.Rows.Add(new object[]
        //                                {
        //                                    url,
        //                                    Convert.ToInt32(rank.Substrings("REACH RANK=\"", "\"/>", 0, StringComparison.Ordinal)[0])
        //                                });
        //                            }));
        //                        }
        //                        else
        //                        {
        //                            base.Invoke(new Action(delegate ()
        //                            {
        //                                this.exploiterTableContainer.Rows.Add(new object[]
        //                                {
        //                                    url,
        //                                    0
        //                                });
        //                            }));
        //                        }
        //                        this.label8.Text = this._base.Count.ToString();
        //                    }
        //                    else
        //                    {
        //                        object locker4 = Main.Locker;
        //                        lock (locker4)
        //                        {
        //                            File.AppendAllText("Bad.txt", url + "\n");
        //                        }
        //                        Control control4 = this.label4;
        //                        int num = this.bad;
        //                        this.bad = num + 1;
        //                        control4.Text = num.ToString();
        //                        this.label8.Text = this._base.Count.ToString();
        //                    }
        //                }
        //            }
        //            catch
        //            {
        //            }
        //        }

        //    }
        //}
        //private int bad = 0;
        //private int expl = 0;
        //public Queue<string> _base;
        //private static object Locker = new object();
        //public static List<Thread> _threadlist;

        private void ExploiterTab_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = Exploiter;
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            SettingsControl.SelectedTab = ScannerTab;
        }

        private void SettingsControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
