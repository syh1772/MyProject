using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace SEMCNS.BCR_TML
{
    public class IniFileManager
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        private string _filePath = Path.Combine(AppContext.BaseDirectory, "Config.ini");

        // 파일명만 또는 전체경로+파일명 전달받음
        public IniFileManager(string fileName)
        {
            try
            {
                string dirPath = Path.GetDirectoryName(fileName);

                // 디렉토리 경로를 지정안했다면
                if (dirPath.Equals(string.Empty))
                {
                    // dirPath = AppContext.BaseDirectory; // 상위폴더로 경로 지정
                    dirPath = Directory.GetCurrentDirectory();

                    _filePath = Path.Combine(dirPath, fileName);
                }
                else
                {
                    _filePath = fileName;
                }

                // 디렉토리가 없으면 새로 만듬
                if (Directory.Exists(dirPath) == false)
                {
                    Directory.CreateDirectory(dirPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static string ReadValue(string section, string key, string def, string filePath)
        {
            StringBuilder sb = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, sb, sb.Capacity, filePath);

            return sb.ToString();
        }

        public static void WriteValue(string section, string key, string value, string filePath)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }
    }
}
