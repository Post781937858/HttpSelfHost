using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpSelfHost.WebApi
{
    public class EventHandles
    {
        public delegate void MessageEventHandle(string msg);
    }
}
