﻿using System;
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

        /* private List<string> LoadThirdColumn(string filePath)
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
        } */

        private void LenearSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = LinearSearchTextBox.Text;

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
        
        //Sort the data by streams using bubble sort
        private void StreamSortButton_Click(object sender, EventArgs e)
        {
            //Reads and store CSV data
            List<string> lines = new List<string>();
            //StreamReader reads the file and dispose of it when done
            using (StreamReader reader = new StreamReader("Streams.csv")) 
            {
                //Saves CSV contents to a lists
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(','); //Splits at the delimiter
                    lines.Add(values[2]); //Adds 3rd element to the list (Streams column)
                }
            }
            
            // Convert the strings to floats
            float[] data = new float[lines.Count];
            for (int x = 0; x < lines.Count; x++) //Iterates through the list
            {
                data[x] = float.Parse(lines[x]); //Converts the string to a float
            }

            // Bubble sort Algorithm
            for (int x = 0; x < data.Length - 1; x++)
            {
                for (int y = 0; y < data.Length - x - 1; y++)
                {
                    if (data[y] > data[y + 1])
                    {
                        float temp = data[y];
                        data[y] = data[y + 1];
                        data[y + 1] = temp;
                    }
                }
            }

            // Rearrange the WinForm table
            for (int x = 0; x < dataGridView1.Rows.Count & x < data.Length; x++)
            {
                dataGridView1.Rows[x].Cells[2].Value = data[x]; //Sets the 3rd column to the sorted data
            }
        }
    }
}


