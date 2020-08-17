﻿using System;

namespace Vendr.Checkout.Web.Dtos
{
    public class VendrOrderAddressDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public Guid Country { get; set; }

        public Guid? Region { get; set; }

        public string Telephone { get; set; }
    }
}
