namespace DocumentModel.Properties;

/// <summary>
/// Part Titles.
/// </summary>
[Newtonsoft.Json.JsonConverter(typeof(HeadingPairsJsonConverter))]
public partial class HeadingPairs
{
  public override string? ToString()
  {
    if (this.VTVector != null)
    {
      var str = VTVector.ToString();
      return str;
    }
    return null;
  }
}