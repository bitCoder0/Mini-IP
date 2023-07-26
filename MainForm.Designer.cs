namespace MiniIP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnCheckIP = new Button();
            txtIP = new Label();
            btnCopyIP = new Button();
            btnCopyJson = new Button();
            btnOpenURL = new Button();
            btnAppInfo = new Button();
            lblIP = new Label();
            lblCountry = new Label();
            txtCountry = new Label();
            lblCity = new Label();
            txtCity = new Label();
            lblISP = new Label();
            txtISP = new Label();
            SuspendLayout();
            // 
            // btnCheckIP
            // 
            btnCheckIP.BackColor = Color.Transparent;
            btnCheckIP.BackgroundImage = Properties.Resources.FlatButton;
            btnCheckIP.BackgroundImageLayout = ImageLayout.Stretch;
            btnCheckIP.FlatAppearance.BorderColor = Color.Black;
            btnCheckIP.FlatAppearance.BorderSize = 0;
            btnCheckIP.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCheckIP.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCheckIP.FlatStyle = FlatStyle.Flat;
            btnCheckIP.Font = new Font("Vazir Code Hack", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckIP.ForeColor = Color.Transparent;
            btnCheckIP.Location = new Point(12, 281);
            btnCheckIP.Name = "btnCheckIP";
            btnCheckIP.Size = new Size(360, 68);
            btnCheckIP.TabIndex = 0;
            btnCheckIP.Text = "Check IP";
            btnCheckIP.UseVisualStyleBackColor = false;
            btnCheckIP.Click += btnCheckIP_Click;
            // 
            // txtIP
            // 
            txtIP.AccessibleRole = AccessibleRole.IpAddress;
            txtIP.Anchor = AnchorStyles.Top;
            txtIP.AutoEllipsis = true;
            txtIP.BackColor = Color.Transparent;
            txtIP.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtIP.ForeColor = Color.MediumSpringGreen;
            txtIP.Location = new Point(153, 40);
            txtIP.MinimumSize = new Size(10, 0);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(191, 21);
            txtIP.TabIndex = 1;
            txtIP.Text = "0.0.0.0";
            txtIP.TextAlign = ContentAlignment.MiddleCenter;
            txtIP.UseCompatibleTextRendering = true;
            // 
            // btnCopyIP
            // 
            btnCopyIP.BackColor = Color.Transparent;
            btnCopyIP.BackgroundImage = Properties.Resources.miniGrayButton;
            btnCopyIP.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyIP.FlatAppearance.BorderSize = 0;
            btnCopyIP.FlatStyle = FlatStyle.Flat;
            btnCopyIP.Font = new Font("Vazir Code Hack", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyIP.ForeColor = SystemColors.ButtonFace;
            btnCopyIP.Location = new Point(13, 252);
            btnCopyIP.Name = "btnCopyIP";
            btnCopyIP.Size = new Size(75, 23);
            btnCopyIP.TabIndex = 2;
            btnCopyIP.Text = "Copy IP";
            btnCopyIP.UseVisualStyleBackColor = false;
            btnCopyIP.Click += button1_Click;
            // 
            // btnCopyJson
            // 
            btnCopyJson.AutoSize = true;
            btnCopyJson.BackColor = Color.Transparent;
            btnCopyJson.BackgroundImage = Properties.Resources.miniGrayButton;
            btnCopyJson.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopyJson.FlatAppearance.BorderSize = 0;
            btnCopyJson.FlatStyle = FlatStyle.Flat;
            btnCopyJson.Font = new Font("Vazir Code Hack", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyJson.ForeColor = SystemColors.ButtonFace;
            btnCopyJson.Location = new Point(91, 252);
            btnCopyJson.Name = "btnCopyJson";
            btnCopyJson.Size = new Size(87, 24);
            btnCopyJson.TabIndex = 3;
            btnCopyJson.Text = "Copy JSON";
            btnCopyJson.UseVisualStyleBackColor = false;
            btnCopyJson.Click += btnCopyJson_Click;
            // 
            // btnOpenURL
            // 
            btnOpenURL.BackColor = Color.Transparent;
            btnOpenURL.BackgroundImage = Properties.Resources.miniGrayButton;
            btnOpenURL.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpenURL.FlatAppearance.BorderSize = 0;
            btnOpenURL.FlatStyle = FlatStyle.Flat;
            btnOpenURL.Font = new Font("Vazir Code Hack", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenURL.ForeColor = SystemColors.ButtonFace;
            btnOpenURL.Location = new Point(182, 252);
            btnOpenURL.Name = "btnOpenURL";
            btnOpenURL.Size = new Size(75, 23);
            btnOpenURL.TabIndex = 4;
            btnOpenURL.Text = "Open URL";
            btnOpenURL.UseVisualStyleBackColor = false;
            btnOpenURL.Click += btnOpenURL_Click;
            // 
            // btnAppInfo
            // 
            btnAppInfo.BackColor = Color.Transparent;
            btnAppInfo.BackgroundImage = Properties.Resources.miniGrayButton;
            btnAppInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnAppInfo.FlatAppearance.BorderColor = Color.White;
            btnAppInfo.FlatAppearance.BorderSize = 0;
            btnAppInfo.FlatStyle = FlatStyle.Flat;
            btnAppInfo.Font = new Font("Vazir Code Hack", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppInfo.ForeColor = SystemColors.ButtonFace;
            btnAppInfo.Location = new Point(261, 252);
            btnAppInfo.Margin = new Padding(0);
            btnAppInfo.Name = "btnAppInfo";
            btnAppInfo.Size = new Size(110, 23);
            btnAppInfo.TabIndex = 5;
            btnAppInfo.Text = "App Info";
            btnAppInfo.UseVisualStyleBackColor = false;
            btnAppInfo.Click += btnAppInfo_click;
            // 
            // lblIP
            // 
            lblIP.AccessibleRole = AccessibleRole.TitleBar;
            lblIP.Anchor = AnchorStyles.Top;
            lblIP.AutoEllipsis = true;
            lblIP.AutoSize = true;
            lblIP.BackColor = Color.Transparent;
            lblIP.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIP.ForeColor = SystemColors.MenuHighlight;
            lblIP.Location = new Point(31, 39);
            lblIP.MinimumSize = new Size(10, 0);
            lblIP.Name = "lblIP";
            lblIP.Size = new Size(118, 21);
            lblIP.TabIndex = 6;
            lblIP.Text = "IP Address:";
            lblIP.TextAlign = ContentAlignment.MiddleLeft;
            lblIP.UseCompatibleTextRendering = true;
            // 
            // lblCountry
            // 
            lblCountry.AccessibleRole = AccessibleRole.TitleBar;
            lblCountry.Anchor = AnchorStyles.Top;
            lblCountry.AutoEllipsis = true;
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.ForeColor = SystemColors.MenuHighlight;
            lblCountry.Location = new Point(31, 89);
            lblCountry.MinimumSize = new Size(10, 0);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(88, 21);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country:";
            lblCountry.TextAlign = ContentAlignment.MiddleLeft;
            lblCountry.UseCompatibleTextRendering = true;
            // 
            // txtCountry
            // 
            txtCountry.AccessibleRole = AccessibleRole.IpAddress;
            txtCountry.Anchor = AnchorStyles.Top;
            txtCountry.AutoEllipsis = true;
            txtCountry.BackColor = Color.Transparent;
            txtCountry.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCountry.ForeColor = Color.MediumSpringGreen;
            txtCountry.Location = new Point(127, 91);
            txtCountry.MinimumSize = new Size(80, 0);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(242, 21);
            txtCountry.TabIndex = 7;
            txtCountry.Text = "-";
            txtCountry.TextAlign = ContentAlignment.MiddleCenter;
            txtCountry.UseCompatibleTextRendering = true;
            // 
            // lblCity
            // 
            lblCity.AccessibleRole = AccessibleRole.TitleBar;
            lblCity.Anchor = AnchorStyles.Top;
            lblCity.AutoEllipsis = true;
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.ForeColor = SystemColors.MenuHighlight;
            lblCity.Location = new Point(31, 140);
            lblCity.MinimumSize = new Size(10, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(57, 21);
            lblCity.TabIndex = 10;
            lblCity.Text = "City:";
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            lblCity.UseCompatibleTextRendering = true;
            // 
            // txtCity
            // 
            txtCity.AccessibleRole = AccessibleRole.IpAddress;
            txtCity.Anchor = AnchorStyles.Top;
            txtCity.AutoEllipsis = true;
            txtCity.BackColor = Color.Transparent;
            txtCity.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCity.ForeColor = Color.MediumSpringGreen;
            txtCity.Location = new Point(127, 142);
            txtCity.MinimumSize = new Size(80, 0);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 21);
            txtCity.TabIndex = 9;
            txtCity.Text = "-";
            txtCity.TextAlign = ContentAlignment.MiddleCenter;
            txtCity.UseCompatibleTextRendering = true;
            // 
            // lblISP
            // 
            lblISP.AccessibleRole = AccessibleRole.TitleBar;
            lblISP.Anchor = AnchorStyles.Top;
            lblISP.AutoEllipsis = true;
            lblISP.AutoSize = true;
            lblISP.BackColor = Color.Transparent;
            lblISP.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblISP.ForeColor = SystemColors.MenuHighlight;
            lblISP.Location = new Point(31, 191);
            lblISP.MinimumSize = new Size(10, 0);
            lblISP.Name = "lblISP";
            lblISP.Size = new Size(47, 21);
            lblISP.TabIndex = 12;
            lblISP.Text = "ISP:";
            lblISP.TextAlign = ContentAlignment.MiddleLeft;
            lblISP.UseCompatibleTextRendering = true;
            // 
            // txtISP
            // 
            txtISP.AccessibleRole = AccessibleRole.IpAddress;
            txtISP.Anchor = AnchorStyles.Top;
            txtISP.AutoEllipsis = true;
            txtISP.BackColor = Color.Transparent;
            txtISP.Font = new Font("Vazir Code Hack", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtISP.ForeColor = Color.MediumSpringGreen;
            txtISP.Location = new Point(127, 172);
            txtISP.MinimumSize = new Size(150, 65);
            txtISP.Name = "txtISP";
            txtISP.Size = new Size(242, 65);
            txtISP.TabIndex = 13;
            txtISP.Text = "-";
            txtISP.TextAlign = ContentAlignment.MiddleCenter;
            txtISP.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(384, 361);
            Controls.Add(txtISP);
            Controls.Add(lblISP);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblCountry);
            Controls.Add(txtCountry);
            Controls.Add(lblIP);
            Controls.Add(btnAppInfo);
            Controls.Add(btnOpenURL);
            Controls.Add(btnCopyJson);
            Controls.Add(btnCopyIP);
            Controls.Add(txtIP);
            Controls.Add(btnCheckIP);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini IP - IP Checker Tool";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckIP;
        private Label txtIP;
        private Button btnCopyIP;
        private Button btnCopyJson;
        private Button btnOpenURL;
        private Button btnAppInfo;
        private Label lblIP;
        private Label lblCountry;
        private Label txtCountry;
        private Label lblCity;
        private Label txtCity;
        private Label lblISP;
        private Label txtISP;
    }
}