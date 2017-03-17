using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzTH
{
    public class GetConfig : ConfigurationSection
    {
        [ConfigurationProperty("UserName")]
        public string UserName
        {
            get { return this["UserName"].ToString(); }
            set { this["UserName"] = value; }
        }

        [ConfigurationProperty("Path")]
        public string Path
        {
            get { return this["Path"].ToString(); }
            set { this["Path"] = value; }
        }
    }
}
