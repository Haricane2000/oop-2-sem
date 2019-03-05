using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_WinForm
{
    class CalculationMemory
    {
        private Double memory = 0;

        public void Memory_Clear()
        {
            memory = 0.0;
        }

        public Double MemoryShow()
        {
            return memory;
        }

        public void M_Sum(Double b)
        {
            memory += b;
        }

        public void M_Sub(Double b)
        {
            memory -= b;
        }
    }
}
