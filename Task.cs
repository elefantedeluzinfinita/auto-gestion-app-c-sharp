using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityWork
{
    public class Task
    {
        public Task(String name)
        {
            this.code = name + new Random();
            this.task_status = "---";
            this.task_name = name;
            this.task_duration = "0";
            this.task_lasttime = "0";
            this.task_owner = "---";
        }

        public Task(String name, String duration)
        {
            this.code = name + new Random();
            this.task_status = "---";
            this.task_name = name;
            this.task_duration = duration;
            this.task_lasttime = "0";
            this.task_owner = "---";
        }

        public Task(String code, String status, String name, String duration, String lasttime, String owner)
        {
            this.code = code;
            this.task_status = status;
            this.task_name = name;
            this.task_duration = duration;
            this.task_lasttime = lasttime;
            this.task_owner = owner;
        }

        public Task(String code, String status, String name, String duration, String lasttime, String owner, String difference, String enabled)
        {
            this.code = code;
            this.task_status = status;
            this.task_name = name;
            this.task_duration = duration;
            this.task_lasttime = lasttime;
            this.task_owner = owner;
            this.task_difference = difference;
            this.task_enabled = enabled;
        }

        public String code { get; set; }

        public String task_status { get; set; }
        
        public String task_name { get; set; }
        
        public String task_duration { get; set; }

        public String task_lasttime { get; set; }
        
        public String task_owner { get; set; }

        public String task_difference { get; set; }

        public String task_enabled { get; set; }

        public String print()
        {
            return this.code + "," + this.task_status + "," + this.task_name + "," + this.task_duration + "," + this.task_lasttime + "," + this.task_owner + "," + this.task_difference + "," + this.task_enabled;
        }
    }
}
