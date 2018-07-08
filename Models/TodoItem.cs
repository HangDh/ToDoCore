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
        public DateTimeOffset? DueAt { get; set; }

        public DateTime StartAt {get;set;}
        public TimeSpan TimeSpend {get;set;}

        public TimeSpan TimeRem {get;set;}
    }
}