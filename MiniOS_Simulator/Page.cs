using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOS_Simulator
{
    public class Page
    {
        private String value;
        private int allocationCount;

        public Page()
        {
            value = "X";
            allocationCount = 0;
        }

        public Page(String val)
        {
            value = val;
            allocationCount = 0;
        }

        public String getValue()
        {
            return value;
        }

        public void setValue(String val)
        {
            value = val;
        }

        public int getAllocationCount()
        {
            return allocationCount;
        }

        public void increaseAllocationCount()
        {
            allocationCount++;
        }
    }
}
