namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   ILine Charts.
/// </summary>
public class LineChart: ModelElement
{
  /// <summary>
  ///   Grouping.
  /// </summary>
  public GroupingKind? Grouping { get; set; }

  /// <summary>
  ///   VaryColors.
  /// </summary>
  public bool? VaryColors { get; set; }

  public Collection<LineChartSeries>? LineChartSeries { get; set; }

  public IDataLabels? IDataLabels { get; set; }

  public IDropLines? IDropLines { get; set; }

  public HighLowLines? HighLowLines { get; set; }

  public UpDownBars? UpDownBars { get; set; }

  public bool? ShowMarker { get; set; }

  public bool? Smooth { get; set; }

  public Collection<UInt32>? AxisIds { get; set; }

  public LineChartExtensionList? LineChartExtensionList { get; set; }
}
