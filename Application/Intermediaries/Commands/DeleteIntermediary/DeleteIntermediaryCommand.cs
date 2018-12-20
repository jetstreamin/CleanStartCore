using MediatR;

namespace Application.Intermediaries.Commands.DeleteIntermediary
{
    public class DeleteIntermediaryCommand : IRequest
    {
        public string Id { get; set; }
    }
}
