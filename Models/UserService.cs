using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dawaawin.Models
{
    public class UserService
    {
        public int activeTabIndex = 0;

        public int ActiveTabIndex
        {
            get { return activeTabIndex; }
            set { activeTabIndex = value; }
        }
    }
}
