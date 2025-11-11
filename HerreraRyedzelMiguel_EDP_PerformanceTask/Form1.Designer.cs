namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            VIewProductBtn = new Button();
            ViewOrderBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "Product Menu";
            // 
            // VIewProductBtn
            // 
            VIewProductBtn.Location = new Point(46, 103);
            VIewProductBtn.Name = "VIewProductBtn";
            VIewProductBtn.Size = new Size(145, 61);
            VIewProductBtn.TabIndex = 1;
            VIewProductBtn.Text = "View Product";
            VIewProductBtn.UseVisualStyleBackColor = true;
            VIewProductBtn.Click += VIewProductBtn_Click;
            // 
            // ViewOrderBtn
            // 
            ViewOrderBtn.Location = new Point(46, 203);
            ViewOrderBtn.Name = "ViewOrderBtn";
            ViewOrderBtn.Size = new Size(145, 61);
            ViewOrderBtn.TabIndex = 2;
            ViewOrderBtn.Text = "Order";
            ViewOrderBtn.UseVisualStyleBackColor = true;
            ViewOrderBtn.Click += ViewOrderBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 342);
            Controls.Add(ViewOrderBtn);
            Controls.Add(VIewProductBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Product Menu";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button VIewProductBtn;
        private Button ViewOrderBtn;
    }
}
