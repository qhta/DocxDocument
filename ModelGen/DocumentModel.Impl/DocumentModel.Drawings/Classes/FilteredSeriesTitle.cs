namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredSeriesTitle Class.
/// </summary>
public class FilteredSeriesTitleImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>, FilteredSeriesTitle
{
  /// <summary>
  /// ChartText.
  /// </summary>
  public ChartText2? ChartText
  {
    get;
    set;
  }
  
}
