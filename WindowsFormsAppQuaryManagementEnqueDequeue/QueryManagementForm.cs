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
        int quaryListViewSerial;        

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            if (nameEtextBox.Text != "" && complainETextBox.Text != "")
            {
                QueryManagement queryObject = new QueryManagement();
                queryObject.serial = (quaryListViewSerial + 1);
                queryObject.name = nameEtextBox.Text;
                queryObject.complain = complainETextBox.Text;

                quaries.Enqueue(queryObject);
                ClearTextBox();

                AddInfoInWaitingQueryListview(queryObject);
                quaryListViewSerial++;
            }
            else
            {
                MessageBox.Show(@"Input your ""Name"" and ""Complain"" ");
            }

        }

        private void AddInfoInWaitingQueryListview(QueryManagement queryObject)
        {
            ListViewItem waitingListview = new ListViewItem(Convert.ToString(queryObject.serial));
            waitingListview.SubItems.Add(queryObject.name);
            waitingListview.SubItems.Add(queryObject.complain);

            waitingQueueListView.Items.Add(waitingListview);
        }

        private void ClearTextBox()
        {
            nameEtextBox.Clear();
            complainETextBox.Clear();
            serialDTextBox.Clear();
            nameDTextBox.Clear();
            complainDTextBox.Clear();
        }

        private void deequeueButton_Click(object sender, EventArgs e)
        {
            if (quaries.Count > 0 )
            {
                int count = quaries.Count();
                foreach (QueryManagement item in quaries)
                {                    
                serialDTextBox.Text = item.serial.ToString();
                nameDTextBox.Text = item.name;
                complainDTextBox.Text = item.complain;
                break;
                }
                QueryManagement Text = quaries.Peek();
                quaries.Dequeue();

                //QueryManagement cust = (QueryManagement)quaries.Dequeue();
                //QueryManagement custt = (QueryManagement)quaries.Peek();

                waitingQueueListView.Items.Clear();

                foreach (QueryManagement item in quaries)
                {
                    AddInfoInWaitingQueryListview(item);
                }               
            }
            else
            {
                ClearTextBox();
                MessageBox.Show("No query left in the waiting queueu");                
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            waitingQueueListView.Items.Clear();
            quaryListViewSerial = 0;
            quaries = new Queue<QueryManagement>();

        }
    }
}
