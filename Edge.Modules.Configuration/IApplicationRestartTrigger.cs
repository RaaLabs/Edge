using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaaLabs.Edge.Modules.Configuration
{
    public interface IApplicationRestartTrigger
    {
        public void RestartApplication();
    }
}
