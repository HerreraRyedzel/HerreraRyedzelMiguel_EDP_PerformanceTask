namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class Products
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
            label1 = new Label();
            DrinkListView = new ListView();
            AddFoodBtn = new Button();
            RemoveFoodBtn = new Button();
            AddDrinkBtn = new Button();
            RemoveDrinkBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            FoodListView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 71);
            label1.TabIndex = 0;
            label1.Text = "Product";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DrinkListView
            // 
            DrinkListView.Location = new Point(328, 132);
            DrinkListView.Name = "DrinkListView";
            DrinkListView.Size = new Size(227, 292);
            DrinkListView.TabIndex = 2;
            DrinkListView.UseCompatibleStateImageBehavior = false;
            // 
            // AddFoodBtn
            // 
            AddFoodBtn.Location = new Point(21, 443);
            AddFoodBtn.Name = "AddFoodBtn";
            AddFoodBtn.Size = new Size(94, 46);
            AddFoodBtn.TabIndex = 3;
            AddFoodBtn.Text = "Add";
            AddFoodBtn.UseVisualStyleBackColor = true;
            AddFoodBtn.Click += AddFoodBtn_Click;
            // 
            // RemoveFoodBtn
            // 
            RemoveFoodBtn.Location = new Point(154, 443);
            RemoveFoodBtn.Name = "RemoveFoodBtn";
            RemoveFoodBtn.Size = new Size(94, 46);
            RemoveFoodBtn.TabIndex = 4;
            RemoveFoodBtn.Text = "Remove";
            RemoveFoodBtn.UseVisualStyleBackColor = true;
            RemoveFoodBtn.Click += RemoveFoodBtn_Click;
            // 
            // AddDrinkBtn
            // 
            AddDrinkBtn.Location = new Point(328, 443);
            AddDrinkBtn.Name = "AddDrinkBtn";
            AddDrinkBtn.Size = new Size(94, 46);
            AddDrinkBtn.TabIndex = 5;
            AddDrinkBtn.Text = "Add";
            AddDrinkBtn.UseVisualStyleBackColor = true;
            AddDrinkBtn.Click += AddDrinkBtn_Click;
            // 
            // RemoveDrinkBtn
            // 
            RemoveDrinkBtn.Location = new Point(461, 443);
            RemoveDrinkBtn.Name = "RemoveDrinkBtn";
            RemoveDrinkBtn.Size = new Size(94, 46);
            RemoveDrinkBtn.TabIndex = 6;
            RemoveDrinkBtn.Text = "Remove";
            RemoveDrinkBtn.UseVisualStyleBackColor = true;
            RemoveDrinkBtn.Click += RemoveDrinkBtn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(227, 49);
            label2.TabIndex = 7;
            label2.Text = "Food";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 80);
            label3.Name = "label3";
            label3.Size = new Size(227, 49);
            label3.TabIndex = 8;
            label3.Text = "Drink";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoodListView
            // 
            FoodListView.Location = new Point(21, 132);
            FoodListView.Name = "FoodListView";
            FoodListView.Size = new Size(227, 292);
            FoodListView.TabIndex = 9;
            FoodListView.UseCompatibleStateImageBehavior = false;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 501);
            Controls.Add(FoodListView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RemoveDrinkBtn);
            Controls.Add(AddDrinkBtn);
            Controls.Add(RemoveFoodBtn);
            Controls.Add(AddFoodBtn);
            Controls.Add(DrinkListView);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListView FoodList;
        private ListView DrinkListView;
        private Button AddFoodBtn;
        private Button RemoveFoodBtn;
        private Button AddDrinkBtn;
        private Button RemoveDrinkBtn;
        private Label label2;
        private Label label3;
        private ListView FoodListView;
    }
}