using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonMothodHelper
{
    class NetPageHelper
    {
        /// <summary>
        /// 获取网站内容
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetNetPageContent(string str)
        {
            try
            {
                System.Net.WebClient webclick = new System.Net.WebClient();
                webclick.Credentials = System.Net.CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
                Byte[] pageData = webclick.DownloadData(str.Trim()); //从指定网站下载数据
                string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            
                //string pageHtml = Encoding.UTF8.GetString(pageData); //如果获取网站页面采用的是UTF-8，则使用这句
                return pageHtml;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 下载内容的异步方法
        /// </summary>
        /// <param name="str">网址</param>
        /// <returns></returns>
        public static Task<string> GetNetPageContentAsync(string str)
        {
            return Task.Run<string>(() =>
            {
                return GetNetPageContent(str);
            });
        }
    }
}
