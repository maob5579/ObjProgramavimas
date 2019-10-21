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
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRateRestaurant
            // 
            this.btnRateRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateRestaurant.Location = new System.Drawing.Point(89, 118);
            this.btnRateRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRateRestaurant.Name = "btnRateRestaurant";
            this.btnRateRestaurant.Size = new System.Drawing.Size(302, 64);
            this.btnRateRestaurant.TabIndex = 0;
            this.btnRateRestaurant.Text = "Rate restaurant";
            this.btnRateRestaurant.UseVisualStyleBackColor = true;
            this.btnRateRestaurant.Click += new System.EventHandler(this.btnRateRestaurant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "User\'s Panel";
            // 
            // btnShowRatedRestaurants
            // 
            this.btnShowRatedRestaurants.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRatedRestaurants.Location = new System.Drawing.Point(89, 198);
            this.btnShowRatedRestaurants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowRatedRestaurants.Name = "btnShowRatedRestaurants";
            this.btnShowRatedRestaurants.Size = new System.Drawing.Size(302, 64);
            this.btnShowRatedRestaurants.TabIndex = 2;
            this.btnShowRatedRestaurants.Text = "Rated restaurants";
            this.btnShowRatedRestaurants.UseVisualStyleBackColor = true;
            this.btnShowRatedRestaurants.Click += new System.EventHandler(this.btnShowRatedRestaurants_Click);
            // 
            // btnShowRestaurantList
            // 
            this.btnShowRestaurantList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRestaurantList.Location = new System.Drawing.Point(89, 278);
            this.btnShowRestaurantList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowRestaurantList.Name = "btnShowRestaurantList";
            this.btnShowRestaurantList.Size = new System.Drawing.Size(302, 64);
            this.btnShowRestaurantList.TabIndex = 3;
            this.btnShowRestaurantList.Text = "Restaurants\' list";
            this.btnShowRestaurantList.UseVisualStyleBackColor = true;
            this.btnShowRestaurantList.Click += new System.EventHandler(this.btnShowRestaurantList_Click);
            // 
            // btnShowFavorites
            // 
            this.btnShowFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFavorites.Location = new System.Drawing.Point(89, 358);
            this.btnShowFavorites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFavorites.Name = "btnShowFavorites";
            this.btnShowFavorites.Size = new System.Drawing.Size(302, 64);
            this.btnShowFavorites.TabIndex = 4;
            this.btnShowFavorites.Text = "Favourite restaurants";
            this.btnShowFavorites.UseVisualStyleBackColor = true;
            this.btnShowFavorites.Click += new System.EventHandler(this.btnShowFavorites_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome, ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(592, 211);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(0, 29);
            this.nameBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(664, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowFavorites);
            this.Controls.Add(this.btnShowRestaurantList);
            this.Controls.Add(this.btnShowRatedRestaurants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRateRestaurant);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRateRestaurant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowRatedRestaurants;
        private System.Windows.Forms.Button btnShowRestaurantList;
        private System.Windows.Forms.Button btnShowFavorites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.Button button1;
    }
}