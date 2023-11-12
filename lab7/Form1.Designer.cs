namespace lab7
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
            TxtBox = new TextBox();
            MainLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(24, 182);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(426, 39);
            TxtBox.TabIndex = 0;
            // 
            // MainLabel
            // 
            MainLabel.Location = new Point(12, 20);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(776, 41);
            MainLabel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(259, 247);
            button1.Name = "button1";
            button1.Size = new Size(191, 59);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(505, 86);
            button2.Name = "button2";
            button2.Size = new Size(242, 39);
            button2.TabIndex = 3;
            button2.Text = "прямой выбор";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Plum;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(505, 150);
            button3.Name = "button3";
            button3.Size = new Size(242, 39);
            button3.TabIndex = 4;
            button3.Text = "прямое включение";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Plum;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(505, 207);
            button4.Name = "button4";
            button4.Size = new Size(242, 39);
            button4.TabIndex = 5;
            button4.Text = "шейкерная";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Plum;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(505, 267);
            button5.Name = "button5";
            button5.Size = new Size(242, 39);
            button5.TabIndex = 6;
            button5.Text = "Шелл";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Plum;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(24, 247);
            button6.Name = "button6";
            button6.Size = new Size(191, 59);
            button6.TabIndex = 7;
            button6.Text = "Очистить";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Plum;
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.Font = new Font("Comfortaa", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(505, 327);
            button7.Name = "button7";
            button7.Size = new Size(242, 39);
            button7.TabIndex = 8;
            button7.Text = "Пузырьковый";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(24, 103);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(111, 36);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Числа";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(170, 103);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(124, 36);
            radioButton2.TabIndex = 10;
            radioButton2.Text = "Строки";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MainLabel);
            Controls.Add(TxtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Label MainLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}