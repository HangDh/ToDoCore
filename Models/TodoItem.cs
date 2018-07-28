using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoCore.Models
{
    public class TodoItem
    {
        public Guid Id {get; set;}
        public string UserId {get;set;}
        public bool IsDone { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime DueAt { get; set; }

        public DateTime StartAt {get;set;}
        public DateTime PausedAt {get;set;}
        public bool IsPaused {get;set;}
        public DateTime StopAt {get;set;}
        public TimeSpan TimeSpend {get;set;}

        public TimeSpan TimeRem {get;set;}

    }
}