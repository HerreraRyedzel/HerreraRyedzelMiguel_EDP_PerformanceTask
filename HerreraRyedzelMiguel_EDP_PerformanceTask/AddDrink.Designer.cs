namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class AddDrink
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
            AddDrinkName = new TextBox();
            DrinkPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddDrinksBtn = new Button();
            AddResultDrinks = new Label();
            SuspendLayout();
            // 
            // AddDrinkName
            // 
            AddDrinkName.Location = new Point(29, 137);
            AddDrinkName.Multiline = true;
            AddDrinkName.Name = "AddDrinkName";
            AddDrinkName.Size = new Size(222, 46);
            AddDrinkName.TabIndex = 0;
            // 
            // DrinkPrice
            // 
            DrinkPrice.Location = new Point(257, 137);
            DrinkPrice.Multiline = true;
            DrinkPrice.Name = "DrinkPrice";
            DrinkPrice.Size = new Size(146, 46);
            DrinkPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 25);
            label1.Name = "label1";
            label1.Size = new Size(176, 41);
            label1.TabIndex = 2;
            label1.Text = "Add Drinks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 3;
            label2.Text = "Drinks Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(257, 106);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            label3.Click += label3_Click;
            // 
            // AddDrinksBtn
            // 
            AddDrinksBtn.Location = new Point(146, 258);
            AddDrinksBtn.Name = "AddDrinksBtn";
            AddDrinksBtn.Size = new Size(124, 52);
            AddDrinksBtn.TabIndex = 6;
            AddDrinksBtn.Text = "Add";
            AddDrinksBtn.UseVisualStyleBackColor = true;
            AddDrinksBtn.Click += AddDrinksBtn_Click;
            // 
            // AddResultDrinks
            // 
            AddResultDrinks.Location = new Point(29, 200);
            AddResultDrinks.Name = "AddResultDrinks";
            AddResultDrinks.Size = new Size(374, 25);
            AddResultDrinks.TabIndex = 7;
            AddResultDrinks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddDrink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(AddResultDrinks);
            Controls.Add(AddDrinksBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DrinkPrice);
            Controls.Add(AddDrinkName);
            Name = "AddDrink";
            Text = "AddDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddDrinkName;
        private TextBox DrinkPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddDrinksBtn;
        private Label AddResultDrinks;
    }
}