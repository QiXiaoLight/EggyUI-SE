using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UseHelp
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DecorationIcon.Image = SystemIcons.Information.ToBitmap();

            // 尝试加载 HelpContent.xml 并将节点添加到 HelpListView
            try
            {
                // 一组可能的位置，按优先级查找
                var baseDir = AppContext.BaseDirectory;
                var candidates = new[] {
                    Path.Combine(baseDir, "HelpContent.xml"),
                    Path.Combine(baseDir, "Resources", "HelpContent.xml"),
                    Path.Combine(Directory.GetCurrentDirectory(), "HelpContent.xml")
                };

                var filePath = candidates.FirstOrDefault(File.Exists);

                if (filePath is null)
                {
                    // 未找到帮助文件，不阻止程序运行
                    return;
                }

                var doc = XDocument.Load(filePath);
                HelpListView.Nodes.Clear();

                var root = doc.Root;
                if (root is null)
                {
                    return;
                }

                foreach (var category in root.Elements("Category"))
                {
                    var catText = category.Attribute("Text")?.Value ?? "未命名分类";
                    var catNode = new TreeNode(catText);

                    foreach (var item in category.Elements("Item"))
                    {
                        var itemText = item.Attribute("Text")?.Value ?? item.Value ?? string.Empty;
                        catNode.Nodes.Add(new TreeNode(itemText));
                    }

                    HelpListView.Nodes.Add(catNode);
                }
            }
            catch (Exception ex)
            {
                // 显示友好的错误信息，但不要抛出未处理异常
                MessageBox.Show($"加载帮助内容失败：{ex.Message}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
