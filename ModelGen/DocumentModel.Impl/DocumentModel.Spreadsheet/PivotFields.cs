namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotField))]
public class PivotFields: IPivotFields
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
