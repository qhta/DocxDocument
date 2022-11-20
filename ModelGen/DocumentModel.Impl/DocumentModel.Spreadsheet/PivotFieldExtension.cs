namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFieldExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IPivotField))]
public class PivotFieldExtension: IPivotFieldExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
