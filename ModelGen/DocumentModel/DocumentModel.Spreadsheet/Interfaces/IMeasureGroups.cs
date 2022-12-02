namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MeasureGroups Class.
/// </summary>
public interface IMeasureGroups // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IMeasureGroup>? MeasureGroups { get ; set; }
  
}
