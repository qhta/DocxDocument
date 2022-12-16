namespace DocumentModel.Drawings.Charts;

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
  
  public Area3DChartExtensionImpl(): base() {}
  
  public Area3DChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Area3DChartExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.Charts.FilteredAreaSeries? FilteredAreaSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredAreaSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredAreaSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
