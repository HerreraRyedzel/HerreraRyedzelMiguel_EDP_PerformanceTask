namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class RemoveFoods
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
            RemoveFood = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RemoveFoodsBtn = new Button();
            RemoveResultFood = new Label();
            SuspendLayout();
            // 
            // RemoveFood
            // 
            RemoveFood.Location = new Point(93, 196);
            RemoveFood.Multiline = true;
            RemoveFood.Name = "RemoveFood";
            RemoveFood.Size = new Size(352, 36);
            RemoveFood.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(93, 173);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 43);
            label2.Name = "label2";
            label2.Size = new Size(215, 66);
            label2.TabIndex = 2;
            label2.Text = "Remove Food";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveFoodsBtn
            // 
            RemoveFoodsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveFoodsBtn.Location = new Point(210, 311);
            RemoveFoodsBtn.Name = "RemoveFoodsBtn";
            RemoveFoodsBtn.Size = new Size(124, 45);
            RemoveFoodsBtn.TabIndex = 3;
            RemoveFoodsBtn.Text = "Remove ";
            RemoveFoodsBtn.UseVisualStyleBackColor = true;
            RemoveFoodsBtn.Click += RemoveFoodsBtn_Click;
            // 
            // RemoveResultFood
            // 
            RemoveResultFood.Location = new Point(97, 239);
            RemoveResultFood.Name = "RemoveResultFood";
            RemoveResultFood.Size = new Size(348, 25);
            RemoveResultFood.TabIndex = 4;
            RemoveResultFood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RemoveFoods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 450);
            Controls.Add(RemoveResultFood);
            Controls.Add(RemoveFoodsBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RemoveFood);
            Name = "RemoveFoods";
            Text = "RemoveFoods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RemoveFood;
        private Label label1;
        private Label label2;
        private Button RemoveFoodsBtn;
        private Label RemoveResultFood;
    }
}