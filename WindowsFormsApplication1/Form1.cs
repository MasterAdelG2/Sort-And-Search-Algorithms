using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static int key;
        public static string DATA;
        public static string RESULTS;
        public static int[] ARRAY=new int[1];
        public Form1()
        {
            InitializeComponent();
            selectFunction.SelectedIndex = 0;
            filePath.Text = "D:\\input.txt";
        }
        public void readFromFile()
        {
            //Reading File
            if (File.Exists(filePath.Text))
                DATA = File.ReadAllText(filePath.Text);
            else
                MessageBox.Show("File Not Found!", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            readArray(DATA);
            if (chk.Checked)
                dataShow.Text = DATA;
        }
        public void writeToFile()
        {
            if (chk.Checked)
                RESULTS = dataShow.Text;
            else
            {
                RESULTS = "";
                for (int i = 0; i < ARRAY.Length; i++)
                    RESULTS += ARRAY[i].ToString() + " ";
            }
            // Writing to File
            File.WriteAllText(filePath.Text, RESULTS);
        }
        public void readArray(string data)
        {
            // Taking Array
            string[] sub = data.Split(new[] { ' ', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);
            ARRAY = new int[sub.Length];
            // Parsing
            for (int i = 0; i < sub.Length; i++)
                if (!Int32.TryParse(sub[i], out ARRAY[i]))
                    MessageBox.Show("Failed to Parse \"" + sub[i] + "\".. please Fix it in the Data show.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void heapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        public void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                heapify(arr, n, largest);
            }
        }
        public void MergeSort(int[] Array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSort(Array, low, middle);
                MergeSort(Array, middle + 1, high);
                Merge(Array, low, middle, high);
            }
        }
        public void Merge(int[] Array, int low, int middle, int high)
        {
             int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (Array[left] < Array[right])
                {
                    tmp[tmpIndex] = Array[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = Array[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }
            while (left <= middle)
            {
                tmp[tmpIndex] = Array[left];
                left = left + 1;
                tmpIndex = tmpIndex + 1;
            }
            while (right <= high)
            {
                tmp[tmpIndex] = Array[right];
                right = right + 1;
                tmpIndex = tmpIndex + 1;
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                Array[low + i] = tmp[i];
            }
        }
        public void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
        public void startSort(string sort)
        {
            if (chk.Checked)
                readArray(dataShow.Text);
            // prepare StopWatch
            Stopwatch stopwatch = new Stopwatch();
            if (sort == "Merge")
            {
                stopwatch.Start();
                MergeSort(ARRAY, 0, ARRAY.Length - 1);
            }
            else if (sort == "Heap")
            {
                stopwatch.Start();
                heapSort(ARRAY);
            }
            else if (sort == "Quick")
            {
                stopwatch.Start();
                quickSort(ARRAY, 0, ARRAY.Length - 1);
            }
            else if (sort == "Counting")
            {
                int k = ARRAY.Max();
                int[] B = new int[ARRAY.Length];
                for (int i = 0; i < B.Length; i++)
                    B[i] = ARRAY[i];
                stopwatch.Start();
                CountingSort(B, ARRAY, k);
            }
            stopwatch.Stop();
            // print Time Elapsed
            timeShow.Text = stopwatch.Elapsed.TotalSeconds.ToString();
            // print Results
            if (chk.Checked)
            {
                RESULTS = "";
                for (int i = 0; i < ARRAY.Length; i++)
                    RESULTS += ARRAY[i].ToString() + " ";
                dataShow.Text = RESULTS;
            }
        }
        public void CountingSort(int[] A, int[] B, int k)
        {
            int[] C = new int[k + 1];
            for (int i = 0; i <= k; i++)
                C[i] = 0;

            for (int i = 0; i < A.Length; i++)
                C[A[i]] += 1;                 
            for (int i = 2; i <= k; i++)
                C[i] = C[i] + C[i - 1];

            for (int i = A.Length - 1; i >= 0; i--)
            {
                B[C[A[i]] - 1] = A[i];
                C[A[i]]--;
            }
        }
        public void Search()
        {
            if (chk.Checked)
                readArray(dataShow.Text);
            // Taking Key from User
            Form2 keyTaker = new Form2();
            keyTaker.ShowDialog();
            // prepare Stopwatch
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Search
            int Result = BinarySearch(ARRAY, 0, ARRAY.Length - 1, key);
            stopwatch.Stop();
            // print Time Elapsed
            timeShow.Text = stopwatch.Elapsed.TotalSeconds.ToString();
            // print Result
            if (Result == -1)
                MessageBox.Show("Element Not Found!", "Wrong Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("("+key.ToString()+")'s Index = " + Result.ToString(), "Founded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public int BinarySearch(int[] Arr, int start, int end, int key)
        {
            int mid = (start + end) / 2;
            if (start <= end)
            {
                if (Arr[mid] > key)
                    return BinarySearch(Arr, start, mid - 1, key);
                else if (Arr[mid] < key)
                    return BinarySearch(Arr, mid + 1, end, key);
                else
                    return mid;
            }
            else return -1;
        }
        public void Swap(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            filePath.Text = op.FileName;
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional Script for better Design
            buttonFunction.Text = selectFunction.SelectedItem.ToString();
            if (filePath.Text == "" || filePath.Text == "D:\\input.txt" || filePath.Text == "D:\\output.txt")
            {
                if (selectFunction.SelectedItem.ToString() == "Read")
                    filePath.Text = "D:\\input.txt";
                else if (selectFunction.SelectedItem.ToString() == "Write")
                    filePath.Text = "D:\\output.txt";
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // Function select
            if (buttonFunction.Text == "Read")
                readFromFile();
            else if (buttonFunction.Text == "Write")
                writeToFile();
            else if (buttonFunction.Text == "Merge Sort")
                startSort("Merge");
            else if (buttonFunction.Text == "Quick Sort")
                startSort("Quick");
            else if (buttonFunction.Text == "Heap Sort")
                startSort("Heap");
            else if (buttonFunction.Text == "Counting Sort")
                startSort("Counting");
            else if (buttonFunction.Text == "Binary Search")
                Search();
        }
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            dataShow.ReadOnly = !dataShow.ReadOnly;
        }
    }
}