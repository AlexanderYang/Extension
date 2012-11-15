using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Extension;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Extension
{
    public partial class WorkloadRibbon
    {
        public SortedDictionary<string, Color> empList { get; set; }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var activeWorksheet = ((Worksheet)Globals.WorkloadAddIn.Application.ActiveSheet);
                Range rows = activeWorksheet.Rows;
                empList = new SortedDictionary<String, Color>();
                empList.Add("<Select name assign to:>", Color.White);
                for (int i = 2; i <= rows.Count && rows[i].Cells[1].Value2 != null; i++)
                {
                    if (!empList.ContainsKey(rows[i].Cells[1].Value2))
                    {
                        empList.Add(rows[i].Cells[1].Value2, System.Drawing.ColorTranslator.FromOle(Convert.ToInt32(rows[i].Cells[1].Interior.Color)));
                    }
                }
                AssignForm assignForm = new AssignForm(empList);
                assignForm.ShowDialog();

                AssignEventArgs assignArgs = assignForm.Args;
                if (!assignForm.IsAssigned)
                {
                    return;
                }
                Color color = assignArgs.backgroundColor;
                if (color.Name == "0" && color.IsEmpty)
                {
                    foreach (String k in empList.Keys)
                    {
                        if (k == assignArgs.AssignedEmp)
                        {
                            color = empList[k];
                            break;
                        }
                        else
                        {
                            //if the new RAE's background color is not defined, assign a default one for him/her.
                            color = System.Drawing.Color.LightGray;
                        }
                    }
                }


                if (!isProjectAssigned(activeWorksheet, assignArgs, color)) 
                {
                    assignProject(activeWorksheet, assignArgs, color);
                }
            }
            catch (Exception)
            {
            }
        }

        private bool isProjectAssigned(Worksheet worksheet, AssignEventArgs assignArgs, Color color)
        {
            bool isAssigned = false;
            var rows = worksheet.Rows;
            for (int i = 2; (i < worksheet.Rows.Count && !isAssigned && rows[i].Cells[1].Value2 != null); ++i)
            {
                if (rows[i].Value2 != null)
                {
                    for (int j = 2; j < 55; j++)
                    {
                        if (rows[i].Cells[j].Value2 == assignArgs.ProjectName)
                        {
                            DialogResult dialogResult = MessageBox.Show(assignArgs.ProjectName + " has been assigned to " + rows[i].Cells[1].Value2 + ".\n Do you want to reassgin it?",
                      "Save Exception", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (dialogResult == DialogResult.OK)
                            {
                                String r = "A" + i.ToString() + ":BB" + i.ToString();
                                worksheet.Range[r].Delete(XlDeleteShiftDirection.xlShiftUp);
                                assignProject(worksheet, assignArgs, color);
                            }
                            isAssigned = true;
                            return true;
                        }
                    }
                }
            }
            return isAssigned;
        }

        private void assignProject(Worksheet worksheet, AssignEventArgs assignArgs, Color color)
        {
            String projectName = assignArgs.ProjectName;
            String empAssigned = assignArgs.AssignedEmp;
            var rows = worksheet.Rows;
            //search for the assigned employee's name in the first clomun
            int i = 2;
            bool hasExisted = false;
            for (; (i < rows.Count && !hasExisted && rows[i].Cells[1].Value2 != null); i++)
            {
                Range row = rows[i];
                //get the last row of this assigned employee.
                int k = i;
                while ((rows[k].Value2 != null) && (rows[k].Cells[1].Value2 == empAssigned) && (k < rows.Count))
                {
                    hasExisted = true;
                    k++;
                }
                if (hasExisted)
                {
                    //insert a new row for the current project.
                    if (rows[k].Cells[1].Value2 != null)//copy the rest range to a row below
                    {
                        int l = k;
                        do { l++; } while (rows[l].Cells[1].Value2 != null);
                        String r = "A" + k.ToString() + ":BB" + k.ToString();
                        worksheet.Range[r].Insert(XlInsertShiftDirection.xlShiftDown);
                        worksheet.Range[r].Cells.ClearFormats();
                        //AutoFill(worksheet.Range[r], false);
                    }
                    SetRow(worksheet, k, assignArgs, color);
                    break;
                }

            }
            if (!hasExisted)
            {
                //add the new emp in the last row
                SetRow(worksheet, i, assignArgs, color);
            }
        }

        private static void SetRow(Worksheet sheet, int index, AssignEventArgs assignArgs, Color color)
        {
            sheet.Cells[index, 1] = assignArgs.AssignedEmp;  
            System.Globalization.CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
            var rule = CalendarWeekRule.FirstFourDayWeek;
            int fromWeekNo = ci.Calendar.GetWeekOfYear(
                assignArgs.FromDate,
                //ci.DateTimeFormat.CalendarWeekRule,
                rule,
                DayOfWeek.Sunday
            );
            int toWeekNo = ci.Calendar.GetWeekOfYear(
                assignArgs.ToDate,
                rule,
                DayOfWeek.Sunday
            );
            for (int j = fromWeekNo; j <= toWeekNo; j++)
            {
                sheet.Cells[index, j+1] = assignArgs.ProjectName;
                sheet.Cells[index, j+1].Interior.Color = color;
            }
            sheet.Cells[index, 1].Interior.Color = color;
            MessageBox.Show(assignArgs.ProjectName + " has been assigned to " + assignArgs.AssignedEmp, "Save Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
