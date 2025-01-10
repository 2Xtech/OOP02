using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_4
{
    /// <summary>
    /// Queue class to define queue specific methods
    /// </summary>
    internal class Queue
    {
        //Intialising a queue
        private static List<string> queue = new List<string>(); 

        /// <summary>
        /// Enqueue
        /// add the element to the end of the list
        /// </summary>
        /// <param name="newELement"></param>
        public static void Enqueue(string newELement)
        {
            queue.Add(newELement);
        }

        /// <summary>
        /// return and delete the first element in the list/queue
        /// </summary>
        /// <returns>dequeued element</returns>
        public static string Dequeue()
        {
            string dequeuedElement = queue[0];
            queue.RemoveAt(0);
            return dequeuedElement;
        }

        /// <summary>
        /// return the queue
        /// </summary>
        /// <returns>queue</returns>
        public static List<string> GetQueue()
        {
            return queue;
        }
    }
}
