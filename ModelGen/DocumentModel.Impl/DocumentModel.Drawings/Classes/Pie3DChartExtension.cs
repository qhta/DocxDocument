namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Pie3DChartExtension Class.
/// </summary>
public class Pie3DChartExtensionImpl: ModelElementImpl, Pie3DChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Pie3DChartExtensionImpl(): base() {}
  
  public Pie3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension openXmlElement): base(openXmlElement)
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
  
  public FilteredPieSeries? FilteredPieSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
