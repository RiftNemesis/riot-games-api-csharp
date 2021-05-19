namespace RiotGamesAPIConsole
{
    partial class Form_ChampionV3
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
            System.Windows.Forms.Label maxNewPlayerLevelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChampionV3));
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.button_GET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
            this.maxNewPlayerLevelTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.championInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            maxNewPlayerLevelLabel = new System.Windows.Forms.Label();
            this.groupBox_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.championInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.dataGridView2);
            this.groupBox_main.Controls.Add(this.dataGridView1);
            this.groupBox_main.Controls.Add(maxNewPlayerLevelLabel);
            this.groupBox_main.Controls.Add(this.maxNewPlayerLevelTextBox);
            this.groupBox_main.Controls.Add(this.button_GET);
            this.groupBox_main.Controls.Add(this.label1);
            this.groupBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(526, 413);
            this.groupBox_main.TabIndex = 3;
            this.groupBox_main.TabStop = false;
            this.groupBox_main.Text = "CHAMPION-V3";
            // 
            // button_GET
            // 
            this.button_GET.Location = new System.Drawing.Point(15, 80);
            this.button_GET.Name = "button_GET";
            this.button_GET.Size = new System.Drawing.Size(148, 31);
            this.button_GET.TabIndex = 2;
            this.button_GET.Text = "GET";
            this.button_GET.UseVisualStyleBackColor = true;
            this.button_GET.Click += new System.EventHandler(this.button_GET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Champion Rotations";
            // 
            // ItemTemplate
            // 
            this.ItemTemplate.Size = new System.Drawing.Size(504, 118);
            // 
            // maxNewPlayerLevelLabel
            // 
            maxNewPlayerLevelLabel.AutoSize = true;
            maxNewPlayerLevelLabel.Location = new System.Drawing.Point(13, 132);
            maxNewPlayerLevelLabel.Name = "maxNewPlayerLevelLabel";
            maxNewPlayerLevelLabel.Size = new System.Drawing.Size(304, 24);
            maxNewPlayerLevelLabel.TabIndex = 2;
            maxNewPlayerLevelLabel.Text = "Max New Player Level:";
            // 
            // maxNewPlayerLevelTextBox
            // 
            this.maxNewPlayerLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.championInfoBindingSource, "MaxNewPlayerLevel", true));
            this.maxNewPlayerLevelTextBox.Location = new System.Drawing.Point(323, 129);
            this.maxNewPlayerLevelTextBox.Name = "maxNewPlayerLevelTextBox";
            this.maxNewPlayerLevelTextBox.ReadOnly = true;
            this.maxNewPlayerLevelTextBox.Size = new System.Drawing.Size(176, 31);
            this.maxNewPlayerLevelTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(267, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 210);
            this.dataGridView2.TabIndex = 5;
            // 
            // championInfoBindingSource
            // 
            this.championInfoBindingSource.DataSource = typeof(RiotGamesAPI.DTO.ChampionInfo);
            // 
            // Form_ChampionV3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 413);
            this.Controls.Add(this.groupBox_main);
            this.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form_ChampionV3";
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.championInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Button button_GET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxNewPlayerLevelTextBox;
        private System.Windows.Forms.BindingSource championInfoBindingSource;
        private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;



    }
}