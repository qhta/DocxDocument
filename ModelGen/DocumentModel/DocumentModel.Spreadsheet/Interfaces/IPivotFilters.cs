namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilters Class.
/// </summary>
public interface IPivotFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPivotFilter>? PivotFilters { get ; set; }
  
}
