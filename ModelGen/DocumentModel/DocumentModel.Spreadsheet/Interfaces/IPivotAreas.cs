namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotAreas Class.
/// </summary>
public interface IPivotAreas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Area Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPivotArea>? PivotAreas { get ; set; }
  
}
