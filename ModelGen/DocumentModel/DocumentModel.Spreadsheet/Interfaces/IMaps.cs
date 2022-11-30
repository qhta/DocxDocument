namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Maps Class.
/// </summary>
public interface IMaps // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IMeasureDimensionMap>? MeasureDimensionMaps { get ; set; }
  
}
