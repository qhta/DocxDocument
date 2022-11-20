namespace DocumentModel.Wordprocessing;

/// <summary>
/// Ignore Space Before Table When Deciding If Table Should Wrap Floating Object.
/// </summary>
public class LayoutRawTableWidth: ILayoutRawTableWidth
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
