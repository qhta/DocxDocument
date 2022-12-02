namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ChartFormats Class.
/// </summary>
public interface IChartFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IChartFormat>? ChartFormats { get ; set; }
  
}
