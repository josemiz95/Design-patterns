namespace MediatorPattern.PingMediatR
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;

    public class PingHandler : IRequestHandler<PingRequest, PingResponse>
    {
        public Task<PingResponse> Handle(PingRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new PingResponse
            {
                Correct = true,
                TimeStamp = DateTime.UtcNow,
                From = request.From
            });
        }
    }
}
