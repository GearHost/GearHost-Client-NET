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
