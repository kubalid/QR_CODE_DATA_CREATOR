namespace QR_CODE_DATA_CREATOR
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
            BaseX = new TextBox();
            BaseY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NextX = new TextBox();
            NextY = new TextBox();
            label3 = new Label();
            label4 = new Label();
            NextStepBTN = new Button();
            SaveBTN = new Button();
            saveFileDialog1 = new SaveFileDialog();
            dataGridViewSteps = new DataGridView();
            SaveBaseBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSteps).BeginInit();
            SuspendLayout();
            // 
            // BaseX
            // 
            BaseX.Location = new Point(25, 60);
            BaseX.Name = "BaseX";
            BaseX.Size = new Size(100, 23);
            BaseX.TabIndex = 0;
            // 
            // BaseY
            // 
            BaseY.Location = new Point(257, 60);
            BaseY.Name = "BaseY";
            BaseY.Size = new Size(100, 23);
            BaseY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Wartość początkowa X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 42);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 3;
            label2.Text = "Wartość początkowa Y";
            // 
            // NextX
            // 
            NextX.Location = new Point(25, 155);
            NextX.Name = "NextX";
            NextX.Size = new Size(100, 23);
            NextX.TabIndex = 4;
            // 
            // NextY
            // 
            NextY.Location = new Point(257, 155);
            NextY.Name = "NextY";
            NextY.Size = new Size(100, 23);
            NextY.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 6;
            label3.Text = "Następny punkt w osi X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 134);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 7;
            label4.Text = "Następny punkt w osi Y";
            // 
            // NextStepBTN
            // 
            NextStepBTN.Location = new Point(136, 182);
            NextStepBTN.Name = "NextStepBTN";
            NextStepBTN.Size = new Size(100, 31);
            NextStepBTN.TabIndex = 8;
            NextStepBTN.Text = "Następny krok";
            NextStepBTN.UseVisualStyleBackColor = true;
            NextStepBTN.Click += NextStepBTN_Click;
            // 
            // SaveBTN
            // 
            SaveBTN.Location = new Point(136, 230);
            SaveBTN.Name = "SaveBTN";
            SaveBTN.Size = new Size(100, 31);
            SaveBTN.TabIndex = 9;
            SaveBTN.Text = "Zapisz";
            SaveBTN.UseVisualStyleBackColor = true;
            SaveBTN.Click += SaveBTN_Click;
            // 
            // dataGridViewSteps
            // 
            dataGridViewSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSteps.Location = new Point(25, 283);
            dataGridViewSteps.Name = "dataGridViewSteps";
            dataGridViewSteps.Size = new Size(332, 226);
            dataGridViewSteps.TabIndex = 11;
            dataGridViewSteps.CellClick += dataGridViewSteps_CellClick;
            // 
            // SaveBaseBTN
            // 
            SaveBaseBTN.Location = new Point(136, 86);
            SaveBaseBTN.Name = "SaveBaseBTN";
            SaveBaseBTN.Size = new Size(100, 45);
            SaveBaseBTN.TabIndex = 12;
            SaveBaseBTN.Text = "Zapisz wartości początkowe";
            SaveBaseBTN.UseVisualStyleBackColor = true;
            SaveBaseBTN.Click += SaveBaseBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 521);
            Controls.Add(SaveBaseBTN);
            Controls.Add(dataGridViewSteps);
            Controls.Add(SaveBTN);
            Controls.Add(NextStepBTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NextY);
            Controls.Add(NextX);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BaseY);
            Controls.Add(BaseX);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSteps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BaseX;
        private TextBox BaseY;
        private Label label1;
        private Label label2;
        private TextBox NextX;
        private TextBox NextY;
        private Label label3;
        private Label label4;
        private Button NextStepBTN;
        private Button SaveBTN;
        private SaveFileDialog saveFileDialog1;
        private DataGridView dataGridViewSteps;
        private Button SaveBaseBTN;
    }
}
