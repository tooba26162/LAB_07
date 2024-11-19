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

namespace lab_07_task8
{
    public partial class Form1 : Form
    {
        private List<string> photoPaths; 
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            { if (dialog.ShowDialog() == DialogResult.OK)
                {
                    photoPaths = Directory.GetFiles(dialog.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("png") || file.ToLower().EndsWith("bmp")).ToList();
                    if (photoPaths.Count > 0)
                    { 
                        currentIndex = 0;
                        DisplayCurrentPhoto();
                            
                   }
                    else
                    {
                        MessageBox.Show("No photos found in the selected folder.");
                    }
                } 
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (photoPaths.Count > 0)
            {
                currentIndex = (currentIndex + 1) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (photoPaths.Count > 0)
            {
                currentIndex = (currentIndex - 1 + photoPaths.Count) % photoPaths.Count;
                DisplayCurrentPhoto();
            }
        }
        private void DisplayCurrentPhoto()
        { 
            if (photoPaths.Count > 0 && currentIndex >= 0) 
            {
                pictureBox1.Image = new Bitmap(photoPaths[currentIndex]);
                lblPhotoInfo.Text = $"Photo {currentIndex + 1} of {photoPaths.Count}";
            } 
        }
    }
}
