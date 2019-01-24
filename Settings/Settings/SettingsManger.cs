using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public class SettingsManger
    {
        public string Change(string path, string key)
        {
            var te = File.ReadAllText(path);
            if (te.Contains(key + ":") == true)
            {
                te = te.Replace(key, "");
                return te;
            }
            else
            {
                return "";
            }

        }
        public string Config(string path, string key, string value)
        {
            if (System.IO.File.Exists(path) == true)
            {
                //label1.Text = Change();
                return Change(path, key);
            }
            else
            {
                StreamWriter test = new StreamWriter(path);

                test.WriteLine(key + ":" + value);
                test.Close();
                return "";
            }
        }
    }
}
