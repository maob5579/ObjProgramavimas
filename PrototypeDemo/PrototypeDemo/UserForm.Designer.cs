namespace PrototypeDemo
{
    partial class UserForm
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
            this.btnRateRestaurant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowRatedRestaurants = new System.Windows.Forms.Button();
            this.btnShowRestaurantList = new System.Windows.Forms.Button();
            this.btnShowFavorites = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRateRestaurant
            // 
            this.btnRateRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateRestaurant.Location = new System.Drawing.Point(191, 81);
            this.btnRateRestaurant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRateRestaurant.Name = "btnRateRestaurant";
            this.btnRateRestaurant.Size = new System.Drawing.Size(201, 52);
            this.btnRateRestaurant.TabIndex = 0;
            this.btnRateRestaurant.Text = "Rate restaurant";
            this.btnRateRestaurant.UseVisualStyleBackColor = true;
            this.btnRateRestaurant.Click += new System.EventHandler(this.btnRateRestaurant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "User\'s Panel";
            // 
            // btnShowRatedRestaurants
            // 
            this.btnShowRatedRestaurants.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRatedRestaurants.Location = new System.Drawing.Point(191, 146);
            this.btnShowRatedRestaurants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowRatedRestaurants.Name = "btnShowRatedRestaurants";
            this.btnShowRatedRestaurants.Size = new System.Drawing.Size(201, 52);
            this.btnShowRatedRestaurants.TabIndex = 2;
            this.btnShowRatedRestaurants.Text = "Rated restaurants";
            this.btnShowRatedRestaurants.UseVisualStyleBackColor = true;
            this.btnShowRatedRestaurants.Click += new System.EventHandler(this.btnShowRatedRestaurants_Click);
            // 
            // btnShowRestaurantList
            // 
            this.btnShowRestaurantList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRestaurantList.Location = new System.Drawing.Point(191, 211);
            this.btnShowRestaurantList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowRestaurantList.Name = "btnShowRestaurantList";
            this.btnShowRestaurantList.Size = new System.Drawing.Size(201, 52);
            this.btnShowRestaurantList.TabIndex = 3;
            this.btnShowRestaurantList.Text = "Restaurants\' list";
            this.btnShowRestaurantList.UseVisualStyleBackColor = true;
            this.btnShowRestaurantList.Click += new System.EventHandler(this.btnShowRestaurantList_Click);
            // 
            // btnShowFavorites
            // 
            this.btnShowFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFavorites.Location = new System.Drawing.Point(191, 276);
            this.btnShowFavorites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowFavorites.Name = "btnShowFavorites";
            this.btnShowFavorites.Size = new System.Drawing.Size(201, 52);
            this.btnShowFavorites.TabIndex = 4;
            this.btnShowFavorites.Text = "Favourite restaurants";
            this.btnShowFavorites.UseVisualStyleBackColor = true;
            this.btnShowFavorites.Click += new System.EventHandler(this.btnShowFavorites_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnShowFavorites);
            this.Controls.Add(this.btnShowRestaurantList);
            this.Controls.Add(this.btnShowRatedRestaurants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRateRestaurant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRateRestaurant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowRatedRestaurants;
        private System.Windows.Forms.Button btnShowRestaurantList;
        private System.Windows.Forms.Button btnShowFavorites;
    }
}