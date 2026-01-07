namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the legend that identifies data series and categories in a chart visualization.
/// </summary>
/// <remarks>
///   This interface defines the legend element that provides a key for
///   interpreting chart data by displaying series names, category labels, and their associated visual indicators
///   (such as colors, patterns, or symbols). The legend helps users understand which visual elements correspond to
///   which data series or categories in the chart, making multi-series or categorized data visualizations interpretable.
///   The legend includes comprehensive positioning control through side position (<see cref="Pos"/>) and alignment
///   (<see cref="Align"/>) properties, overlay behavior for space optimization (<see cref="Overlay"/>), visual styling
///   through shape properties (<see cref="ShapeProperties"/>), text formatting properties (<see cref="TxPrTextBody"/>),
///   and support for custom extensions (<see cref="ExtensionList"/>). Legends typically display a list of entries where
///   each entry shows a visual marker (colored box, line style, or symbol) alongside the corresponding series or category
///   name. The legend can be positioned at various locations around the chart (top, bottom, left, right) with flexible
///   alignment options (center, near, far) to accommodate different chart layouts and data visualization needs. The
///   overlay option enables space-efficient charts where the legend is drawn over the plot area rather than reducing
///   the plot area size, useful when maximizing data visualization space is a priority. Legend positioning and styling
///   significantly impact chart readability and should be chosen based on the number of series, chart type, and available
///   space. The legend is an optional but commonly used component of <see cref="Chart"/>, helping users interpret complex
///   multi-series visualizations, compare data across categories, and understand the meaning of different visual encodings
///   (colors, patterns, symbols) used throughout the chart.
/// </remarks>
public interface Legend
{
  /// <summary>
  ///   Gets or sets the side position where the legend is displayed relative to the chart.
  /// </summary>
  /// <remarks>
  ///   The position determines where the legend appears relative to the chart plot area. Common positions include
  ///   right (most common, placing the legend beside the chart), bottom (useful for horizontal charts or when vertical
  ///   space is limited), top (sometimes used for emphasis or specific layouts), and left (less common but available).
  ///   The chosen position affects how the plot area is sized (unless <see cref="Overlay"/> is enabled) and influences
  ///   the overall chart layout. Right-side legends are traditional and work well for most chart types. Bottom legends
  ///   are effective when horizontal space is abundant but vertical space is limited, or for charts with horizontal
  ///   orientation. The position should be chosen based on the chart type, number of legend entries, available space,
  ///   and visual design requirements.
  /// </remarks>
  public SidePos? Pos { get; set; }

  /// <summary>
  ///   Gets or sets the alignment of the legend within its positioned area.
  /// </summary>
  /// <remarks>
  ///   The alignment controls how the legend is positioned within the space allocated at the specified side position.
  ///   For example, a right-positioned legend can be center-aligned (vertically centered), near-aligned (top-aligned),
  ///   or far-aligned (bottom-aligned) along the right edge. Similarly, a bottom-positioned legend can be center-aligned
  ///   (horizontally centered), near-aligned (left-aligned), or far-aligned (right-aligned) along the bottom edge.
  ///   Alignment provides fine-grained control over legend placement, enabling precise positioning that complements
  ///   the chart design and maximizes space utilization.
  /// </remarks>
  public PosAlign? Align { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the legend overlays the plot area.
  /// </summary>
  /// <remarks>
  ///   When overlay is enabled, the legend is drawn over the plot area, allowing the plot area to use the full available
  ///   space without being reduced to accommodate the legend. This maximizes the data visualization area but requires
  ///   careful positioning to ensure the legend doesn't obscure important data. Overlay mode is useful when space is
  ///   at a premium or when the legend can be positioned in an area of the chart with minimal data density. When overlay
  ///   is disabled (the default), the plot area is sized to accommodate the legend outside its boundaries, providing
  ///   clear separation between legend and data but reducing the space available for data display. The choice between
  ///   overlay and non-overlay depends on the specific chart, data density, legend size, and whether maximizing data
  ///   visualization space or maintaining clear visual separation is more important.
  /// </remarks>
  public bool? Overlay { get; set; }

  /// <summary>
  ///   Gets or sets the visual styling properties for the legend.
  /// </summary>
  /// <remarks>
  ///   Shape properties control the visual appearance of the legend container, including background fill, border
  ///   styling, shadows, and other visual effects. These properties enable customization of the legend's visual
  ///   presentation to match the chart's overall design, provide visual emphasis, or ensure readability against
  ///   various backgrounds. Common styling includes adding a subtle background fill with borders to distinguish
  ///   the legend from the chart background, or applying effects for visual interest. Appropriate styling enhances
  ///   legend visibility and integration with the overall chart design.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the text formatting properties for legend text.
  /// </summary>
  /// <remarks>
  ///   Text properties control the formatting of legend entry text, including font family, size, color, style
  ///   (bold, italic), alignment, and spacing. These properties ensure legend text is readable, visually consistent
  ///   with the chart, and properly formatted for the available space. Legend text formatting is particularly important
  ///   when the legend contains many entries or long series names, where appropriate font sizing and spacing ensure
  ///   all entries remain readable without excessive legend size. The text formatting can be customized to match the
  ///   chart's typography, provide emphasis for specific aspects, or ensure readability in different display contexts.
  /// </remarks>
  public TxPrTextBody? TxPrTextBody { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <remarks>
  ///   Extension elements allow for future enhancements to legend functionality without breaking compatibility
  ///   with existing implementations. This could include additional layout options, interactive features, custom
  ///   entry formatting, or advanced legend types introduced in future versions.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}