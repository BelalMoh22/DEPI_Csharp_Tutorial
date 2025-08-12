using System.IO;
using System.Text;

namespace IODemo
{
    public partial class Form1 : Form
    {
        FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Drivers
            var Drivers = DriveInfo.GetDrives();
            foreach (var Driver in Drivers)
            {
                if (Driver.IsReady == true && Driver.DriveType == DriveType.Fixed)
                {
                    comboBox1.Items.Add(Driver);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DriveInfo Di = comboBox1.SelectedItem as DriveInfo; 
            // or
            //string result = "";
            // or 
            StringBuilder stringBuilder = new StringBuilder();
            DriveInfo Di = new DriveInfo(comboBox1.Text);
            //result = Di.Name + Environment.NewLine;
            // or
            stringBuilder.Append(Di.Name + Environment.NewLine);
            //result += $"Total Size : {Di.TotalSize / 1024/1024/1024} GB" + Environment.NewLine; 
            //or 
            stringBuilder.Append($"Total Size : {Di.TotalSize / 1024 / 1024 / 1024} GB" + Environment.NewLine);
            //result += $"Free Space : {Di.AvailableFreeSpace/1024/1024/1024} GB" + Environment.NewLine;
            //or
            stringBuilder.Append($"Free Space : {Di.AvailableFreeSpace / 1024 / 1024 / 1024} GB" + Environment.NewLine);
            lbl.Text = stringBuilder.ToString();


            // Folders

            //Directory DirectoryInfo   Folder 
            //Directory      --> static Methods
            //DirectoryInfo  --> instanced Method Must Create Object

            //Directory folders = new Directory(); // here error because class static cannot make from it instance

            //DirectoryInfo folderinfo = new DirectoryInfo(comboBox1.Text);
            //folderinfo.

            string[] folders = Directory.GetDirectories(comboBox1.Text);
            listBox1.Items.Clear();
            foreach (string folder in folders)
            {
                listBox1.Items.Add(folder);
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // files
            string[] files = Directory.GetFiles(listBox1.Text);
            listBox2.Items.Clear();
            foreach (string item in files)
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox2.Text;
            FileInfo fi = new FileInfo(listBox1.Text);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{fi.FullName + Environment.NewLine}");
            stringBuilder.Append($"{fi.CreationTimeUtc + Environment.NewLine}");

            label4.Text = stringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Folder
            Directory.CreateDirectory(comboBox1.Text + "NewFolderFromMyApp");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete Folder
            if (Directory.Exists(comboBox1.Text + "NewFolderFromMyApp"))
            {
                Directory.Delete(comboBox1.Text + "NewFolderFromMyApp");
                MessageBox.Show("Folder Deleted");
            }
            else
            {
                MessageBox.Show("Folder not Found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(@"F:\s.txt", richTextBox1.Text);
            File.WriteAllLines(@"D:\s.txt", richTextBox1.Lines);
            MessageBox.Show("Saving ");
            richTextBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // File Read
            richTextBox1.Lines = File.ReadAllLines(@"D:\s.txt");
            //richTextBox1.Text = File.ReadAllText(@"F:\s.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Stream s = new Stream();
            // to create file By FileStream
            //if (!File.Exists(@"D:\Sayed1.txt"))
            //    File.Create(@"D:\Sayed1.txt");
            //MemoryStream // read from memory
            fs = new FileStream(@"D:\Sayed1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // read from file
            // to read the File 
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            MessageBox.Show("Open ....");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //fs = new FileStream(@"D:\Sayed1.txt", FileMode.OpenOrCreate);
            //// to write the text 
            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write(richTextBox1.Text);
            //sw.Close();
            //MessageBox.Show("Saving ....");
            //richTextBox1.Text = string.Empty;

            // Block Using
            using (StreamWriter sw = new StreamWriter(fs)) // resource
            {
                sw.Write(richTextBox1.Text);
                //sw.Close();  // after end the block it wil close auto 
            }
            MessageBox.Show("Saving ....");
            richTextBox1.Text = string.Empty;

        }
    }
}
