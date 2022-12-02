namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public interface IFilteredLineSeriesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public ILineChartSeries? LineChartSeries { get ; set; }
  
}
