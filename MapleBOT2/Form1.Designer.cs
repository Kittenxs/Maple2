namespace MapleBOT2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._zValue = new System.Windows.Forms.Label();
            this._yValue = new System.Windows.Forms.Label();
            this._xValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._movementSpeed = new System.Windows.Forms.Label();
            this._attackSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._attackSpeedModifier = new System.Windows.Forms.NumericUpDown();
            this._movementSpeedModifier = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this._jumpDistLbl = new System.Windows.Forms.Label();
            this._jumpDistanceModifier = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this._jumpHeightModifier = new System.Windows.Forms.NumericUpDown();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label9 = new System.Windows.Forms.Label();
            this._jumpHeightLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._surfSpdModifier = new System.Windows.Forms.NumericUpDown();
            this._surfSpdLbl = new System.Windows.Forms.Label();
            this._locations = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._attackSpeedModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._movementSpeedModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._jumpDistanceModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._jumpHeightModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._surfSpdModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this._locations);
            this.groupBox1.Controls.Add(this._zValue);
            this.groupBox1.Controls.Add(this._yValue);
            this.groupBox1.Controls.Add(this._xValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PlayerLocation";
            // 
            // _zValue
            // 
            this._zValue.AutoSize = true;
            this._zValue.Location = new System.Drawing.Point(46, 90);
            this._zValue.Name = "_zValue";
            this._zValue.Size = new System.Drawing.Size(35, 13);
            this._zValue.TabIndex = 4;
            this._zValue.Text = "label6";
            // 
            // _yValue
            // 
            this._yValue.AutoSize = true;
            this._yValue.Location = new System.Drawing.Point(46, 63);
            this._yValue.Name = "_yValue";
            this._yValue.Size = new System.Drawing.Size(35, 13);
            this._yValue.TabIndex = 3;
            this._yValue.Text = "label5";
            // 
            // _xValue
            // 
            this._xValue.AutoSize = true;
            this._xValue.Location = new System.Drawing.Point(46, 34);
            this._xValue.Name = "_xValue";
            this._xValue.Size = new System.Drawing.Size(35, 13);
            this._xValue.TabIndex = 1;
            this._xValue.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._surfSpdLbl);
            this.groupBox2.Controls.Add(this._surfSpdModifier);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._jumpHeightLbl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this._jumpHeightModifier);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this._jumpDistanceModifier);
            this.groupBox2.Controls.Add(this._jumpDistLbl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._movementSpeedModifier);
            this.groupBox2.Controls.Add(this._attackSpeedModifier);
            this.groupBox2.Controls.Add(this._movementSpeed);
            this.groupBox2.Controls.Add(this._attackSpeed);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Stats";
            // 
            // _movementSpeed
            // 
            this._movementSpeed.AutoSize = true;
            this._movementSpeed.Location = new System.Drawing.Point(128, 56);
            this._movementSpeed.Name = "_movementSpeed";
            this._movementSpeed.Size = new System.Drawing.Size(35, 13);
            this._movementSpeed.TabIndex = 4;
            this._movementSpeed.Text = "label7";
            // 
            // _attackSpeed
            // 
            this._attackSpeed.AutoSize = true;
            this._attackSpeed.Location = new System.Drawing.Point(128, 34);
            this._attackSpeed.Name = "_attackSpeed";
            this._attackSpeed.Size = new System.Drawing.Size(35, 13);
            this._attackSpeed.TabIndex = 3;
            this._attackSpeed.Text = "label7";
            this._attackSpeed.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Movement Speed :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Attack Speed % :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // _attackSpeedModifier
            // 
            this._attackSpeedModifier.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._attackSpeedModifier.Location = new System.Drawing.Point(256, 27);
            this._attackSpeedModifier.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this._attackSpeedModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._attackSpeedModifier.Name = "_attackSpeedModifier";
            this._attackSpeedModifier.Size = new System.Drawing.Size(102, 20);
            this._attackSpeedModifier.TabIndex = 6;
            this._attackSpeedModifier.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._attackSpeedModifier.ValueChanged += new System.EventHandler(this._attackSpeedModifier_ValueChanged);
            // 
            // _movementSpeedModifier
            // 
            this._movementSpeedModifier.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._movementSpeedModifier.Location = new System.Drawing.Point(256, 50);
            this._movementSpeedModifier.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._movementSpeedModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._movementSpeedModifier.Name = "_movementSpeedModifier";
            this._movementSpeedModifier.Size = new System.Drawing.Size(102, 20);
            this._movementSpeedModifier.TabIndex = 7;
            this._movementSpeedModifier.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jump Distance :";
            // 
            // _jumpDistLbl
            // 
            this._jumpDistLbl.AutoSize = true;
            this._jumpDistLbl.Location = new System.Drawing.Point(128, 78);
            this._jumpDistLbl.Name = "_jumpDistLbl";
            this._jumpDistLbl.Size = new System.Drawing.Size(35, 13);
            this._jumpDistLbl.TabIndex = 9;
            this._jumpDistLbl.Text = "label7";
            // 
            // _jumpDistanceModifier
            // 
            this._jumpDistanceModifier.Location = new System.Drawing.Point(256, 74);
            this._jumpDistanceModifier.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._jumpDistanceModifier.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._jumpDistanceModifier.Name = "_jumpDistanceModifier";
            this._jumpDistanceModifier.Size = new System.Drawing.Size(102, 20);
            this._jumpDistanceModifier.TabIndex = 10;
            this._jumpDistanceModifier.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Surf Speed :";
            // 
            // _jumpHeightModifier
            // 
            this._jumpHeightModifier.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._jumpHeightModifier.Location = new System.Drawing.Point(256, 97);
            this._jumpHeightModifier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._jumpHeightModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._jumpHeightModifier.Name = "_jumpHeightModifier";
            this._jumpHeightModifier.Size = new System.Drawing.Size(102, 20);
            this._jumpHeightModifier.TabIndex = 12;
            this._jumpHeightModifier.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Jump Height :";
            // 
            // _jumpHeightLbl
            // 
            this._jumpHeightLbl.AutoSize = true;
            this._jumpHeightLbl.Location = new System.Drawing.Point(128, 101);
            this._jumpHeightLbl.Name = "_jumpHeightLbl";
            this._jumpHeightLbl.Size = new System.Drawing.Size(41, 13);
            this._jumpHeightLbl.TabIndex = 14;
            this._jumpHeightLbl.Text = "label10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "BASE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "EDIT";
            // 
            // _surfSpdModifier
            // 
            this._surfSpdModifier.Location = new System.Drawing.Point(256, 118);
            this._surfSpdModifier.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._surfSpdModifier.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._surfSpdModifier.Name = "_surfSpdModifier";
            this._surfSpdModifier.Size = new System.Drawing.Size(102, 20);
            this._surfSpdModifier.TabIndex = 17;
            this._surfSpdModifier.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _surfSpdLbl
            // 
            this._surfSpdLbl.AutoSize = true;
            this._surfSpdLbl.Location = new System.Drawing.Point(128, 125);
            this._surfSpdLbl.Name = "_surfSpdLbl";
            this._surfSpdLbl.Size = new System.Drawing.Size(41, 13);
            this._surfSpdLbl.TabIndex = 18;
            this._surfSpdLbl.Text = "label10";
            // 
            // _locations
            // 
            this._locations.FormattingEnabled = true;
            this._locations.Location = new System.Drawing.Point(184, 24);
            this._locations.Name = "_locations";
            this._locations.Size = new System.Drawing.Size(226, 95);
            this._locations.TabIndex = 5;
            this._locations.DoubleClick += new System.EventHandler(this._locations_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Saved Locations";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear Locations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Start TPs";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Stop TPs";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NiggerBOT - BETA Version";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._attackSpeedModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._movementSpeedModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._jumpDistanceModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._jumpHeightModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._surfSpdModifier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label _zValue;
        private System.Windows.Forms.Label _yValue;
        private System.Windows.Forms.Label _xValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _attackSpeed;
        private System.Windows.Forms.Label _movementSpeed;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown _movementSpeedModifier;
        private System.Windows.Forms.NumericUpDown _attackSpeedModifier;
        private System.Windows.Forms.NumericUpDown _jumpHeightModifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown _jumpDistanceModifier;
        private System.Windows.Forms.Label _jumpDistLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _jumpHeightLbl;
        private System.Windows.Forms.Label _surfSpdLbl;
        private System.Windows.Forms.NumericUpDown _surfSpdModifier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox _locations;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

