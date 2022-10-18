namespace MediatorPattern.PingMediatR
{
    using System;
    using MediatR;

    public class PingRequest : IRequest<PingResponse>
    {
        public string From { get; set; }
    }

    public class PingResponse
    {
        public bool Correct { get; set; }
        public DateTime TimeStamp { get; set; }
        public string From { get; set; }
    }
}
