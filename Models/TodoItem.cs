using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoCore.Models
{
    public class TodoItem
    {
        public Guid Id {get; set;}
        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime DueAt { get; set; }

        public DateTime StartAt {get;set;}
        public DateTime StopAt {get;set;}
        public TimeSpan TimeSpend {
            get {
                return StopAt - StartAt;
            }
            set{}
        }

        public TimeSpan TimeRem {
            get{
                if ((DueAt - StartAt) < TimeSpan.FromSeconds(0)) {
                    return TimeSpan.FromSeconds(0);
                }
                else return DueAt - StartAt;
            }
            set{}
        }
    }
}