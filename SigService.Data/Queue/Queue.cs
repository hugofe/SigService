using SigService.Data.Queue.Enum;
using System;

namespace SigService.Data.Queue
{
    public class Queue
    {
        public int QueueId { get; set; }
        public double RequesterId { get; set; }
        public string Departament { get; set; }
        public string RequesterNumber { get; set; }
        public string RequesterName { get; set; }
        public string Subject { get; set; }
        public string Atendent { get; set; }
        public string Description { get; set; }
        public Status status { get; set; }
        public Priority priority { get; set; }
    }
}
