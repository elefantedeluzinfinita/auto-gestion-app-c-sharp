using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityWork
{
    public partial class ButtonTask : UserControl
    {
        Task assignedTask;
        public ButtonTask(Task task)
        {
            InitializeComponent();
            update(task);
        }

        private void ButtonTask_Load(object sender, EventArgs e)
        {

        }

        public void update(Task task)
        {
            this.assignedTask = task;

            this.label_header.Text = task.task_status;
            this.label_body.Text = task.task_name;
            this.label_time.Text = task.task_difference;
            this.label_owner.Text = task.task_owner;

            if (task.task_status.Equals("COMPLETO"))
            {
                this.label_header.BackColor = Color.Green;
                this.label_time.BackColor = Color.Green;
                this.label_venc.BackColor = Color.Green;
                this.label_completed.BackColor = Color.Green;
                this.label_owner.BackColor = Color.Green;

                this.label_venc.Text = "TAREA VENCE EN:";
            }
            if (task.task_status.Equals("INCOMPLETO"))
            {
                this.label_header.BackColor = Color.Red;
                this.label_time.BackColor = Color.Red;
                this.label_venc.BackColor = Color.Red;
                this.label_completed.BackColor = Color.Red;
                this.label_owner.BackColor = Color.Red;

                this.label_venc.Text = "TAREA VENCIDA HACE:";
                this.label_owner.Text = "-----";
            }
        }

        private void ButtonTask_Click(object sender, EventArgs e)
        {
            assignedTask.task_lasttime = DateTime.Now.AddMinutes(double.Parse(assignedTask.task_duration)).Ticks.ToString();
            assignedTask.task_owner = "MEOW";

            DataProvider.Instance.updateTask(assignedTask.code, assignedTask.task_lasttime, assignedTask.task_owner);

            Console.WriteLine("CLICKED");
        }
    }
}
