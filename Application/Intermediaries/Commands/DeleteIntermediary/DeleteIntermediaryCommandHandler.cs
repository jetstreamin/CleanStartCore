//using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Application.Exceptions;
using Domain.Entities;
using Persistence;

namespace Application.Intermediaries.Commands.DeleteIntermediary
{
    public class DeleteIntermediaryCommandHandler : IRequestHandler<DeleteIntermediaryCommand>
    {
        private readonly CleanBoilerplateDbContext _context;

        public DeleteIntermediaryCommandHandler(CleanBoilerplateDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteIntermediaryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Intermediaries
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Intermediary), request.Id);
            }

            var hasFiles = false; //_context.Files.Any(o => o.IntermediaryId == entity.IntermediaryId);
            if (hasFiles)
            {
                throw new DeleteFailureException(nameof(Intermediary), request.Id, "There are existing files associated with this Intermediary.");
            }

            _context.Intermediaries.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
