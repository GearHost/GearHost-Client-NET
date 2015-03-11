# Net-GearHost
.NET client wrapper for the GearHost API.


## usage
In order to begin using the GearHost client library, you must start by locating your api key within your my.gearhost.com control panel [my.gearhost.com]. It will be located under the **API** tab.

Once you have your API key, you'll need to update your application's config file ( App.config or Web.config ). Add a new **section** element to the **configSections** element as follows.

```xml
  <configSections>
    <section name="gearhost" type="GearHost.Core.Configuration.GearHostSection, GearHost.Core"/>
  </configSections>
```

Next, you'll need to add a **gearhost** section to your config file.

```xml
  <gearhost
      baseUrl="http://api.gearhost.com/"
      primaryApiKey="primaryApiKey"
    />
```

