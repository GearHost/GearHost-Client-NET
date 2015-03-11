using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearHost.Core.Contracts
{
  using GearHost.Core.Entities;

  public interface IAccountService
  {
    Account Get();
  }
}
