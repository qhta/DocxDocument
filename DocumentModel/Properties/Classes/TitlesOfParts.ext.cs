namespace DocumentModel.Properties;

/// <summary>
/// Part Titles.
/// </summary>
public partial class TitlesOfParts
{
  public override string? ToString()
  {
    if (this.Vector != null)
    {
      var str = Vector.ToString();
      return str;
    }
    return null;
  }
}