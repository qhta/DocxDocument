namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Bypass East Asian/Complex Script Layout Code.
/// </summary>
public class UseFarEastLayout: IUseFarEastLayout
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
