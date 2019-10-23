namespace PrototypeDemo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.angerLabel = new System.Windows.Forms.Label();
            this.contemptLabel = new System.Windows.Forms.Label();
            this.disgustLabel = new System.Windows.Forms.Label();
            this.fearLabel = new System.Windows.Forms.Label();
            this.happinessLabel = new System.Windows.Forms.Label();
            this.neutralLabel = new System.Windows.Forms.Label();
            this.sadnessLabel = new System.Windows.Forms.Label();
            this.surpirseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrototypeDemo.Properties.Resources.how_to_be_happy;
            this.pictureBox1.Location = new System.Drawing.Point(71, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(249, 322);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(116, 38);
            this.btnMeasure.TabIndex = 1;
            this.btnMeasure.Text = "Measure mod";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // angerLabel
            // 
            this.angerLabel.AutoSize = true;
            this.angerLabel.Location = new System.Drawing.Point(524, 66);
            this.angerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angerLabel.Name = "angerLabel";
            this.angerLabel.Size = new System.Drawing.Size(41, 13);
            this.angerLabel.TabIndex = 2;
            this.angerLabel.Text = "Anger: ";
            // 
            // contemptLabel
            // 
            this.contemptLabel.AutoSize = true;
            this.contemptLabel.Location = new System.Drawing.Point(508, 89);
            this.contemptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contemptLabel.Name = "contemptLabel";
            this.contemptLabel.Size = new System.Drawing.Size(58, 13);
            this.contemptLabel.TabIndex = 3;
            this.contemptLabel.Text = "Contempt: ";
            // 
            // disgustLabel
            // 
            this.disgustLabel.AutoSize = true;
            this.disgustLabel.Location = new System.Drawing.Point(518, 114);
            this.disgustLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.disgustLabel.Name = "disgustLabel";
            this.disgustLabel.Size = new System.Drawing.Size(48, 13);
            this.disgustLabel.TabIndex = 4;
            this.disgustLabel.Text = "Disgust: ";
            // 
            // fearLabel
            // 
            this.fearLabel.AutoSize = true;
            this.fearLabel.Location = new System.Drawing.Point(532, 140);
            this.fearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fearLabel.Name = "fearLabel";
            this.fearLabel.Size = new System.Drawing.Size(34, 13);
            this.fearLabel.TabIndex = 5;
            this.fearLabel.Text = "Fear: ";
            // 
            // happinessLabel
            // 
            this.happinessLabel.AutoSize = true;
            this.happinessLabel.Location = new System.Drawing.Point(503, 163);
            this.happinessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.happinessLabel.Name = "happinessLabel";
            this.happinessLabel.Size = new System.Drawing.Size(63, 13);
            this.happinessLabel.TabIndex = 6;
            this.happinessLabel.Text = "Happiness: ";
            // 
            // neutralLabel
            // 
            this.neutralLabel.AutoSize = true;
            this.neutralLabel.Location = new System.Drawing.Point(518, 188);
            this.neutralLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.neutralLabel.Name = "neutralLabel";
            this.neutralLabel.Size = new System.Drawing.Size(47, 13);
            this.neutralLabel.TabIndex = 7;
            this.neutralLabel.Text = "Neutral: ";
            // 
            // sadnessLabel
            // 
            this.sadnessLabel.AutoSize = true;
            this.sadnessLabel.Location = new System.Drawing.Point(512, 214);
            this.sadnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sadnessLabel.Name = "sadnessLabel";
            this.sadnessLabel.Size = new System.Drawing.Size(54, 13);
            this.sadnessLabel.TabIndex = 8;
            this.sadnessLabel.Text = "Sadness: ";
            // 
            // surpirseLabel
            // 
            this.surpirseLabel.AutoSize = true;
            this.surpirseLabel.Location = new System.Drawing.Point(513, 241);
            this.surpirseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surpirseLabel.Name = "surpirseLabel";
            this.surpirseLabel.Size = new System.Drawing.Size(51, 13);
            this.surpirseLabel.TabIndex = 9;
            this.surpirseLabel.Text = "Surprise: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 409);
            this.Controls.Add(this.surpirseLabel);
            this.Controls.Add(this.sadnessLabel);
            this.Controls.Add(this.neutralLabel);
            this.Controls.Add(this.happinessLabel);
            this.Controls.Add(this.fearLabel);
            this.Controls.Add(this.disgustLabel);
            this.Controls.Add(this.contemptLabel);
            this.Controls.Add(this.angerLabel);
            this.Controls.Add(this.btnMeasure);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Label angerLabel;
        private System.Windows.Forms.Label contemptLabel;
        private System.Windows.Forms.Label disgustLabel;
        private System.Windows.Forms.Label fearLabel;
        private System.Windows.Forms.Label happinessLabel;
        private System.Windows.Forms.Label neutralLabel;
        private System.Windows.Forms.Label sadnessLabel;
        private System.Windows.Forms.Label surpirseLabel;
    }
}

