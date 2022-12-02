namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public interface IRadarChartExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFilteredRadarSeries? FilteredRadarSeries { get ; set; }
  
}
