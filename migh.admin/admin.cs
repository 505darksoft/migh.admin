using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using migh.api;
using System.Windows.Forms;
using System.IO;
using JsonTools;

namespace migh.admin
{
    public class admin
    {
        public static Library Library = new Library();
        public static string Todos = "(Todos)";
        //public static string LibraryFile = "migh.lib";
        //public static string ConfigurationFile = "migh.admin.config";

        //public static Configuration configuration = new Configuration();

        //public static void SaveConfiguration()
        //{
        //    try
        //    {
        //        string json = configuration.ToJsonString();
        //        try
        //        {
        //            File.WriteAllText(ConfigurationFile, json);
        //        }
        //        catch { }
        //    }
        //    catch { }
        //}
        //public static void LoadConfiguration()
        //{
        //    string json = "";
        //    if (!File.Exists(ConfigurationFile))
        //    {
        //        Configuration config = new Configuration();
        //        SaveConfiguration();
        //    }
        //    using (StreamReader sr = new StreamReader(ConfigurationFile))
        //    {
        //        json = sr.ReadToEnd();
        //    }
        //    configuration = json.ToObject<Configuration>();
        //}

        //public class Configuration
        //{
        //    public string LibrarySourceURL { get; set; }
        //    public string SourceURLFormat { get; set; }
        //    public string LibrarySourceURL_Alt { get; set; }
        //    public string FTP_Server { get; set; }
        //    public string FTP_Username { get; set; }
        //    public string FTP_Password { get; set; }
        //}

        public class ListItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
