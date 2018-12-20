using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Exceptions;
using Domain.Entities;
using Persistence;

namespace Application.Intermediaries.Commands.UpdateIntermediary
{
    public class UpdateIntermediaryCommandHandler : IRequestHandler<UpdateIntermediaryCommand, Unit>
    {
        private readonly CleanBoilerplateDbContext _context;

        public UpdateIntermediaryCommandHandler(CleanBoilerplateDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateIntermediaryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Intermediaries
                .SingleAsync(c => c.IntermediaryId == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Intermediary), request.Id);
            }

            entity.Address = request.Address;
            entity.City = request.City;
            entity.Name = request.Name;
            entity.ContactName = request.ContactName;
            entity.ContactTitle = request.ContactTitle;
            entity.Country = request.Country;
            entity.Fax = request.Fax;
            entity.Phone = request.Phone;
            entity.PostalCode = request.PostalCode;

            _context.Intermediaries.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
