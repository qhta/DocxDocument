namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredLineSeriesExtension Class.
/// </summary>
public partial class FilteredLineSeriesExtensionImpl: ModelElementImpl, FilteredLineSeriesExtension
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FilteredLineSeriesExtensionImpl(): base() {}
  
  public FilteredLineSeriesExtensionImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredLineSeriesExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// LineChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.LineChartSeries3? LineChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.LineChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LineChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.LineChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
