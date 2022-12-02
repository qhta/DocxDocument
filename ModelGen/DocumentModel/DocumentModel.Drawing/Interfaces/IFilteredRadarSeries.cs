namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FilteredRadarSeries Class.
/// </summary>
public interface IFilteredRadarSeries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RadarChartSeries.
  /// </summary>
  public DocumentModel.Drawing.IRadarChartSeries? RadarChartSeries { get ; set; }
  
}
