namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Maps Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMeasureDimensionMap))]
public interface IMaps // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
