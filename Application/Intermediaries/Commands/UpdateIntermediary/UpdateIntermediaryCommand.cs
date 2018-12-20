﻿using MediatR;

namespace Application.Intermediaries.Commands.UpdateIntermediary
{
    public class UpdateIntermediaryCommand : IRequest
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
    }
}
