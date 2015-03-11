
namespace GearHost.Core.Services
{
  using GearHost.Core.Contracts;
  using GearHost.Core.Entities;

  public class ActionService : GearHostApiBase, IActionService
  {
    private const string ActionKey = "actions";

    public ActionService(string apiBaseUrl, string primaryApiKey)
      : base(apiBaseUrl, primaryApiKey)
    { }

    public Actions Get()
    {
      string url = string.Format("/{0}", ActionKey);
      return this.GetRequest<Actions>(url, "actions");
    }
  }
}
