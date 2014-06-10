namespace MatrixExplorer
{
    partial class Form1
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
            this.glControl1 = new OpenTK.GLControl();
            this.rotateAngle = new System.Windows.Forms.NumericUpDown();
            this.rotateBox = new System.Windows.Forms.GroupBox();
            this.rotateZ = new System.Windows.Forms.NumericUpDown();
            this.rotateY = new System.Windows.Forms.NumericUpDown();
            this.rotateX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.translateZ = new System.Windows.Forms.NumericUpDown();
            this.translateY = new System.Windows.Forms.NumericUpDown();
            this.translateX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Size = new System.Windows.Forms.GroupBox();
            this.modelviewButton = new System.Windows.Forms.RadioButton();
            this.projectionButton = new System.Windows.Forms.RadioButton();
            this.MatrixModeBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).BeginInit();
            this.rotateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).BeginInit();
            this.Size.SuspendLayout();
            this.MatrixModeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(34, 26);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(350, 350);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasMouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasMouseUp);
            // 
            // rotateAngle
            // 
            this.rotateAngle.Location = new System.Drawing.Point(49, 16);
            this.rotateAngle.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.rotateAngle.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.rotateAngle.Name = "rotateAngle";
            this.rotateAngle.Size = new System.Drawing.Size(60, 20);
            this.rotateAngle.TabIndex = 2;
            this.rotateAngle.ThousandsSeparator = true;
            this.rotateAngle.ValueChanged += new System.EventHandler(this.rotateAngleValueChanged);
            // 
            // rotateBox
            // 
            this.rotateBox.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.rotateBox.Controls.Add(this.rotateZ);
            this.rotateBox.Controls.Add(this.rotateY);
            this.rotateBox.Controls.Add(this.rotateX);
            this.rotateBox.Controls.Add(this.label4);
            this.rotateBox.Controls.Add(this.label3);
            this.rotateBox.Controls.Add(this.label2);
            this.rotateBox.Controls.Add(this.label1);
            this.rotateBox.Controls.Add(this.rotateAngle);
            this.rotateBox.Location = new System.Drawing.Point(434, 29);
            this.rotateBox.Name = "rotateBox";
            this.rotateBox.Size = new System.Drawing.Size(125, 121);
            this.rotateBox.TabIndex = 3;
            this.rotateBox.TabStop = false;
            this.rotateBox.Text = "Rotate";
            // 
            // rotateZ
            // 
            this.rotateZ.Location = new System.Drawing.Point(49, 95);
            this.rotateZ.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.rotateZ.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.rotateZ.Name = "rotateZ";
            this.rotateZ.Size = new System.Drawing.Size(60, 20);
            this.rotateZ.TabIndex = 12;
            this.rotateZ.ValueChanged += new System.EventHandler(this.rotateZValueChanged);
            // 
            // rotateY
            // 
            this.rotateY.Location = new System.Drawing.Point(49, 69);
            this.rotateY.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.rotateY.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.rotateY.Name = "rotateY";
            this.rotateY.Size = new System.Drawing.Size(60, 20);
            this.rotateY.TabIndex = 11;
            this.rotateY.ValueChanged += new System.EventHandler(this.rotateYValueChanged);
            // 
            // rotateX
            // 
            this.rotateX.Location = new System.Drawing.Point(49, 42);
            this.rotateX.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.rotateX.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.rotateX.Name = "rotateX";
            this.rotateX.Size = new System.Drawing.Size(60, 20);
            this.rotateX.TabIndex = 10;
            this.rotateX.ValueChanged += new System.EventHandler(this.rotateXValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "z-Axis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "y-Axis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x-Axis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Angle:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(146, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(14, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(60, 20);
            this.textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(80, 81);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(60, 20);
            this.textBox8.TabIndex = 11;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(146, 81);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(60, 20);
            this.textBox9.TabIndex = 12;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(14, 19);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(60, 20);
            this.textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(80, 19);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(60, 20);
            this.textBox11.TabIndex = 20;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(146, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(60, 20);
            this.textBox12.TabIndex = 19;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(14, 45);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(60, 20);
            this.textBox13.TabIndex = 18;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(80, 45);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(60, 20);
            this.textBox14.TabIndex = 17;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(146, 45);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(60, 20);
            this.textBox15.TabIndex = 16;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(14, 71);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(60, 20);
            this.textBox16.TabIndex = 15;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(80, 71);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(60, 20);
            this.textBox17.TabIndex = 14;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(146, 71);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(60, 20);
            this.textBox18.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(574, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 121);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelview Matrix";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Location = new System.Drawing.Point(574, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 119);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projection Matrix";
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.groupBox3.Controls.Add(this.translateZ);
            this.groupBox3.Controls.Add(this.translateY);
            this.groupBox3.Controls.Add(this.translateX);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(434, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 121);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Translate";
            // 
            // translateZ
            // 
            this.translateZ.Location = new System.Drawing.Point(49, 75);
            this.translateZ.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.translateZ.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.translateZ.Name = "translateZ";
            this.translateZ.Size = new System.Drawing.Size(60, 20);
            this.translateZ.TabIndex = 12;
            this.translateZ.ValueChanged += new System.EventHandler(this.translateZValueChanged);
            // 
            // translateY
            // 
            this.translateY.Location = new System.Drawing.Point(49, 49);
            this.translateY.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.translateY.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.translateY.Name = "translateY";
            this.translateY.Size = new System.Drawing.Size(60, 20);
            this.translateY.TabIndex = 11;
            this.translateY.ValueChanged += new System.EventHandler(this.translateYValueChanged);
            // 
            // translateX
            // 
            this.translateX.Location = new System.Drawing.Point(49, 22);
            this.translateX.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.translateX.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.translateX.Name = "translateX";
            this.translateX.Size = new System.Drawing.Size(60, 20);
            this.translateX.TabIndex = 10;
            this.translateX.ValueChanged += new System.EventHandler(this.translateXValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "z-Axis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "y-Axis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "x-Axis:";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(9, 34);
            this.hScrollBar1.Maximum = 30;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(346, 17);
            this.hScrollBar1.TabIndex = 24;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Size
            // 
            this.Size.Controls.Add(this.hScrollBar1);
            this.Size.Location = new System.Drawing.Point(434, 342);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(360, 81);
            this.Size.TabIndex = 25;
            this.Size.TabStop = false;
            this.Size.Text = "Size";
            // 
            // modelviewButton
            // 
            this.modelviewButton.AutoSize = true;
            this.modelviewButton.Checked = true;
            this.modelviewButton.Location = new System.Drawing.Point(10, 19);
            this.modelviewButton.Name = "modelviewButton";
            this.modelviewButton.Size = new System.Drawing.Size(76, 17);
            this.modelviewButton.TabIndex = 26;
            this.modelviewButton.TabStop = true;
            this.modelviewButton.Text = "Modelview";
            this.modelviewButton.UseVisualStyleBackColor = true;
            this.modelviewButton.CheckedChanged += new System.EventHandler(this.modelviewButton_CheckedChanged);
            // 
            // projectionButton
            // 
            this.projectionButton.AutoSize = true;
            this.projectionButton.Location = new System.Drawing.Point(101, 20);
            this.projectionButton.Name = "projectionButton";
            this.projectionButton.Size = new System.Drawing.Size(72, 17);
            this.projectionButton.TabIndex = 27;
            this.projectionButton.Text = "Projection";
            this.projectionButton.UseVisualStyleBackColor = true;
            this.projectionButton.CheckedChanged += new System.EventHandler(this.projectionButton_CheckedChanged);
            // 
            // MatrixModeBox
            // 
            this.MatrixModeBox.Controls.Add(this.label8);
            this.MatrixModeBox.Controls.Add(this.projectionButton);
            this.MatrixModeBox.Controls.Add(this.modelviewButton);
            this.MatrixModeBox.Location = new System.Drawing.Point(434, 293);
            this.MatrixModeBox.Name = "MatrixModeBox";
            this.MatrixModeBox.Size = new System.Drawing.Size(361, 43);
            this.MatrixModeBox.TabIndex = 28;
            this.MatrixModeBox.TabStop = false;
            this.MatrixModeBox.Text = "MatrixMode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "PROJECTION ONLY PRE-ALPHA! USE WITH CAUTION!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 429);
            this.Controls.Add(this.MatrixModeBox);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rotateBox);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rotateAngle)).EndInit();
            this.rotateBox.ResumeLayout(false);
            this.rotateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).EndInit();
            this.Size.ResumeLayout(false);
            this.MatrixModeBox.ResumeLayout(false);
            this.MatrixModeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.NumericUpDown rotateAngle;
        private System.Windows.Forms.GroupBox rotateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.NumericUpDown rotateZ;
        private System.Windows.Forms.NumericUpDown rotateY;
        private System.Windows.Forms.NumericUpDown rotateX;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown translateZ;
        private System.Windows.Forms.NumericUpDown translateY;
        private System.Windows.Forms.NumericUpDown translateX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox Size;
        private System.Windows.Forms.RadioButton modelviewButton;
        private System.Windows.Forms.RadioButton projectionButton;
        private System.Windows.Forms.GroupBox MatrixModeBox;
        private System.Windows.Forms.Label label8;
    }
}

