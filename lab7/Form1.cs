namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        List<string> string_list = new List<string>();
        bool is_int = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text != "")
            {
                if (is_int)
                {
                    int number = Convert.ToInt32(TxtBox.Text);
                    list.Add(number);
                    MainLabel.Text = String.Join(", ", list);
                }
                else
                {
                    string number = TxtBox.Text;
                    string_list.Add(number);
                    MainLabel.Text = String.Join(", ", string_list);
                }

            }
            else
            {
                MessageBox.Show("¬ведите элемент", "ќшибка ввода", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Clear();
            MainLabel.Text = String.Join(", ", list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (is_int)
            {
                IntSorting sorting = new IntSorting();
                var result = sorting.CurrentChoiceSort(list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
            else
            {
                StringSorting sorting = new StringSorting();
                var result = sorting.BubbleSort(string_list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (is_int)
            {
                IntSorting sorting = new IntSorting();
                var result = sorting.InsertionSort(list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
            else
            {
                StringSorting sorting = new StringSorting();
                var result = sorting.BubbleSort(string_list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (is_int)
            {
                IntSorting sorting = new IntSorting();
                var result = sorting.CocktailSort(list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
            else
            {
                StringSorting sorting = new StringSorting();
                var result = sorting.BubbleSort(string_list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (is_int)
            {
                IntSorting sorting = new IntSorting();
                var result = sorting.ShellSort(list.ToArray(), list.ToArray().Length);
                MainLabel.Text = String.Join(", ", result);
            }
            else
            {
                StringSorting sorting = new StringSorting();
                var result = sorting.BubbleSort(string_list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (is_int)
            {
                IntSorting sorting = new IntSorting();
                var result = sorting.BubbleSort(list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
            else
            {
                StringSorting sorting = new StringSorting();
                var result = sorting.BubbleSort(string_list.ToArray());
                MainLabel.Text = String.Join(", ", result);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            is_int = false;
            string_list.Clear();
            list.Clear();
            MainLabel.Text = String.Join(", ", string_list);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            is_int = true;
            string_list.Clear();
            list.Clear();
            MainLabel.Text = String.Join(", ", list);

        }
    }
}