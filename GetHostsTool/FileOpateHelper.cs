using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CommonMothodHelper
{
    class FileOpateHelper
    {
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="parh">文件位置</param>
        /// <returns></returns>
        public static bool Delete(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        /// <summary>
        ///创建一个文件并写入内容
        /// </summary>
        /// <param name="path"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void CreateFile(string path, string value)
        {
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            using (StreamWriter sw = new StreamWriter("hosts",false,Encoding.Default))
            {
                sw.Write(value);
                sw.Close();
            }
        }
        /// <summary>
        /// 读取文件并返回StringBuilder
        /// </summary>
        /// <param name="path">文件位置</param>
        /// <returns></returns>
        public static StringBuilder StringReader(string path)
        {
            StringBuilder strBul = new StringBuilder();
            string line;
            try
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(path);
                while ((line = streamReader.ReadLine()) != null)
                {
                    strBul.Append(line + "\n");
                }
                return strBul;
            }
            catch (Exception ex)
            {
                return strBul.Append(ex.ToString());
            }
        }
        /// <summary>
        /// 读取文件并返回对应行数的内容
        /// </summary>
        /// <param name="path">文件位置</param>
        /// <param name="line">行号</param>
        /// <returns></returns>
        public static string GetFileLineContentStringReader(string path, int line)
        {
            try
            {
                StreamReader strReader = new StreamReader(path);
                string lineStr = string.Empty;
                for (int i = 0; i < line; i++)
                {
                    lineStr = strReader.ReadLine();
                }
                strReader.Close();
                return lineStr;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 检查目录是否存在
        /// </summary>
        /// <param name="postion">定位</param>
        /// <returns></returns>
        public static bool IsExistsDirectory(string postion)
        {
            return Directory.Exists(postion);
        }
        /// <summary>
        /// 获取目录下所有文件名
        /// </summary>
        /// <param name="postion"></param>
        /// <returns></returns>
        public static string[] GetFileNames(string postion)
        {
            if (IsExistsDirectory(postion))
            {
                return Directory.GetFiles(postion);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 读取文件并返回标记内容(未完成)
        /// </summary>
        /// <param name="postion"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        public static List<string> StringReaderForList(string postion, string mark)
        {
            StringBuilder strBui = new StringBuilder();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(postion);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {

            }
            return null;
        }
    }
}
