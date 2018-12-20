using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Intermediaries.Queries.GetIntermediariesList
{
    public class GetIntermediariesListQueryHandler : IRequestHandler<GetIntermediariesListQuery, IntermediariesListViewModel>
    {
        private readonly CleanBoilerplateDbContext _context;

        public GetIntermediariesListQueryHandler(CleanBoilerplateDbContext context)
        {
            _context = context;
        }

        public async Task<IntermediariesListViewModel> Handle(GetIntermediariesListQuery request, CancellationToken cancellationToken)
        {
            var vm = new IntermediariesListViewModel
            {
                Intermediaries = await _context.Intermediaries.Select(c =>
                    new IntermediaryLookupModel
                    {
                        Id = c.IntermediaryId,
                        Name = c.Name
                    }).ToListAsync(cancellationToken)
            };

            return vm;
        }
    }
}
