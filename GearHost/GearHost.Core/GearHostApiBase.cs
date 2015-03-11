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
  using System;
  using System.Net;

  using RestSharp;
  using RestSharp.Serializers;

  /// <summary>
  /// 
  /// </summary>
  public class GearHostApiBase
  {
    #region Properties and Accessors

    protected string BaseUrl { get; private set; }
    protected string PrimaryApiKey { get; private set; }

    private static string _userAgent;

    private static string UserAgent
    {
      get
      {
        return _userAgent
               ?? (_userAgent =
                   String.Format(
                     "GearHost.NET RestSharp Client v"
                     + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version));
      }
    }

    private readonly RestClient _client;

    #endregion

    #region Constructors

    /// <summary>
    /// 
    /// </summary>
    /// <param name="baseUrl"></param>
    /// <param name="primaryApiKey"></param>
    public GearHostApiBase(string baseUrl, string primaryApiKey)
    {
      if (string.IsNullOrEmpty(primaryApiKey))
        throw new ArgumentException("Primary Subscription Key is required.");

      if (string.IsNullOrEmpty(baseUrl))
        throw new ArgumentException("Api Base Url is required.");

      this.PrimaryApiKey = primaryApiKey;

      if (baseUrl.EndsWith("/"))
        baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);

      BaseUrl = baseUrl;

      _client = new RestClient()
                  {
                    UserAgent = UserAgent, 
                    BaseUrl = new Uri(Config.ApiBaseUrl),
                    Authenticator = new HttpBasicAuthenticator("api-key", primaryApiKey),
                    CookieContainer = new CookieContainer()
                  };
    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="path"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public T GetRequest<T>(string path, params object[] args) where T : new()
    {
      return this.GetRequest<T>(path, string.Empty, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="path"></param>
    /// <param name="rootElement"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public T GetRequest<T>(string path, string rootElement, params object[] args) where T : new()
    {
      var request = new RestRequest(this.BuildUrl(path, args));
      if (!string.IsNullOrWhiteSpace(rootElement))
      {
        request.RootElement = rootElement;
      }

      this.InitializeRequest(request);
      var response = this._client.Execute<T>(request);

      if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
      {
        throw new GearHostException("Not Found");
      }
      if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
      {
        throw new GearHostException("Internal Server Error");
      }

      return response.Data;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public string BuildUrl(string path, params object[] args)
    {
      return string.Format(path, args);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    public void InitializeRequest(RestRequest request)
    {
      request.RequestFormat = DataFormat.Json;
      request.JsonSerializer = new JsonSerializer();

      request.AddHeader("Authorization", string.Format("api-key {0}", this.PrimaryApiKey));
    }
  }
}