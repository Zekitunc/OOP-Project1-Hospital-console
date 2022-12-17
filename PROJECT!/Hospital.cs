using System;
using System.Collections.Generic;
using System.Text;

namespace PROJECT_
{
    class Hospital
    {
        public List<employee> Hospitalemployee = new List<employee> {  };
        public Dictionary<employee, List<DateTime>> Calendar = new Dictionary<employee, List<DateTime>> { }; 
    }
}
