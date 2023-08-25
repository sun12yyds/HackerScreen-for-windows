using System;
using System.IO;
using System.Windows.Forms;

namespace Hacker
{
    public partial class SetConfig : Form
    {

        /// <summary>
        /// 程序启动目录
        /// </summary>
        private readonly string appPath;
        /// <summary>
        /// 配置文件路径
        /// </summary>
        private readonly string configPath;

        public SetConfig()
        {
            InitializeComponent();

            appPath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            configPath = Path.Combine(appPath, "html", "config.xml");
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radLocal.Checked)
            {
                if (!File.Exists(txtInfo.Text))
                {
                    if (txtInfo.Text == "")
                    {
                        MessageBox.Show($"未修改任何设置，将使用默认地址:\n{appPath}\\html\\hacker.html", "黑客模拟器", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("指定的网页文件不存在，请检查设置。", "黑客模拟器", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                if (!txtInfo.Text.StartsWith("http", true, null))
                {
                    MessageBox.Show("请输入 http 或 https 开头的网址。", "黑客模拟器", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            config.isLocal = radLocal.Checked;
            config.uInfo = txtInfo.Text;
            config.Opacity = optBar.Value;
            config.autoExit = !checkWebExit.Checked;
            config.Save(configPath);
            Application.Exit();
        }
        
        // 保存初始值
        string selHtml = string.Empty;
        string setUrl = string.Empty;
        
        // 加载配置
        private SimpleSetting config = new SimpleSetting();

        private void SetConfig_Load(object sender, EventArgs e)
        {
            // 创建 html 目录
            if (!Directory.Exists(appPath + "\\html\\")) Directory.CreateDirectory(appPath + "\\html\\");

            if (File.Exists(configPath))
            {
                config = new SimpleSetting(configPath);
            }
 
            optBar.Value = config.Opacity;
            labTip.Text = config.isLocal ? "点击下方文本框选择一个网页文件":"请在下方输入一个网址";
            radLocal.Checked= config.isLocal;
            radNet.Checked= !config.isLocal;
            txtInfo.ReadOnly = config.isLocal;
            checkWebExit.Checked = !config.autoExit;

            //保存信息
            if (config.isLocal)
            {
                selHtml = config.uInfo;
            }
            else
            {
                setUrl = config.uInfo;
            }

            if (!string.IsNullOrWhiteSpace(config.uInfo))txtInfo.Text = config.uInfo;
        }

        private void radLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtInfo.ReadOnly = radLocal.Checked;
            labTip.Text = radLocal.Checked ? "点击下方文本框选择一个网页文件" : "请在下方输入一个网址";
            txtInfo.Text = radLocal.Checked ? selHtml : setUrl;
        }

        private void txtInfo_Click(object sender, EventArgs e)
        {
            if (radLocal.Checked)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory= appPath;
                dialog.Multiselect = false;
                dialog.Title = "请选择文件夹";
                dialog.Filter = "网页文件(*.html)|*.html";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtInfo.Text = dialog.FileName;
                }
            }
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 打开帮助页面
            System.Diagnostics.Process.Start("https://github.com/sangyuxiaowu/HackerScreenSaver");
        }
    }
}
