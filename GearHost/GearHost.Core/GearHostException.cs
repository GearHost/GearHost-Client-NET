namespace GearHost.Core
{
  using System;

  public class GearHostException : Exception
  {
    public GearHostException(string message)
      : base(message)
    {
    }
  }
}
