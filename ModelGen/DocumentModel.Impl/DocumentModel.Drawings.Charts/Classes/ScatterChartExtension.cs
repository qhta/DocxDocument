namespace DocumentModel.Drawings.Charts;

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
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredScatterSeries? FilteredScatterSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredScatterSeriesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredScatterSeriesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
