using SigService.Data.Queue;
using System;

namespace SigService.Application
{
    public interface IQueueService
    {
        Queue GetAll();

    }
}
