namespace DocumentModel.Spreadsheet;

/// <summary>
/// Deleted Fields.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDeletedField))]
public class QueryTableDeletedFields: IQueryTableDeletedFields
{
  /// <summary>
  /// Deleted Fields Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
