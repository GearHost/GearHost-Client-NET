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

namespace GearHost.CoreTests
{
  using GearHost.Core;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class GearHostClientTests
  {
    /// <summary>
    /// Get Account integration test.
    /// </summary>
    [TestMethod]
    public void Get_Account_IsNotNull()
    {
      var cut = new GearHostClient();
      var result = cut.Accounts.Get();
      Assert.IsNotNull(result);
    }

    /// <summary>
    /// Get Account integration test.
    /// </summary>
    [TestMethod]
    public void Get_Account_Email_Equals_DustinDotHoppeAtGmailDotCom()
    {
      var cut = new GearHostClient();
      var result = cut.Accounts.Get();
      Assert.AreEqual(result.email, "dustin.hoppe@gmail.com");
    }

    /// <summary>
    /// Get Actions integration test.
    /// </summary>
    [TestMethod]
    public void Get_Actions_Count_Greater_Than_Zero()
    {
      var cut = new GearHostClient();
      var result = cut.Actions.Get();
      Assert.IsTrue(result.Count > 0);
    }
  }
}
