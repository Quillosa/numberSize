using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSize
{
    internal class _sizes
    {
        private int size;
        private string value;

        public void setSize(int firstNum, int secondNum)
        {
            size = firstNum + secondNum;


        }
        public int getSize()
        {

            return size;
        }



        public string getValue()
        {
            int num = 0;
            int num2 = 11;
            int num3 = 17;
            int num4 = 21; ;

            if (num <= size && num >= 10)
            {
                value = "small";
                return value;

            }
            else if (num2 <= size && size <= 16)
            {
                value = "med";
                return value;

            }
            else if (num3 <= size && size <= 31)
            {

                value = " large";
                return value;

            }
            else if (num4 <= size && size >= 32)
            {
                value = "xl";
                return value;
            }
            else 
            {
                value = "error";
                return value;

            }
            
        }
    }


    }

