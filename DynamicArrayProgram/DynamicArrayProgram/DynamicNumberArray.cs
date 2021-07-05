using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayProgram
{
    public class DynamicNumberArray
    {

        int[] buffer;
        public DynamicNumberArray()
        {
            buffer = new int[5];
        }
        
        public DynamicNumberArray(int initialSize)
        {
            buffer = new int[initialSize];
        }

        public int this[int index]
        {
            /*if(index >= buffer.Length)
            {
              Array.Resize(ref buffer,index+5)
            }*/
            set
            {
                Array.Resize(ref buffer, index+5);
                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }

        }
    }
}


    

