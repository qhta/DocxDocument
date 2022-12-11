namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterChartExtension Class.
/// </summary>
public class ScatterChartExtensionImpl: ModelElementImpl, ScatterChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ScatterChartExtensionImpl(): base() {}
  
  public ScatterChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtension openXmlElement): base(openXmlElement)
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
  
  public FilteredScatterSeries? FilteredScatterSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
