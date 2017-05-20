using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcpkgManager.Common
{
    public class VcpkgManager
    {
        // 远端路径
        private string GitVcpkgUrl = "https://github.com/Microsoft/vcpkg.git";
        private string GitPath = "C:\\Program Files\\Git\\cmd\\git.exe"; // 动态获得Git路径

        public bool setupGit()
        {
            GitPath = SoftwareChecker.getGitPath(); // 获得本地git路径
        }

        public bool gitclone(string targetPath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} clone --progress -v \"{1}\" \"{2}\"",
                GitPath, GitVcpkgUrl, targetPath);

            
        }
    }
}
