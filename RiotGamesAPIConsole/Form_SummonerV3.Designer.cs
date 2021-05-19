namespace RiotGamesAPIConsole
{
    partial class Form_SummonerV3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label accountIdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label profileIconIdLabel;
            System.Windows.Forms.Label revisionDateLabel;
            System.Windows.Forms.Label summonerLevelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SummonerV3));
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.textBox_region = new System.Windows.Forms.TextBox();
            this.linkLabel_refresh = new System.Windows.Forms.LinkLabel();
            this.accountIdTextBox = new System.Windows.Forms.TextBox();
            this.summonerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.profileIconIdTextBox = new System.Windows.Forms.TextBox();
            this.revisionDateTextBox = new System.Windows.Forms.TextBox();
            this.summonerLevelTextBox = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_summonerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            accountIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            profileIconIdLabel = new System.Windows.Forms.Label();
            revisionDateLabel = new System.Windows.Forms.Label();
            summonerLevelLabel = new System.Windows.Forms.Label();
            this.groupBox_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summonerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Location = new System.Drawing.Point(16, 132);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new System.Drawing.Size(164, 24);
            accountIdLabel.TabIndex = 3;
            accountIdLabel.Text = "Account Id:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 169);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(52, 24);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(16, 206);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(80, 24);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // profileIconIdLabel
            // 
            profileIconIdLabel.AutoSize = true;
            profileIconIdLabel.Location = new System.Drawing.Point(16, 243);
            profileIconIdLabel.Name = "profileIconIdLabel";
            profileIconIdLabel.Size = new System.Drawing.Size(234, 24);
            profileIconIdLabel.TabIndex = 9;
            profileIconIdLabel.Text = "Profile Icon Id:";
            // 
            // revisionDateLabel
            // 
            revisionDateLabel.AutoSize = true;
            revisionDateLabel.Location = new System.Drawing.Point(16, 280);
            revisionDateLabel.Name = "revisionDateLabel";
            revisionDateLabel.Size = new System.Drawing.Size(206, 24);
            revisionDateLabel.TabIndex = 11;
            revisionDateLabel.Text = "Revision Date:";
            // 
            // summonerLevelLabel
            // 
            summonerLevelLabel.AutoSize = true;
            summonerLevelLabel.Location = new System.Drawing.Point(16, 317);
            summonerLevelLabel.Name = "summonerLevelLabel";
            summonerLevelLabel.Size = new System.Drawing.Size(220, 24);
            summonerLevelLabel.TabIndex = 13;
            summonerLevelLabel.Text = "Summoner Level:";
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.textBox_region);
            this.groupBox_main.Controls.Add(this.linkLabel_refresh);
            this.groupBox_main.Controls.Add(accountIdLabel);
            this.groupBox_main.Controls.Add(this.accountIdTextBox);
            this.groupBox_main.Controls.Add(idLabel);
            this.groupBox_main.Controls.Add(this.idTextBox);
            this.groupBox_main.Controls.Add(nameLabel);
            this.groupBox_main.Controls.Add(this.nameTextBox);
            this.groupBox_main.Controls.Add(profileIconIdLabel);
            this.groupBox_main.Controls.Add(this.profileIconIdTextBox);
            this.groupBox_main.Controls.Add(revisionDateLabel);
            this.groupBox_main.Controls.Add(this.revisionDateTextBox);
            this.groupBox_main.Controls.Add(summonerLevelLabel);
            this.groupBox_main.Controls.Add(this.summonerLevelTextBox);
            this.groupBox_main.Controls.Add(this.button_OK);
            this.groupBox_main.Controls.Add(this.textBox_summonerName);
            this.groupBox_main.Controls.Add(this.label1);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(488, 407);
            this.groupBox_main.TabIndex = 3;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "SUMMONER-V3";
            // 
            // textBox_region
            // 
            this.textBox_region.Location = new System.Drawing.Point(281, 69);
            this.textBox_region.Name = "textBox_region";
            this.textBox_region.ReadOnly = true;
            this.textBox_region.Size = new System.Drawing.Size(71, 31);
            this.textBox_region.TabIndex = 16;
            // 
            // linkLabel_refresh
            // 
            this.linkLabel_refresh.AutoSize = true;
            this.linkLabel_refresh.Location = new System.Drawing.Point(16, 361);
            this.linkLabel_refresh.Name = "linkLabel_refresh";
            this.linkLabel_refresh.Size = new System.Drawing.Size(360, 24);
            this.linkLabel_refresh.TabIndex = 15;
            this.linkLabel_refresh.TabStop = true;
            this.linkLabel_refresh.Text = "Refresh this cache result";
            this.linkLabel_refresh.Visible = false;
            this.linkLabel_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refresh_LinkClicked);
            // 
            // accountIdTextBox
            // 
            this.accountIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summonerDTOBindingSource, "AccountId", true));
            this.accountIdTextBox.Location = new System.Drawing.Point(256, 129);
            this.accountIdTextBox.Name = "accountIdTextBox";
            this.accountIdTextBox.ReadOnly = true;
            this.accountIdTextBox.Size = new System.Drawing.Size(206, 31);
            this.accountIdTextBox.TabIndex = 4;
            // 
            // summonerDTOBindingSource
            // 
            this.summonerDTOBindingSource.DataSource = typeof(RiotGamesAPI.DTO.SummonerDTO);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summonerDTOBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(256, 166);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(206, 31);
            this.idTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summonerDTOBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(256, 203);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(206, 31);
            this.nameTextBox.TabIndex = 8;
            // 
            // profileIconIdTextBox
            // 
            this.profileIconIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summonerDTOBindingSource, "ProfileIconId", true));
            this.profileIconIdTextBox.Location = new System.Drawing.Point(256, 240);
            this.profileIconIdTextBox.Name = "profileIconIdTextBox";
            this.profileIconIdTextBox.ReadOnly = true;
            this.profileIconIdTextBox.Size = new System.Drawing.Size(206, 31);
            this.profileIconIdTextBox.TabIndex = 10;
            // 
            // revisionDateTextBox
            // 
            this.revisionDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summonerDTOBindingSource, "RevisionDate", true));
            this.revisionDateTextBox.Location = new System.Drawing.Point(256, 277);
            this.revisionDateTextBox.Name = "revisionDateTextBox";
            this.revisionDateTextBox.ReadOnly = true;
            this.revisionDateTextBox.Size = new System.Drawing.Size(206, 31);
            this.revisionDateTextBox.TabIndex = 12;
            // 
            // summonerLevelTextBox
            // 
            this.summonerLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summonerDTOBindingSource, "SummonerLevel", true));
            this.summonerLevelTextBox.Location = new System.Drawing.Point(256, 314);
            this.summonerLevelTextBox.Name = "summonerLevelTextBox";
            this.summonerLevelTextBox.ReadOnly = true;
            this.summonerLevelTextBox.Size = new System.Drawing.Size(206, 31);
            this.summonerLevelTextBox.TabIndex = 14;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(358, 69);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(109, 31);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_summonerName
            // 
            this.textBox_summonerName.Location = new System.Drawing.Point(16, 69);
            this.textBox_summonerName.Name = "textBox_summonerName";
            this.textBox_summonerName.Size = new System.Drawing.Size(262, 31);
            this.textBox_summonerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Summoner Name";
            // 
            // Form_SummonerV3
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 407);
            this.Controls.Add(this.groupBox_main);
            this.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form_SummonerV3";
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summonerDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_summonerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.BindingSource summonerDTOBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox profileIconIdTextBox;
        private System.Windows.Forms.TextBox revisionDateTextBox;
        private System.Windows.Forms.TextBox summonerLevelTextBox;
        private System.Windows.Forms.LinkLabel linkLabel_refresh;
        private System.Windows.Forms.TextBox textBox_region;



    }
}