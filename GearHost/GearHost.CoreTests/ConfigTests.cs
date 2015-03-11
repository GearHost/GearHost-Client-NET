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

  Foobar is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
  -----------------------------------------------------------------------
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GearHost.CoreTests
{
  using GearHost.Core;

  [TestClass]
  public class ConfigTests
  {
    [TestMethod]
    public void Config_ApiBaseUrl_IsNotNull()
    {
      var vut = Config.ApiBaseUrl;
      Assert.IsNotNull(vut);
    }

    [TestMethod]
    public void Config_ApiBaseUrl_Equals_GearHostApiUrl()
    {
      var vut = Config.ApiBaseUrl;
      Assert.AreEqual(vut, "https://api.gearhost.com/");
    }

    [TestMethod]
    public void Config_PrimaryApiKey_IsNotNull()
    {
      var vut = Config.PrimaryApiKey;
      Assert.IsNotNull(vut);
    }

    [TestMethod]
    public void Config_PrimaryApiKey_Equals_primaryApiKey()
    {
      var vut = Config.PrimaryApiKey;
      Assert.AreEqual(vut, "dff0af8d4cae4f3baeb0bdb96bfe5e67");
    }
  }
}
