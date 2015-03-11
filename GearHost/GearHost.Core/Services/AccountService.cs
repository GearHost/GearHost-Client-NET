using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearHost.Core.Services
{
  using GearHost.Core.Contracts;
  using GearHost.Core.Entities;

  public class AccountService: GearHostApiBase, IAccountService
  {
    private const string AccountKey = "account";

    public AccountService(string apiBaseUrl, string primaryApiKey)
      : base(apiBaseUrl, primaryApiKey)
    { }

    public Account Get()
    {
      var url = string.Format("/{0}", AccountKey);
      return this.GetRequest<Account>(url, "account");
    }
  }
}
