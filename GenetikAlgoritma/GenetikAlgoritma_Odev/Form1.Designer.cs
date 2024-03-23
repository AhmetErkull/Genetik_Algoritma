namespace GenetikAlgoritma_Odev
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_fx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nm_populasyon = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nm_carprazlama = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nm_mutasyon = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nm_seckinlik = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nm_jenerasyon = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_baslat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_populasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_carprazlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_mutasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_seckinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_jenerasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(36, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(603, 304);
            this.chart1.TabIndex = 16;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "En İyi Sonuç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "F(x):";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(152, 406);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(0, 13);
            this.lbl_x.TabIndex = 3;
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(152, 433);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(0, 13);
            this.lbl_y.TabIndex = 3;
            // 
            // lbl_fx
            // 
            this.lbl_fx.AutoSize = true;
            this.lbl_fx.Location = new System.Drawing.Point(152, 380);
            this.lbl_fx.Name = "lbl_fx";
            this.lbl_fx.Size = new System.Drawing.Size(0, 13);
            this.lbl_fx.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GenetikAlgoritma_Odev.Properties.Resources.test_problemi;
            this.pictureBox1.Location = new System.Drawing.Point(292, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nm_populasyon
            // 
            this.nm_populasyon.Location = new System.Drawing.Point(803, 33);
            this.nm_populasyon.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nm_populasyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_populasyon.Name = "nm_populasyon";
            this.nm_populasyon.Size = new System.Drawing.Size(74, 20);
            this.nm_populasyon.TabIndex = 0;
            this.nm_populasyon.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Popülasyon Boyutu:";
            // 
            // nm_carprazlama
            // 
            this.nm_carprazlama.DecimalPlaces = 3;
            this.nm_carprazlama.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nm_carprazlama.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nm_carprazlama.Location = new System.Drawing.Point(803, 59);
            this.nm_carprazlama.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_carprazlama.Name = "nm_carprazlama";
            this.nm_carprazlama.Size = new System.Drawing.Size(74, 20);
            this.nm_carprazlama.TabIndex = 1;
            this.nm_carprazlama.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(701, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Çarprazlama Oranı:";
            // 
            // nm_mutasyon
            // 
            this.nm_mutasyon.DecimalPlaces = 3;
            this.nm_mutasyon.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nm_mutasyon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nm_mutasyon.Location = new System.Drawing.Point(803, 85);
            this.nm_mutasyon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_mutasyon.Name = "nm_mutasyon";
            this.nm_mutasyon.Size = new System.Drawing.Size(74, 20);
            this.nm_mutasyon.TabIndex = 2;
            this.nm_mutasyon.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(713, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mutasyon Oranı:";
            // 
            // nm_seckinlik
            // 
            this.nm_seckinlik.DecimalPlaces = 3;
            this.nm_seckinlik.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nm_seckinlik.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nm_seckinlik.Location = new System.Drawing.Point(803, 111);
            this.nm_seckinlik.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_seckinlik.Name = "nm_seckinlik";
            this.nm_seckinlik.Size = new System.Drawing.Size(74, 20);
            this.nm_seckinlik.TabIndex = 3;
            this.nm_seckinlik.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seçkinlik Oranı:";
            // 
            // nm_jenerasyon
            // 
            this.nm_jenerasyon.Location = new System.Drawing.Point(803, 137);
            this.nm_jenerasyon.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nm_jenerasyon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_jenerasyon.Name = "nm_jenerasyon";
            this.nm_jenerasyon.Size = new System.Drawing.Size(74, 20);
            this.nm_jenerasyon.TabIndex = 4;
            this.nm_jenerasyon.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Jenerasyon Sayısı:";
            // 
            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(704, 172);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(173, 41);
            this.btn_baslat.TabIndex = 5;
            this.btn_baslat.Text = "Başlat";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 511);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nm_seckinlik);
            this.Controls.Add(this.nm_mutasyon);
            this.Controls.Add(this.nm_carprazlama);
            this.Controls.Add(this.nm_jenerasyon);
            this.Controls.Add(this.nm_populasyon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_fx);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "203311109 Ahmet Erkul";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_populasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_carprazlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_mutasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_seckinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_jenerasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_fx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nm_populasyon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nm_carprazlama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nm_mutasyon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nm_seckinlik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nm_jenerasyon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_baslat;
    }
}

