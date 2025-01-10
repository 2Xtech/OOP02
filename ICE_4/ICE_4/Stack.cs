using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_4
{
    /// <summary>
    /// Stack class for stack specific methods/functions/objects
    /// </summary>
    internal class Stack
    {
        //intialising a stack as a list of string elements
        private static List <string> stack = new List <string> ();


        /// <summary>
        /// Push
        /// adds the new element to the front of the list
        /// </summary>
        /// <param name="newElement"></param>
        public static void Push(string newElement)
        {
            stack.Insert(0,newElement);
        }

        /// <summary>
        ///Pop 
        ///Deletes the first element of the list
        /// </summary>
        /// <returns>
        /// Popped element as string
        /// </returns>
        public static string Pop()
        {
            string poppedElement = stack[0];
            stack.RemoveAt(0);
            return poppedElement;
        }

        /// <summary>
        /// Return the stack
        /// </summary>
        /// <returns></returns>
        public static List<string> GetStack()
        {
            return stack;
        }

        
    }
}
