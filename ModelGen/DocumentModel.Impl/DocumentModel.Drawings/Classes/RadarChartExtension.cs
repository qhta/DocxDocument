namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RadarChartExtension Class.
/// </summary>
public class RadarChartExtensionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension>, RadarChartExtension
{
  public FilteredRadarSeries? FilteredRadarSeries
  {
    get;
    set;
  }
  
}
