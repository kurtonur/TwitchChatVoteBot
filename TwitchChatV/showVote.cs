using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchChatV
{
    public partial class showVote : Form
    {
        
        public showVote()
        {
            InitializeComponent();
        }

        private void showVote_Load(object sender, EventArgs e)
        {
            int index = main.keylist.Count;
            showOlustur(main.paternlist);
        }


        public void showOlustur(List<string> list)
        {
            this.Size = new Size(this.Size.Width, this.Size.Height+ 100* (list.Count-1));
            for (int i = 0; i < list.Count; i++)
            {

                Label tempLabel = new Label();
     
                ProgressBar tempBar = new ProgressBar();
                Label tempBarLabel = new Label();

                tempLabel.AutoSize = true;
                tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tempLabel.Location = new System.Drawing.Point(15, 14 + 100 * i);
                tempLabel.Name = "lbl_"+list[i];
                tempLabel.Size = new System.Drawing.Size(51, 20);
                tempLabel.TabIndex = 1;
                tempLabel.Text = list[i];
                

                tempBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
                tempBar.ForeColor = System.Drawing.Color.Blue;
                tempBar.Location = new System.Drawing.Point(12, 37 + 100 * i);
                tempBar.Name = "bar_"+ list[i];
                tempBar.Size = new System.Drawing.Size(399, 23);
                tempBar.TabIndex = 0;
                tempBar.Value = 11;
                

                tempBarLabel.AutoSize = true;
                tempBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tempBarLabel.Location = new System.Drawing.Point(205, 39 + 100 * i);
                tempBarLabel.Name = "barlbl_" + list[i];
                tempBarLabel.Size = new System.Drawing.Size(51, 20);
                tempBarLabel.TabIndex = 2;
                tempBarLabel.Text = "0";


                this.Controls.Add(tempLabel);
                this.Controls.Add(tempBarLabel);
                this.Controls.Add(tempBar);
            }
        }

        public void change(int max)
        {
            foreach (Control x in this.Controls)
            {
                if (x is ProgressBar)
                {
                    ((ProgressBar)x).Maximum = max;
                    ((ProgressBar)x).Value = main.keylist[((ProgressBar)x).Name.Split('_')[1]];
                }
                else
                {   
                    if(((Label)x).Name.Split('_')[0] == "barlbl")
                    {
                        ((Label)x).Text = main.keylist[((Label)x).Name.Split('_')[1]].ToString();
                    }
                    
                }
            }
            label1.Text = "Toplam Vote :" +main.ToplamVote.ToString();
        }
    }
}
