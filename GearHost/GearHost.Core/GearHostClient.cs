namespace GearHost.Core
{
  using GearHost.Core.Contracts;
  using GearHost.Core.Services;

  public class GearHostClient
  {
    #region Accessors

    /// <summary>
    /// 
    /// </summary>
    public IAccountService Accounts { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public IActionService Actions { get; private set; }

    #endregion

    #region Constructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiBaseUrl"></param>
    /// <param name="primaryApiKey"></param>
    public GearHostClient(string apiBaseUrl, string primaryApiKey)
    {
      this.Accounts = new AccountService(apiBaseUrl, primaryApiKey);
      this.Actions = new ActionService(apiBaseUrl, primaryApiKey);
    }

    /// <summary>
    /// 
    /// </summary>
    public GearHostClient()
      : this(Config.ApiBaseUrl, Config.PrimaryApiKey)
    { }

    #endregion
  }
}
