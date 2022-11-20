namespace DocumentModel.Spreadsheet;

/// <summary>
/// Query table fields.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQueryTableField))]
public class QueryTableFields: IQueryTableFields
{
  /// <summary>
  /// Column Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
