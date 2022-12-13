namespace DocumentModel.Drawings13.Charts;

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
  public DocumentModel.Drawings13.Charts.ChartText? ChartText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
