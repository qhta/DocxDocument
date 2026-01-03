namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the title displayed for a chart with positioning and formatting options.
/// </summary>
/// <remarks>
///   This interface defines the title element that appears at the
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
  /// <remarks>
   ///   The position determines where the title appears relative to the chart plot area, such as top, bottom,
  ///   left, or right. Different positions may be more appropriate depending on the chart type, layout
  ///   requirements, and space constraints.
  /// </remarks>
  public SidePos? Pos { get; set; }

  /// <summary>
  ///   Gets or sets the alignment of the chart title within its positioned area.
  /// </summary>
  /// <remarks>
   ///   The alignment controls how the title is positioned within the space allocated for it at the
  ///   specified side position. For example, a top-positioned title can be center-aligned, left-aligned,
  ///   or right-aligned across the width of the chart.
  /// </remarks>
  public PosAlign? Align { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the chart title overlays the plot area.
  /// </summary>
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
  /// <remarks>
  ///   The text content defines what label is displayed for the chart, providing a high-level description
  ///   of the data visualization's purpose and content. This can include plain text or rich text with formatting.
  /// </remarks>
  public Text? Text { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the chart title.
  /// </summary>
  /// <remarks>
  ///   Shape properties control the visual appearance of the title element, including background fill,
  ///   border styling, shadows, and other visual effects that enhance the title's presentation and
  ///   ensure it stands out appropriately within the chart.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for the chart title.
  /// </summary>
  /// <remarks>
  ///   Text properties control the formatting of the title text, including font family, size, color,
  ///   style (bold, italic), alignment, rotation, and spacing. This enables precise control over
  ///   the title's typographic appearance and ensures it maintains visual hierarchy within the chart.
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