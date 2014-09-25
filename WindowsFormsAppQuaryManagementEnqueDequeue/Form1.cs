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
    public partial class QuaryManagementUI : Form
    {
        public QuaryManagementUI()
        {
            InitializeComponent();
        }

        Queue<QueryManagement> quaries = new Queue<QueryManagement>();
        int quarySerial;        

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (nameEtextBox.Text != "" && complainETextBox.Text != "")
            {
                QueryManagement queryObject = new QueryManagement();
                queryObject.serial = (quarySerial + 1);
                queryObject.name = nameEtextBox.Text;
                queryObject.complain = complainETextBox.Text;

                quaries.Enqueue(queryObject);
                ClearTextBox();


                ListViewItem waitingListview = new ListViewItem(Convert.ToString(queryObject.serial));
                waitingListview.SubItems.Add(queryObject.name);
                waitingListview.SubItems.Add(queryObject.complain);

                waitingQueueListView.Items.Add(waitingListview);
                quarySerial++;

            }
            else
            {
                MessageBox.Show(@"Input your ""Name"" and ""Complain"" ");
            }

        }

        private void ClearTextBox()
        {
            nameEtextBox.Clear();
            complainETextBox.Clear();
        }

        private void deequeueButton_Click(object sender, EventArgs e)
        {
            if (quaries.Count > 0 )
            {
                int count = quaries.Count();
                //foreach (QueryManagement item in quaries)
                //{                    
                    //serialDTextBox.Text = aQuaries.serial.ToString();
                //nameDTextBox.Text = quaries.Dequeue(
                    //complainDTextBox.Text = aQuaries.complain;                    
                //}
                //serialDTextBox.Text = quaries.Peek();
                quaries.Dequeue();
                QueryManagement cust = (QueryManagement)quaries.Dequeue();
                QueryManagement custt = (QueryManagement)quaries.Peek();


               
                //foreach (QueryManagement item in quaries)
                //{
                //    ListViewItem waitingListview = new ListViewItem(Convert.ToString(item.serial));
                //    waitingListview.SubItems.Add(item.name);
                //    waitingListview.SubItems.Add(item.complain);

                //    waitingQueueListView.Items.Add(waitingListview);

                //}
               
            }
            else
            {
                MessageBox.Show("No query left in the waiting queueu");
            }
            
            
            ////string[] listviewCompalinlist = complainQueue.Dequeue().ToArray();
            //serialDTextBox.Text = waitingQueueListView.SelectedItems[0].Text;
            //nameDTextBox.Text = waitingQueueListView.SelectedItems[0].SubItems[1].Text;
            //complainDTextBox.Text = waitingQueueListView.SelectedItems[0].SubItems[2].Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            waitingQueueListView.Items.Clear();
            quarySerial = 0;
        }
    }
}
