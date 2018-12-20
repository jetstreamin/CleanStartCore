using System.Collections.Generic;

namespace Application.Intermediaries.Queries.GetIntermediariesList
{
    public class IntermediariesListViewModel
    {
        public IList<IntermediaryLookupModel> Intermediaries { get; set; }
    }
}
