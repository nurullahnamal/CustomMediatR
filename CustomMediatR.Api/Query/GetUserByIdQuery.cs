using CustomMediatR.Library.Interfaces;
using Microsoft.AspNetCore.Http.Features;

namespace CustomMediatR.Api.Query
{
    public class GetUserByIdQuery:IRequest<UserViewModel>
    {
        public int Id { get; set; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
