using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearHost.Core.Services
{
  using GearHost.Core.Contracts;
  using GearHost.Core.Entities;

  public class CloudSiteService : GearHostApiBase, ICloudSiteService
  {
    private const string CloudSiteKey = "cloudsites";

    public CloudSiteService(string apiBaseUrl, string primaryApiKey)
      : base(apiBaseUrl, primaryApiKey)
    { }

    public CloudSites Get()
    {
      var url = string.Format("/{0}", CloudSiteKey);
      return this.GetRequest<CloudSites>(url, "cloudSites");
    }

    public CloudSite GetById(string id)
    {
      var url = string.Format("/{0}/{1}", CloudSiteKey, id);
      return this.GetRequest<CloudSite>(url, "cloudSite");
    }

    public void Create(string name, string plan)
    {
      throw new NotImplementedException();
    }
  }
}
