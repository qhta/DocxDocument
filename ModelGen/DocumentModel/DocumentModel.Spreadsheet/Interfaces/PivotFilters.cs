namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilters Class.
/// </summary>
public interface PivotFilters // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotFilter>? PivotFilters { get ; set; }
  
}
