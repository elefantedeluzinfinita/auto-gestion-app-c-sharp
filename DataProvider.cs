using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityWork
{
    public sealed class DataProvider
    {
        private readonly static DataProvider _instance = new DataProvider();

        private DataProvider()
        {
        }

        public static DataProvider Instance
        {
            get
            {
                return _instance;
            }
        }


        List<Task> currentTasks = null;
        public List<Task> generate()
        {
            currentTasks = loadData();
            /* Inicio de procesamiento y actualizacion del registro */
            DateTime now = DateTime.Now;
            foreach (Task task in currentTasks)
            {
                /* STEP 0: DATOS NUEVOS DEL SISTEMA * FILL * taskname+duration */
                if (task.task_lasttime.Equals(null)) task.task_lasttime = now.Ticks.ToString();
                if (task.task_lasttime.Equals("0")) task.task_lasttime = now.Ticks.ToString();
                if (task.task_duration.Equals(null)) task.task_duration = "1440"; /* 24 hrs -> 24*60 -> 1440 min */
                if (task.task_name.Equals(null)) task.task_enabled = "false";

                /* STEP 1: PROCESAR TASKS */
                long lasttime = long.Parse(task.task_lasttime);
                long duration = long.Parse(task.task_duration);

                /* 1 min = 60 sec => 1 sec = 1000msec */

                if (now.Ticks < lasttime + (duration * 60 * 1000))
                {
                    task.task_status = "COMPLETO";

                    DateTime time_lasttime = new DateTime(long.Parse(task.task_lasttime));

                    task.task_difference = time_lasttime.Subtract(now) + "";
                }
                if (now.Ticks > lasttime + (duration * 60 * 1000))
                {
                    task.task_status = "INCOMPLETO";
                    task.task_difference = now.Subtract(new DateTime(lasttime)) + "";
                }

            }

            /* SEND TO STORAGE */
            saveData();

            /* Fin de procesamiento, listo para renderizado */
            return currentTasks;
        }

        public List<Task> loadData()
        {
            List<Task> tasks = new List<Task>();

            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("upload.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);

                    String[] data = line.Split(',');
                    if (data.Length == 1)
                    {
                        tasks.Add(new Task(data[0]));
                    }
                    if (data.Length == 2)
                    {
                        tasks.Add(new Task(data[0], data[1]));
                    }
                    if (data.Length == 8)
                    {
                        tasks.Add(new Task(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]));
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return tasks;
        }

        public void saveData()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("upload.txt");
                //Write a line of text
                foreach (Task task in currentTasks)
                {
                    sw.WriteLine(task.print());
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void updateTask(String code, String lasttime, String owner)
        {
            foreach (Task task in currentTasks)
            {
                if(task.code.Equals(code))
                {
                    task.task_lasttime = lasttime;
                    task.task_owner = owner;
                }
            }

            saveData();
        }
    }
}
