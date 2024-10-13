using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBasicThread
{
    public partial class frmBasicThread : Form
    {
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            label1.Text = "----Before starting thread----";

            ThreadStart thread1 = new ThreadStart(MyThreadClass.Thread1);


            Thread ThreadA = new Thread(thread1);
            Thread ThreadB = new Thread(thread1);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Priority = ThreadPriority.Normal;
            ThreadB.Priority = ThreadPriority.Highest;

            ThreadA.Start();
            ThreadB.Start();


            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("End of Thread");
            label1.Text = "End of Thread";

        }

        private void frmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
