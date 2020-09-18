using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sreenshot2file___
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && !String.IsNullOrEmpty(args[0]))
            {
                screen2file(args[0]);
            }
            else
            {
                System.Security.Principal.WindowsIdentity identity =
                    System.Security.Principal.WindowsIdentity.GetCurrent();
                System.Security.Principal.WindowsPrincipal principal =
                    new System.Security.Principal.WindowsPrincipal(identity);
                if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator))
                {
                    try
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "screenshot2file");
                    }
                }
                else
                {
                    //创建启动对象
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.UseShellExecute = true;
                    startInfo.WorkingDirectory = Environment.CurrentDirectory;
                    startInfo.FileName = Application.ExecutablePath;
                    //startInfo.Arguments = String.Join(" ", "Args");
                    //设置启动动作,确保以管理员身份运行
                    startInfo.Verb = "runas";
                    try
                    {
                        System.Diagnostics.Process.Start(startInfo);
                    }
                    catch
                    {
                        return;
                    }

                    //退出
                    Application.Exit();
                }
            }
        }

        private static void screen2file(String path)
        {
            if (Clipboard.ContainsImage())
            {
                Image image = (Image) Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
                string timestamp = DateTime.Now.ToString("-yyyy-MM-dd-HH-mm-ss");
                var screenshot = path + "\\screenshot" + timestamp + ".jpeg";
                Console.WriteLine("Save to file " + screenshot);
                image.Save(screenshot, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                Console.WriteLine("Clipboard empty.");
            }
        }
    }
}