﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ServiceAuto_Server.Domain;
using System.Diagnostics;
using System.Windows.Forms;

namespace ServiceAuto_Client.Service
{
    public class XMLSaveService : FileSaveService
    {
        public XMLSaveService()
        {
            this.extension = ".xml";
            this.fileType = "XML files (*.xml)|*.xml";
        }

        protected override void save(MemoryStream chartImage, List<Car> carList, string figureTitle, string fileName)
        {
            try
            {
                // Serialize the car list to XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, carList);
                }

                // Optionally, handle the chart image if needed (e.g., save it alongside the XML file)
                string imagePath = Path.ChangeExtension(fileName, ".jpg");
                SaveChartImage(chartImage, imagePath);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error writing in the XML file! " + exception.ToString());
            }
        }

        protected override void openFile(string fileName)
        {
            try
            {
                // Open the XML file with the default application
                Process.Start(new ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error opening the XML file! " + exception.ToString());
            }
        }

        private void SaveChartImage(MemoryStream chartImage, string imagePath)
        {
            try
            {
                // Save the chart image as a JPEG file
                using (System.Drawing.Image image = System.Drawing.Image.FromStream(chartImage))
                {
                    image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error saving the chart image! " + exception.ToString());
            }
        }
    }
}
