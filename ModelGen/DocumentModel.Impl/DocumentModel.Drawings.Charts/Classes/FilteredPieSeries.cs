namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredPieSeries Class.
/// </summary>
public partial class FilteredPieSeriesImpl: ModelElementImpl, FilteredPieSeries
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FilteredPieSeriesImpl(): base() {}
  
  public FilteredPieSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredPieSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// PieChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.PieChartSeries3? PieChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PieChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PieChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PieChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
