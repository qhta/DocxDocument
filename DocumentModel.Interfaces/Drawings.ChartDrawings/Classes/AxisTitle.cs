namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the title displayed for a chart axis.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the title element that labels
///   a chart axis, providing context and meaning to the data represented along that axis. The axis
///   title includes the text content, visual styling properties through shape properties, text formatting
///   properties, and support for custom extensions. Axis titles help users understand what data dimension
///   is represented on each axis (e.g., "Sales Revenue", "Year", "Temperature"). The title can be
///   extensively customized in terms of appearance, positioning, and text formatting to match the
///   chart's overall design and ensure readability.
/// </remarks>
public interface AxisTitle : IModelElement
{
  /// <summary>
  ///   Gets or sets the text content displayed as the axis title.
  /// </summary>
  /// <value>
  ///   A <see cref="Text"/> object containing the title text and its properties,
  ///   or <c>null</c> if no title text is specified.
  /// </value>
  /// <remarks>
  ///   The text content defines what label is displayed for the axis, providing semantic meaning
  ///   to the axis values. This can include plain text or rich text with formatting.
  /// </remarks>
  public Text? Text { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the axis title.
  /// </summary>
  /// <value>
  ///   A <see cref="ShapeProperties"/> object defining fill, line, and effect properties,
  ///   or <c>null</c> if default styling is used.
  /// </value>
  /// <remarks>
  ///   Shape properties control the visual appearance of the title element, including background fill,
  ///   border styling, shadows, and other visual effects that enhance the title's presentation.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for the axis title.
  /// </summary>
  /// <value>
  ///   A <see cref="TxPrTextBody"/> object defining font, alignment, and paragraph properties,
  ///   or <c>null</c> if default text formatting is used.
  /// </value>
  /// <remarks>
  ///   Text properties control the formatting of the title text, including font family, size, color,
  ///   style (bold, italic), alignment, rotation, and spacing. This enables precise control over
  ///   the title's typographic appearance.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements and custom properties without breaking
  ///   compatibility with existing implementations.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}