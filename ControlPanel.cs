using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityWork
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();

            this.groupBoxPanelOne.Controls.Clear();
            List<Task> tasks = DataProvider.Instance.generate();
            List<ButtonTask> buttonTasks = new List<ButtonTask>();
            foreach (Task task in tasks)
            {
                buttonTasks.Add(new ButtonTask(task));
                this.groupBoxPanelOne.Controls.Add(new ButtonTask(task));
            }

            initTimer();
        }

        private Timer timer;
        public void initTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // in miliseconds
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.groupBoxPanelOne.Controls.Clear();
            List<Task> tasks = DataProvider.Instance.generate();
            foreach (Task task in tasks)
            {
                this.groupBoxPanelOne.Controls.Add(new ButtonTask(task));
            }
        }
    }
}
