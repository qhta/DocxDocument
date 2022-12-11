namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineChartExtension Class.
/// </summary>
public class LineChartExtensionImpl: ModelElementImpl, LineChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineChartExtensionImpl(): base() {}
  
  public LineChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension openXmlElement): base(openXmlElement)
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
  
  public FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
