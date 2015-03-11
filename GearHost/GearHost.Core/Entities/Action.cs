using System;
using System.Collections.Generic;
using System.Linq;

namespace GearHost.Core.Entities
{
  public class Actions : List<Action>
  { }

  public class Action
  {
    public string id { get; set; }
    public string action { get; set; }
    public string ip { get; set; }
    public DateTime date { get; set; }
  }
}
