using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_4
{
    public partial class Form1 : Form
    {
        // Constructor for Form1 - initializes the form and its components
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the tab control changes.
        /// Updates controls, labels, and button properties based on the selected tab (Stack or Queue).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangedTabs(object sender, EventArgs e)
        {
            // First tab (Stack - FILO)
            if (tabControl1.SelectedIndex == 0)
            {
                labelTitle.Text = "Stack - FILO";  // Update the label to show "Stack - FILO"
                panelTitle.BackColor = Color.DarkTurquoise;  // Change the background color of the panel
                // Set AcceptButton and CancelButton for stack operations
                AcceptButton = buttonPushStack;
                CancelButton = buttonPopStack;
            }
            // Second tab (Queue - FIFO)
            else
            {
                labelTitle.Text = "Queue - FIFO";  // Update the label to show "Queue - FIFO"
                panelTitle.BackColor = Color.Salmon;  // Change the background color of the panel
                // Set AcceptButton and CancelButton for queue operations
                AcceptButton = buttonEnqueue;
                CancelButton = buttonDequeue;
            }
        }

        /// <summary>
        /// Updates the DataGridView control to display the current elements of the stack.
        /// </summary>
        private void UpdateStack()
        {
            // Create a new DataTable for the stack
            DataTable newStack = new DataTable();
            newStack.Columns.Add();  // Add a column to the DataTable

            // Add each element of the stack to the DataTable as a new row
            foreach (string element in Stack.GetStack())
                newStack.Rows.Add(element);

            // Update the DataGridView control to display the new DataTable
            dataGridViewStack.DataSource = newStack;
        }

        /// <summary>
        /// Updates the DataGridView control to display the current elements of the queue.
        /// </summary>
        private void UpdateQueue()
        {
            // Create a new DataTable for the queue
            DataTable newQueue = new DataTable();
            DataRow row = newQueue.Rows.Add();  // Add a new row to the DataTable
            int index = 0;

            // Add each element of the queue to the row in the DataTable
            foreach (string element in Queue.GetQueue())
            {
                newQueue.Columns.Add();  // Add a new column for each queue element
                row[index] = Queue.GetQueue()[index];  // Insert the queue element into the row
                index++;
            }

            // Update the DataGridView control to display the new DataTable
            dataGridViewQueue.DataSource = newQueue;
        }

        /// <summary>
        /// Push button click event.
        /// Adds the element from the textbox to the top of the stack.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPushStack_Click(object sender, EventArgs e)
        {
            // Ensure the textbox is not empty before pushing to the stack
            if (textBoxPushElement.Text != "" || textBoxPushElement.Text == null)
            {
                Stack.Push(textBoxPushElement.Text);  // Push the element onto the stack
                UpdateStack();  // Update the stack display
                textBoxPushElement.Text = "";  // Clear the textbox after pushing
            }
            else
                MessageBox.Show("The element can't be empty");  // Display a warning if the textbox is empty
        }

        /// <summary>
        /// Pop button click event.
        /// Removes the element from the top of the stack and displays it in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPopStack_Click(object sender, EventArgs e)
        {
            // Check if the stack is empty
            if (Stack.GetStack().Count == 0)
                MessageBox.Show("The stack is already empty");  // Display a warning if the stack is empty
            else
            {
                textBoxPopElement.Text = Stack.Pop();  // Pop the element from the stack and display it
                UpdateStack();  // Update the stack display
            }
        }

        /// <summary>
        /// Enqueue button click event.
        /// Adds the element from the textbox to the end of the queue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            // Ensure the textbox is not empty before enqueueing
            if (textBoxEnqueueElement.Text == null || textBoxEnqueueElement.Text == "")
                MessageBox.Show("The element can't be empty");  // Display a warning if the textbox is empty
            else
            {
                Queue.Enqueue(textBoxEnqueueElement.Text);  // Add the element to the queue
                UpdateQueue();  // Update the queue display
                textBoxEnqueueElement.Text = "";  // Clear the textbox after enqueueing
            }
        }

        /// <summary>
        /// Dequeue button click event.
        /// Removes the element from the front of the queue and displays it in the textbox.
        /// </summary>
        /// <param="sender"></param>
        /// <param name="e"></param>
        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            // Check if the queue is empty
            if (Queue.GetQueue().Count == 0)
                MessageBox.Show("The Queue is already empty");  // Display a warning if the queue is empty
            else
            {
                textBoxDequeueElement.Text = Queue.Dequeue();  // Dequeue the element and display it
                UpdateQueue();  // Update the queue display
            }
        }
    }
}

