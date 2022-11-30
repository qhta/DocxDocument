namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilters Class.
/// </summary>
public interface IPivotFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Filter Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotFilter>? PivotFilters { get ; set; }
  
}
