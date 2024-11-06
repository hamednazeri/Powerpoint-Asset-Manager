namespace PowerpointAssetManager
{
    partial class PowerpointAssetManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerpointAssetManager));
            this.btnSelectPowerpoint = new System.Windows.Forms.Button();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnAddToPowerpointRtl = new System.Windows.Forms.Button();
            this.txtSlideNumber = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblShowDuration = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToPowerpointLtr = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDuration = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectPowerpoint
            // 
            this.btnSelectPowerpoint.Font = new System.Drawing.Font("Mikhak Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectPowerpoint.Location = new System.Drawing.Point(24, 36);
            this.btnSelectPowerpoint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectPowerpoint.Name = "btnSelectPowerpoint";
            this.btnSelectPowerpoint.Size = new System.Drawing.Size(193, 38);
            this.btnSelectPowerpoint.TabIndex = 1;
            this.btnSelectPowerpoint.Text = "انتخاب پاورپوینت";
            this.btnSelectPowerpoint.UseVisualStyleBackColor = true;
            this.btnSelectPowerpoint.Click += new System.EventHandler(this.btnSelectPowerpoint_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Font = new System.Drawing.Font("Mikhak Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddFiles.Location = new System.Drawing.Point(24, 141);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(193, 38);
            this.btnAddFiles.TabIndex = 3;
            this.btnAddFiles.Text = "انتخاب پوشه محتوا";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // btnAddToPowerpointRtl
            // 
            this.btnAddToPowerpointRtl.Font = new System.Drawing.Font("Mikhak Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddToPowerpointRtl.Location = new System.Drawing.Point(24, 399);
            this.btnAddToPowerpointRtl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddToPowerpointRtl.Name = "btnAddToPowerpointRtl";
            this.btnAddToPowerpointRtl.Size = new System.Drawing.Size(193, 38);
            this.btnAddToPowerpointRtl.TabIndex = 6;
            this.btnAddToPowerpointRtl.Text = "افزودن محتوا راست به چپ";
            this.btnAddToPowerpointRtl.UseVisualStyleBackColor = true;
            this.btnAddToPowerpointRtl.Click += new System.EventHandler(this.btnAddToPowerpoint_Click);
            // 
            // txtSlideNumber
            // 
            this.txtSlideNumber.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSlideNumber.Location = new System.Drawing.Point(24, 90);
            this.txtSlideNumber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSlideNumber.Name = "txtSlideNumber";
            this.txtSlideNumber.Size = new System.Drawing.Size(96, 35);
            this.txtSlideNumber.TabIndex = 2;
            // 
            // lstFiles
            // 
            this.lstFiles.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 28;
            this.lstFiles.Location = new System.Drawing.Point(24, 232);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstFiles.Size = new System.Drawing.Size(192, 144);
            this.lstFiles.TabIndex = 4;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblShowDuration
            // 
            this.lblShowDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowDuration.Font = new System.Drawing.Font("Mikhak Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowDuration.Location = new System.Drawing.Point(284, 0);
            this.lblShowDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowDuration.Name = "lblShowDuration";
            this.lblShowDuration.Size = new System.Drawing.Size(271, 81);
            this.lblShowDuration.TabIndex = 8;
            this.lblShowDuration.Text = "0";
            this.lblShowDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSlideNumber);
            this.groupBox1.Controls.Add(this.btnSelectPowerpoint);
            this.groupBox1.Controls.Add(this.btnAddFiles);
            this.groupBox1.Controls.Add(this.btnAddToPowerpointLtr);
            this.groupBox1.Controls.Add(this.btnAddToPowerpointRtl);
            this.groupBox1.Controls.Add(this.lstFiles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(567, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(287, 515);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(229, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "5-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(128, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "2- شماره اسلاید : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(55, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "4- انتخاب محتوای مورد نظر : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(228, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "3-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(234, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "1-";
            // 
            // btnAddToPowerpointLtr
            // 
            this.btnAddToPowerpointLtr.Font = new System.Drawing.Font("Mikhak Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddToPowerpointLtr.Location = new System.Drawing.Point(24, 453);
            this.btnAddToPowerpointLtr.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddToPowerpointLtr.Name = "btnAddToPowerpointLtr";
            this.btnAddToPowerpointLtr.Size = new System.Drawing.Size(193, 38);
            this.btnAddToPowerpointLtr.TabIndex = 6;
            this.btnAddToPowerpointLtr.Text = "افزودن محتوا چپ به راست";
            this.btnAddToPowerpointLtr.UseVisualStyleBackColor = true;
            this.btnAddToPowerpointLtr.Click += new System.EventHandler(this.btnAddToPowerpointLtr_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PictureBox);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(567, 515);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(4, 28);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(559, 400);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 8;
            this.PictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblShowDuration, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDuration, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 428);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 81);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnDuration
            // 
            this.btnDuration.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDuration.Font = new System.Drawing.Font("Mikhak Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDuration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDuration.Location = new System.Drawing.Point(4, 6);
            this.btnDuration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDuration.Name = "btnDuration";
            this.btnDuration.Size = new System.Drawing.Size(272, 69);
            this.btnDuration.TabIndex = 5;
            this.btnDuration.Text = "شروع";
            this.btnDuration.UseVisualStyleBackColor = false;
            this.btnDuration.Click += new System.EventHandler(this.btnDuration_Click);
            // 
            // PowerpointAssetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Mikhak Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "PowerpointAssetManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "powerpoint helper - @nazeriict in telegram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PowerpointAssetManager_FormClosing);
            this.Load += new System.EventHandler(this.PowerpointAssetManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectPowerpoint;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnAddToPowerpointRtl;
        private System.Windows.Forms.TextBox txtSlideNumber;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblShowDuration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToPowerpointLtr;
    }
}

