namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Create Custom Tab Stop for Hanging Indent.
/// </summary>
public class NoTabHangIndent: INoTabHangIndent
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
