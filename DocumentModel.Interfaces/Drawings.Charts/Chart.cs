namespace DocumentModel.Drawings;

/// <summary>
/// Represents a chart to animate, including series and category indices, animation build step, and extension options.
/// </summary>
public interface Chart: ExtendableElement
{
  /// <summary>
  /// Series index for the chart animation.
  /// </summary>
  public Int32? SeriesIndex { get; set; }

  /// <summary>
  /// Category index for the chart animation.
  /// </summary>
  public Int32? CategoryIndex { get; set; }

  /// <summary>
  /// Animation build step for the chart.
  /// </summary>
  public ChartBuildStepKind? BuildStep { get; set; }
}