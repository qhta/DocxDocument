namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotAreas Class.
/// </summary>
public interface PivotAreas // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Pivot Area Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotArea>? PivotAreas { get ; set; }
  
}
