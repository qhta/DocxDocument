namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MeasureGroups Class.
/// </summary>
public interface MeasureGroups // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<MeasureGroup>? MeasureGroups { get ; set; }
  
}
