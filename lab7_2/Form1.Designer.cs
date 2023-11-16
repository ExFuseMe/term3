namespace lab7_2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button5 = new Button();
            button7 = new Button();
            sorting_method = new ComboBox();
            data = new DataGridView();
            button6 = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(96, 12);
            button1.Name = "button1";
            button1.Size = new Size(198, 46);
            button1.TabIndex = 0;
            button1.Text = "ID";
            button1.UseVisualStyleBackColor = false;
            button1.Click += sorting_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(294, 12);
            button2.Name = "button2";
            button2.Size = new Size(199, 46);
            button2.TabIndex = 1;
            button2.Text = "Weight";
            button2.UseVisualStyleBackColor = false;
            button2.Click += sorting_button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(499, 12);
            button3.Name = "button3";
            button3.Size = new Size(196, 46);
            button3.TabIndex = 2;
            button3.Text = "Type";
            button3.UseVisualStyleBackColor = false;
            button3.Click += sorting_button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Location = new Point(694, 12);
            button4.Name = "button4";
            button4.Size = new Size(201, 46);
            button4.TabIndex = 3;
            button4.Text = "Company";
            button4.UseVisualStyleBackColor = false;
            button4.Click += sorting_button_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(sorting_method);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(1221, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(241, 1111);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(3, 153);
            button5.Name = "button5";
            button5.Size = new Size(242, 46);
            button5.TabIndex = 10;
            button5.Text = "Сохранить данные";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Location = new Point(3, 49);
            button7.Name = "button7";
            button7.Size = new Size(238, 46);
            button7.TabIndex = 7;
            button7.Text = "Заполнить строки";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // sorting_method
            // 
            sorting_method.FormattingEnabled = true;
            sorting_method.Items.AddRange(new object[] { "Пузырьковая сортировка", "Сортировка прямым выбором", "Сортировка вставками", "Шейкерная сортировка", "Сортировка Шелла" });
            sorting_method.Location = new Point(3, 3);
            sorting_method.Name = "sorting_method";
            sorting_method.Size = new Size(242, 40);
            sorting_method.TabIndex = 9;
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.ColumnHeadersVisible = false;
            data.Location = new Point(96, 67);
            data.Name = "data";
            data.RowHeadersVisible = false;
            data.RowHeadersWidth = 82;
            data.RowTemplate.Height = 41;
            data.Size = new Size(811, 300);
            data.TabIndex = 5;
            // 
            // button6
            // 
            button6.Location = new Point(3, 101);
            button6.Name = "button6";
            button6.Size = new Size(238, 46);
            button6.TabIndex = 11;
            button6.Text = "Открыть данные";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 1048);
            Controls.Add(data);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button7;
        private ComboBox sorting_method;
        private DataGridView data;
        private Button button5;
        private Button button6;
    }
}