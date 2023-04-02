using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DataStructuresAssignment
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Song", "Song");
            dataGridView1.Columns.Add("Artist", "Artist");
            dataGridView1.Columns.Add("Streams (Billions)", "Streams (Billions)");
            dataGridView1.Columns.Add("Release Date", "Release Date");

            //data = ShellSort(data);

            dataGridView1.Rows.Clear();
            foreach (string[] row in data)
            {
                dataGridView1.Rows.Add(row);
            }
        }
        private List<string[]> LoadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    data.Add(values);
                }
            }

            // Sort the data by the song name
            data.Sort((x, y) => string.Compare(x[0], y[0], StringComparison.OrdinalIgnoreCase));

            return data;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
                List<string[]> data = LoadCSV(filePath);

                string[] result = BinarySearch(data, searchTerm);

                if (result != null)
                {
                    MessageBox.Show($"Song: {result[0]}\nArtist: {result[1]}\nStreams (Billions): {result[2]}\nRelease Date: {result[3]}");
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }

        private string[] BinarySearch(List<string[]> data, string searchTerm)
        {
            string[] result = null;

            int left = 0;
            int right = data.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compareResult = string.Compare(data[mid][0], searchTerm, StringComparison.OrdinalIgnoreCase);

                if (compareResult == 0)
                {
                    result = data[mid];
                    break;
                }
                else if (compareResult < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
        private void AddRowButton_Click(object sender, EventArgs e)
        {

            string[] newRow = new string[] { "New Song", "New Artist", "0.5", "2023-03-24" };
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);
            data.Add(newRow);


            dataGridView1.Rows.Clear();
            foreach (string[] row in data)
            {
                dataGridView1.Rows.Add(row);
            }

            using (var writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine(string.Join(",", newRow));
            }
        }

        private void RemoveRowButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }
        private void SortByArtistButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Song", "Song");
            dataGridView1.Columns.Add("Artist", "Artist");
            dataGridView1.Columns.Add("Streams (Billions)", "Streams (Billions)");
            dataGridView1.Columns.Add("Release Date", "Release Date");

            //data = ShellSort(data);

            foreach (string[] row in data)
            {
                dataGridView1.Rows.Add(row);
            }
        }
        /*private List<string[]> ShellSort(List<string[]> data)
        {
            int n = data.Count;
            int gap = n / 2;

            // Start the timer
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    string[] temp = data[i];
                    int j = i;

                    while (j >= gap && string.Compare(data[j - gap][1], temp[1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        data[j] = data[j - gap];
                        j -= gap;
                    }

                    data[j] = temp;
                }

                gap /= 2;
            }

            // Stop the timer and calculate the elapsed time
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine($"ShellSort took {elapsedTime.TotalMilliseconds} milliseconds");

            return data;
        }*/

        private void BubbleSort(List<string[]> data)
        {
            int n = data.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (float.Parse(data[j][2]) > float.Parse(data[j + 1][2]))
                    {
                        // swap data[j] and data[j+1]
                        string[] temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        private void SortByStreamsButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            BubbleSort(data);

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Song", "Song");
            dataGridView1.Columns.Add("Artist", "Artist");
            dataGridView1.Columns.Add("Streams (Billions)", "Streams (Billions)");
            dataGridView1.Columns.Add("Release Date", "Release Date");

            foreach (string[] row in data)
            {
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
