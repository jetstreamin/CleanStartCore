using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;
using Persistence;

namespace Application.Intermediaries.Commands.CreateIntermediary
{
    public class CreateIntermediaryCommandHandler : IRequestHandler<CreateIntermediaryCommand, Unit>
    {
        private readonly CleanBoilerplateDbContext _context;

        public CreateIntermediaryCommandHandler(
            CleanBoilerplateDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateIntermediaryCommand request, CancellationToken cancellationToken)
        {
            var entity = new Intermediary
            {
                IntermediaryId = request.Id,
                Name = request.Name,
                Address = request.Address,
                City = request.City,
                ContactName = request.ContactName,
                ContactTitle = request.ContactTitle,
                Country = request.Country,
                Fax = request.Fax,
                Phone = request.Phone,
                PostalCode = request.PostalCode
            };

            _context.Intermediaries.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
