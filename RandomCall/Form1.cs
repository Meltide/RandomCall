using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace RandomCall
{
    public partial class Form1 : Form
    {
        IWorkbook nameList = null;
        List<string[]> excelData = new List<string[]>(); // 初始化动态数组

        public Form1()
        {
            InitializeComponent();
        }

        private void 导入名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Multiselect = false;
            fileDlg.Title = "导入名单文件";
            fileDlg.Filter = "Excel文件 (*.xls;*.xlsx)|*.xls;*.xlsx|所有文件 (*.*)|*.*";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                string file = fileDlg.FileName;
                List<string[]> excelData = ReadExcel(file); // 调用读取方法
                label1.Text = "名单已导入"; // 更新标签文本
            }
        }
        private void 已点名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", excelData), "已点名名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<string[]> ReadExcel(string filePath)
        {
            List<string[]> data = new List<string[]>(); // 动态数组存储数据
            IWorkbook workbook;

            // 打开文件流
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // 根据文件扩展名选择解析器
                if (Path.GetExtension(filePath).Equals(".xls"))
                {
                    workbook = new HSSFWorkbook(file); // 处理 .xls 文件
                }
                else
                {
                    workbook = new XSSFWorkbook(file); // 处理 .xlsx 文件
                }
            }

            // 获取第一个工作表
            ISheet sheet = workbook.GetSheetAt(0);

            // 遍历行
            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row != null)
                {
                    List<string> rowData = new List<string>();
                    // 遍历列
                    for (int j = 0; j < row.LastCellNum; j++)
                    {
                        ICell cell = row.GetCell(j);
                        if (cell != null)
                        {
                            rowData.Add(cell.ToString()); // 将单元格内容添加到行数据
                        }
                        else
                        {
                            rowData.Add(string.Empty); // 如果单元格为空，添加空字符串
                        }
                    }
                    data.Add(rowData.ToArray()); // 将行数据添加到动态数组
                }
            }

            return data; // 返回动态数组
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
