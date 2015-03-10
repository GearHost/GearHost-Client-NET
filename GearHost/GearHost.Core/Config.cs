
namespace GearHost.Core
{
  using System;
  using System.Configuration;

  using GearHost.Core.Configuration;

  /// <summary>
  /// 
  /// </summary>
  public class Config
  {
    /// <summary>
    /// 
    /// </summary>
    public static string PrimaryApiKey
    {
      get
      {
        return GearHostSection.Current.PrimaryApiKey;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public static string ApiBaseUrl
    {
      get
      {
        return GearHostSection.Current.ApiBaseUrl;
      }
    }
  }
}