using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CommonMothodHelper;
using GetHostsTool;

namespace HostsGetTool
{
    public partial class HostsLoader : Form
    {
        #region 变量
        /// <summary>
        /// 镜像下载连接
        /// </summary>
        public static string[] _link = new string[3] 
        { 
            "https://raw.githubusercontent.com/racaljk/hosts/master/hosts",
            "https://coding.net/u/scaffrey/p/hosts/git/raw/master/hosts",
            ""
        };
        /// <summary>
        /// 储存镜像数据
        /// </summary>
        private static List<string> pageData = new List<string>();
        private static DateTime[] _date = {
                                              new DateTime(2016,1,1),//本地hosts
                                              new DateTime(2016,1,1),//Github
                                              new DateTime(2016,1,1)//Coding
                                          };
        /// <summary>
        /// CMD输出内容
        /// </summary>
        private string strout = string.Empty;
        #endregion

        #region 构造
        /// <summary>
        /// 构造方法
        /// </summary>
        public HostsLoader()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Load(object sender, EventArgs e)
        {
            GetLocalHostsDate();//获取本地Hosts日期
            ImageDataDownloader();//下载镜像文件
            
        }

        /// <summary>
        /// 更新Hosts按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdata_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32\drivers\etc\hosts";
            SaveHostsToFile(path);
            //刷新DNS
            FlushSystemDNS();
            //刷新本地hosts版本
            GetLocalHostsDate();
            MessageBox.Show(strout);
        }

        /// <summary>
        /// 恢复hosts按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegain_Click(object sender, EventArgs e)
        {
            try
            {
                string hosts = GetHostsTool.Properties.Resources.hosts;
                using (StreamWriter sw = new StreamWriter("hosts", false, Encoding.Default))
                {
                    sw.Write(hosts);
                    sw.Close();
                }
                File.Copy("hosts", @"C:\Windows\System32\drivers\etc\hosts", true);
                MessageBox.Show("恢复成功!", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件修改异常,请查看是否占用文件!\nERROR:" + ex, "异常");
            }
            finally
            {
                File.Delete("hosts");
                GetLocalHostsDate();
            }
        }
        
        #region 菜单栏
        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 下载Hosts文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HostsToolStripMenuItemDownLoader_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = fileDialog.SelectedPath;
                path = foldPath + "\\hosts";
                SaveHostsToFile(path);
            }
            
        }
        /// <summary>
        /// 下载镜像按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmImageDownloadLink_Click(object sender, EventArgs e)
        {
            using (FrmAction act = new FrmAction())
            {
                act.StartPosition = FormStartPosition.CenterScreen;
                act.MaximizeBox = false;
                act.MinimizeBox = false;
                act.ShowIcon = false;
                act.CallBack += () => { UpDataForLink(); };
                act.ShowDialog();
            }
        }
        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没有更新!", "提示");
        }
        private void ToolStripMenuAbout_Click(object sender, EventArgs e)
        {
            GetHostsToolAbout about = new GetHostsToolAbout();
            about.ShowDialog();
        }
        #endregion
        #endregion

        #region 方法
        /// <summary>
        /// 更新Link后的下载镜像文件
        /// </summary>
        private void UpDataForLink()
        {
            try
            {
                string data = NetPageHelper.GetNetPageContent(_link[2]);
                if (!string.IsNullOrEmpty(data))
                {
                    string path = @"C:\Windows\System32\drivers\etc\hosts";
                    StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
                    data = data.Replace("\n", "\r\n");
                    sw.Write(data);
                    MessageBox.Show("文件写入成功!", "提示");
                }
                else
                {
                    MessageBox.Show("文件下载或写入失败!","异常");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件下载或写入失败!\nERROR:"+ex, "异常");
            }
        }
        /// <summary>
        /// 比较并写入hosts
        /// </summary>
        /// <param name="path">写入地址</param>
        private void SaveHostsToFile(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
                if (DateTime.Compare(_date[1], _date[2]) <= 0)
                {
                    pageData[0] = pageData[0].Replace("\n", "\r\n");
                    sw.Write(pageData[0]);
                }
                else
                {
                    pageData[1] = pageData[1].Replace("\n", "\r\n");
                    sw.Write(pageData[1]);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件修改异常,请查看是否占用文件!\nERROR:" + ex, "异常");
            }
            finally
            {
                GetLocalHostsDate();
            }
        }

        /// <summary>
        /// 下载镜像文件
        /// </summary>
        private async void ImageDataDownloader()
        {
            Task<string> githubData, codingData;
            githubData = NetPageHelper.GetNetPageContentAsync(_link[0]);
            codingData = NetPageHelper.GetNetPageContentAsync(_link[1]);
            await Task.WhenAll(githubData, codingData);
            pageData.Add(githubData.Result);
            pageData.Add(codingData.Result);

            CheckImageDate();//检查连接状态

        }
        /// <summary>
        /// 检查连接状态
        /// </summary>
        private void CheckImageDate()
        {
            bool btnStatic = false;
            string date;
            try
            {
                #region Github
                if (!string.IsNullOrEmpty(pageData[0]))
                {
                    labGithubCheck.Text = "连接成功";
                    //获取日期
                    date = pageData[0].Substring(pageData[0].LastIndexOf(@"# Last updated:"), 26);
                    if (date != null)
                    {
                        date = date.Substring(15).Trim();
                        _date[1] = Convert.ToDateTime(date);
                        btnStatic = true;
                    }
                }
                else
                {
                    labGithubCheck.Text = "连接失败";
                    labGithubCheck.ForeColor = Color.Red;
                }
                #endregion

                #region Coding

                if (!string.IsNullOrEmpty(pageData[1]))
                {
                    labCodingCheck.Text = "连接成功";
                    //获取日期
                    date = pageData[0].Substring(pageData[1].LastIndexOf(@"# Last updated:"), 26);
                    if (date != null)
                    {
                        date = date.Substring(15).Trim();
                        _date[2] = Convert.ToDateTime(date);
                        btnStatic = true;
                    }
                }
                else
                {
                    labCodingCheck.Text = "连接失败";
                    labCodingCheck.ForeColor = Color.Red;
                }
                #endregion

                //对比两方服务器时间数据
                if (DateTime.Compare(_date[1], _date[2]) <= 0)
                {
                    labServerVersion.Text = _date[1].ToString("yyyy-MM-dd");
                }
                else
                {
                    labServerVersion.Text = _date[2].ToString("yyyy-MM-dd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:"+ ex, "异常");
            }
            finally
            {
                //更改按钮禁用状态
                if (btnStatic)
                {
                    btnUpdate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("镜像数据获取异常!", "错误");
                }
            }
  
        }
        /// <summary>
        /// 获取本地Hosts日期
        /// </summary>
        private void GetLocalHostsDate()
        {
            string path = @"C:\Windows\System32\drivers\etc\hosts";
            string date = FileOpateHelper.GetFileLineContentStringReader(path, 3);
            if (date != null && date.IndexOf("sample HOSTS") == -1)
            {
                date = date.Substring(15).Trim();
                _date[0] = Convert.ToDateTime(date);
                labLocalVersion.Text = date;
            }
            else
            {
                labLocalVersion.Text = "默认系统HOSTS";
            }
        }
        /// <summary>
        /// 刷新系统DNS
        /// </summary>
        private void FlushSystemDNS()
        {
            string strCmd = "ipconfig /flushdns";
            CMDHelper.RunCmd(strCmd, out strout);
            //Console.WriteLine(strout);
        }
        #endregion

    }
}
