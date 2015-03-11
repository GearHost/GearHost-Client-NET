using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearHost.Core.Entities
{
  public class Account
  {
    public string email { get; set; }
    public bool emailVerified { get; set; }
    public bool billingVerified { get; set; }
    public DateTime memberSince { get; set; }
  }
}
