using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.bài_3
{
    internal class Program
    {
            static void Main(string[] args)
            {
                JobManager jobManager = new JobManager();

                // Thêm các công việc mới vào danh sách
                jobManager.AddJob("Task 1");
                jobManager.AddJob("Task 2");
                jobManager.AddJob("Task 3");

                // Hiển thị danh sách công việc
                jobManager.DisplayJobs();

                // Đánh dấu một công việc đã hoàn thành
                jobManager.MarkJobAsCompleted("Task 2");

                // Hiển thị lại danh sách công việc sau khi đánh dấu
                jobManager.DisplayJobs();
            }
        }
    }

