using System;
using System.IO;
using System.Xml.Serialization;
using CommonTools;
using Newtonsoft.Json;

namespace SodukuUI.Config
{
    /// <summary>
    /// 所有配置类
    /// </summary>
   public class ClsAllConfig
   {

       public ClsColorConfig ColorConfig;
       public ClsGenConfig GenConfig;

       public void SaveToFile()
       {



           string json = JsonConvert.SerializeObject(this);
            string dir = AppDomain.CurrentDomain.BaseDirectory;
           string configName = Path.Combine(dir, "config.json");
           File.WriteAllText(configName, json);
       }
    }
}
