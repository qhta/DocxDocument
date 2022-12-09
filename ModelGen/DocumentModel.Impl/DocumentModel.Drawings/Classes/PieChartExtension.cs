namespace DocumentModel.Drawings;

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
