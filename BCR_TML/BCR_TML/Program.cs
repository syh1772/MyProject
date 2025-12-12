using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMCNS.BCR_TML
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TerminalDevice.Terminal = new TerminalDevice("Config.ini");

            // DLL 실행파일에 포함하는 구문
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(ResolveAssembly);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        // DLL 실행파일에 포함하는 구문
        // 사용법 : DLL을 기존항목 추가로 가져오기 → 빌드 작업 : 포함 리소스
        private static System.Reflection.Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            System.Reflection.Assembly thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            string resourcesName = null;
            string fileName = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";

            foreach (string name in thisAssembly.GetManifestResourceNames())
            {
                if (name.EndsWith(fileName))
                {
                    resourcesName = name;
                }
            }

            if (resourcesName != null)
            {
                using (System.IO.Stream stream = thisAssembly.GetManifestResourceStream(resourcesName))
                {
                    if (stream != null)
                    {
                        byte[] data = new byte[stream.Length];
                        stream.Read(data, 0, data.Length);
                        return System.Reflection.Assembly.Load(data);
                    }
                }
            }

            return null;
        }
    }
}
