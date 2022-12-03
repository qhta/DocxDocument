namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Maps Class.
/// </summary>
public interface Maps // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<MeasureDimensionMap>? MeasureDimensionMaps { get ; set; }
  
}
