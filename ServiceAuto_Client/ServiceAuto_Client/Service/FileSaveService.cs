﻿using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using ServiceAuto_Server.Domain;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ServiceAuto_Client.Service
{
    public abstract class FileSaveService
    {
        protected string extension;
        protected string fileType;

        public void CreateFile(MemoryStream chartImage, List<Car> carList, string figureTitle)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Enter the file name!";
            sfd.FileName = "ServiceAuto";
            sfd.DefaultExt = this.extension;
            sfd.Filter = this.fileType;
            sfd.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            sfd.CheckFileExists = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(sfd.FileName))
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(sfd.FileName);
                    }
                    this.save(chartImage, carList, figureTitle, sfd.FileName);
                    DialogResult dialogResult = MessageBox.Show("Do you want to open the file??", "Save completed!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.openFile(sfd.FileName);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error writing in the Word file!  " + exception.ToString());
                }
            }
        }

        protected string createImage(MemoryStream chartImage)
        {
            string pathNameFile = "";
            try
            {
                Image returnImage = Image.FromStream(chartImage);
                returnImage.Save("chart.jpg", ImageFormat.Jpeg);
                string path = Directory.GetCurrentDirectory();
                pathNameFile = path + "\\chart.jpg";
                return pathNameFile;
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected void deleteFile(string target)
        {
            if (target != null && target != "")
                File.Delete(target);
        }
        protected abstract void openFile(string fileName);
        protected abstract void save(MemoryStream chartImage, List<Car> carList, string figureTitle, string fileName);
    }
}
