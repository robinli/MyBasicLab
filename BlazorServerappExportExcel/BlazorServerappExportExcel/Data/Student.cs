using Microsoft.JSInterop;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;

namespace BlazorServerappExportExcel.Data
{
    public class Student
    {
        public void GenerateExcel(IJSRuntime iJSRuntime)
        {
            byte[] filecontents;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using(var package=new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                #region Header Row
                workSheet.Cells[1, 1].Value = "Student Name";
                workSheet.Cells[1, 1].Style.Font.Size = 12;
                workSheet.Cells[1, 1].Style.Font.Bold = true;
                workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                workSheet.Cells[1, 2].Value = "Student Roll";
                workSheet.Cells[1, 2].Style.Font.Size = 12;
                workSheet.Cells[1, 2].Style.Font.Bold = true;
                workSheet.Cells[1, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                #endregion

                #region Body 1st Row
                workSheet.Cells[2, 1].Value = "Tom";
                workSheet.Cells[2, 1].Style.Font.Size = 12;
                workSheet.Cells[2, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                                
                workSheet.Cells[2, 2].Value = "1001";
                workSheet.Cells[2, 2].Style.Font.Size = 12;
                workSheet.Cells[2, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                #endregion

                #region Body 2nd Row
                workSheet.Cells[3, 1].Value = "Course";
                workSheet.Cells[3, 1].Style.Font.Size = 12;
                workSheet.Cells[3, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                                
                workSheet.Cells[3, 2].Value = "1002";
                workSheet.Cells[3, 2].Style.Font.Size = 12;
                workSheet.Cells[3, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                #endregion

                #region Body 3hd Row
                workSheet.Cells[4, 1].Value = "Jack";
                workSheet.Cells[4, 1].Style.Font.Size = 12;
                workSheet.Cells[4, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                                
                workSheet.Cells[4, 2].Value = "1003";
                workSheet.Cells[4, 2].Style.Font.Size = 12;
                workSheet.Cells[4, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                #endregion

                filecontents = package.GetAsByteArray();
            }

            iJSRuntime.InvokeAsync<Student>(
                "saveAsFile",
                "StudentList.xlsx",
                Convert.ToBase64String(filecontents)
                );
        }
    }
}
