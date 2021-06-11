
/*
* Build and design by kemw tech 
* This software is free to use any one to Learn C# Programing
* Version 1.0
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DropME_Video_to_mp3
{
    public partial class DropMe : Form
    {

      //  private String[] filepath;
        string file_path;
        public DropMe()
        {
            InitializeComponent();
            ((Control)Videobox).AllowDrop = true;
         

        }

      

        
       

     

       

        private void DirLoc_Click(object sender, EventArgs e)
        {
            Transcode();
        }

        private void Transcode()
        {
            try
            {
                timer1.Interval = openFileDialog1.SafeFileName.Length;
                timer1.Start();
                file_path = openFileDialog1.FileName;
                string name = Path.GetFileNameWithoutExtension(file_path);
                string command = string.Format("-i {0} {1}.mp3", file_path, name);
                Console.WriteLine("comm" + command);
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    //  WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Application.StartupPath + "\\ffmpeg.exe",
                    Arguments = command
                };
               
                process.StartInfo = startInfo;
                process.Start();
                if (process.HasExited)
                {
                    MessageBox.Show("finish");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Eror while converting file " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            done.Increment(1);
            if (done.Value == done.Maximum)
            {
                timer1.Stop();
                string file_path = fileInput.Text;
                string name = Path.GetFileNameWithoutExtension(file_path) + ".mp3";
                MessageBox.Show("Done converting " + file_path + "\nNew File created " + name, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                done.Value = done.Minimum;
                label2.Show();
            }
        }

        private void Videobox_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string path = openFileDialog1.FileName;
                fileInput.Text = path;

                if (DialogResult == DialogResult.Cancel)
                {
                    fileInput.Text = "Select a file ...";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Eror while opening file (File must be an mp4 file!!)" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("If you need to Learn More About It...... Click Smash button to Github Repository...", "Help", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start("https://github.com/kemw/DropME-Video-to-mp3");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string files_folder = Directory.CreateDirectory("mp3").FullName;

                string folder = Environment.CurrentDirectory;


                string[] items = System.IO.Directory.GetFiles(folder, "*.mp3", System.IO.SearchOption.TopDirectoryOnly);
                foreach (string filePath in items)
                {
                    string newFile = System.IO.Path.Combine(files_folder, System.IO.Path.GetFileName(filePath));
                    if (File.Exists(newFile))
                    {
                        MessageBox.Show("File already exists!!\n Overwriting!", "Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // File.Delete(file);
                        File.Delete(filePath);
                        continue;
                    }

                    File.Move(filePath, newFile);

                }

                string path = Directory.GetCurrentDirectory();
                string folder1 = "mp3";
                string full_path = Path.Combine(path, folder1);

                Process.Start("explorer.exe", full_path);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror while moving files " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void DropMe_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process processs in Process.GetProcessesByName(Application.StartupPath + "\\ffmpeg.exe"))
            {
                processs.Kill();
            }
            foreach (Process processs in Process.GetProcessesByName("DropME-Video-to-mp3.exe"))
            {
                processs.Kill();

            }
            Environment.Exit(0);
            Application.Exit();
            Dispose();
        }

        private void Videobox_DragEnter(object sender, DragEventArgs e)
        {
            file_path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            fileInput.Text=file_path;
            
           // Transcode();
        }

       

       
        

        

      
        
        

        
    }
}
