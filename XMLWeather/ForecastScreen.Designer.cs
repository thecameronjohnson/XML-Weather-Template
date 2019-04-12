namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.condition1 = new System.Windows.Forms.Label();
            this.condition2 = new System.Windows.Forms.Label();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.condition3 = new System.Windows.Forms.Label();
            this.picture3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(196, 434);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 65;
            this.forecastLabel.Text = "3 Day";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.Black;
            this.todayLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.todayLabel.Location = new System.Drawing.Point(25, 434);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(110, 34);
            this.todayLabel.TabIndex = 64;
            this.todayLabel.Text = "Today";
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(4, 12);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(325, 57);
            this.cityOutput.TabIndex = 66;
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min1
            // 
            this.min1.AutoSize = true;
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.ForeColor = System.Drawing.Color.White;
            this.min1.Location = new System.Drawing.Point(230, 113);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(46, 17);
            this.min1.TabIndex = 69;
            this.min1.Text = "label3";
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.ForeColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(115, 113);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(46, 17);
            this.max1.TabIndex = 68;
            this.max1.Text = "label1";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(174, 152);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(46, 17);
            this.date1.TabIndex = 67;
            this.date1.Text = "label2";
            this.date1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min2
            // 
            this.min2.AutoSize = true;
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.ForeColor = System.Drawing.Color.White;
            this.min2.Location = new System.Drawing.Point(230, 224);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(46, 17);
            this.min2.TabIndex = 72;
            this.min2.Text = "label3";
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.ForeColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(115, 224);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(46, 17);
            this.max2.TabIndex = 71;
            this.max2.Text = "label1";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(174, 264);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(46, 17);
            this.date2.TabIndex = 70;
            this.date2.Text = "label2";
            this.date2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min3
            // 
            this.min3.AutoSize = true;
            this.min3.BackColor = System.Drawing.Color.Transparent;
            this.min3.ForeColor = System.Drawing.Color.White;
            this.min3.Location = new System.Drawing.Point(230, 337);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(46, 17);
            this.min3.TabIndex = 75;
            this.min3.Text = "label3";
            // 
            // max3
            // 
            this.max3.AutoSize = true;
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.ForeColor = System.Drawing.Color.White;
            this.max3.Location = new System.Drawing.Point(115, 337);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(46, 17);
            this.max3.TabIndex = 74;
            this.max3.Text = "label1";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.BackColor = System.Drawing.Color.Transparent;
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(174, 377);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(46, 17);
            this.date3.TabIndex = 73;
            this.date3.Text = "label2";
            this.date3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.Color.Transparent;
            this.picture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture1.Location = new System.Drawing.Point(19, 81);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(72, 68);
            this.picture1.TabIndex = 76;
            this.picture1.TabStop = false;
            // 
            // condition1
            // 
            this.condition1.AutoSize = true;
            this.condition1.BackColor = System.Drawing.Color.Transparent;
            this.condition1.ForeColor = System.Drawing.Color.White;
            this.condition1.Location = new System.Drawing.Point(30, 152);
            this.condition1.Name = "condition1";
            this.condition1.Size = new System.Drawing.Size(46, 17);
            this.condition1.TabIndex = 78;
            this.condition1.Text = "label2";
            // 
            // condition2
            // 
            this.condition2.AutoSize = true;
            this.condition2.BackColor = System.Drawing.Color.Transparent;
            this.condition2.ForeColor = System.Drawing.Color.White;
            this.condition2.Location = new System.Drawing.Point(30, 273);
            this.condition2.Name = "condition2";
            this.condition2.Size = new System.Drawing.Size(46, 17);
            this.condition2.TabIndex = 80;
            this.condition2.Text = "label1";
            // 
            // picture2
            // 
            this.picture2.BackColor = System.Drawing.Color.Transparent;
            this.picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture2.Location = new System.Drawing.Point(19, 202);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(72, 68);
            this.picture2.TabIndex = 79;
            this.picture2.TabStop = false;
            // 
            // condition3
            // 
            this.condition3.AutoSize = true;
            this.condition3.BackColor = System.Drawing.Color.Transparent;
            this.condition3.ForeColor = System.Drawing.Color.White;
            this.condition3.Location = new System.Drawing.Point(30, 387);
            this.condition3.Name = "condition3";
            this.condition3.Size = new System.Drawing.Size(46, 17);
            this.condition3.TabIndex = 82;
            this.condition3.Text = "label3";
            // 
            // picture3
            // 
            this.picture3.BackColor = System.Drawing.Color.Transparent;
            this.picture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture3.Location = new System.Drawing.Point(19, 316);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(72, 68);
            this.picture3.TabIndex = 81;
            this.picture3.TabStop = false;
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.condition3);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.condition2);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.condition1);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(333, 492);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label condition1;
        private System.Windows.Forms.Label condition2;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.Label condition3;
        private System.Windows.Forms.PictureBox picture3;
    }
}
