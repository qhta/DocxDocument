namespace DocumentModel.Wordprocessing;

/// <summary>
/// Disable Features Incompatible With Earlier Word Processing Formats.
/// </summary>
public class UICompatibleWith97To2003: IUICompatibleWith97To2003
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
