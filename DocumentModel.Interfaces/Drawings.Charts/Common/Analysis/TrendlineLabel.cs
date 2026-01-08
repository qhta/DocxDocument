namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the label for a trendline in a chart.
///   The trendline label provides additional information, formatting, and layout options for displaying the trendline's equation, name, or other details on the chart.
/// </summary>
public interface TrendlineLabel
{
  /// <summary>
  ///   Layout configuration for the trendline label, controlling its position and alignment within the chart area.
  /// </summary>
  public Layout? Layout { get; set; }

  /// <summary>
  ///   Text content and formatting for the trendline label.
  /// </summary>
  public ChartText? ChartText { get; set; }

  /// <summary>
  ///   Number format applied to values displayed in the trendline label.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Visual and shape properties for the trendline label.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Text formatting and style properties for the trendline label.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional customization of the trendline label.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}