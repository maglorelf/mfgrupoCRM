using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.IO;
namespace mfgrupoCRM.Controllers
{
    public class ExportController : Controller
    {

        //public IActionResult Index(string SaveOption)
        //{
        //    if (SaveOption == null)
        //        return View();
        //    //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
        //    //The instantiation process consists of two steps.
        //    //Step 1 : Instantiate the spreadsheet creation engine.
        //    ExcelEngine excelEngine = new ExcelEngine();
        //    //Step 2 : Instantiate the excel application object.
        //    IApplication application = excelEngine.Excel;
        //    // Creating new workbook
        //    IWorkbook workbook = application.Workbooks.Create(3);
        //    IWorksheet sheet = workbook.Worksheets[0];
        //    #region Generate Excel
        //    sheet.Range["A2"].ColumnWidth = 30;
        //    sheet.Range["B2"].ColumnWidth = 30;
        //    sheet.Range["C2"].ColumnWidth = 30;
        //    sheet.Range["D2"].ColumnWidth = 30;
        //    sheet.Range["A2:D2"].Merge(true);
        //    //Inserting sample text into the first cell of the first sheet.
        //    sheet.Range["A2"].Text = "EXPENSE REPORT";
        //    sheet.Range["A2"].CellStyle.Font.FontName = "Verdana";
        //    sheet.Range["A2"].CellStyle.Font.Bold = true;
        //    sheet.Range["A2"].CellStyle.Font.Size = 28;
        //    sheet.Range["A2"].CellStyle.Font.RGBColor = Color.FromArgb(0, 0, 112, 192);
        //    sheet.Range["A2"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
        //    sheet.Range["A4"].Text = "Employee";
        //    sheet.Range["B4"].Text = "Roger Federer";
        //    sheet.Range["A4:B7"].CellStyle.Font.FontName = "Verdana";
        //    sheet.Range["A4:B7"].CellStyle.Font.Bold = true;
        //    sheet.Range["A4:B7"].CellStyle.Font.Size = 11;
        //    sheet.Range["A4:A7"].CellStyle.Font.RGBColor = Color.FromArgb(0, 128, 128, 128);
        //    sheet.Range["A4:A7"].HorizontalAlignment = ExcelHAlign.HAlignLeft;
        //    sheet.Range["B4:B7"].CellStyle.Font.RGBColor = Color.FromArgb(0, 174, 170, 170);
        //    sheet.Range["B4:B7"].HorizontalAlignment = ExcelHAlign.HAlignRight;
        //    sheet.Range["A9:D20"].CellStyle.Font.FontName = "Verdana";
        //    sheet.Range["A9:D20"].CellStyle.Font.Size = 11;
        //    sheet.Range["A5"].Text = "Department";
        //    sheet.Range["B5"].Text = "Administration";
        //    sheet.Range["A6"].Text = "Week Ending";
        //    sheet.Range["B6"].NumberFormat = "m/d/yyyy";
        //    sheet.Range["B6"].DateTime = DateTime.Parse("10/20/2012", CultureInfo.InvariantCulture);
        //    sheet.Range["A7"].Text = "Mileage Rate";
        //    sheet.Range["B7"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B7"].Number = 0.70;
        //    sheet.Range["A10"].Text = "Miles Driven";
        //    sheet.Range["A11"].Text = "Miles Reimbursement";
        //    sheet.Range["A12"].Text = "Parking and Tolls";
        //    sheet.Range["A13"].Text = "Auto Rental";
        //    sheet.Range["A14"].Text = "Lodging";
        //    sheet.Range["A15"].Text = "Breakfast";
        //    sheet.Range["A16"].Text = "Lunch";
        //    sheet.Range["A17"].Text = "Dinner";
        //    sheet.Range["A18"].Text = "Snacks";
        //    sheet.Range["A19"].Text = "Others";
        //    sheet.Range["A20"].Text = "Total";
        //    sheet.Range["A20:D20"].CellStyle.Color = Color.FromArgb(0, 0, 112, 192);
        //    sheet.Range["A20:D20"].CellStyle.Font.Color = ExcelKnownColors.White;
        //    sheet.Range["A20:D20"].CellStyle.Font.Bold = true;
        //    IStyle style = sheet["B9:D9"].CellStyle;
        //    style.VerticalAlignment = ExcelVAlign.VAlignCenter;
        //    style.HorizontalAlignment = ExcelHAlign.HAlignRight;
        //    style.Color = Color.FromArgb(0, 0, 112, 192);
        //    style.Font.Bold = true;
        //    style.Font.Color = ExcelKnownColors.White;
        //    sheet.Range["A9"].Text = "Expenses";
        //    sheet.Range["A9"].CellStyle.Color = Color.FromArgb(0, 0, 112, 192);
        //    sheet.Range["A9"].CellStyle.Font.Color = ExcelKnownColors.White;
        //    sheet.Range["A9"].CellStyle.Font.Bold = true;
        //    sheet.Range["B9"].Text = "Day 1";
        //    sheet.Range["B10"].Number = 100;
        //    sheet.Range["B11"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B11"].Formula = "=(B7*B10)";
        //    sheet.Range["B12"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B12"].Number = 0;
        //    sheet.Range["B13"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B13"].Number = 0;
        //    sheet.Range["B14"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B14"].Number = 0;
        //    sheet.Range["B15"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B15"].Number = 9;
        //    sheet.Range["B16"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B16"].Number = 12;
        //    sheet.Range["B17"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B17"].Number = 13;
        //    sheet.Range["B18"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B18"].Number = 9.5;
        //    sheet.Range["B19"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B19"].Number = 0;
        //    sheet.Range["B20"].NumberFormat = "$#,##0.00";
        //    sheet.Range["B20"].Formula = "=SUM(B11:B19)";
        //    sheet.Range["C9"].Text = "Day 2";
        //    sheet.Range["C10"].Number = 145;
        //    sheet.Range["C11"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C11"].Formula = "=(B7*C10)";
        //    sheet.Range["C12"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C12"].Number = 15;
        //    sheet.Range["C13"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C13"].Number = 0;
        //    sheet.Range["C14"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C14"].Number = 45;
        //    sheet.Range["C15"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C15"].Number = 9;
        //    sheet.Range["C16"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C16"].Number = 12;
        //    sheet.Range["C17"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C17"].Number = 15;
        //    sheet.Range["C18"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C18"].Number = 7;
        //    sheet.Range["C19"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C19"].Number = 0;
        //    sheet.Range["C20"].NumberFormat = "$#,##0.00";
        //    sheet.Range["C20"].Formula = "=SUM(C11:C19)";
        //    sheet.Range["D9"].Text = "Day 3";
        //    sheet.Range["D10"].Number = 113;
        //    sheet.Range["D11"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D11"].Formula = "=(B7*D10)";
        //    sheet.Range["D12"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D12"].Number = 17;
        //    sheet.Range["D13"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D13"].Number = 8;
        //    sheet.Range["D14"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D14"].Number = 45;
        //    sheet.Range["D15"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D15"].Number = 7;
        //    sheet.Range["D16"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D16"].Number = 11;
        //    sheet.Range["D17"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D17"].Number = 16;
        //    sheet.Range["D18"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D18"].Number = 7;
        //    sheet.Range["D19"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D19"].Number = 5;
        //    sheet.Range["D20"].NumberFormat = "$#,##0.00";
        //    sheet.Range["D20"].Formula = "=SUM(D11:D19)";
        //    #endregion
        //    string ContentType = null;
        //    string fileName = null;
        //    if (SaveOption == "ExcelXls")
        //    {
        //        ContentType = "Application/vnd.ms-excel";
        //        fileName = "Sample.xls";
        //    }
        //    else
        //    {
        //        workbook.Version = ExcelVersion.Excel2013;
        //        ContentType = "Application/msexcel";
        //        fileName = "Sample.xlsx";
        //    }
        //    MemoryStream ms = new MemoryStream();
        //    workbook.SaveAs(ms);
        //    ms.Position = 0;
        //    return File(ms, ContentType, fileName);
        //}
        //#region PDF
        ////Declaring necessary objects.        
        //Color gray = Color.FromArgb(255, 77, 77, 77);
        //Color black = Color.FromArgb(255, 0, 0, 0);
        //Color white = Color.FromArgb(255, 255, 255, 255);
        //Color violet = Color.FromArgb(255, 151, 108, 174);
        //public IActionResult PdfFeatures()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult GeneratePDF()
        //{
        //    //Creating new PDF document instance
        //    PdfDocument document = new PdfDocument();
        //    //Setting margin
        //    document.PageSettings.Margins.All = 0;
        //    //Adding a new page
        //    PdfPage page = document.Pages.Add();
        //    PdfGraphics g = page.Graphics;
        //    //Creating font instances
        //    PdfFont headerFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 35);
        //    PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);
        //    //Drawing content onto the PDF
        //    g.DrawRectangle(new PdfSolidBrush(gray), new Syncfusion.Drawing.RectangleF(0, 0, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height));
        //    g.DrawRectangle(new PdfSolidBrush(black), new Syncfusion.Drawing.RectangleF(0, 0, page.Graphics.ClientSize.Width, 130));
        //    g.DrawRectangle(new PdfSolidBrush(white), new Syncfusion.Drawing.RectangleF(0, 400, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height - 450));
        //    g.DrawString("Enterprise", headerFont, new PdfSolidBrush(violet), new Syncfusion.Drawing.PointF(10, 20));
        //    g.DrawRectangle(new PdfSolidBrush(violet), new Syncfusion.Drawing.RectangleF(10, 63, 140, 35));
        //    g.DrawString("Reporting Solutions", subHeadingFont, new PdfSolidBrush(black), new Syncfusion.Drawing.PointF(15, 70));
        //    PdfLayoutResult result = HeaderPoints("Develop cloud-ready reporting applications in as little as 20% of the time.", 15, page);
        //    result = HeaderPoints("Proven, reliable platform thousands of users over the past 10 years.", result.Bounds.Bottom + 15, page);
        //    result = HeaderPoints("Microsoft Excel, Word, Adobe PDF, RDL display and editing.", result.Bounds.Bottom + 15, page);
        //    result = HeaderPoints("Why start from scratch? Rely on our dependable solution frameworks", result.Bounds.Bottom + 15, page);
        //    result = BodyContent("Deployment-ready framework tailored to your needs.", result.Bounds.Bottom + 45, page);
        //    result = BodyContent("Our architects and developers have years of reporting experience.", result.Bounds.Bottom + 25, page);
        //    result = BodyContent("Solutions available for web, desktop, and mobile applications.", result.Bounds.Bottom + 25, page);
        //    result = BodyContent("Backed by our end-to-end product maintenance infrastructure.", result.Bounds.Bottom + 25, page);
        //    result = BodyContent("The quickest path from concept to delivery.", result.Bounds.Bottom + 25, page);
        //    PdfPen redPen = new PdfPen(PdfBrushes.Red, 2);
        //    g.DrawLine(redPen, new Syncfusion.Drawing.PointF(40, result.Bounds.Bottom + 92), new Syncfusion.Drawing.PointF(40, result.Bounds.Bottom + 145));
        //    float headerBulletsXposition = 40;
        //    PdfTextElement txtElement = new PdfTextElement("The Experts");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
        //    txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 90, 450, 200));
        //    PdfPen violetPen = new PdfPen(PdfBrushes.Violet, 2);
        //    g.DrawLine(violetPen, new Syncfusion.Drawing.PointF(headerBulletsXposition + 280, result.Bounds.Bottom + 92), new Syncfusion.Drawing.PointF(headerBulletsXposition + 280, result.Bounds.Bottom + 145));
        //    txtElement = new PdfTextElement("Accurate Estimates");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
        //    result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 290, result.Bounds.Bottom + 90, 450, 200));
        //    txtElement = new PdfTextElement("A substantial number of .NET reporting applications use our frameworks");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
        //    result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 5, 250, 200));
        //    txtElement = new PdfTextElement("Given our expertise, you can expect estimates to be accurate.");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
        //    result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 290, result.Bounds.Y, 250, 200));
        //    PdfPen greenPen = new PdfPen(PdfBrushes.Green, 2);
        //    g.DrawLine(greenPen, new Syncfusion.Drawing.PointF(40, result.Bounds.Bottom + 32), new Syncfusion.Drawing.PointF(40, result.Bounds.Bottom + 85));
        //    txtElement = new PdfTextElement("Product Licensing");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
        //    txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 30, 450, 200));
        //    PdfPen bluePen = new PdfPen(PdfBrushes.Blue, 2);
        //    g.DrawLine(bluePen, new Syncfusion.Drawing.PointF(headerBulletsXposition + 280, result.Bounds.Bottom + 32), new Syncfusion.Drawing.PointF(headerBulletsXposition + 280, result.Bounds.Bottom + 85));
        //    txtElement = new PdfTextElement("About Syncfusion");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 20);
        //    result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 290, result.Bounds.Bottom + 30, 450, 200));
        //    txtElement = new PdfTextElement("Solution packages can be combined with product licensing for great cost savings.");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
        //    result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 5, result.Bounds.Bottom + 5, 250, 200));
        //    txtElement = new PdfTextElement("Syncfusion has more than 7,000 customers including large financial institutions and Fortune 100 companies.");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);
        //    result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 290, result.Bounds.Y, 250, 200));
        //    g.DrawString("All trademarks mentioned belong to their owners.", new PdfStandardFont(PdfFontFamily.TimesRoman, 8, PdfFontStyle.Italic), PdfBrushes.White, new Syncfusion.Drawing.PointF(10, g.ClientSize.Height - 30));
        //    PdfTextWebLink linkAnnot = new PdfTextWebLink();
        //    linkAnnot.Url = "//www.syncfusion.com";
        //    linkAnnot.Text = "www.syncfusion.com";
        //    linkAnnot.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 8, PdfFontStyle.Italic);
        //    linkAnnot.Brush = PdfBrushes.White;
        //    linkAnnot.DrawTextWebLink(page, new Syncfusion.Drawing.PointF(g.ClientSize.Width - 100, g.ClientSize.Height - 30));
        //    //Saving the PDF to the MemoryStream
        //    MemoryStream ms = new MemoryStream();
        //    document.Save(ms);
        //    //If the position is not set to '0' then the PDF will be empty.
        //    ms.Position = 0;
        //    //Download the PDF document in the browser.
        //    FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
        //    fileStreamResult.FileDownloadName = "Sample.pdf";
        //    return fileStreamResult;
        //}
        //private PdfLayoutResult BodyContent(string text, float yPosition, PdfPage page)
        //{
        //    float headerBulletsXposition = 35;
        //    PdfTextElement txtElement = new PdfTextElement("3");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.ZapfDingbats, 16);
        //    txtElement.Brush = new PdfSolidBrush(violet);
        //    txtElement.StringFormat = new PdfStringFormat();
        //    txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
        //    txtElement.StringFormat.LineLimit = true;
        //    txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition, yPosition, 320, 100));
        //    txtElement = new PdfTextElement(text);
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 17);
        //    txtElement.Brush = new PdfSolidBrush(white);
        //    txtElement.StringFormat = new PdfStringFormat();
        //    txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
        //    txtElement.StringFormat.LineLimit = true;
        //    PdfLayoutResult result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 25, yPosition, 450, 130));
        //    return result;
        //}
        //private PdfLayoutResult HeaderPoints(string text, float yPosition, PdfPage page)
        //{
        //    float headerBulletsXposition = 220;
        //    PdfTextElement txtElement = new PdfTextElement("l");
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.ZapfDingbats, 10);
        //    txtElement.Brush = new PdfSolidBrush(violet);
        //    txtElement.StringFormat = new PdfStringFormat();
        //    txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
        //    txtElement.StringFormat.LineLimit = true;
        //    txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition, yPosition, 300, 100));
        //    txtElement = new PdfTextElement(text);
        //    txtElement.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 11);
        //    txtElement.Brush = new PdfSolidBrush(white);
        //    txtElement.StringFormat = new PdfStringFormat();
        //    txtElement.StringFormat.WordWrap = PdfWordWrapType.Word;
        //    txtElement.StringFormat.LineLimit = true;
        //    PdfLayoutResult result = txtElement.Draw(page, new Syncfusion.Drawing.RectangleF(headerBulletsXposition + 20, yPosition, 320, 100));
        //    return result;
        //}
        //#endregion
    }
}
