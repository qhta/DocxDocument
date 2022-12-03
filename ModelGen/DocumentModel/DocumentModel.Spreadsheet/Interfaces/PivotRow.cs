namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotRow Class.
/// </summary>
public interface PivotRow // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// r, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Reference { get ; set; }
  
  /// <summary>
  /// count, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotValueCell>? PivotValueCells { get ; set; }
  
}
