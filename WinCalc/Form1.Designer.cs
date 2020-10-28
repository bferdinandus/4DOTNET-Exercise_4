namespace WinCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getalALabel = new System.Windows.Forms.Label();
            this.getalAUpDown = new System.Windows.Forms.NumericUpDown();
            this.getalBLabel = new System.Windows.Forms.Label();
            this.getalBUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeRemainingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getalAUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getalBUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // getalALabel
            // 
            this.getalALabel.AutoSize = true;
            this.getalALabel.Location = new System.Drawing.Point(64, 55);
            this.getalALabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.getalALabel.Name = "getalALabel";
            this.getalALabel.Size = new System.Drawing.Size(81, 30);
            this.getalALabel.TabIndex = 0;
            this.getalALabel.Text = "Getal A";
            // 
            // getalAUpDown
            // 
            this.getalAUpDown.Location = new System.Drawing.Point(159, 53);
            this.getalAUpDown.Margin = new System.Windows.Forms.Padding(7);
            this.getalAUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.getalAUpDown.Name = "getalAUpDown";
            this.getalAUpDown.Size = new System.Drawing.Size(240, 35);
            this.getalAUpDown.TabIndex = 1;
            // 
            // getalBLabel
            // 
            this.getalBLabel.AutoSize = true;
            this.getalBLabel.Location = new System.Drawing.Point(64, 101);
            this.getalBLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.getalBLabel.Name = "getalBLabel";
            this.getalBLabel.Size = new System.Drawing.Size(79, 30);
            this.getalBLabel.TabIndex = 0;
            this.getalBLabel.Text = "Getal B";
            // 
            // getalBUpDown
            // 
            this.getalBUpDown.Location = new System.Drawing.Point(159, 99);
            this.getalBUpDown.Margin = new System.Windows.Forms.Padding(7);
            this.getalBUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.getalBUpDown.Name = "getalBUpDown";
            this.getalBUpDown.Size = new System.Drawing.Size(240, 35);
            this.getalBUpDown.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(432, 55);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 79);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(542, 76);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(179, 37);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "=========";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeRemainingLabel
            // 
            this.timeRemainingLabel.AutoSize = true;
            this.timeRemainingLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemainingLabel.Location = new System.Drawing.Point(408, 158);
            this.timeRemainingLabel.Name = "timeRemainingLabel";
            this.timeRemainingLabel.Size = new System.Drawing.Size(0, 45);
            this.timeRemainingLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 234);
            this.Controls.Add(this.timeRemainingLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.getalBUpDown);
            this.Controls.Add(this.getalAUpDown);
            this.Controls.Add(this.getalBLabel);
            this.Controls.Add(this.getalALabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Win Calcio";
            ((System.ComponentModel.ISupportInitialize)(this.getalAUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getalBUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getalALabel;
        private System.Windows.Forms.NumericUpDown getalAUpDown;
        private System.Windows.Forms.Label getalBLabel;
        private System.Windows.Forms.NumericUpDown getalBUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeRemainingLabel;
    }
}

