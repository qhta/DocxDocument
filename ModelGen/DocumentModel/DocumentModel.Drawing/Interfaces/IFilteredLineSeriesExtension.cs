namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public interface IFilteredLineSeriesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public DocumentModel.Drawing.ILineChartSeries? LineChartSeries { get ; set; }
  
}
