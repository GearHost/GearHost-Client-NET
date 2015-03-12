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

    public Actions Get(int page = 1)
    {
      var url = string.Format("/{0}?page={1}", ActionKey, page);
      return this.GetRequest<Actions>(url, "actions");
    }

    public Action GetById(string id)
    {
      var url = string.Format("/{0}/{1}", ActionKey, id);
      return this.GetRequest<Action>(url, "action");
    }
  }
}
