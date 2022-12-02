namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Dimensions Class.
/// </summary>
public interface IDimensions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// OLAP Dimensions Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IDimension>? Dimensions { get ; set; }
  
}
