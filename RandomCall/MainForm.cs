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
    public partial class MainForm : Form
    {
        IWorkbook nameList = null;
        string file = "list.xlsx"; // 选中的文件路径
        bool enableRepeat = false; // 是否允许重复点名
        List<string[]> excelData = new List<string[]>(); // 初始化导入的名单
        List<string[]> callData = new List<string[]>(); // 初始化已点名名单

        public MainForm()
        {
            InitializeComponent();

            // 启用自动缩放
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F); // 基于标准 DPI (96 DPI)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                excelData = ReadExcel(file); // 读取默认名单文件
                label2.Text = "已加载名单: " + excelData.Count.ToString() + "人"; // 更新标签文本
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到默认名单文件，请手动导入", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "请导入名单"; // 更新标签文本
                label2.Text = "未加载名单"; // 更新标签文本
            }
        }

        private void 已点名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableRepeat)
            {
                MessageBox.Show("允许重复点名已开启", "已点名名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (callData.Count < 1)
            {
                MessageBox.Show("没有已点名名单", "已点名名单", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder(); // 创建一个StringBuilder对象用于拼接字符串
            foreach (string[] row in callData) // 遍历动态数组中的每一行
            {
                foreach (string cell in row) // 遍历每一行中的每个单元格
                {
                    sb.Append(cell + ", "); // 将单元格内容添加到StringBuilder中，并用制表符分隔
                }
            }
            MessageBox.Show(sb.ToString(), "已点名名单");
        }

        private void 导入名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Multiselect = false;
            fileDlg.Title = "导入名单文件";
            fileDlg.Filter = "Excel文件 (*.xls;*.xlsx)|*.xls;*.xlsx|所有文件 (*.*)|*.*";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                file = fileDlg.FileName;
                excelData = ReadExcel(file); // 调用读取方法
                label2.Text = "已加载名单: " + excelData.Count.ToString() + "人"; // 更新标签文本
                label1.Text = "名单已导入"; // 更新标签文本
            }
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
            for (int i = 1; i <= sheet.LastRowNum; i++)
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

        private void 重置名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excelData = ReadExcel(file);
            callData = null;
            label1.Text = "名单已重置";
        }

        private void 允许重复点名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (允许重复点名ToolStripMenuItem.Checked)
            {
                enableRepeat = true; // 允许重复点名
            }
            else
            {
                enableRepeat = false; // 不允许重复点名
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm form2 = new AboutForm();
            form2.ShowDialog();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (excelData == null || excelData.Count == 0)
            {
                label1.Text = "名单为空"; // 更新标签文本
                return;
            }

            Random rand = new Random(); // 创建一个随机数生成器
            int index = -1; // 用于存储随机索引

            start_btn.Text = "点名中..."; // 更新按钮文本
            start_btn.Enabled = false; // 禁用按钮

            for (int i = 0; i < 10; i++)
            {
                index = rand.Next(0, excelData.Count); // 随机生成索引
                string name = excelData[index][0]; // 获取随机姓名
                label1.Text = name; // 更新标签文本
                label1.Refresh(); // 刷新标签以显示最新姓名
                System.Threading.Thread.Sleep(75); // 暂停100毫秒
            }

            if (!enableRepeat) // 如果不允许重复点名
            {
                if (index >= 0 && index < excelData.Count)
                {
                    // 保存选中的元素
                    string[] selected = excelData[index];

                    // 移除选中的元素
                    excelData.RemoveAt(index);

                    // 将选中的元素添加到已点名名单
                    callData.Add(selected);
                }
            }

            start_btn.Text = "点名"; // 更新按钮文本
            start_btn.Enabled = true; // 启用按钮
        }
    }
}
