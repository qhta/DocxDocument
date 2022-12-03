namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ChartFormats Class.
/// </summary>
public interface ChartFormats // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<ChartFormat>? ChartFormats { get ; set; }
  
}
