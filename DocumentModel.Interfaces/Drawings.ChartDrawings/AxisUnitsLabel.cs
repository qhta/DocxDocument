namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the label displayed for axis units in a chart.
/// </summary>
/// <remarks>
///   This interface defines the label element that describes
///   the units or scale applied to a chart axis. The axis units label provides textual context for the
///   magnitude or measurement type of axis values (e.g., "in millions", "°Celsius", "USD", "percentage").
///   The label includes text content, visual styling properties through shape properties, text formatting
///   properties, and support for custom extensions. This label helps users interpret axis values correctly
///   by clarifying the scale factor or measurement unit, particularly when axis values are displayed in
///   abbreviated or scaled format. The label can be extensively customized in terms of appearance,
///   positioning, and text formatting to match the chart's overall design.
/// </remarks>
public interface AxisUnitsLabel
{
  /// <summary>
  ///   Gets or sets the text content displayed as the axis units label.
  /// </summary>
  /// <remarks>
  ///   The text content defines what unit description is displayed, providing clarity about the scale
  ///   or measurement type (e.g., "(thousands)", "millions", "°F", "%"). This can include plain text
  ///   or rich text with formatting.
  /// </remarks>
  public Text? Text { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the axis units label.
  /// </summary>
  /// <remarks>
  ///   Shape properties control the visual appearance of the label element, including background fill,
  ///   border styling, shadows, and other visual effects that enhance the label's presentation and
  ///   ensure it stands out appropriately within the chart.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for the axis units label.
  /// </summary>
  /// <remarks>
  ///   Text properties control the formatting of the label text, including font family, size, color,
  ///   style (bold, italic), alignment, rotation, and spacing. This enables precise control over
  ///   the label's typographic appearance and ensures readability alongside axis values.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <remarks>
  ///   Extension elements allow for future enhancements and custom properties without breaking
  ///   compatibility with existing implementations.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}