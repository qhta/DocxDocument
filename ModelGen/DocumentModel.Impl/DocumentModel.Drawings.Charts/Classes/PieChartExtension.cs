namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the PieChartExtension Class.
/// </summary>
public class PieChartExtensionImpl: ModelElementImpl, PieChartExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PieChartExtensionImpl(): base() {}
  
  public PieChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings13.Charts.FilteredPieSeries? FilteredPieSeries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
