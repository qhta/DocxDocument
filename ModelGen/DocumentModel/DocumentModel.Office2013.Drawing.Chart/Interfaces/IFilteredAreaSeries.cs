namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public interface IFilteredAreaSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IAreaChartSeries? AreaChartSeries { get ; set; }
  
}
