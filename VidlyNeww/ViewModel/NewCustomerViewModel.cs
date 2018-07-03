using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyNeww.Models;

namespace VidlyNeww.ViewModel
{
    public class NewCustomerViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}