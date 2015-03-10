
namespace GearHost.Core.Configuration
{
  using System.Configuration;

  public class GearHostSection : ConfigurationSection
  {
    public static GearHostSection Current
    {
      get
      {
        var section = ConfigurationManager.GetSection("gearhost") as GearHostSection;
        if (section == null)
        {
          throw new GearHostException("Unable to load 'gearhost' configuration section");
        }
        return section;
      }
    }

    [ConfigurationProperty("baseUrl", IsRequired = true, DefaultValue = "http://api.gearhost.com/api/")]
    public string ApiBaseUrl
    {
      get
      {
        return (string)this["baseUrl"];
      }
      set
      {
        this["baseUrl"] = value;
      }
    }

    [ConfigurationProperty("primaryApiKey", IsRequired = true, DefaultValue = "NotSet")]
    public string PrimaryApiKey
    {
      get
      {
        return (string)this["primaryApiKey"];
      }
      set
      {
        this["primaryApiKey"] = value;
      }
    }
  }
}