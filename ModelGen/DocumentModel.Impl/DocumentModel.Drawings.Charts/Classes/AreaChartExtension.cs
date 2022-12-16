namespace DocumentModel.Drawings.Charts;

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
  
  public AreaChartExtensionImpl(): base() {}
  
  public AreaChartExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.AreaChartExtension openXmlElement): base(openXmlElement)
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
