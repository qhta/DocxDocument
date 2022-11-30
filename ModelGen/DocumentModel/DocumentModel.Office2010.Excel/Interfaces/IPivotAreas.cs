namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the PivotAreas Class.
/// </summary>
public interface IPivotAreas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Area Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotArea>? PivotAreas { get ; set; }
  
}
