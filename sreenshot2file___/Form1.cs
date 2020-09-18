using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace sreenshot2file___
{
    public partial class Form1 : Form
    {

        private String myPath;
        public Form1()
        {
            InitializeComponent();
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                "\\screenshot2file\\";
            Directory.CreateDirectory(folderPath);
            string myName = System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName;
            myPath = folderPath + myName;
            RegistryKey classesRoot = Registry.ClassesRoot;
            RegistryKey shell = classesRoot.OpenSubKey("Folder\\shell\\screenshot2file");
            if (shell == null)
            {
                uninstallBtn.Enabled = false;
            }
            else
            {
                installBtn.Enabled = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey classesRoot = Registry.ClassesRoot;
            RegistryKey shell = classesRoot.OpenSubKey(@"Folder\shell", true);
            RegistryKey subKey = shell.CreateSubKey("screenshot2file");
            RegistryKey command = subKey.CreateSubKey("command");
            
            string me = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            File.Copy(me, myPath, true);
            command.SetValue(null, "\"" + myPath + "\" \"%1\"");
            installBtn.Enabled = false;
            uninstallBtn.Enabled = true;

            MessageBox.Show("已安装screenshot2file!点击鼠标右键, 选择screenshot2file菜单项即可将截图转换为文件", "screenshot2file");
        }

  
        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistryKey classesRoot = Registry.ClassesRoot;
            RegistryKey shell = classesRoot.OpenSubKey(@"Folder\shell", true);
            shell.DeleteSubKeyTree("screenshot2file");
            
            
            installBtn.Enabled = true;
            uninstallBtn.Enabled = false;
            
            File.Delete(myPath);

            MessageBox.Show("已移除screenshot2file右键菜单项", "screenshot2file");
        }
    }
}