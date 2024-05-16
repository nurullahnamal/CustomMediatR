﻿using System.Threading.Tasks;

namespace CustomMediatR.Library.Interfaces
{
    public interface IRequestHandler<TRequest,TResponse> where TRequest : IRequest<TResponse>
    {
        Task <TResponse> Handle (TRequest request);
    }
}