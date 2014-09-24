using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppQuaryManagementEnqueDequeue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;
        string complain;
        Queue<string> complainQueue = new Queue<string>();
        int count = 1;

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            name = nameEtextBox.Text;
            complain = complainETextBox.Text;
            complainQueue.Enqueue(name);
            complainQueue.Enqueue(complain);


            ListViewItem waitingListview = new ListViewItem(Convert.ToString(count));            
            waitingListview.SubItems.Add(name);
            waitingListview.SubItems.Add(complain);
            waitingQueueListView.Items.Add(waitingListview);
            count++;
            nameEtextBox.Clear();
            complainETextBox.Clear();

            //string[] row = { Convert.ToString(count), name, complain };
            //var listViewItem = new ListViewItem(row);
            //waitingQueueListView.Items.Add(listViewItem);
            //count++;
            //nameEtextBox.Clear();
            //complainETextBox.Clear();
        }

        private void deequeueButton_Click(object sender, EventArgs e)
        {
            //string[] listviewCompalinlist = complainQueue.Dequeue().ToArray();
            serialDTextBox.Text = waitingQueueListView.SelectedItems[0].Text;
            nameDTextBox.Text = waitingQueueListView.SelectedItems[0].SubItems[1].Text;
            complainDTextBox.Text = waitingQueueListView.SelectedItems[0].SubItems[2].Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            waitingQueueListView.Clear();
        }
    }
}
