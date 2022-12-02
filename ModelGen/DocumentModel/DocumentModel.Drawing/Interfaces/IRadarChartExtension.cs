namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public interface IRadarChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFilteredRadarSeries? FilteredRadarSeries { get ; set; }
  
}
