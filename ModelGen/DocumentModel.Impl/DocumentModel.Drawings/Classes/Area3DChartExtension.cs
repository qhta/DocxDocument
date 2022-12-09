namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Area3DChartExtension Class.
/// </summary>
public class Area3DChartExtensionImpl: ModelElementImpl, Area3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension?)_OpenXmlElement;
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
