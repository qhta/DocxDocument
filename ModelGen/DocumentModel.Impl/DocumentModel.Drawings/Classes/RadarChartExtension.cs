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
  
  public RadarChartExtensionImpl(): base() {}
  
  public RadarChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public FilteredRadarSeries? FilteredRadarSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
