using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.bài_3
{
    internal class Job
    {
        
            public string Name { get; set; }
            private bool completed;

            public bool Completed
            {
                get { return completed; }
                set
                {
                    // Kiểm tra xem trạng thái đã thay đổi chưa
                    if (completed != value)
                    {
                        completed = value;
                        // Nếu đã thay đổi, kích hoạt sự kiện OnJobStateChanged
                        OnJobStateChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
            }

            // Sự kiện được kích hoạt khi trạng thái của công việc thay đổi
            public event EventHandler OnJobStateChanged;

            public Job(string name)
            {
                Name = name;
            }
        }
    }

