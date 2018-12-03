namespace TwitchChatV
{
    partial class main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.link = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.start = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.paterns = new System.Windows.Forms.ListBox();
            this.alert = new MaterialSkin.Controls.MaterialLabel();
            this.addpatern = new MaterialSkin.Controls.MaterialFlatButton();
            this.removepatern = new MaterialSkin.Controls.MaterialFlatButton();
            this.patern = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.votetime = new System.Windows.Forms.Timer(this.components);
            this.toplamoy = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(0, 0);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(0, 0);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // link
            // 
            this.link.Depth = 0;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.Hint = "ChannelName";
            this.link.Location = new System.Drawing.Point(16, 85);
            this.link.MouseState = MaterialSkin.MouseState.HOVER;
            this.link.Name = "link";
            this.link.PasswordChar = '\0';
            this.link.SelectedText = "";
            this.link.SelectionLength = 0;
            this.link.SelectionStart = 0;
            this.link.Size = new System.Drawing.Size(418, 23);
            this.link.TabIndex = 1;
            this.link.UseSystemPasswordChar = false;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.start.Depth = 0;
            this.start.Location = new System.Drawing.Point(379, 117);
            this.start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.start.MouseState = MaterialSkin.MouseState.HOVER;
            this.start.Name = "start";
            this.start.Primary = false;
            this.start.Size = new System.Drawing.Size(55, 36);
            this.start.TabIndex = 2;
            this.start.Text = "Başla";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 121);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(212, 250);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // paterns
            // 
            this.paterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paterns.FormattingEnabled = true;
            this.paterns.ItemHeight = 20;
            this.paterns.Location = new System.Drawing.Point(12, 163);
            this.paterns.Name = "paterns";
            this.paterns.Size = new System.Drawing.Size(212, 124);
            this.paterns.TabIndex = 5;
            this.paterns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.paterns_KeyDown);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Depth = 0;
            this.alert.Font = new System.Drawing.Font("Roboto", 11F);
            this.alert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alert.Location = new System.Drawing.Point(243, 125);
            this.alert.MouseState = MaterialSkin.MouseState.HOVER;
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 19);
            this.alert.TabIndex = 6;
            // 
            // addpatern
            // 
            this.addpatern.AutoSize = true;
            this.addpatern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addpatern.Depth = 0;
            this.addpatern.Location = new System.Drawing.Point(171, 325);
            this.addpatern.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addpatern.MouseState = MaterialSkin.MouseState.HOVER;
            this.addpatern.Name = "addpatern";
            this.addpatern.Primary = false;
            this.addpatern.Size = new System.Drawing.Size(44, 36);
            this.addpatern.TabIndex = 7;
            this.addpatern.Text = "Ekle";
            this.addpatern.UseVisualStyleBackColor = true;
            this.addpatern.Click += new System.EventHandler(this.addpatern_Click);
            // 
            // removepatern
            // 
            this.removepatern.AutoSize = true;
            this.removepatern.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removepatern.Depth = 0;
            this.removepatern.Location = new System.Drawing.Point(16, 325);
            this.removepatern.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removepatern.MouseState = MaterialSkin.MouseState.HOVER;
            this.removepatern.Name = "removepatern";
            this.removepatern.Primary = false;
            this.removepatern.Size = new System.Drawing.Size(32, 36);
            this.removepatern.TabIndex = 8;
            this.removepatern.Text = "Sil";
            this.removepatern.UseVisualStyleBackColor = true;
            this.removepatern.Click += new System.EventHandler(this.removepatern_Click);
            // 
            // patern
            // 
            this.patern.Depth = 0;
            this.patern.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patern.Hint = "Kelime(Key)";
            this.patern.Location = new System.Drawing.Point(16, 293);
            this.patern.MouseState = MaterialSkin.MouseState.HOVER;
            this.patern.Name = "patern";
            this.patern.PasswordChar = '\0';
            this.patern.SelectedText = "";
            this.patern.SelectionLength = 0;
            this.patern.SelectionStart = 0;
            this.patern.Size = new System.Drawing.Size(199, 23);
            this.patern.TabIndex = 9;
            this.patern.UseSystemPasswordChar = false;
            this.patern.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patern_KeyDown);
            this.patern.TextChanged += new System.EventHandler(this.patern_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(51, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(132, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Chat\'e Yazılıcaklar";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Location = new System.Drawing.Point(369, 163);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton3.TabIndex = 11;
            this.materialFlatButton3.Text = "Durdur";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // votetime
            // 
            this.votetime.Tick += new System.EventHandler(this.votetime_Tick);
            // 
            // toplamoy
            // 
            this.toplamoy.AutoSize = true;
            this.toplamoy.Depth = 0;
            this.toplamoy.Font = new System.Drawing.Font("Roboto", 11F);
            this.toplamoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toplamoy.Location = new System.Drawing.Point(243, 171);
            this.toplamoy.MouseState = MaterialSkin.MouseState.HOVER;
            this.toplamoy.Name = "toplamoy";
            this.toplamoy.Size = new System.Drawing.Size(0, 19);
            this.toplamoy.TabIndex = 12;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 394);
            this.Controls.Add(this.toplamoy);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.patern);
            this.Controls.Add(this.removepatern);
            this.Controls.Add(this.addpatern);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.paterns);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.link);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(446, 394);
            this.MinimumSize = new System.Drawing.Size(446, 394);
            this.Name = "main";
            this.Text = "Twitch Chat Vote";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField link;
        private MaterialSkin.Controls.MaterialFlatButton start;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ListBox paterns;
        private MaterialSkin.Controls.MaterialLabel alert;
        private MaterialSkin.Controls.MaterialFlatButton addpatern;
        private MaterialSkin.Controls.MaterialFlatButton removepatern;
        private MaterialSkin.Controls.MaterialSingleLineTextField patern;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Timer votetime;
        private MaterialSkin.Controls.MaterialLabel toplamoy;
    }
}

