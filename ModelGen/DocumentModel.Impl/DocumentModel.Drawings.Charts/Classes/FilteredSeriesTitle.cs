namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public class FilteredSeriesTitleImpl: ModelElementImpl, FilteredSeriesTitle
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FilteredSeriesTitleImpl(): base() {}
  
  public FilteredSeriesTitleImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartText3? ChartText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartText3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.ChartText>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartText3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
