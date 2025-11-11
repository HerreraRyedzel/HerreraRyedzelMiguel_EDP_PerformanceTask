namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class Orders
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
            FoodList = new ListView();
            DrinkList = new ListView();
            label2 = new Label();
            label3 = new Label();
            OrderBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 41);
            label1.Name = "label1";
            label1.Size = new Size(196, 61);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FoodList
            // 
            FoodList.Location = new Point(53, 173);
            FoodList.Name = "FoodList";
            FoodList.Size = new Size(186, 229);
            FoodList.TabIndex = 1;
            FoodList.UseCompatibleStateImageBehavior = false;
            // 
            // DrinkList
            // 
            DrinkList.Location = new Point(319, 173);
            DrinkList.Name = "DrinkList";
            DrinkList.Size = new Size(186, 229);
            DrinkList.TabIndex = 2;
            DrinkList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 132);
            label2.Name = "label2";
            label2.Size = new Size(186, 38);
            label2.TabIndex = 3;
            label2.Text = "Food";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 132);
            label3.Name = "label3";
            label3.Size = new Size(186, 38);
            label3.TabIndex = 4;
            label3.Text = "Drink";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderBtn
            // 
            OrderBtn.Location = new Point(232, 434);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(93, 48);
            OrderBtn.TabIndex = 5;
            OrderBtn.Text = "Order";
            OrderBtn.UseVisualStyleBackColor = true;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 506);
            Controls.Add(OrderBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DrinkList);
            Controls.Add(FoodList);
            Controls.Add(label1);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListView FoodList;
        private ListView DrinkList;
        private Label label2;
        private Label label3;
        private Button OrderBtn;
    }
}