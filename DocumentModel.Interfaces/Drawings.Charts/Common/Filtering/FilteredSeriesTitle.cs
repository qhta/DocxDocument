namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a filtered series title for a chart, including the chart text.
/// </summary>
public interface FilteredSeriesTitle
{
  /// <summary>
  ///   Chart text associated with the filtered series title.
  /// </summary>
  public ChartText3 ChartText { get; set; }
}