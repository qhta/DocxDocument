namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotHierarchies Class.
/// </summary>
public interface IPivotHierarchies // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Hierarchy Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotHierarchy>? PivotHierarchies { get ; set; }
  
}
