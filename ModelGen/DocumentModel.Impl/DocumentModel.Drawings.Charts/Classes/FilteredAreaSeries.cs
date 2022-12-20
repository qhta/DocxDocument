namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredAreaSeries Class.
/// </summary>
public partial class FilteredAreaSeriesImpl: ModelElementImpl, FilteredAreaSeries
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FilteredAreaSeriesImpl(): base() {}
  
  public FilteredAreaSeriesImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredAreaSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// AreaChartSeries.
  /// </summary>
  public DocumentModel.Drawings.Charts.AreaChartSeries3? AreaChartSeries
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.AreaChartSeries3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AreaChartSeries>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.AreaChartSeries3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
