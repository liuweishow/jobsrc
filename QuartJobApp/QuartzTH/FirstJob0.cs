using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzTH
{
    public sealed class FirstJob0 : IJob
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(FirstJob0));
        public int i;
        public void Execute(IJobExecutionContext context)
        {
            logger.InfoFormat("my first job0！");
        }
    }
}
