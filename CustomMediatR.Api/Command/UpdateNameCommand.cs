using System;
using CustomMediatR.Library.Interfaces;

namespace CustomMediatR.Api.Command
{
    public class UpdateNameCommand:IRequest<int>
    {
        public string FirstName { get; set; }

        public UpdateNameCommand(string firstName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        }


    }
}
