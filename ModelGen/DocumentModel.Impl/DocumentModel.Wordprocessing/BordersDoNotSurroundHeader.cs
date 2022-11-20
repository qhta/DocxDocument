namespace DocumentModel.Wordprocessing;

/// <summary>
/// Page Border Excludes Header.
/// </summary>
public class BordersDoNotSurroundHeader: IBordersDoNotSurroundHeader
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
