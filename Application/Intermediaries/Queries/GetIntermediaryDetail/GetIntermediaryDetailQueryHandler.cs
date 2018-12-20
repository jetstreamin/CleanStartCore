using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Application.Exceptions;
using Domain.Entities;
using Persistence;

namespace Application.Intermediaries.Queries.GetIntermediaryDetail
{
    public class GetIntermediaryDetailQueryHandler : IRequestHandler<GetIntermediaryDetailQuery, IntermediaryDetailModel>
    {
        private readonly CleanBoilerplateDbContext _context;

        public GetIntermediaryDetailQueryHandler(CleanBoilerplateDbContext context)
        {
            _context = context;
        }

        public async Task<IntermediaryDetailModel> Handle(GetIntermediaryDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Intermediaries
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Intermediary), request.Id);
            }

            return new IntermediaryDetailModel
            {
                Id = entity.IntermediaryId,
                Address = entity.Address,
                City = entity.City,
                Name = entity.Name,
                ContactName = entity.ContactName,
                ContactTitle = entity.ContactTitle,
                Country = entity.Country,
                Fax = entity.Fax,
                Phone = entity.Phone,
                PostalCode = entity.PostalCode,
                Region = entity.Region
            };
        }
    }
}
