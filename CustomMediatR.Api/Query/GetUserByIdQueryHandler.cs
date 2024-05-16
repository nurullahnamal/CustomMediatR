using System.Threading.Tasks;
using CustomMediatR.Library.Interfaces;

namespace CustomMediatR.Api.Query
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        public Task<UserViewModel> Handle(GetUserByIdQuery request)
        {
            // get data from db

            return Task.FromResult(new UserViewModel()
            {
                FirstName = "Nurullah",
                LastName = "Namal"
            });
        }
    }
}