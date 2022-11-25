namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public interface IFilteredRadarSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IRadarChartSeries? RadarChartSeries { get ; set; }
  
}
