using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace lab7_2
{
    public partial class Form1 : Form
    {
        [Serializable]
        class Scanner
        {
            public int ID { get; set; }
            public double Weight { get; set; }
            public string Type { get; set; }
            public string Company { get; set; }

            public Scanner(int id, double weight, string type, string company)
            {
                ID = id;
                Weight = weight;
                Type = type;
                Company = company;
            }
        }
        public Form1()
        {
            InitializeComponent();
            data.ColumnCount = 4;
            data.Columns[0].HeaderText = "ID";
            data.Columns[0].ValueType = typeof(int);
            data.Columns[1].HeaderText = "Weight";
            data.Columns[1].ValueType = typeof(double);
            data.Columns[2].HeaderText = "Type";
            data.Columns[3].HeaderText = "Company";
            sorting_method.SelectedIndex = 0;
        }

        static void BubbleSort(List<Scanner> scanners, int column)
        {
            for (int i = 0; i < scanners.Count - 1; i++)
            {
                for (int j = 0; j < scanners.Count - 1 - i; j++)
                {
                    bool swap = false;
                    if (column == 1) swap = scanners[j].ID > scanners[j + 1].ID;
                    else if (column == 2) swap = scanners[j].Weight > scanners[j + 1].Weight;
                    else if (column == 3) swap = String.Compare(scanners[j].Type, scanners[j + 1].Type) > 0;
                    else if (column == 4) swap = String.Compare(scanners[j].Company, scanners[j + 1].Company) > 0;

                    if (swap)
                    {
                        Scanner temp = scanners[j];
                        scanners[j] = scanners[j + 1];
                        scanners[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectSort(List<Scanner> scanners, int column)
        {
            for (int i = 0; i < scanners.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < scanners.Count; j++)
                {
                    if (column == 1) minIndex = scanners[j].ID < scanners[minIndex].ID ? j : minIndex;
                    else if (column == 2) minIndex = scanners[j].Weight < scanners[minIndex].Weight ? j : minIndex;
                    else if (column == 3) minIndex = String.Compare(scanners[j].Type, scanners[minIndex].Type) < 0 ? j : minIndex;
                    else if (column == 4) minIndex = String.Compare(scanners[j].Company, scanners[minIndex].Company) < 0 ? j : minIndex;
                }

                if (minIndex != i)
                {
                    Scanner temp = scanners[i];
                    scanners[i] = scanners[minIndex];
                    scanners[minIndex] = temp;
                }
            }
        }

        static void CocktailSort(List<Scanner> scanners, int column)
        {
            int left = 0;
            int right = scanners.Count - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    int swap = Compare(scanners[i], scanners[i + 1], column);

                    if (swap > 0)
                    {
                        Scanner temp = scanners[i];
                        scanners[i] = scanners[i + 1];
                        scanners[i + 1] = temp;
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    int swap = Compare(scanners[i], scanners[i + 1], column);

                    if (swap > 0)
                    {
                        Scanner temp = scanners[i];
                        scanners[i] = scanners[i - 1];
                        scanners[i - 1] = temp;
                    }
                }
                left++;
            }
        }

        static void InsertionSort(List<Scanner> scanners, int column)
        {
            for (int i = 1; i < scanners.Count; i++)
            {
                Scanner key = scanners[i];
                int j = i - 1;

                while (j >= 0 && Compare(scanners[j], key, column) > 0)
                {
                    scanners[j + 1] = scanners[j];
                    j = j - 1;
                }
                scanners[j + 1] = key;
            }
        }

        static void ShellSort(List<Scanner> scanners, int column)
        {
            int n = scanners.Count;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    Scanner temp = scanners[i];
                    int j = i;

                    while (j >= gap && Compare(scanners[j - gap], temp, column) > 0)
                    {
                        scanners[j] = scanners[j - gap];
                        j = j - gap;
                    }
                    scanners[j] = temp;
                }
                gap = gap / 2;
            }
        }

        private static int Compare(Scanner a, Scanner b, int column)
        {
            if (column == 1) return a.ID.CompareTo(b.ID);
            else if (column == 2) return a.Weight.CompareTo(b.Weight);
            else if (column == 3) return string.Compare(a.Type, b.Type);
            else if (column == 4) return string.Compare(a.Company, b.Company);
            else return 0;
        }

        private void PopulateDataGridView(List<Scanner> list)
        {

            // Fill the DataGridView with the data from the list.
            foreach (var item in list)
            {
                int n = data.Rows.Add();
                data.Rows[n].Cells[0].Value = item.ID;
                data.Rows[n].Cells[1].Value = item.Weight;
                data.Rows[n].Cells[2].Value = item.Type;
                data.Rows[n].Cells[3].Value = item.Company;
            }
        }
        public void Randomize()
        {
            Random random = new Random();
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                if (data.Rows[i].Cells[0].Value == null)
                {
                    data.Rows[i].Cells[0].Value = random.Next(1, 100000).ToString();
                }
                if (data.Rows[i].Cells[1].Value == null)
                {
                    data.Rows[i].Cells[1].Value = Convert.ToInt32((10 / random.NextDouble())).ToString();
                }
                if (data.Rows[i].Cells[2].Value == null)
                {
                    var list = new List<string> { "Xerox", "Acer", "Epson", "Kodak" };
                    int index = random.Next(list.Count);
                    data.Rows[i].Cells[2].Value = list[index];
                }
                if (data.Rows[i].Cells[3].Value == null)
                {
                    var list = new List<string> { "Drum", "Slide", "Flatbed", "Sheetfeed" };
                    int index = random.Next(list.Count);
                    data.Rows[i].Cells[3].Value = list[index];
                }
            }
        }


        bool is_sorted = false;
        List<Scanner> original_scanners = new List<Scanner>();
        List<Scanner> scanners = new List<Scanner>();
        BindingList<Scanner> result = new BindingList<Scanner>();

        private void sorting_button_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            // очищение массива
            scanners.Clear();
            // добавление данных в массив
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                if (data.Rows[i].Cells[0].Value != null)
                {
                    Scanner _ = new Scanner(Convert.ToInt32(data.Rows[i].Cells[0].Value), Convert.ToDouble(data.Rows[i].Cells[1].Value), data.Rows[i].Cells[2].Value.ToString(), data.Rows[i].Cells[3].Value.ToString());
                    scanners.Add(_);
                }
                else
                {
                    break;
                }
            }
            // определение нажатой кнопки
            string pressed_button_text = (sender as Button).Text;
            string[] pressed_buttons = { "ID", "Weight", "Type", "Company" };
            int column = Array.IndexOf(pressed_buttons, pressed_button_text) + 1;
            int method = sorting_method.SelectedIndex;
            if (method == 0)
            {
                BubbleSort(scanners, column);
            }
            else if (method == 1)
            {
                SelectSort(scanners, column);
            }
            else if (method == 2)
            {
                InsertionSort(scanners, column);
            }
            else if (method == 3)
            {
                CocktailSort(scanners, column);
            }
            else
            {
                ShellSort(scanners, column);
            }
            data.Rows.Clear();
            for (int i = 0; i < scanners.Count; i++)
            {
                data.Rows.Add(scanners[i].ID.ToString(), scanners[i].Weight.ToString(), scanners[i].Type, scanners[i].Company);
            }
            stopWatch.Stop();
            MessageBox.Show(stopWatch.Elapsed.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Randomize();
        }
        static void SaveScannersToBinaryFile(List<Scanner> scanners)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("scanners.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(fileStream, scanners);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // очищение массива
            scanners.Clear();
            // добавление данных в массив
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                if (data.Rows[i].Cells[0].Value != null)
                {
                    Scanner _ = new Scanner(Convert.ToInt32(data.Rows[i].Cells[0].Value), Convert.ToDouble(data.Rows[i].Cells[1].Value), data.Rows[i].Cells[2].Value.ToString(), data.Rows[i].Cells[3].Value.ToString());
                    scanners.Add(_);
                }
                else
                {
                    break;
                }
            }
            SaveScannersToBinaryFile(scanners);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists("scanners.bin"))
            {
                MessageBox.Show("File not found. Please make sure the binary file is in the same directory as the program.");
                return;
            }
            // Read binary file
            using (Stream stream = File.Open("scanners.bin", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                scanners = (List<Scanner>)formatter.Deserialize(stream);
            }

            data.Rows.Clear();
            for (int i = 0; i < scanners.Count; i++)
            {
                data.Rows.Add(scanners[i].ID.ToString(), scanners[i].Weight.ToString(), scanners[i].Type, scanners[i].Company);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            original_scanners.Clear();
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                if (data.Rows[i].Cells[0].Value != null)
                {
                    Scanner _ = new Scanner(Convert.ToInt32(data.Rows[i].Cells[0].Value), Convert.ToDouble(data.Rows[i].Cells[1].Value), data.Rows[i].Cells[2].Value.ToString(), data.Rows[i].Cells[3].Value.ToString());
                    original_scanners.Add(_);
                }
                else
                {
                    break;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();
            for (int i = 0; i < original_scanners.Count; i++)
            {
                data.Rows.Add(original_scanners[i].ID.ToString(), original_scanners[i].Weight.ToString(), original_scanners[i].Type, original_scanners[i].Company);
            }
        }
    }
}