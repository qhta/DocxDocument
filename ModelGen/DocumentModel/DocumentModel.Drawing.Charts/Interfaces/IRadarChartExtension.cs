namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public interface IRadarChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFilteredRadarSeries? FilteredRadarSeries { get ; set; }
  
}
