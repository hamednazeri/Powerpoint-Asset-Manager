using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace PowerpointAssetManager
{
    public partial class PowerpointAssetManager : Form
    {
        private PowerPoint.Application pptApplication;
        private PowerPoint.Presentation presentation;
        private string selectedPowerpointFile;
        private int selectedSlideIndex, TimingDuration;
        string folderPath;
        public PowerpointAssetManager()
        {
            InitializeComponent();
        }

        private void PowerpointAssetManager_Load(object sender, EventArgs e)
        {

        }

        private void PowerpointAssetManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void btnSelectPowerpoint_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PowerPoint Files|*.pptx;*.ppt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPowerpointFile = openFileDialog.FileName;
                LoadPowerpoint(selectedPowerpointFile);
            }
        }
        private void LoadPowerpoint(string fileName)
        {
            pptApplication = new PowerPoint.Application();
            presentation = pptApplication.Presentations.Open(fileName, ReadOnly: Office.MsoTriState.msoTrue);
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                LoadFilesInFolder(folderPath);
            }
        }

        private void LoadFilesInFolder(string folderPath)
        {
            // Clear list of files
            lstFiles.Items.Clear();

            // Get all image and video files from the folder
            string[] imageFiles = Directory.GetFiles(folderPath, "*.jpg")
                                            .Concat(Directory.GetFiles(folderPath, "*.jpeg"))
                                            .Concat(Directory.GetFiles(folderPath, "*.png"))
                                            .ToArray();

            string[] videoFiles = Directory.GetFiles(folderPath, "*.mp4")
                                            .Concat(Directory.GetFiles(folderPath, "*.avi"))
                                            .Concat(Directory.GetFiles(folderPath, "*.mov"))
                                            .ToArray();

            // Display files in the list
            foreach (string file in imageFiles)
            {
                lstFiles.Items.Add(Path.GetFileName(file) + " (Image)");
            }

            foreach (string file in videoFiles)
            {
                lstFiles.Items.Add(Path.GetFileName(file) + " (Video)");
            }
        }

        private void btnAddToPowerpoint_Click(object sender, EventArgs e)
        {
            if (presentation == null)
            {
                MessageBox.Show("ابتدا پاورپوینت مورد نظر را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSlideNumber.Text))
            {
                MessageBox.Show("شماره اسلاید را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSlideNumber.Text, out selectedSlideIndex) || selectedSlideIndex < 1 || selectedSlideIndex > presentation.Slides.Count)
            {
                MessageBox.Show("شماره اسلاید نامعتبر است.شماره اسلاید معتبر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add selected files to the selected slide
            foreach (string item in lstFiles.SelectedItems)
            {
                string fileName = item.Split('(')[0].Trim();

                if (item.EndsWith("(Image)"))
                {
                    AddImageToSlide(Path.Combine(folderPath, fileName), selectedSlideIndex, "RTL");
                }
                else if (item.EndsWith("(Video)"))
                {
                    AddVideoToSlide(Path.Combine(folderPath, fileName), selectedSlideIndex);
                }

            }
            //lstFiles.Items.Remove(lstFiles.SelectedItem);
            MessageBox.Show("تصویر با موفقیت به پاورپوینت افزوده شد","نکته",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void AddImageToSlide(string imagePath, int slideIndex,string way)
        {
            PowerPoint.Slide slide = presentation.Slides[slideIndex];
            var shape = slide.Shapes.AddPicture(imagePath, Office.MsoTriState.msoFalse, Office.MsoTriState.msoCTrue, 50, 50);
            PowerPoint.Effect effect = slide.TimeLine.MainSequence.AddEffect(
                shape,
                PowerPoint.MsoAnimEffect.msoAnimEffectWipe,
                PowerPoint.MsoAnimateByLevel.msoAnimateLevelNone,
                PowerPoint.MsoAnimTriggerType.msoAnimTriggerOnPageClick
            );
            PowerPoint.EffectParameters effectParams = effect.EffectParameters;
            if (way == "RTL")
            {
                effectParams.Direction = PowerPoint.MsoAnimDirection.msoAnimDirectionRight;
            }
            else if (way == "LTR")
            {
                effectParams.Direction = PowerPoint.MsoAnimDirection.msoAnimDirectionLeft;
            }
            effect.Timing.Duration = TimingDuration; // مدت زمان انیمیشن به 20 ثانیه تنظیم شده است
        }


        private void AddVideoToSlide(string videoPath, int slideIndex)
        {
            PowerPoint.Slide slide = presentation.Slides[slideIndex];
            PowerPoint.Shape mediaShape = slide.Shapes.AddMediaObject2(
                FileName: videoPath,
                LinkToFile: Office.MsoTriState.msoFalse,
                SaveWithDocument: Office.MsoTriState.msoCTrue
            );

            slide.TimeLine.MainSequence.AddEffect(
                mediaShape,
                PowerPoint.MsoAnimEffect.msoAnimEffectFade
            );
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            presentation?.Close();
            pptApplication?.Quit();
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = folderPath + @"\" + lstFiles.SelectedItem.ToString().Split('(')[0].Trim();
            PictureBox.ImageLocation = filePath;
        }
        int ClickNum = 0;
        private void btnDuration_Click(object sender, EventArgs e)
        {
            if (ClickNum == 0)
            {
                ClickNum++;
                btnDuration.Text = "پایان";
                this.btnDuration.BackColor = System.Drawing.Color.DarkRed;
                TimingDuration = 0;
                timer.Start();
            }
            else if (ClickNum == 1)
            {
                ClickNum = 0;
                btnDuration.Text = "شروع";
                this.btnDuration.BackColor = System.Drawing.Color.ForestGreen;
                timer.Stop();
            }
        }

        private void btnAddToPowerpointLtr_Click(object sender, EventArgs e)
        {
            if (presentation == null)
            {
                MessageBox.Show("ابتدا پاورپوینت مورد نظر را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSlideNumber.Text))
            {
                MessageBox.Show("شماره اسلاید را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtSlideNumber.Text, out selectedSlideIndex) || selectedSlideIndex < 1 || selectedSlideIndex > presentation.Slides.Count)
            {
                MessageBox.Show("شماره اسلاید نامعتبر است.شماره اسلاید معتبر وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add selected files to the selected slide
            foreach (string item in lstFiles.SelectedItems)
            {
                string fileName = item.Split('(')[0].Trim();

                if (item.EndsWith("(Image)"))
                {
                    AddImageToSlide(Path.Combine(folderPath, fileName), selectedSlideIndex,"LTR");
                }
                else if (item.EndsWith("(Video)"))
                {
                    AddVideoToSlide(Path.Combine(folderPath, fileName), selectedSlideIndex);
                }

            }
            //lstFiles.Items.Remove(lstFiles.SelectedItem);
            MessageBox.Show("تصویر با موفقیت به پاورپوینت افزوده شد", "نکته", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimingDuration++;
            lblShowDuration.Text = TimingDuration.ToString();
        }
    }
}
