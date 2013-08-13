using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class TodoNote
    {
        public string Id { get; set;}
        public string Title { get; set; }
        public Status Status { get; set; }
        public int Priority { get; set; }
        public string[] DetailId { get; set; }
        public Dictionary<string, string> Tags { get; set; }
    }

    public class Detail
    {
        public string Id {get; set;}
        public int IterationNumber { get; set; }
        public string Topic { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTIme { get; set; }
        public String Description { get; set; }
        public Dictionary<string, string> Tags { get; set; }
    }

    public enum Status { NEW, COMPLETE, MISSED}; 
}