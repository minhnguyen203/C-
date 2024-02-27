using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.bài_3
{
    internal class JobManager
    {
        private List<Job> jobs = new List<Job>();

        // Phương thức để thêm công việc mới vào danh sách
        public void AddJob(string name)
        {
            Job newJob = new Job(name);
            newJob.OnJobStateChanged += Job_OnJobStateChanged; // Gắn sự kiện để theo dõi sự thay đổi trạng thái
            jobs.Add(newJob);
            Console.WriteLine($"Added new job: {name}");
        }

        // Phương thức để hiển thị danh sách công việc
        public void DisplayJobs()
        {
            Console.WriteLine("Current Jobs:");
            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.Name} - {(job.Completed ? "Completed" : "Not Completed")}");
            }
        }

        // Phương thức xử lý sự kiện khi trạng thái của công việc thay đổi
        private void Job_OnJobStateChanged(object sender, EventArgs e)
        {
            Job job = (Job)sender;
            Console.WriteLine($"Job '{job.Name}' state changed: {(job.Completed ? "Completed" : "Not Completed")}");
        }

        // Phương thức để đánh dấu công việc đã hoàn thành
        public void MarkJobAsCompleted(string name)
        {
            Job job = jobs.Find(j => j.Name == name);
            if (job != null)
            {
                job.Completed = true;
                Console.WriteLine($"Marked job '{name}' as completed");
            }
            else
            {
                Console.WriteLine($"Job '{name}' not found");
            }
        }
    }
}
