namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Dimensions Class.
/// </summary>
public interface IDimensions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Dimensions Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IDimension>? Dimensions { get ; set; }
  
}
