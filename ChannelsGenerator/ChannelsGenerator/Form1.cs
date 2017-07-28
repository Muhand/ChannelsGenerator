using AxAXVLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelsGenerator
{
    public partial class ChannelsGenerator : Form
    {
        #region Properties
        public SupportedFilesTypes inputFileType { get; set; }
        public SupportedFilesTypes outputFileType { get; set; }
        public string[] rawChannels { get; set; }
        BackgroundWorker loadBG;
        BackgroundWorker verifyBG;
        BackgroundWorker generateBG;
        List<Channel> loadedChannels;
        int errorWhileLoadingChannels;
        List<Channel> verifiedChannels;
        int errorWhileVerifyingChannels;
        bool errorPlaying;

        #endregion

        public ChannelsGenerator()
        {
            InitializeComponent();

            #region FileTypes
            if (inputChan.Checked == true)
                inputFileType = SupportedFilesTypes.mama;
            else
                inputFileType = SupportedFilesTypes.m3u;

            if (outputMama.Checked == true)
                outputFileType = SupportedFilesTypes.mama;
            else
                outputFileType = SupportedFilesTypes.m3u;
            #endregion

            rawChannels = null;
            loadedChannels = new List<Channel>();
            errorWhileLoadingChannels = 0;

            verifiedChannels = new List<Channel>();
            errorWhileVerifyingChannels = 0;
            errorPlaying = false;

            #region Background workers
            loadBG = new BackgroundWorker();
            loadBG.DoWork += loadBG_DoWork;
            loadBG.ProgressChanged += loadBG_ProgressChanged;
            loadBG.RunWorkerCompleted += loadBG_RunWorkerCompleted;
            loadBG.WorkerReportsProgress = true;

            verifyBG = new BackgroundWorker();
            verifyBG.DoWork += VerifyBG_DoWork;
            verifyBG.ProgressChanged += VerifyBG_ProgressChanged;
            verifyBG.RunWorkerCompleted += VerifyBG_RunWorkerCompleted;
            verifyBG.WorkerReportsProgress = true;

            generateBG = new BackgroundWorker();
            generateBG.DoWork += generateBG_DoWork;
            generateBG.ProgressChanged += generateBG_ProgressChanged;
            generateBG.RunWorkerCompleted += generateBG_RunWorkerCompleted;
            generateBG.WorkerReportsProgress = true;
            #endregion
        }

        #region Load
        private void loadBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            writeToLog(Environment.NewLine+"Channels loading is done.");
            writeToLog(loadedChannels.Count + " were loaded successfully.");
            writeToLog(errorWhileLoadingChannels + " were not loaded successfully." + Environment.NewLine);
        }

        private void loadBG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progress.Text = string.Format("{0}/{1}", e.ProgressPercentage, progressBar1.Maximum);
        }

        private void loadBG_DoWork(object sender, DoWorkEventArgs e)
        {
            load();
        }
        #endregion
        
        #region Verify
        private void VerifyBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            writeToLog(Environment.NewLine + "Channels verification is done.");
            writeToLog(loadedChannels.Count + " were verified successfully.");
            writeToLog(errorWhileLoadingChannels + " are not working." + Environment.NewLine);
        }

        private void VerifyBG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progress.Text = string.Format("{0}/{1}", e.ProgressPercentage, progressBar1.Maximum);
        }

        private void VerifyBG_DoWork(object sender, DoWorkEventArgs e)
        {
            //progressBar1.Maximum = loadedChannels.Count;
            //progressBar1.Value = 0;
            Action action = () => progressBar1.Maximum = loadedChannels.Count;
            log.Invoke(action);
            action = () => progressBar1.Value = 0;
            log.Invoke(action);
            verifyBG.ReportProgress(0);

            verifyChannels();
        }
        #endregion

        #region Generate
        private void generateBG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            writeToLog(Environment.NewLine + "Channels generation is done.");
            writeToLog(verifiedChannels.Count + " were generated successfully.");
        }

        private void generateBG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progress.Text = string.Format("{0}/{1}", e.ProgressPercentage, progressBar1.Maximum);
        }

        private void generateBG_DoWork(object sender, DoWorkEventArgs e)
        {
            Action action = () => progressBar1.Maximum = verifiedChannels.Count;
            log.Invoke(action);

            action = () => progressBar1.Value = 0;
            log.Invoke(action);

            generateBG.ReportProgress(0);

            generateChannels();
        }
        #endregion

        #region Main Methods

        private void load()
        {
            //Browse the file and prepare it
            Thread th = new Thread(Browse);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            th.Join();

            if (rawChannels != null)
            {
                //Set progress bar
                writeToLog("Loading channels began..." + Environment.NewLine);
                Action action = () => progressBar1.Maximum = rawChannels.Length;
                log.Invoke(action);

                //Start loading the channels
                switch (inputFileType)
                {
                    case SupportedFilesTypes.m3u:
                        loadm3u();
                        break;
                    case SupportedFilesTypes.mama:
                        loadMama();
                        break;
                    default:
                        writeToLog("Incorrect file extension was loaded");
                        break;
                }
            }


        }

        private void verifyChannels()
        {
            writeToLog("Channels verification began..." + Environment.NewLine);

            var t = new Thread(verify);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            t.Join();
        }

        private void generateChannels()
        {
            writeToLog("Channels generator began..." + Environment.NewLine);

            var t = new Thread(generate);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            t.Join();
        }
        #endregion

        #region Buttons
        private void clearLog_Click(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadBG.RunWorkerAsync();
        }
        private void verifyBtn_Click(object sender, EventArgs e)
        {
            verifyBG.RunWorkerAsync();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            generateBG.RunWorkerAsync();
        }
        #endregion

        #region Checkbox
        private void inputMama_CheckedChanged(object sender, EventArgs e)
        {
            inputFileType = SupportedFilesTypes.mama;
        }

        private void outputMama_CheckedChanged(object sender, EventArgs e)
        {
            outputFileType = SupportedFilesTypes.mama;
        }

        private void inputM3u_CheckedChanged(object sender, EventArgs e)
        {
            inputFileType = SupportedFilesTypes.m3u;
        }

        private void outputM3u_CheckedChanged(object sender, EventArgs e)
        {
            outputFileType = SupportedFilesTypes.m3u;
        }
        #endregion

        #region Extra Methods
        private void Browse()
        {

            Stream fileStream = null;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.InitialDirectory = @"C:\Users\Muhand\Desktop\IPTV Channels\arabic.m3u";
            fileDialog.Filter = inputFileType + " files (*." + inputFileType + ")|*." + inputFileType;
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if ((fileStream = fileDialog.OpenFile()) != null)
                    {
                        
                        Action action = () => dirName.Text = fileDialog.FileName;
                        log.Invoke(action);

                        action = () => outputFileName.Text = Path.GetFileNameWithoutExtension(fileDialog.FileName);
                        log.Invoke(action);


                        writeToLog(dirName.Text + " was opened successfuly.");
                        //action = () => verifyBtn.Enabled = true;
                        //log.Invoke(action);
                        rawChannels = File.ReadAllLines(dirName.Text);
                        writeToLog("Read: " + rawChannels.Length + " lines." + Environment.NewLine);
                    }
                    else
                    {
                        
                        //Action action = () => verifyBtn.Enabled = false;
                        //log.Invoke(action);
                    }
                }
                catch (Exception ex)
                {
                    writeToLog("Error: Could not read file from disk. Original error: " + ex.Message);
                    
                    //Action action = () => verifyBtn.Enabled = false;
                    //log.Invoke(action);
                }
                finally
                {
                    fileStream.Close();
                }
            }
        }

        private void loadMama()
        {
            //Verify its the correct file type
            if (rawChannels[0] == "#MAMAEXT")
            {
                int inc = 2;
                loadBG.ReportProgress(1);
                for (int i = 1; i < rawChannels.Length; i+=inc)
                {
                    string currentLine = rawChannels[i];

                    //As long as this line is not seperator then continue
                    if (currentLine[0] != '-')
                    {
                        inc = 2;

                        writeToLog(Environment.NewLine + "Creating a new channel...");

                        string nextLine = rawChannels[i + 1];

                        //Create temporary channel
                        Channel temp = new Channel();

                        //Split the line
                        string[] chanName = currentLine.Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
                        string[] chanUrl = nextLine.Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries);

                        //Check if the property is channel name or url
                        //if (trimmed[0] == "ChannelName")
                        //    temp.ChannelName = trimmed[1];                          //If channel name then add to channel name  
                        //else if (trimmed[0] == "ChannelURL")
                        //    temp.ChannelURL = trimmed[1];                           //Else add to channel URL
                        temp.ChannelName = chanName[1];
                        temp.ChannelURL = chanUrl[1];

                        loadedChannels.Add(temp);

                        Action action = () => listBox1.Items.Add(temp.ChannelName);
                        log.Invoke(action);

                        writeToLog("Channel Name: " + temp.ChannelName);
                        writeToLog("Channel URL: " + temp.ChannelURL);
                        writeToLog("New channel was added successfully");
                    }
                    else
                        inc = 1;

                    loadBG.ReportProgress(i+1);
                }

                Action action2 = () => verifyBtn.Enabled = true;
                log.Invoke(action2);
            }
            else
            {
                writeToLog("Incorrect file type was loaded.");
                return;
            }
        }

        private void loadm3u()
        {

        }

        private void verify()
        {
            
            player.MediaPlayerEncounteredError += Vlc_MediaPlayerEncounteredError;
            for (int i = 0; i < loadedChannels.Count; i++)
            {
                Channel temp = loadedChannels[i];

                writeToLog("Testing a new channel");
                writeToLog("Channel Name: " + temp.ChannelName);
                writeToLog("Channel URL: " + temp.ChannelURL);
                
                player.playlist.add(temp.ChannelURL);
                player.playlist.playItem(i);

                Thread.Sleep(4000);

                if (!errorPlaying)
                {
                    verifiedChannels.Add(temp);

                    Action action = () => listBox2.Items.Add(temp);
                    log.Invoke(action);
                    writeToLog(temp.ChannelName + " is verified successfully"+Environment.NewLine);
                }
                else
                {
                    errorWhileLoadingChannels++;
                    errorPlaying = false;
                    writeToLog(temp.ChannelName + " is not working"+Environment.NewLine);
                }

                verifyBG.ReportProgress(i + 1);
            }

            Action action2 = () => generateBtn.Enabled = true;
            log.Invoke(action2);
        }

        private void Vlc_MediaPlayerEncounteredError(object sender, EventArgs e)
        {
            errorPlaying = true;
        }

        private void generate()
        {
            string filename = outputFileName.Text + "." + outputFileType;
            writeToLog("Now writing to "+filename + Environment.NewLine);

            try
            {
                //StreamWriter w = new StreamWriter("channels_" + DateTime.Now.ToString("dd-MM-yyyy") + ".conf");
                StreamWriter w = new StreamWriter(filename);

                using (w)
                {
                    for (int i = 0; i < verifiedChannels.Count; i++)
                    {
                        writeToLog(verifiedChannels[i].ToString());

                        //w.WriteLine(string.Format("{0}\n{1}\n---------------------"), channels[i].ChannelName, channels[i].ChannelURL);
                        w.WriteLine(verifiedChannels[i].ChannelName + Environment.NewLine + verifiedChannels[i].ChannelURL + Environment.NewLine + "---------------------");

                        writeToLog("Written successfully");
                        writeToLog("----------------------------------------------" + Environment.NewLine);
                        generateBG.ReportProgress(i + 1);
                    }
                }
                w.Close();
                writeToLog(verifiedChannels.Count + " channels were written to "+filename+" successfully");
            }
            catch (Exception ex)
            {
                writeToLog(String.Format("There was an error writing to "+filename+", original error is: {0}", ex.Message));
            }
        }

        private void writeToLog(string message)
        {
            Action action = () => log.AppendText(message + Environment.NewLine);
            log.Invoke(action);
            //log.AppendText(message + Environment.NewLine);
            //log.ScrollToCaret();
            action = () => log.ScrollToCaret();
            log.Invoke(action);
        }
        #endregion

        #region Preview channel
        Channel selectedItem;
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.SelectedIndex = listBox2.IndexFromPoint(e.X, e.Y);
            selectedItem = (Channel)listBox2.SelectedItem;
            //selectedItem = 
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                previewer.playlist.items.clear();
                previewer.playlist.add(selectedItem.ChannelURL);
                previewer.playlist.playItem(0);
                tabControl1.SelectTab(2);
            }
        }
        #endregion
    }
}
