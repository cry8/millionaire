using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Events
{
    public class HighLightEvent
    {
        public object Label{get;set;}
        public HighLightEvent(object label) { Label = label; }
    }
}
