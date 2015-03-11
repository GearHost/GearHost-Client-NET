

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
