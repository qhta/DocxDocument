namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredBarSeries Class.
/// </summary>
public partial class FilteredBarSeriesImpl: ModelElementImpl, FilteredBarSeries
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FilteredBarSeriesImpl(): base() {}
  
  public FilteredBarSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredBarSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// BarChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.BarChartSeries3? BarChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.BarChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.BarChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.BarChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
