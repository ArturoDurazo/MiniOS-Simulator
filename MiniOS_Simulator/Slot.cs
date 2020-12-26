using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOS_Simulator
{
    class Slot
    {
        private String value;
        private int processIdx;
        private int pageIdx;
        private int arrivalTime;
        private int usageTime;

        public Slot()
        {
            value = "Null";
            arrivalTime = -1;
            usageTime = 0;
        }

        public Slot(String val, int arrivalTime)
        {
            value = val;
            this.arrivalTime = arrivalTime;
        }

        public int getProcessIdx()
        {
            return processIdx;
        }

        public int getPageIdx()
        {
            return pageIdx;
        }

        public void setProcessIdx(int p)
        {
            processIdx = p;
        }

        public void setPageIdx(int p)
        {
            pageIdx = p;
        }

        public void setValue(String val)
        {
            value = val;
        }

        public String getValue()
        {
            return value;
        }

        public int getArrivalTime()
        {
            return arrivalTime;
        }

        public int getUsageTime()
        {
            return usageTime;
        }

        public void setArrivalTime(int arr)
        {
            arrivalTime = arr;
        }

        public void  increaseUsageTime()
        {
            usageTime++;
        }
        
        public void resetUsageTime()
        {
            usageTime = 0;
        }
    }
}
