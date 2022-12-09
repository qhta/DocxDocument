namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public ChartText2? ChartText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
