using System;
using System.Collections.Generic;

namespace GearHost.Core.Entities
{
  public class CloudSites : List<CloudSite>
  { }

  public class CloudSite
  {
    public string id { get; set; }
    public string name { get; set; }
    public string plan { get; set; }
    public DateTime dateCreated { get; set; }
    public string status { get; set; }
    public int instances { get; set; }
  }
}
