/*
  -----------------------------------------------------------------------
  Dusty Hoppe (@HopDizzle)
  http://github.com/hopdizzle/gearhost-client-net
  ------------------------------------------------------------------------
  This file is part of gearhost-client-net.

  gearhost-client-net is free software: you can redistribute it and/or 
  modify it under the terms of the GNU General Public License as published 
  by the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  gearhost-client-net is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
  -----------------------------------------------------------------------
 */

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

    /// <summary>
    /// 
    /// </summary>
    public ICloudSiteService CloudSites { get; private set; }

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
      this.CloudSites = new CloudSiteService(apiBaseUrl, primaryApiKey);
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
