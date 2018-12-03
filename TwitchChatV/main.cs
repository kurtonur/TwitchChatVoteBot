using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using MaterialSkin.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TwitchChatV
{
    public partial class main : MaterialForm
    {   
        IJavaScriptExecutor js;
        ChromeDriver browser;
        public static  Dictionary<string, int> keylist = new Dictionary<string, int>();
        public static int ToplamVote=0;
        public static List<string> paternlist = new List<string>();
        List<string> voters;
        showVote showit;
        bool finis = false;
        
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
            voters = new List<string>();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArguments("--lang=tr");
            browser = new ChromeDriver(service, options);
            js = (IJavaScriptExecutor)browser;
        }


        public bool connectChat(string s)
        {
            if (s.Trim() != ""){
                browser.Navigate().GoToUrl("https://www.twitch.tv/popout/" + s + "/chat");
                return true;
            }
            else
            {
                uyarilar("Nickname Boş", 0);
                return false;
            }     
        }

        private void start_Click(object sender, EventArgs e)
        {
            finis = false;
            if (paterns.Items.Count != 0)
            {
                if (connectChat(link.Text))
                {
                    showit = new showVote();
                    foreach (string item in paterns.Items)
                    {
                        keylist.Add(item, 0);
                        paternlist.Add(item);
                    }
                    Thread thread1 = new Thread(new ThreadStart(FunctionTH));
                    thread1.Start();
                    votetime.Start();
                    uyarilar("Başladı", 2);
                    toggle(1);
                    showit.Show();
                    
                }
            }
            else
                uyarilar("Kelime Listesi Boş",0);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            browser.Quit();
            base.OnClosing(e);
        }

        public void uyarilar(string s,int type)
        {
            if(type == 2)
            {
                alert.ForeColor = Color.Green;
            }
            else if(type==1){
                alert.ForeColor = Color.Yellow;
            }
            else
            {
                alert.ForeColor = Color.Red;
            }
            alert.Text = s;
        }

        private void addpatern_Click(object sender, EventArgs e)
        {
            if (patern.Text.Trim().ToLower() != "" && !paterns.Items.Contains(patern.Text.Trim().ToLower()))
            {
                paterns.Items.Add(patern.Text.Trim().ToLower());
                patern.Text = "";
            }
        }

        private void removepatern_Click(object sender, EventArgs e)
        {
            int index = paterns.SelectedIndex;
            if (index != -1 && paterns.Items.Count != 0)
            {
                paterns.Items.RemoveAt(index);
            }
        }
        

        private void votetime_Tick(object sender, EventArgs e)
        {
            toplamoy.Text = "Toplam : " + ToplamVote.ToString();
            showit.change(ToplamVote);
        }

        void FunctionTH()
        {
            while (true)
            {
                if (finis) break; 
                try
                {
                    IWebElement text = browser.FindElementByXPath("//*[@id=\"root\"]/div/div[1]/div/div/section/div/div[2]/div[2]/div[3]/div/div/div[@class=\"chat-line__message\"][last()]");
                    string[] temp = text.Text.Split(':');
                    if (!voters.Contains(temp[0].Trim()))
                    {
                        if (temp[1].Trim().Length < 20)
                            if (keylist.ContainsKey(temp[1].Trim().ToLower()))
                            {
                                keylist[temp[1].Trim()] += 1;
                                voters.Add(temp[0].Trim());
                                ToplamVote++;
                            }
                    }
                    //js.ExecuteScript("return document.getElementsByClassName(\"chat-line__message\")[0].remove()");
                }
                catch
                {


                }
            }
        }
        
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            finis = true;
            votetime.Stop();
            uyarilar("Bitti", 2);
            keylist.Clear();
            voters.Clear();
            showit.Close();
            toggle(0);
            ToplamVote = 0;
            paternlist.Clear();
            toplamoy.Text = "0";
            
        }

        public void toggle(int istart)
        {
            if (istart == 1)
            {
                start.Enabled = false;
                materialFlatButton3.Enabled = true;
                addpatern.Enabled = false;
                removepatern.Enabled = false;
            }
            else
            {
                start.Enabled = true;
                materialFlatButton3.Enabled = false;
                addpatern.Enabled = true;
                removepatern.Enabled = true;
            }
        }

        private void patern_TextChanged(object sender, EventArgs e)
        {
            if (patern.TextLength > 20)
            {
                patern.Text = patern.Text.Substring(0, 20);
            }
        }

        private void patern_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                addpatern_Click(sender, e);
            }
        }

        private void paterns_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == 8)
            {
                removepatern_Click(sender, e);
            }
        }
    }
}
