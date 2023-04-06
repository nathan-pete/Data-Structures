using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

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


        /* private double JumpSearch(double[] thirdColumnFloats, double searchTerm)
        {
            int dataSize = thirdColumnFloats.Length;
            int stepSize = (int)Math.Sqrt(dataSize);
            double prevStep = 0;
            double result = 0;

            while (thirdColumnFloats[Math.Min(stepSize, dataSize) - 1] < searchTerm)
            {
                prevStep = stepSize;
                stepSize += (int)Math.Sqrt(dataSize);
                if (prevStep >= dataSize)
                {
                    return result;
                }
            }
            
            for (double i = prevStep; i < searchTerm; i++)
            {
                prevStep++;
                double p = Math.Min(stepSize, dataSize);
                if(prevStep == p)
                {
                    return result;
                } 
                
                if (prevStep == searchTerm)
                {
                    result = prevStep;
                }
            }

            return result; 
        } */

        private void SearchBwutton_Click(object sender, EventArgs e)
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
        private void BucketSortButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
            List<string[]> data = LoadCSV(filePath);

            // Create a dictionary to store the buckets
            Dictionary<string, List<string[]>> buckets = new Dictionary<string, List<string[]>>();

            // Iterate over each row in the data and add it to the appropriate bucket
            foreach (string[] row in data)
            {
                string artist = row[1];
                if (buckets.ContainsKey(artist))
                {
                    buckets[artist].Add(row);
                }
                else
                {
                    buckets.Add(artist, new List<string[]> { row });
                }
            }

            // Sort the buckets by artist name
            List<string[]> sortedData = new List<string[]>();
            foreach (var bucket in buckets.OrderBy(x => x.Key))
            {
                sortedData.AddRange(bucket.Value);
            }

            // Clear the data grid view and add the sorted data
            dataGridView1.Rows.Clear();
            foreach (string[] row in sortedData)
            {
                dataGridView1.Rows.Add(row);
            }
        }


        /*private void SortByArtistButton_Click(object sender, EventArgs e)
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
        */



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

        /*private void JumpSearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = JumpSearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string filePath = Path.Combine(Application.StartupPath, "Streams.csv");
                List<string> thirdColumnValues = LoadThirdColumn(filePath);
                List<string[]> data = LoadCSV(filePath);
                List<string> result = LinearSearch(data, thirdColumnValues, searchTerm);
                
                if (result != null)
                {
                    MessageBox.Show($"Song: {result[0]}\nArtist: {result[1]}\nStreams (Billions): {result[2]}\nRelease Date: {result[3]}");; //\nSong: {result[1]}\nStreams (Billions): {result[2]}\nRelease Date: {result[3]}");
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }*/



        private List<string> LoadThirdColumn(string filePath)
        {
            List<string> thirdColumnValues = new List<string>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length >= 3)
                    {
                        // Extract the value in the third column (index 2)
                        string thirdColumnValue = values[2];

                        // Add the value to the list of third column values
                        thirdColumnValues.Add(thirdColumnValue);
                    }
                }
            }

            return thirdColumnValues;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = JumpSearchTextBox.Text;
            //bool isFound = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string value = row.Cells["Streams (Billions)"].Value.ToString();

                if (value.Equals(searchTerm))
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    MessageBox.Show($"Song: {row.Cells[0].Value.ToString()}\nArtist: {row.Cells[1].Value.ToString()}\nStreams (Billions): {row.Cells[2].Value.ToString()}\nRelease Date: {row.Cells[3].Value.ToString()}");
                    break;
                }
                else
                {
                    MessageBox.Show("Search term not found, try again.");
                    break;
                }
                
            }
        }

    }
}


