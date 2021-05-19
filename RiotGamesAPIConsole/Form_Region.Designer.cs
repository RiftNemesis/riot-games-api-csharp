namespace RiotGamesAPIConsole
{
    partial class Form_Region
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Region));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_region = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Region";
            // 
            // comboBox_region
            // 
            this.comboBox_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_region.FormattingEnabled = true;
            this.comboBox_region.Location = new System.Drawing.Point(17, 49);
            this.comboBox_region.Name = "comboBox_region";
            this.comboBox_region.Size = new System.Drawing.Size(323, 32);
            this.comboBox_region.TabIndex = 1;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(265, 87);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 32);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 132);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_region);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Form_Region";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_region;
        private System.Windows.Forms.Button button_OK;
    }
}