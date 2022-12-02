namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Maps Class.
/// </summary>
public interface IMaps // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IMeasureDimensionMap>? MeasureDimensionMaps { get ; set; }
  
}
