
namespace TriangleInOut
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nudPointPx = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPointPz = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPointPy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPointAy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPointAz = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPointAx = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPointBy = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudPointBz = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudPointBx = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudPointCy = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudPointCz = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudPointCx = new System.Windows.Forms.NumericUpDown();
            this.Judge = new System.Windows.Forms.Button();
            this.tbxJudge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointAy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointAz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointAx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointBz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCx)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPointPx
            // 
            this.nudPointPx.DecimalPlaces = 2;
            this.nudPointPx.Location = new System.Drawing.Point(78, 18);
            this.nudPointPx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointPx.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointPx.Name = "nudPointPx";
            this.nudPointPx.Size = new System.Drawing.Size(62, 19);
            this.nudPointPx.TabIndex = 0;
            this.nudPointPx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointPx.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "点P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Z";
            // 
            // nudPointPz
            // 
            this.nudPointPz.DecimalPlaces = 2;
            this.nudPointPz.Location = new System.Drawing.Point(78, 68);
            this.nudPointPz.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointPz.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointPz.Name = "nudPointPz";
            this.nudPointPz.Size = new System.Drawing.Size(62, 19);
            this.nudPointPz.TabIndex = 2;
            this.nudPointPz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointPz.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y";
            // 
            // nudPointPy
            // 
            this.nudPointPy.DecimalPlaces = 2;
            this.nudPointPy.Location = new System.Drawing.Point(78, 43);
            this.nudPointPy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointPy.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointPy.Name = "nudPointPy";
            this.nudPointPy.Size = new System.Drawing.Size(62, 19);
            this.nudPointPy.TabIndex = 1;
            this.nudPointPy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointPy.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Y";
            // 
            // nudPointAy
            // 
            this.nudPointAy.DecimalPlaces = 2;
            this.nudPointAy.Location = new System.Drawing.Point(78, 135);
            this.nudPointAy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointAy.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointAy.Name = "nudPointAy";
            this.nudPointAy.Size = new System.Drawing.Size(62, 19);
            this.nudPointAy.TabIndex = 4;
            this.nudPointAy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointAy.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Z";
            // 
            // nudPointAz
            // 
            this.nudPointAz.DecimalPlaces = 2;
            this.nudPointAz.Location = new System.Drawing.Point(78, 160);
            this.nudPointAz.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointAz.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointAz.Name = "nudPointAz";
            this.nudPointAz.Size = new System.Drawing.Size(62, 19);
            this.nudPointAz.TabIndex = 5;
            this.nudPointAz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "点A";
            // 
            // nudPointAx
            // 
            this.nudPointAx.DecimalPlaces = 2;
            this.nudPointAx.Location = new System.Drawing.Point(78, 110);
            this.nudPointAx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointAx.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointAx.Name = "nudPointAx";
            this.nudPointAx.Size = new System.Drawing.Size(62, 19);
            this.nudPointAx.TabIndex = 3;
            this.nudPointAx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointAx.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Y";
            // 
            // nudPointBy
            // 
            this.nudPointBy.DecimalPlaces = 2;
            this.nudPointBy.Location = new System.Drawing.Point(212, 135);
            this.nudPointBy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointBy.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointBy.Name = "nudPointBy";
            this.nudPointBy.Size = new System.Drawing.Size(62, 19);
            this.nudPointBy.TabIndex = 7;
            this.nudPointBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointBy.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Z";
            // 
            // nudPointBz
            // 
            this.nudPointBz.DecimalPlaces = 2;
            this.nudPointBz.Location = new System.Drawing.Point(212, 160);
            this.nudPointBz.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointBz.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointBz.Name = "nudPointBz";
            this.nudPointBz.Size = new System.Drawing.Size(62, 19);
            this.nudPointBz.TabIndex = 8;
            this.nudPointBz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointBz.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "点B";
            // 
            // nudPointBx
            // 
            this.nudPointBx.DecimalPlaces = 2;
            this.nudPointBx.Location = new System.Drawing.Point(212, 110);
            this.nudPointBx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointBx.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointBx.Name = "nudPointBx";
            this.nudPointBx.Size = new System.Drawing.Size(62, 19);
            this.nudPointBx.TabIndex = 6;
            this.nudPointBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "Y";
            // 
            // nudPointCy
            // 
            this.nudPointCy.DecimalPlaces = 2;
            this.nudPointCy.Location = new System.Drawing.Point(348, 135);
            this.nudPointCy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointCy.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointCy.Name = "nudPointCy";
            this.nudPointCy.Size = new System.Drawing.Size(62, 19);
            this.nudPointCy.TabIndex = 10;
            this.nudPointCy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPointCy.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(330, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "Z";
            // 
            // nudPointCz
            // 
            this.nudPointCz.DecimalPlaces = 2;
            this.nudPointCz.Location = new System.Drawing.Point(348, 160);
            this.nudPointCz.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointCz.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointCz.Name = "nudPointCz";
            this.nudPointCz.Size = new System.Drawing.Size(62, 19);
            this.nudPointCz.TabIndex = 11;
            this.nudPointCz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 12);
            this.label15.TabIndex = 24;
            this.label15.Text = "X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(300, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "点C";
            // 
            // nudPointCx
            // 
            this.nudPointCx.DecimalPlaces = 2;
            this.nudPointCx.Location = new System.Drawing.Point(348, 110);
            this.nudPointCx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPointCx.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPointCx.Name = "nudPointCx";
            this.nudPointCx.Size = new System.Drawing.Size(62, 19);
            this.nudPointCx.TabIndex = 9;
            this.nudPointCx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Judge
            // 
            this.Judge.Location = new System.Drawing.Point(166, 59);
            this.Judge.Name = "Judge";
            this.Judge.Size = new System.Drawing.Size(244, 23);
            this.Judge.TabIndex = 12;
            this.Judge.Text = "判　定";
            this.Judge.UseVisualStyleBackColor = true;
            this.Judge.Click += new System.EventHandler(this.Judge_Click);
            // 
            // tbxJudge
            // 
            this.tbxJudge.Location = new System.Drawing.Point(166, 20);
            this.tbxJudge.Name = "tbxJudge";
            this.tbxJudge.Size = new System.Drawing.Size(240, 19);
            this.tbxJudge.TabIndex = 30;
            this.tbxJudge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 191);
            this.Controls.Add(this.tbxJudge);
            this.Controls.Add(this.Judge);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nudPointCy);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nudPointCz);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.nudPointCx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPointBy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudPointBz);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudPointBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPointAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudPointAz);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudPointAx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPointPy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPointPz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPointPx);
            this.Name = "Form1";
            this.Text = "点Pが三角形ABCの内側にあるか";
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointAy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointAz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointAx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointBz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPointPx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPointPz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPointPy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPointAy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPointAz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPointAx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudPointBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudPointBz;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudPointBx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudPointCy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudPointCz;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudPointCx;
        private System.Windows.Forms.Button Judge;
        private System.Windows.Forms.TextBox tbxJudge;
    }
}

