using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMediatR.Library.Interfaces
{
    public interface IMediator
    {

        Task<TResponse> Send<TResponse>(IRequest<TResponse> request);
    }
}
