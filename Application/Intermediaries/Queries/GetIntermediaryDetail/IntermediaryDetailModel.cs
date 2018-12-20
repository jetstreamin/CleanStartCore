using System;
using System.Linq.Expressions;
using Domain.Entities;

namespace Application.Intermediaries.Queries.GetIntermediaryDetail
{
    public class IntermediaryDetailModel
    {

        public string Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }

        public static Expression<Func<Intermediary, IntermediaryDetailModel>> Projection
        {
            get
            {
                return intermediary => new IntermediaryDetailModel
                {
                    Id = intermediary.IntermediaryId,
                    Address = intermediary.Address,
                    City = intermediary.City,
                    Name = intermediary.Name,
                    ContactName = intermediary.ContactName,
                    ContactTitle = intermediary.ContactTitle,
                    Country = intermediary.Country,
                    Fax = intermediary.Fax,
                    Phone = intermediary.Phone,
                    PostalCode = intermediary.PostalCode,
                    Region = intermediary.Region
                };
            }
        }

        public static IntermediaryDetailModel Create(Intermediary intermediary)
        {
            return Projection.Compile().Invoke(intermediary);
        }

    }
}
