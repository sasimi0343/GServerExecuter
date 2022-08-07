using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace GServerExecuter
{
    public class ServerConfig
    {
        public ServerConfig()
        {

        }

        public int playercount;
        public string gamemode;
        public string serverName;
        public string map;
        public string token;


        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }

        public void SaveConfig(string name)
        {
            try
            {
                Console.WriteLine(Path.Combine(Application.StartupPath, "ServerConfigs", name + ".gse"));
                File.WriteAllText(Path.Combine(Application.StartupPath, "ServerConfigs", name + ".gse"), ToJSON(), Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static ServerConfig LoadConfig(string name)
        {
            try
            {
                return JsonConvert.DeserializeObject<ServerConfig>(File.ReadAllText(Path.Combine(Application.StartupPath, "ServerConfigs", name), Encoding.UTF8));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
