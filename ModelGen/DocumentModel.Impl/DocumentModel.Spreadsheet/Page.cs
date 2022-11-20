namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageItem))]
public class Page: IPage
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
