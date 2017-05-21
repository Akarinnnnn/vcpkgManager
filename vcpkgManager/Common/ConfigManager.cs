using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser.Model;
using IniParser;

namespace vcpkgManager.Common
{
    /// <summary>
    /// 管理配置文件信息
    /// </summary>
    public class ConfigManager
    {
        #region 单件部分
        private static volatile ConfigManager _instance = null;
        private static object objLock = new Object();
        public static ConfigManager Ins
        {
            get
            {
                if (_instance == null)
                {
                    lock (objLock)
                    {
                        _instance = new ConfigManager();
                    }
                }
                return _instance;
            }
        }
        #endregion

        private FileIniDataParser dataParser = new FileIniDataParser();
        private IniData dataValue = null;

        public bool isInited = false;
        public string vcpkgPath = "";

        public bool loadConfig()
        {
            if (dataValue != null)
                return true;
            try
            {
                dataValue = dataParser.ReadFile(System.Environment.CurrentDirectory + "\\config\\App.conf");

                isInited = bool.Parse(dataValue["App"]["IsInit"]);
                vcpkgPath = dataValue["App"]["VcpkgPath"];
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void saveConfig()
        {
            if (dataValue == null)
                return;
            try
            {
                dataValue["App"]["IsInit"] = isInited ? "true" : "false";
                dataValue["App"]["VcpkgPath"] = vcpkgPath;

                dataParser.WriteFile(System.Environment.CurrentDirectory + "\\config\\App.conf", dataValue); // 保存到文件
            }
            catch (Exception ex)
            {
            }
        }
    }
}
