//using MetadataExtractor;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(@"E:\Учеба 2019\МПИСиТ\FilesDir\13545844805_1fe22f9631_k.jpg");
        String[] dir = Directory.GetFiles(@"E:\Учеба 2019\МПИСиТ\FilesDir\");



        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Start new one");
            foreach (var d in dir)
            {
                Console.WriteLine(d);
            }
                    


        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
           infoLabel.Text = ("Deleted");
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            infoLabel.Text = ("Created");
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            infoLabel.Text = ("Changed");
        }
    }
}
