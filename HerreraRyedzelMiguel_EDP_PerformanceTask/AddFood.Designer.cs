namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class AddFood
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
            AddFoodName = new TextBox();
            FoodPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddFoodsBtn = new Button();
            AddResultFood = new Label();
            SuspendLayout();
            // 
            // AddFoodName
            // 
            AddFoodName.Location = new Point(28, 136);
            AddFoodName.Multiline = true;
            AddFoodName.Name = "AddFoodName";
            AddFoodName.Size = new Size(255, 43);
            AddFoodName.TabIndex = 0;
            // 
            // FoodPrice
            // 
            FoodPrice.Location = new Point(289, 136);
            FoodPrice.Multiline = true;
            FoodPrice.Name = "FoodPrice";
            FoodPrice.Size = new Size(121, 43);
            FoodPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 105);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 2;
            label1.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 3;
            label2.Text = "Food Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(130, 23);
            label3.Name = "label3";
            label3.Size = new Size(176, 46);
            label3.TabIndex = 4;
            label3.Text = "Add Food";
            // 
            // AddFoodsBtn
            // 
            AddFoodsBtn.Location = new Point(163, 243);
            AddFoodsBtn.Name = "AddFoodsBtn";
            AddFoodsBtn.Size = new Size(120, 44);
            AddFoodsBtn.TabIndex = 5;
            AddFoodsBtn.Text = "Add";
            AddFoodsBtn.UseVisualStyleBackColor = true;
            AddFoodsBtn.Click += AddFoodsBtn_Click;
            // 
            // AddResultFood
            // 
            AddResultFood.Location = new Point(28, 192);
            AddResultFood.Name = "AddResultFood";
            AddResultFood.Size = new Size(382, 25);
            AddResultFood.TabIndex = 6;
            AddResultFood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 421);
            Controls.Add(AddResultFood);
            Controls.Add(AddFoodsBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FoodPrice);
            Controls.Add(AddFoodName);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddFoodName;
        private TextBox FoodPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddFoodsBtn;
        private Label AddResultFood;
    }
}