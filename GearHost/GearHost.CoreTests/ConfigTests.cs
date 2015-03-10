using System;
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
      Assert.AreEqual(vut, "http://api.gearhost.com/api/");
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
      Assert.AreEqual(vut, "primaryApiKey");
    }
  }
}
