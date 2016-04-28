using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Events
{
    public class ActivatePlayerEvent
    {
        public bool Activate { get; set; }
        public ActivatePlayerEvent(bool flag) { Activate = flag; }
    }
}
