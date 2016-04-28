using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Events
{
    public class ActivateAnswersEvent
    {
        public bool Activate { get; set; }
        public ActivateAnswersEvent(bool flag)
        {
            Activate = flag;
        }
    }
}
