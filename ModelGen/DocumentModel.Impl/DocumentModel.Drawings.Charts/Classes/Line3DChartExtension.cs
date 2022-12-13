namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Line3DChartExtension Class.
/// </summary>
public class Line3DChartExtensionImpl: ModelElementImpl, Line3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Line3DChartExtensionImpl(): base() {}
  
  public Line3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings13.Charts.FilteredLineSeriesExtension? FilteredLineSeriesExtension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
