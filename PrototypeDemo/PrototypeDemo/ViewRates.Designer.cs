﻿namespace PrototypeDemo
{
    partial class ViewRates
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
            this.btnBack = new System.Windows.Forms.Button();
            this.comboRestaurantList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Evaluation = new System.Windows.Forms.ListView();
            this.MoodRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Experience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurants\' ratings";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.BackgroundImage = global::PrototypeDemo.Properties.Resources.kisspng_arrow_computer_icons_clip_art_scalable_vector_grap_return_arrow_svg_png_icon_free_download_72268_5cd6cd8be41546_5477184415575811959342;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(745, 403);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 39);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboRestaurantList
            // 
            this.comboRestaurantList.AllowDrop = true;
            this.comboRestaurantList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRestaurantList.FormattingEnabled = true;
            this.comboRestaurantList.Location = new System.Drawing.Point(422, 128);
            this.comboRestaurantList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboRestaurantList.Name = "comboRestaurantList";
            this.comboRestaurantList.Size = new System.Drawing.Size(336, 24);
            this.comboRestaurantList.TabIndex = 3;
            this.comboRestaurantList.SelectedIndexChanged += new System.EventHandler(this.comboRestaurantList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select restaurant";
            // 
            // listView_Evaluation
            // 
<<<<<<< HEAD
            this.listView_Evaluation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MoodRating,
            this.Price,
            this.Experience});
            this.listView_Evaluation.FullRowSelect = true;
            this.listView_Evaluation.GridLines = true;
            this.listView_Evaluation.HideSelection = false;
            this.listView_Evaluation.Location = new System.Drawing.Point(41, 159);
            this.listView_Evaluation.Name = "listView_Evaluation";
            this.listView_Evaluation.Size = new System.Drawing.Size(503, 195);
            this.listView_Evaluation.TabIndex = 5;
            this.listView_Evaluation.UseCompatibleStateImageBehavior = false;
            this.listView_Evaluation.View = System.Windows.Forms.View.Details;
            this.listView_Evaluation.SelectedIndexChanged += new System.EventHandler(this.listView_Evaluation_SelectedIndexChanged);
            // 
            // MoodRating
            // 
            this.MoodRating.Text = "MoodRating";
            this.MoodRating.Width = 184;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 140;
            // 
            // Experience
            // 
            this.Experience.Text = "Experience";
            this.Experience.Width = 169;
=======
            this.RatingListBox.FormattingEnabled = true;
            this.RatingListBox.ItemHeight = 16;
            this.RatingListBox.Location = new System.Drawing.Point(252, 250);
            this.RatingListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RatingListBox.Name = "RatingListBox";
            this.RatingListBox.Size = new System.Drawing.Size(291, 164);
            this.RatingListBox.TabIndex = 6;
            this.RatingListBox.SelectedIndexChanged += new System.EventHandler(this.RatingListBox_SelectedIndexChanged);
>>>>>>> 4b6a960bf4287f6120459ae5c3f0abbab9efa8b4
            // 
            // ViewRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(609, 371);
            this.Controls.Add(this.listView_Evaluation);
=======
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.RatingListBox);
>>>>>>> 4b6a960bf4287f6120459ae5c3f0abbab9efa8b4
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboRestaurantList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRates";
            this.Load += new System.EventHandler(this.ViewRates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboRestaurantList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Evaluation;
        private System.Windows.Forms.ColumnHeader MoodRating;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Experience;
    }
}