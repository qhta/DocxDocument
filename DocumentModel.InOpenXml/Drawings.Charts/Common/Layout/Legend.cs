namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Describes legend data and formatting for a chart, including position, entries, layout, overlay, shape formatting, text formatting, and extensions.
/// </summary>
public class Legend//: ExtendableElement
{
  /// <summary>
  /// Specifies the position of the legend within the chart area.
  /// </summary>
  public LegendPosition? LegendPosition { get; set; }

  /// <summary>
  /// Collection of legend entries representing individual series or data points.
  /// </summary>
  public LegendEntries? LegendEntries { get; set; }

  /// <summary>
  /// Layout information for the legend, such as size and alignment.
  /// </summary>
  public Layout? Layout { get; set; }

  /// <summary>
  /// Indicates whether the legend overlays the chart area.
  /// </summary>
  public bool? Overlay { get; set; }

  /// <summary>
  /// Shape formatting and visual properties for the legend background and border.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  /// Text formatting and properties for legend labels.
  /// </summary>
  public TextProperties? TextProperties { get; set; }
}