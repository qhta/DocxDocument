namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the title displayed for a chart with positioning and formatting options.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines the title element that appears at the
///   top or other designated position of a chart, providing a descriptive label for the entire visualization.
///   The chart title includes comprehensive positioning control (side position and alignment), overlay behavior
///   for space optimization, text content, visual styling through shape properties, text formatting properties,
///   and support for custom extensions. Chart titles help users quickly understand what the chart represents
///   and can be positioned flexibly around the chart area. The title can overlay the plot area to save space
///   or be positioned outside the plot area for clearer separation. Extensive customization options enable
///   the title to match the chart's overall design while maintaining readability and visual hierarchy.
/// </remarks>
public interface ChartTitle : IModelElement
{
  /// <summary>
  ///   Gets or sets the side position where the chart title is displayed.
  /// </summary>
  /// <value>
  ///   A <see cref="SidePos"/> value specifying the title's position relative to the chart,
  ///   or <c>null</c> to use the default position (typically top).
  /// </value>
  /// <remarks>
   ///   The position determines where the title appears relative to the chart plot area, such as top, bottom,
  ///   left, or right. Different positions may be more appropriate depending on the chart type, layout
  ///   requirements, and space constraints.
  /// </remarks>
  public SidePos? Pos { get; set; }

  /// <summary>
  ///   Gets or sets the alignment of the chart title within its positioned area.
  /// </summary>
  /// <value>
  ///   A <see cref="PosAlign"/> value specifying how the title is aligned (e.g., center, left, right),
  ///   or <c>null</c> to use the default alignment.
  /// </value>
  /// <remarks>
   ///   The alignment controls how the title is positioned within the space allocated for it at the
  ///   specified side position. For example, a top-positioned title can be center-aligned, left-aligned,
  ///   or right-aligned across the width of the chart.
  /// </remarks>
  public PosAlign? Align { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the chart title overlays the plot area.
  /// </summary>
  /// <value>
  ///   <c>true</c> if the title overlays the plot area; <c>false</c> if the title is positioned outside
  ///   the plot area; or <c>null</c> to use the default overlay behavior.
  /// </value>
  /// <remarks>
   ///   When overlay is enabled, the title is drawn over the plot area, allowing the plot area to use
  ///   the full available space. This can be useful for maximizing the data visualization area, but
  ///   care must be taken to ensure the title doesn't obscure important data. When overlay is disabled,
  ///   the plot area is sized to accommodate the title outside its boundaries, providing clearer
  ///   separation but reducing the space available for data display.
  /// </remarks>
  public bool? Overlay { get; set; }

  /// <summary>
  ///   Gets or sets the text content displayed as the chart title.
  /// </summary>
  /// <value>
  ///   A <see cref="Text"/> object containing the title text and its properties,
  ///   or <c>null</c> if no title text is specified.
  /// </value>
  /// <remarks>
  ///   The text content defines what label is displayed for the chart, providing a high-level description
  ///   of the data visualization's purpose and content. This can include plain text or rich text with formatting.
  /// </remarks>
  public Text? Text { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the chart title.
  /// </summary>
  /// <value>
  ///   A <see cref="ShapeProperties"/> object defining fill, line, and effect properties,
  ///   or <c>null</c> if default styling is used.
  /// </value>
  /// <remarks>
  ///   Shape properties control the visual appearance of the title element, including background fill,
  ///   border styling, shadows, and other visual effects that enhance the title's presentation and
  ///   ensure it stands out appropriately within the chart.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for the chart title.
  /// </summary>
  /// <value>
  ///   A <see cref="TxPrTextBody"/> object defining font, alignment, and paragraph properties,
  ///   or <c>null</c> if default text formatting is used.
  /// </value>
  /// <remarks>
  ///   Text properties control the formatting of the title text, including font family, size, color,
  ///   style (bold, italic), alignment, rotation, and spacing. This enables precise control over
  ///   the title's typographic appearance and ensures it maintains visual hierarchy within the chart.
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