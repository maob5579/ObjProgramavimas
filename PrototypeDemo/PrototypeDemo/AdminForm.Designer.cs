namespace PrototypeDemo
{
    partial class AdminForm
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
            this.comboRestaurantList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageRatings = new System.Windows.Forms.Button();
            this.btnChangeRestAddress = new System.Windows.Forms.Button();
            this.btnChangeRestName = new System.Windows.Forms.Button();
            this.btnDeleteRestaurant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin\'s Panel";
            // 
            // comboRestaurantList
            // 
            this.comboRestaurantList.FormattingEnabled = true;
            this.comboRestaurantList.Location = new System.Drawing.Point(299, 99);
            this.comboRestaurantList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboRestaurantList.Name = "comboRestaurantList";
            this.comboRestaurantList.Size = new System.Drawing.Size(280, 21);
            this.comboRestaurantList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select restaurant";
            // 
            // btnManageRatings
            // 
            this.btnManageRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRatings.Location = new System.Drawing.Point(8, 260);
            this.btnManageRatings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageRatings.Name = "btnManageRatings";
            this.btnManageRatings.Size = new System.Drawing.Size(131, 75);
            this.btnManageRatings.TabIndex = 3;
            this.btnManageRatings.Text = "Manage ratings";
            this.btnManageRatings.UseVisualStyleBackColor = true;
            this.btnManageRatings.Click += new System.EventHandler(this.btnManageRatings_Click);
            // 
            // btnChangeRestAddress
            // 
            this.btnChangeRestAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRestAddress.Location = new System.Drawing.Point(308, 260);
            this.btnChangeRestAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeRestAddress.Name = "btnChangeRestAddress";
            this.btnChangeRestAddress.Size = new System.Drawing.Size(131, 75);
            this.btnChangeRestAddress.TabIndex = 4;
            this.btnChangeRestAddress.Text = "Change address";
            this.btnChangeRestAddress.UseVisualStyleBackColor = true;
            this.btnChangeRestAddress.Click += new System.EventHandler(this.btnChangeRestAddress_Click);
            // 
            // btnChangeRestName
            // 
            this.btnChangeRestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRestName.Location = new System.Drawing.Point(158, 260);
            this.btnChangeRestName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeRestName.Name = "btnChangeRestName";
            this.btnChangeRestName.Size = new System.Drawing.Size(131, 75);
            this.btnChangeRestName.TabIndex = 5;
            this.btnChangeRestName.Text = "Change name";
            this.btnChangeRestName.UseVisualStyleBackColor = true;
            this.btnChangeRestName.Click += new System.EventHandler(this.btnChangeRestName_Click);
            // 
            // btnDeleteRestaurant
            // 
            this.btnDeleteRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRestaurant.Location = new System.Drawing.Point(458, 260);
            this.btnDeleteRestaurant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteRestaurant.Name = "btnDeleteRestaurant";
            this.btnDeleteRestaurant.Size = new System.Drawing.Size(131, 75);
            this.btnDeleteRestaurant.TabIndex = 6;
            this.btnDeleteRestaurant.Text = "Delete restaurant";
            this.btnDeleteRestaurant.UseVisualStyleBackColor = true;
            this.btnDeleteRestaurant.Click += new System.EventHandler(this.btnDeleteRestaurant_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeleteRestaurant);
            this.Controls.Add(this.btnChangeRestName);
            this.Controls.Add(this.btnChangeRestAddress);
            this.Controls.Add(this.btnManageRatings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRestaurantList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRestaurantList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageRatings;
        private System.Windows.Forms.Button btnChangeRestAddress;
        private System.Windows.Forms.Button btnChangeRestName;
        private System.Windows.Forms.Button btnDeleteRestaurant;
    }
}