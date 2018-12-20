using MediatR;

namespace Application.Intermediaries.Queries.GetIntermediaryDetail
{
    public class GetIntermediaryDetailQuery : IRequest<IntermediaryDetailModel>
    {
        public string Id { get; set; }
    }
}
