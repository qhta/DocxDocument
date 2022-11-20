namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PageFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPageField))]
public class PageFields: IPageFields
{
  /// <summary>
  /// Page Item Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
