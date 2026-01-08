namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a series axis for a chart, including tick label and mark skipping, and extension list.
/// </summary>
public interface SeriesAxis : AxisType
{
  /// <summary>
  ///   Number of tick labels to skip on the axis.
  /// </summary>
  public Int32? TickLabelSkip { get; set; }

  /// <summary>
  ///   Number of tick marks to skip on the axis.
  /// </summary>
  public Int32? TickMarkSkip { get; set; }

  /// <summary>
  ///   Extension list for additional series axis properties.
  /// </summary>
  public SerAxExtensionList? SerAxExtensionList { get; set; }
}