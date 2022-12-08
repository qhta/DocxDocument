namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public class RadarChartExtensionImpl: ModelElementImpl, RadarChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredRadarSeries? FilteredRadarSeries
  {
    get;
    set;
  }
  
}
