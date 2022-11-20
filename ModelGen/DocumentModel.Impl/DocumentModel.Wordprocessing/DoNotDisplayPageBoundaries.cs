namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Display Visual Boundary For Header/Footer or Between Pages.
/// </summary>
public class DoNotDisplayPageBoundaries: IDoNotDisplayPageBoundaries
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
