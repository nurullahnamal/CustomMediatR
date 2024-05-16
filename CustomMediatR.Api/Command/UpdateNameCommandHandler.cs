using System.Threading.Tasks;
using CustomMediatR.Library.Interfaces;

namespace CustomMediatR.Api.Command
{
    public class UpdateNameCommandHandler: IRequestHandler<UpdateNameCommand,int>
    {
        public Task<int> Handle(UpdateNameCommand request)
        {
            // update on database

            return Task.FromResult(1);
        }
    }
}