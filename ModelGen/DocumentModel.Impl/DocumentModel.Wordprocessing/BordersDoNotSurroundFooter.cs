namespace DocumentModel.Wordprocessing;

/// <summary>
/// Page Border Excludes Footer.
/// </summary>
public class BordersDoNotSurroundFooter: IBordersDoNotSurroundFooter
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
