using System;
using System.Collections.Generic;
using System.IO;
using ServiceAuto_Server.Domain;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;

namespace ServiceAuto_Client.Service
{
    public class ExcelSaveService : FileSaveService
    {
        public ExcelSaveService()
        {
            this.extension = ".xlsx";
            this.fileType = "Excel files (*.xlsx)|*.xlsx";
        }
        protected override void save(MemoryStream chartImage, List<Car> carList, string figureTitle, string fileName)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;
                object misValue = System.Reflection.Missing.Value;
                _Workbook workbook = app.Workbooks.Add(misValue);
                _Worksheet worksheet = workbook.Worksheets[1];
                worksheet.Name = "Company";
                worksheet.EnableSelection = XlEnableSelection.xlNoSelection;

                Range xlRange;
                xlRange = worksheet.Cells[1, 3];
                xlRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                xlRange.Interior.Color = Color.LightBlue;
                worksheet.Cells[1, 3] = "Car List";
                worksheet.Range[worksheet.Cells[1, 3], worksheet.Cells[1, 5]].Merge();

                worksheet.Cells[3, 2] = "CarID";
                worksheet.Columns[2].ColumnWidth = 5;
                worksheet.Cells[3, 3] = "Brand";
                worksheet.Columns[3].ColumnWidth = 30;
                worksheet.Cells[3, 4] = "Owner";
                worksheet.Columns[4].ColumnWidth = 15;
                worksheet.Cells[3, 5] = "Color";
                worksheet.Columns[5].ColumnWidth = 15;
                worksheet.Cells[3, 6] = "Fuel";
                worksheet.Columns[6].ColumnWidth = 20;
                worksheet.Cells[3, 7] = "EngineNo";
                worksheet.Columns[6].ColumnWidth = 20;
                worksheet.Cells[3, 8] = "PlateNo";
                worksheet.Columns[6].ColumnWidth = 20;
                worksheet.Cells[3, 9] = "Repaired";
                worksheet.Columns[6].ColumnWidth = 20;
                for (int j = 1; j <= 8; j++)
                {
                    xlRange = worksheet.Cells[3, j + 1];
                    xlRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    xlRange.Borders.Color = Color.DarkBlue;
                    xlRange.Font.Size = 12;
                    xlRange.Font.FontStyle = FontStyle.Bold;
                }

                int rowsNumber = carList.Count;
                for (int i = 1; i <= rowsNumber; i++)
                {
                    worksheet.Cells[3 + i, 2] = carList[i - 1].CarID.ToString();
                    worksheet.Cells[3 + i, 3] = carList[i - 1].Owner;
                    worksheet.Cells[3 + i, 4] = carList[i - 1].Brand;
                    worksheet.Cells[3 + i, 5] = carList[i - 1].Color.ToString();
                    worksheet.Cells[3 + i, 6] = carList[i - 1].Fuel.ToString();
                    worksheet.Cells[3 + i, 7] = carList[i - 1].EngineNo.ToString();
                    worksheet.Cells[3 + i, 8] = carList[i - 1].PlateNo.ToString();
                    worksheet.Cells[3 + i, 9] = carList[i - 1].Repaired.ToString();
                    for (int j = 1; j <= 8; j++)
                    {
                        xlRange = worksheet.Cells[3 + i, j + 1];
                        xlRange.Font.Size = 12;
                        xlRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                        xlRange.Borders.Color = Color.DarkBlue;
                        xlRange.Font.Size = 12;
                        if (i % 2 == 0)
                            xlRange.Interior.Color = Color.LightBlue;
                        else
                            xlRange.Interior.Color = Color.White;
                    }
                }
                string target = this.createImage(chartImage);
                if (target != null && target != "")
                {
                    worksheet.Cells[rowsNumber + 5, 2] = "Adding picture in Excel File";
                    worksheet.Range[worksheet.Cells[rowsNumber + 6, 2], worksheet.Cells[rowsNumber + 15, 5]].Merge();
                    xlRange = worksheet.Cells[rowsNumber + 6, 2];
                    float left = (float)((double)xlRange.Left);
                    float top = (float)((double)xlRange.Top);
                    worksheet.Shapes.AddPicture(target, MsoTriState.msoFalse, MsoTriState.msoCTrue, left, top, xlRange.Width * 10, xlRange.Height * 15);
                    this.deleteFile(target);
                }
                workbook.SaveAs(fileName, misValue, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                this.objectRelease(worksheet);
                workbook.Close(true, misValue, misValue);
                app.Quit();
                this.objectRelease(workbook);
                this.objectRelease(app);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error writing in Excel file!  " + exception.ToString());
            }
        }

        protected override void openFile(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Workbook wb = excel.Workbooks.Open(fileName);
        }

        private void objectRelease(object obj)
        {
            try
            {
                Marshal.FinalReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
