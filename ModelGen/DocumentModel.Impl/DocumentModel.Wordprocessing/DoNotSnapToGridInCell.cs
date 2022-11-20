namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Snap to Document Grid in Table Cells with Objects.
/// </summary>
public class DoNotSnapToGridInCell: IDoNotSnapToGridInCell
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
