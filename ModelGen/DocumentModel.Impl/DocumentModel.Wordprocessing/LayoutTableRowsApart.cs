namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Table Rows to Wrap Inline Objects Independently.
/// </summary>
public class LayoutTableRowsApart: ILayoutTableRowsApart
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
