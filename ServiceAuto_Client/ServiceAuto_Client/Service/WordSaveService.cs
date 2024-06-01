using System;
using System.Collections.Generic;
using System.IO;
using ServiceAuto_Server.Domain;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace ServiceAuto_Client.Service
{
    public class WordSaveService : FileSaveService
    {
        public WordSaveService()
        {
            this.extension = ".docx";
            this.fileType = "Word File (.docx ,.doc)|*.docx";
        }
        protected override void save(MemoryStream chartImage, List<Car> carList, string figureTitle, string fileName)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                application.Visible = false;
                Document document = application.Documents.Add();
                document.PageSetup.TopMargin = (float)50;
                document.PageSetup.BottomMargin = (float)50;
                document.PageSetup.RightMargin = (float)50;
                document.PageSetup.LeftMargin = (float)50;
                foreach (Section wordSection in document.Sections)
                {
                    HeaderFooter ftr = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary];
                    ftr.PageNumbers.RestartNumberingAtSection = false;
                    ftr.PageNumbers.StartingNumber = 1;
                    Range footerRange = ftr.Range;
                    footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    object CurrentPage = WdFieldType.wdFieldPage;
                    string additionalFooter = " / " + DateTime.Today.Day;
                    additionalFooter += ":" + DateTime.Today.Month + ":" + DateTime.Today.Year;
                    footerRange.Fields.Add(footerRange, ref CurrentPage);
                    footerRange.InsertAfter(additionalFooter);
                    footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                }
                object missing = System.Reflection.Missing.Value;
                Paragraph paragraph = document.Content.Paragraphs.Add(ref missing);
                paragraph.Range.Font.Size = 40;
                paragraph.Range.Text = "Employees List" + Environment.NewLine;
                paragraph.Range.InsertParagraphAfter();
                paragraph.Range.Font.Size = 14;
                int rowsNumber = carList.Count + 1;
                Table table = document.Tables.Add(paragraph.Range, rowsNumber, 5, missing, missing);
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                table.Columns[1].PreferredWidth = 70;
                table.Columns[2].PreferredWidth = 150;
                table.Columns[3].PreferredWidth = 60;
                table.Columns[4].PreferredWidth = 80;
                table.Columns[5].PreferredWidth = 110;
                for (int j = 1; j <= 5; j++)
                {
                    table.Cell(1, j).Range.Font.Bold = 1;
                    table.Cell(1, j).Range.Font.Size = 12;
                }
                table.Cell(1, 1).Range.Text = "CarID";
                table.Cell(1, 2).Range.Text = "Brand";
                table.Cell(1, 3).Range.Text = "Owner";
                table.Cell(1, 4).Range.Text = "Color";
                table.Cell(1, 5).Range.Text = "Fuel";
                table.Cell(1, 6).Range.Text = "EngineNo";
                table.Cell(1, 7).Range.Text = "PlateNo";
                table.Cell(1, 8).Range.Text = "Repaired";
                table.Rows.SetHeight(14, WdRowHeightRule.wdRowHeightExactly);
                table.Rows[1].HeadingFormat = -1;
                for (int i = 2; i <= rowsNumber; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        table.Cell(i, j).Range.Font.Size = 12;
                        table.Cell(i, j).Range.Font.Name = "Calibri";
                    }
                    table.Cell(i, 1).Range.Text = carList[i - 2].CarID.ToString();
                    table.Cell(i, 2).Range.Text = carList[i - 2].Brand;
                    table.Cell(i, 3).Range.Text = carList[i - 2].Owner;
                    table.Cell(i, 4).Range.Text = carList[i - 2].Color.ToString();
                    table.Cell(i, 5).Range.Text = carList[i - 2].Fuel.ToString();
                    table.Cell(i, 6).Range.Text = carList[i - 2].EngineNo.ToString();
                    table.Cell(i, 7).Range.Text = carList[i - 2].PlateNo.ToString();
                    table.Cell(i, 8).Range.Text = carList[i - 2].Repaired.ToString();
                }
                paragraph.Range.Text = Environment.NewLine;
                paragraph.Range.Text = Environment.NewLine;
                paragraph.Range.InlineShapes.AddHorizontalLineStandard();
                string target = this.createImage(chartImage);
                if (target != null && target != "")
                {
                    paragraph.Range.InlineShapes.AddPicture(target);
                    paragraph.Range.InsertParagraphAfter();
                    paragraph.Range.Text = "Figure: " + figureTitle;
                    paragraph.Range.Font.Size = 14;
                    paragraph.Range.InsertParagraphAfter();
                    this.deleteFile(target);
                }
                paragraph.Range.InlineShapes.AddHorizontalLineStandard();
                document.SaveAs2(fileName);
                document.Close();
                application.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
                //
                //if (target != null && target != "")
                //File.Delete(target);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error writing in Word file!  " + exception.ToString());
            }
        }

        protected override void openFile(string fileName)
        {
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
