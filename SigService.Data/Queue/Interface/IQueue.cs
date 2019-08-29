using SigService.Data.Queue.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigService.Data.Queue.Interface
{
    public interface IQueue
    {
        int QueueId { get; set; }
        double RequesterId { get; set; }
        string Departament { get; set; }
        string RequesterNumber { get; set; }
        string RequesterName { get; set; }
        string Subject { get; set; }
        string Atendent { get; set; }
        string Description { get; set; }
        Status status { get; set; }
        Priority priority { get; set; }
    }
}
