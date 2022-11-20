namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the ListItem Class.
/// </summary>
public class ListItem: IListItem
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
