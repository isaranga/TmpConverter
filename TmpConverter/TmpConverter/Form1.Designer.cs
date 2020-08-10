namespace TmpConverter
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
            this.label4 = new System.Windows.Forms.Label();
            this.KelvinNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.FahrenheitNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CelsiusNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KelvinNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FahrenheitNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelsiusNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(74, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "מחשבון טמפרטורות";
            // 
            // KelvinNumUpDown
            // 
            this.KelvinNumUpDown.DecimalPlaces = 2;
            this.KelvinNumUpDown.Location = new System.Drawing.Point(119, 173);
            this.KelvinNumUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KelvinNumUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.KelvinNumUpDown.Name = "KelvinNumUpDown";
            this.KelvinNumUpDown.Size = new System.Drawing.Size(131, 26);
            this.KelvinNumUpDown.TabIndex = 6;
            this.KelvinNumUpDown.ValueChanged += new System.EventHandler(this.KelvinNumUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "קלווין";
            // 
            // FahrenheitNumUpDown
            // 
            this.FahrenheitNumUpDown.DecimalPlaces = 2;
            this.FahrenheitNumUpDown.Location = new System.Drawing.Point(119, 129);
            this.FahrenheitNumUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FahrenheitNumUpDown.Maximum = new decimal(new int[] {
            179954033,
            0,
            0,
            131072});
            this.FahrenheitNumUpDown.Minimum = new decimal(new int[] {
            45967,
            0,
            0,
            -2147352576});
            this.FahrenheitNumUpDown.Name = "FahrenheitNumUpDown";
            this.FahrenheitNumUpDown.Size = new System.Drawing.Size(131, 26);
            this.FahrenheitNumUpDown.TabIndex = 4;
            this.FahrenheitNumUpDown.ValueChanged += new System.EventHandler(this.FahrenheitNumUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "פרנהייט";
            // 
            // CelsiusNumUpDown
            // 
            this.CelsiusNumUpDown.DecimalPlaces = 2;
            this.CelsiusNumUpDown.Location = new System.Drawing.Point(119, 86);
            this.CelsiusNumUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CelsiusNumUpDown.Maximum = new decimal(new int[] {
            99972685,
            0,
            0,
            131072});
            this.CelsiusNumUpDown.Minimum = new decimal(new int[] {
            27315,
            0,
            0,
            -2147352576});
            this.CelsiusNumUpDown.Name = "CelsiusNumUpDown";
            this.CelsiusNumUpDown.Size = new System.Drawing.Size(131, 26);
            this.CelsiusNumUpDown.TabIndex = 2;
            this.CelsiusNumUpDown.ValueChanged += new System.EventHandler(this.CelsiusNumUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "צלזיוס";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KelvinNumUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FahrenheitNumUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CelsiusNumUpDown);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "מחשבון טמפרטורות";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KelvinNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FahrenheitNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelsiusNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown KelvinNumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown FahrenheitNumUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CelsiusNumUpDown;
        private System.Windows.Forms.Label label1;
    }
}

