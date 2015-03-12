
namespace GearHost.Core.Contracts
{
  using System;

  using GearHost.Core.Entities;

  public interface ICloudSiteService
  {
    CloudSites Get();

    CloudSite GetById(string id);

    void Create(string name, string plan);
  }
}
