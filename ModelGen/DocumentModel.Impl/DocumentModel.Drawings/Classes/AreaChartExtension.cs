namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AreaChartExtension Class.
/// </summary>
public class AreaChartExtensionImpl: ModelElementImpl, AreaChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  public FilteredAreaSeries? FilteredAreaSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
