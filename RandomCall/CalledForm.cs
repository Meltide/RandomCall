using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCall
{
    public partial class CalledForm : Form
    {
        private List<string[]> originData;
        private List<string[]> excelData;
        private List<string[]> callData;
        private MainForm mainForm; // 保存 MainForm 的实例

        public CalledForm(MainForm form, List<string[]> origin, List<string[]> data, List<string[]> called)
        {
            InitializeComponent();
            mainForm = form; // 初始化 MainForm 实例
            originData = origin;
            excelData = data;
            callData = called;
        }

        private void CalledForm_Load(object sender, EventArgs e)
        {
            foreach (var item in excelData)
            {
                listBox1.Items.Add(string.Join(", ", item));
            }
            label3.Text = excelData.Count.ToString() + "人"; // 更新标签文本

            foreach (var item in callData)
            {
                listBox2.Items.Add(string.Join(", ", item));
            }
            label4.Text = callData.Count.ToString() + "人"; // 更新标签文本
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择要移出的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedItem = listBox1.SelectedItem;

            if (selectedItem.ToString() == "名单未加载" || selectedItem.ToString() == "名单已点完")
            {
                return;
            }

            int selectedIndex = listBox1.SelectedIndex;

            // 确保索引在有效范围内
            if (selectedIndex >= 0 && selectedIndex < excelData.Count)
            {
                listBox1.Items.Remove(selectedItem);
                excelData.RemoveAt(selectedIndex); // 从数据列表中移除对应项
                label3.Text = excelData.Count.ToString() + "人"; // 更新标签文本

                listBox2.Items.Add(selectedItem);
                callData.Add(new string[] { selectedItem.ToString() }); // 将移出的人员添加到已点名名单中
                label4.Text = callData.Count.ToString() + "人"; // 更新标签文本
            }
            else
            {
                MessageBox.Show("索引超出范围，请检查数据同步。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择要移出的人员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedItem = listBox2.SelectedItem;

            if (selectedItem.ToString() == "暂无点名记录")
            {
                return;
            }

            int selectedIndex = listBox2.SelectedIndex;

            // 确保索引在有效范围内
            if (selectedIndex >= 0 && selectedIndex < callData.Count)
            {
                listBox2.Items.Remove(selectedItem);
                callData.RemoveAt(selectedIndex); // 从已点名数据列表中移除对应项
                label4.Text = callData.Count.ToString() + "人"; // 更新标签文本

                listBox1.Items.Add(selectedItem);
                excelData.Add(new string[] { selectedItem.ToString() }); // 将移出的人员添加到剩余名单中
                label3.Text = excelData.Count.ToString() + "人"; // 更新标签文本
            }
            else
            {
                MessageBox.Show("索引超出范围，请检查数据同步。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (callData != null && callData.Count > 0)
            {
                callData.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                excelData.Clear();
                excelData.AddRange(originData);

                foreach (var item in excelData)
                {
                    listBox1.Items.Add(string.Join(", ", item));
                }
                label3.Text = excelData.Count.ToString() + "人";

                label4.Text = "0人"; // 更新标签文本

                // 使用 MainForm 实例更新标签
                mainForm.label1.Text = "名单已重置";
            }
            else
            {
                MessageBox.Show("暂无点名记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
