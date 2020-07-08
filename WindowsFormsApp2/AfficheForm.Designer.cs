namespace WindowsFormsApp2
{
    partial class AfficheForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameCat = new System.Windows.Forms.Label();
            this.labelPic = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCatg = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAdvert = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvert)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(14, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Advert Name :";
            // 
            // labelNameCat
            // 
            this.labelNameCat.AutoSize = true;
            this.labelNameCat.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameCat.Location = new System.Drawing.Point(5, 136);
            this.labelNameCat.Name = "labelNameCat";
            this.labelNameCat.Size = new System.Drawing.Size(142, 22);
            this.labelNameCat.TabIndex = 1;
            this.labelNameCat.Text = "Name Catgeory:";
            // 
            // labelPic
            // 
            this.labelPic.AutoSize = true;
            this.labelPic.Location = new System.Drawing.Point(439, 35);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(40, 13);
            this.labelPic.TabIndex = 2;
            this.labelPic.Text = "Picture";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(138, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCatg
            // 
            this.textBoxCatg.Location = new System.Drawing.Point(148, 139);
            this.textBoxCatg.Name = "textBoxCatg";
            this.textBoxCatg.Size = new System.Drawing.Size(206, 20);
            this.textBoxCatg.TabIndex = 4;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Accept"});
            this.comboBoxStatus.Location = new System.Drawing.Point(91, 229);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(263, 21);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelStatus.Location = new System.Drawing.Point(4, 223);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(76, 26);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "Status:";
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAccept.Location = new System.Drawing.Point(103, 390);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(120, 38);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonRefuse.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefuse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefuse.Location = new System.Drawing.Point(466, 390);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(118, 38);
            this.buttonRefuse.TabIndex = 9;
            this.buttonRefuse.Text = "Refuse";
            this.buttonRefuse.UseVisualStyleBackColor = false;
            this.buttonRefuse.Click += new System.EventHandler(this.buttonRefuse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.comboBoxStatus);
            this.panel1.Controls.Add(this.LabelStatus);
            this.panel1.Controls.Add(this.textBoxCatg);
            this.panel1.Controls.Add(this.labelNameCat);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 335);
            this.panel1.TabIndex = 10;
            // 
            // pictureBoxAdvert
            // 
            this.pictureBoxAdvert.Location = new System.Drawing.Point(431, 51);
            this.pictureBoxAdvert.Name = "pictureBoxAdvert";
            this.pictureBoxAdvert.Size = new System.Drawing.Size(357, 322);
            this.pictureBoxAdvert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdvert.TabIndex = 5;
            this.pictureBoxAdvert.TabStop = false;
            // 
            // AfficheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefuse);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.pictureBoxAdvert);
            this.Controls.Add(this.labelPic);
            this.Name = "AfficheForm";
            this.Text = "AfficheForm";
            this.Load += new System.EventHandler(this.AfficheForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdvert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameCat;
        private System.Windows.Forms.Label labelPic;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonRefuse;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxCatg;
        public System.Windows.Forms.PictureBox pictureBoxAdvert;
        public System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Panel panel1;
    }
}