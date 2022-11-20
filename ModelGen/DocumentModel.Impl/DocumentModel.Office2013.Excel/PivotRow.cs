namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotRow Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IPivotValueCell))]
public class PivotRow: IPivotRow
{
  /// <summary>
  /// r, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Reference
  {
    get;
    set;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
