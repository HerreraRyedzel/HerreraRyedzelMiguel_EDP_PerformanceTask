namespace HerreraRyedzelMiguel_EDP_PerformanceTask
{
    partial class ProcessOrder
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
            SearchOrder = new TextBox();
            AddOrderBtn = new Button();
            RemoveOrderBtn = new Button();
            ProcessOrderList = new ListView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PaymentAmount = new TextBox();
            PayBtn = new Button();
            TotalResult = new Label();
            ChangeResult = new Label();
            TotalOrderAmount = new Label();
            ChangeAmount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 32);
            label1.Name = "label1";
            label1.Size = new Size(292, 75);
            label1.TabIndex = 0;
            label1.Text = "Process Order";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchOrder
            // 
            SearchOrder.Location = new Point(105, 123);
            SearchOrder.Multiline = true;
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(339, 36);
            SearchOrder.TabIndex = 1;
            // 
            // AddOrderBtn
            // 
            AddOrderBtn.Location = new Point(280, 165);
            AddOrderBtn.Name = "AddOrderBtn";
            AddOrderBtn.Size = new Size(79, 29);
            AddOrderBtn.TabIndex = 2;
            AddOrderBtn.Text = "Add";
            AddOrderBtn.UseVisualStyleBackColor = true;
            AddOrderBtn.Click += AddOrderBtn_Click;
            // 
            // RemoveOrderBtn
            // 
            RemoveOrderBtn.Location = new Point(365, 165);
            RemoveOrderBtn.Name = "RemoveOrderBtn";
            RemoveOrderBtn.Size = new Size(79, 29);
            RemoveOrderBtn.TabIndex = 3;
            RemoveOrderBtn.Text = "Remove";
            RemoveOrderBtn.UseVisualStyleBackColor = true;
            RemoveOrderBtn.Click += RemoveOrderBtn_Click;
            // 
            // ProcessOrderList
            // 
            ProcessOrderList.Location = new Point(105, 218);
            ProcessOrderList.Name = "ProcessOrderList";
            ProcessOrderList.Size = new Size(339, 194);
            ProcessOrderList.TabIndex = 4;
            ProcessOrderList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.Location = new Point(105, 415);
            label2.Name = "label2";
            label2.Size = new Size(51, 32);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(105, 447);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 6;
            label3.Text = "Payment:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(105, 477);
            label4.Name = "label4";
            label4.Size = new Size(68, 32);
            label4.TabIndex = 7;
            label4.Text = "Change:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentAmount
            // 
            PaymentAmount.Location = new Point(179, 447);
            PaymentAmount.Multiline = true;
            PaymentAmount.Name = "PaymentAmount";
            PaymentAmount.Size = new Size(166, 30);
            PaymentAmount.TabIndex = 8;
            // 
            // PayBtn
            // 
            PayBtn.Location = new Point(365, 446);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(79, 29);
            PayBtn.TabIndex = 9;
            PayBtn.Text = "Pay";
            PayBtn.UseVisualStyleBackColor = true;
            PayBtn.Click += PayBtn_Click;
            // 
            // TotalResult
            // 
            TotalResult.AutoSize = true;
            TotalResult.Location = new Point(179, 421);
            TotalResult.Name = "TotalResult";
            TotalResult.Size = new Size(0, 20);
            TotalResult.TabIndex = 10;
            // 
            // ChangeResult
            // 
            ChangeResult.AutoSize = true;
            ChangeResult.Location = new Point(179, 483);
            ChangeResult.Name = "ChangeResult";
            ChangeResult.Size = new Size(0, 20);
            ChangeResult.TabIndex = 11;
            // 
            // TotalOrderAmount
            // 
            TotalOrderAmount.Location = new Point(179, 421);
            TotalOrderAmount.Name = "TotalOrderAmount";
            TotalOrderAmount.Size = new Size(166, 25);
            TotalOrderAmount.TabIndex = 12;
            // 
            // ChangeAmount
            // 
            ChangeAmount.Location = new Point(179, 480);
            ChangeAmount.Name = "ChangeAmount";
            ChangeAmount.Size = new Size(166, 25);
            ChangeAmount.TabIndex = 13;
            // 
            // ProcessOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 518);
            Controls.Add(ChangeAmount);
            Controls.Add(TotalOrderAmount);
            Controls.Add(ChangeResult);
            Controls.Add(TotalResult);
            Controls.Add(PayBtn);
            Controls.Add(PaymentAmount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProcessOrderList);
            Controls.Add(RemoveOrderBtn);
            Controls.Add(AddOrderBtn);
            Controls.Add(SearchOrder);
            Controls.Add(label1);
            Name = "ProcessOrder";
            Text = "ProcessOrder";
            Load += ProcessOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchOrder;
        private Button AddOrderBtn;
        private Button RemoveOrderBtn;
        private ListView ProcessOrderList;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox PaymentAmount;
        private Button PayBtn;
        private Label TotalResult;
        private Label ChangeResult;
        private Label TotalOrderAmount;
        private Label ChangeAmount;
    }
}