namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class RemoveDrinks
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
            RemoveDrink = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RemoveDrinksBtn = new Button();
            RemoveResultDrinks = new Label();
            SuspendLayout();
            // 
            // RemoveDrink
            // 
            RemoveDrink.Location = new Point(99, 203);
            RemoveDrink.Multiline = true;
            RemoveDrink.Name = "RemoveDrink";
            RemoveDrink.Size = new Size(345, 40);
            RemoveDrink.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(99, 175);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 38);
            label2.Name = "label2";
            label2.Size = new Size(234, 68);
            label2.TabIndex = 2;
            label2.Text = "Remove Drinks";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveDrinksBtn
            // 
            RemoveDrinksBtn.Location = new Point(210, 305);
            RemoveDrinksBtn.Name = "RemoveDrinksBtn";
            RemoveDrinksBtn.Size = new Size(108, 48);
            RemoveDrinksBtn.TabIndex = 3;
            RemoveDrinksBtn.Text = "Remove";
            RemoveDrinksBtn.UseVisualStyleBackColor = true;
            RemoveDrinksBtn.Click += RemoveDrinksBtn_Click;
            // 
            // RemoveResultDrinks
            // 
            RemoveResultDrinks.Location = new Point(99, 246);
            RemoveResultDrinks.Name = "RemoveResultDrinks";
            RemoveResultDrinks.Size = new Size(345, 25);
            RemoveResultDrinks.TabIndex = 4;
            RemoveResultDrinks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveDrinks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(RemoveResultDrinks);
            Controls.Add(RemoveDrinksBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RemoveDrink);
            Name = "RemoveDrinks";
            Text = "RemoveDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RemoveDrink;
        private Label label1;
        private Label label2;
        private Button RemoveDrinksBtn;
        private Label RemoveResultDrinks;
    }
}