using System;
//using System.Collections.Generic;
using System.Linq;
using DataStructure;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DoubleQueue
    {
        private Queue<int> fast;
        private Queue<int> slow;
        private int counter = 0;
        public DoubleQueue()
        {
            fast = new Queue<int>();
            slow = new Queue<int>();
        }
        public Queue<int> queue(int act)
        {
            if (act == 1)
            {
                return fast;
            }
            return slow;
        }

        public void Add(int num, int act)
        {
            Queue<int> q = queue(act);
            q.Insert(num);
        }

        public int GetCounter()
        { return counter; }

        public int Remove()
        {
            int val;
            if (counter < 5)
            {
                if (!fast.IsEmpty())
                {
                    val = fast.Remove();
                    counter++;
                    return val;
                }
                else if (!slow.IsEmpty())
                {
                    val = slow.Remove();
                    return val;
                }
                return 0;
            }

            if (counter > 5)
            {
                counter = 0;
                if (!slow.IsEmpty())
                {
                    val = slow.Remove();
                    return val;
                }
                return 0;
            }
            return 0;
        }
    } 
    
}
