using SiteEvents.Models;
using System;

namespace RequestWorkflow.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public virtual Event Event { get; set; }
        public int EventId { get; set; }
    }
}