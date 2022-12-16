namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredScatterSeries Class.
/// </summary>
public class FilteredScatterSeriesImpl: ModelElementImpl, FilteredScatterSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FilteredScatterSeriesImpl(): base() {}
  
  public FilteredScatterSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredScatterSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ScatterChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.ScatterChartSeries3? ScatterChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ScatterChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ScatterChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ScatterChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
