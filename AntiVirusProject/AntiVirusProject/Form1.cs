using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace AntiVirusProject
{
    public partial class Form1 : Form
    {
        int viruses, i = 0, counter = 0;
        string[] viruslist = new string[] { "shortcut", "hacker", "trozan", "virus" };
        String[] str = new String[5000];
        List<String> files = new List<string>();
        string[] hashes = new string[10000];
        Process[] processList1;
        Process[] processList2;

        string st="abc";
        private Func<Type, object> s;

        public Form1()
        {
           
           /* InitializeComponent();
            //Thread th = new Thread(newProcess);
            //th.Start();
            timer1.Start();
            processList1 = Process.GetProcesses();
            //  progressBar1.Visible = false;
            timer4.Start();*/

        }
        private void getAllFiles(string root)
        {
            /*try
            {
                string[] filesinroot = Directory.GetFiles(root);

                files.AddRange(filesinroot);
                foreach (var folder in Directory.GetDirectories(root))
                {
                    getAllFiles(folder);
                }
            }
            catch(UnauthorizedAccessException ex)
            {

            }
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void auto_Scan()
        {

           

            List<string> search = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*").ToList();
          

           
            getAllFiles(folderBrowserDialog1.SelectedPath);
            

           
            int count = 0;
            using (StreamWriter sw = new StreamWriter("File.txt"))
            {
                foreach (string st in files)
                {
                    sw.WriteLine(st);
                    count++;
                    if(count==35)
                    {
                        timer4.Stop();
                    }

                }

            }
           // String[] str = new String[500000];
            String[] AllLines = new String[5000];
            using (StreamReader sr = File.OpenText("File.txt"))
            {
                int x = 0;
                while (!sr.EndOfStream)
                {
                    AllLines[x] = sr.ReadLine();
                    str[x] = CreateMD5(AllLines[x]);
                    x++;
                }

            }
            using (StreamReader sr = File.OpenText("md5list.txt"))
            {

                try
                {
                    while (!sr.EndOfStream)
                    {
                        for(int i=0;i<str.Length;i++)
                        {
                            string s = str[i];
                            if (sr.ReadLine().Equals(s))
                            {
                                viruses += 1;
                                MessageBox.Show(viruses.ToString());

                            }
                            else
                            {
                              //  MessageBox.Show(viruses.ToString());
                            }
                        }



                       

                    }
                   // MessageBox.Show(viruses.ToString());

                }
                catch (Exception ex)
                {

                }

            }
                
            Parallel.For(0, AllLines.Length, x =>
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter("File3.txt"))
                    {
                        sw.WriteLine(AllLines[x]);
                    }

                   // backgroundWorker1.RunWorkerAsync(AllLines[x]);
                }
                catch (Exception ex)
                {


                }
            });


            foreach (string item in files)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();

                    foreach (string st in viruslist)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            // viruses += 1;
                            //lblvirus.Text = "Viruses" + viruses.ToString();
                            //path.Items.Add(item);


                        }

                        var lineCount = File.ReadLines("file1.txt").Count();
                        string s = lineCount.ToString();
                        //MessageBox.Show(s);

                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            /* proListView.Visible = true;

             Process[] processList = Process.GetProcesses();
             //Process[] processList1 = Process.GetProcesses();
             foreach (Process process in processList)
             {
                 ListViewItem item = new ListViewItem(process.ProcessName);
                 item.Tag = process;
                 try
                 {
                     proListView.Items.Add(item);


                 }
                 catch (Exception ex)
                 {

                 }

             }*/
            //GetProcesses();
            proListView.Visible = true;
            EndButton.Visible = true;
            //button5.Visible = true;
            loadprocesslist();*/
            
        }

        private void button1_Click(object sender, EventArgs e)     //browse Folder
        {
           
           /* folderBrowserDialog1.ShowDialog();
            lblfolder.Text = folderBrowserDialog1.SelectedPath;
            // viruses = 0;
            //lblvirus.Text +="Viruses"+ viruses.ToString();
            //progressBar1.Value = 0;
            //path.Items.Clear();
            */

        }

        private void button2_Click(object sender, EventArgs e)   // scanning process
        {
           // progressBar1.Visible = true;


            /*timer3.Start();
            List<string> search = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*").ToList();
            
            getAllFiles(folderBrowserDialog1.SelectedPath);
            //string path = @"C:\emu8086\MySource";
            //getAllFiles(path);
            //progressBar1.Maximum = files.Count;
            // Statuslbl.Visible = false;

            using (StreamWriter sw = new StreamWriter("File.txt"))
            {
                foreach (string st in files)
                {
                    sw.WriteLine(st);
                    
                }

            }
           string[] AllLines = new string[1000];
            

            /*using (StreamReader sr = File.OpenText("file.txt"))
            {
                int x = 0;
                while (!sr.EndOfStream)
                {
                    AllLines[x] = sr.ReadLine();
                    str[x] = CreateMD5(AllLines[x]);
                    x++;
                }

            }*/
           
           /* Parallel.For(0, AllLines.Length, x =>
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter("File3.txt"))
                    {
                        sw.WriteLine(AllLines[x]);
                    }

                    backgroundWorker1.RunWorkerAsync(AllLines[x]);

                }
                catch (Exception ex)
                {


                }
            });

   
            foreach (string item in files)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();

                    foreach (string st in viruslist)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            // viruses += 1;
                            //lblvirus.Text = "Viruses" + viruses.ToString();
                            //path.Items.Add(item);


                        }

                        var lineCount = File.ReadLines("file1.txt").Count();
                        string s = lineCount.ToString();
                        //MessageBox.Show(s);
                       
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }


    

        private void Statuslbl_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            proListView.Visible = false;
            EndButton.Visible = false;
            // button5.Visible = false;
            /*notifyIcon1.BalloonTipText = "Antivirus is Running Background";
            notifyIcon1.BalloonTipTitle = "Warning";*/


        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
           /* using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2").ToLower());
                }
                return sb.ToString();

            }*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
           /* byte[] HashStore;
            int byteRead;
            long size;
            long totalByteRead = 0;
            int i = files.Count;
            /*while (i != 0)
            {
                     
                    progressBar1.Increment(1);
                    int percent = (int)((((double)progressBar1.Value / (double)progressBar1.Maximum)) * 100);
                    progressBar1.Refresh();
                    progressBar1.CreateGraphics().DrawString(percent.ToString() + "%",
                        new Font("Arial", (float)8.25, FontStyle.Regular),
                        Brushes.Black,
                        new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                    i--;
               
            }*/
            /*try
            {
                string filepath = e.Argument.ToString();
                using (Stream file = File.OpenRead(filepath))
                {
                    size = file.Length;
                    using (HashAlgorithm hasher = MD5.Create())
                    {
                        do
                        {
                            HashStore = new byte[8192];
                            byteRead = file.Read(HashStore, 0, HashStore.Length);
                            totalByteRead += byteRead;
                            hasher.TransformBlock(HashStore, 0, byteRead, null, 0);
                        }
                        while (byteRead != 0);
                        hasher.TransformFinalBlock(HashStore, 0, 0);
                        e.Result = MakeHashString(hasher.Hash);

                    }
                }


            }
            catch (Exception ex)
            {

            }
            string stp=null;
            try
            {
                stp = e.Result.ToString();
                MessageBox.Show(stp);
            }
            catch(NullReferenceException ex)
            {

            }
           

            using (StreamWriter sw = new StreamWriter("file2.txt"))
            {
                sw.WriteLine(stp);
               // MessageBox.Show(stp);
            }

            using (StreamReader sr = File.OpenText("md5list.txt"))
            {

                try
                {
                    while (!sr.EndOfStream)
                    {


                        if (sr.ReadLine().Equals(stp))
                        {
                            viruses += 1;

                        }
                        

                    }

                }

                catch (Exception ex)
                {

                }
                string r = run.Text;
                if (viruses > 0)
                {


                    //Statuslbl.Visible = true;
                    MessageBox.Show(viruses.ToString() + " " + "Virus Found");
                    //Antivirus.ShowBalloonTip(1000, "Warning", " Potential Harmful Program Detected " , ToolTipIcon.Warning); 
                    // label1.Text = "Viruses" + viruses.ToString();
                    //path.Items.Add(filepath);
                }
                else
                {
                    //MessageBox.Show("No virus!!!!You Are Protected");
                    Antivirus.ShowBalloonTip(1000, "Warning",""+r+" is safe to Use ", ToolTipIcon.Warning);
                }

                sr.Close();
                // MessageBox.Show(count.ToString());
            }
        }
        private static string MakeHashString(byte[] hashbyte)
        {
            StringBuilder hash = new StringBuilder(64);
            foreach (byte b in hashbyte)
            {
                hash.Append(b.ToString("x2").ToLower());
            }
            return hash.ToString();
        }*/

        private void button4_Click(object sender, EventArgs e)    //start process
        {
            
            try
            {
                string text = startTextBox.Text;
                Process process = new Process();
                process.StartInfo.FileName = text;
                process.Start();

            } 
            catch (Exception ex)
            {

            }
        }
      /* Process[] process;
        public void GetProcesses()
        {
            process = Process.GetProcesses();
            if(Convert.ToInt32(label2.Text)!=process.Length)
            {
                proListView.Items.Clear();
                for(int i=0;i<process.Length;i++)
                {
                    proListView.Items.Add(process[i].ProcessName);
                }
                label2.Text = process.Length.ToString();
            }

        }*/
        public void loadprocesslist()
        {


            try
            {

                proListView.Clear();
                Process[] processList1 = Process.GetProcesses();
                int pro = processList1.Count();
                foreach (Process process in processList1)
                {
                    ListViewItem item = new ListViewItem(process.ProcessName);
                    item.Tag = process;
                    proListView.Items.Add(item);

                }
                label2.Text = pro.ToString();



            }
            catch (Exception ex)
            {

            }
        
            
        }
        DateTime min;
        public void newProcess()
        {
            int i = 0;
            Process[] processList2 = Process.GetProcesses();
            try
            {
                DateTime min = processList2[i].StartTime;
            }
            catch(Win32Exception ex)
            {

            }

            int count = 0;
            Process last = new Process();
            foreach (Process a in processList2)
            {

                try
                {
                    if (DateTime.Compare(a.StartTime, min) >= 0)
                    {
                        last = a;
                        min = a.StartTime;
                    }

                }
                catch (Exception)
                {

                }

            }
           
            
                try
                {
                    string str = last.ProcessName;
                    run.Text = str;
                    Antivirus.ShowBalloonTip(1000, "Warning", str + " " + " is running", ToolTipIcon.None);
                    //backgroundWorker1.RunWorkerAsync(last.MainModule.FileName);
                    /* using (StreamWriter sw = new StreamWriter("File5.txt")) 
                     {
                         sw.WriteLine(str);
                     }
                     using (StreamReader sr = File.OpenText("File5.txt"))
                     {
                         while(!sr.EndOfStream)
                         {
                             if(sr.ReadLine().Equals(str))
                             {

                                 //Antivirus.ShowBalloonTip(1000, "Warning", str + " " + " is running", ToolTipIcon.None);
                                 count++;
                             }
                             if (count > 1)
                             {
                                 timer2.Stop();
                             }

                         }*/

                

                       
                }
                catch(InvalidOperationException ex)
                {

                }
               
                //st = last.ProcessName;
                
                //this.s = this.GetService;
                //MessageBox.Show(s.ToString());

                try
                {
                   // backgroundWorker1.RunWorkerAsync(last.MainModule.FileName);
                   // MessageBox.Show("" + last.MainModule.FileName);
                }
                catch(InvalidOperationException ex)
                {

                }
            catch(Win32Exception ex)
            {

            }

                



            
            
        }
       
       
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            newProcess();
            
            //GetProcesses();
           
        }

        private void EndButton_Click(object sender, EventArgs e)   // End process
        {
            try
            {
                ListViewItem item = proListView.SelectedItems[0];
                Process process = (Process)item.Tag;
                process.Kill();

            }
            catch (Exception ex)
            {

            }

        }

       

        private void startTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfolder_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            //this.WindowState = FormWindowState.Normal;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loadprocesslist();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            /*ShowIcon = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            //this.WindowState = FormWindowState.Normal;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       private void Form1_Move(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                Antivirus.ShowBalloonTip(1000, "WARNING", "Antivirus is running on Background", ToolTipIcon.Info);

            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /*if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                Antivirus.ShowBalloonTip(1000, "WARNING", "Antivirus is running on Background", ToolTipIcon.Info);

            }*/
            //if(this.WindowState=FormWindowState.Minimized)
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           // progressBar1.Increment(4);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           // progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //progressBar1.Value = 0;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            auto_Scan();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
