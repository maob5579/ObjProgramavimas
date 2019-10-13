namespace PrototypeDemo
{
    partial class OwnerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewRatings = new System.Windows.Forms.Button();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.btnDeleteRestaurant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Owner\'s Panel";
            // 
            // btnViewRatings
            // 
            this.btnViewRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRatings.Location = new System.Drawing.Point(191, 98);
            this.btnViewRatings.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewRatings.Name = "btnViewRatings";
            this.btnViewRatings.Size = new System.Drawing.Size(216, 65);
            this.btnViewRatings.TabIndex = 3;
            this.btnViewRatings.Text = "View restaurants\' ratings";
            this.btnViewRatings.UseVisualStyleBackColor = true;
            this.btnViewRatings.Click += new System.EventHandler(this.btnViewRatings_Click);
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRestaurant.Location = new System.Drawing.Point(191, 191);
            this.btnAddRestaurant.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(216, 55);
            this.btnAddRestaurant.TabIndex = 4;
            this.btnAddRestaurant.Text = "Add restaurant";
            this.btnAddRestaurant.UseVisualStyleBackColor = true;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click);
            // 
            // btnDeleteRestaurant
            // 
            this.btnDeleteRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRestaurant.Location = new System.Drawing.Point(191, 269);
            this.btnDeleteRestaurant.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteRestaurant.Name = "btnDeleteRestaurant";
            this.btnDeleteRestaurant.Size = new System.Drawing.Size(216, 55);
            this.btnDeleteRestaurant.TabIndex = 5;
            this.btnDeleteRestaurant.Text = "Delete restaurant";
            this.btnDeleteRestaurant.UseVisualStyleBackColor = true;
            this.btnDeleteRestaurant.Click += new System.EventHandler(this.btnDeleteRestaurant_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeleteRestaurant);
            this.Controls.Add(this.btnAddRestaurant);
            this.Controls.Add(this.btnViewRatings);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OwnerForm";
            this.Text = "OwnerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRatings;
        private System.Windows.Forms.Button btnAddRestaurant;
        private System.Windows.Forms.Button btnDeleteRestaurant;
    }
}