namespace DocumentModel.Spreadsheet;

/// <summary>
/// Value.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDdeLinkValue))]
public class Value: IValue
{
  /// <summary>
  /// DDE Value Type
  /// </summary>
  public DocumentModel.Spreadsheet.DdeValues? ValueType
  {
    get;
    set;
  }
  
  /// <summary>
  /// DDE Link Value.
  /// </summary>
  public IDdeLinkValue? DdeLinkValue
  {
    get;
    set;
  }
  
}
