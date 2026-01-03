namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the mapping between logical color roles and theme color scheme indices for a chart.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines how chart colors are mapped to the
///   document's theme color scheme, ensuring visual consistency between the chart and the overall document design.
///   The color mapping establishes relationships between semantic color roles (such as backgrounds, text colors,
///   accent colors, and hyperlinks) and specific positions in the theme's color scheme. This enables charts to
///   automatically adapt their color palette when the document theme changes, maintaining design coherence without
///   manual color adjustments. The mapping includes primary and secondary background and text colors, six accent
///   colors for data series differentiation, and hyperlink colors for interactive elements. Each mapping property
///   references a <see cref="ColorSchemeIndexKind"/> value that identifies a position in the theme color scheme.
///   This theme-based approach promotes consistent branding and design across documents while allowing flexibility
///   through theme customization. The color mapping is referenced by the <see cref="ChartSpace"/> to apply
///   theme colors throughout the chart's visual elements.
/// </remarks>
public interface ColorMappingType : IModelElement
{
  /// <summary>
  ///   Gets or sets the theme color scheme index for the primary background color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the primary background,
  ///   or <c>null</c> to use the default theme background color.
  /// </value>
  /// <remarks>
  ///   The primary background color is typically used for the main chart background and provides the base
  ///   color layer for the visualization. It should contrast appropriately with text and data elements.
  /// </remarks>
  public ColorSchemeIndexKind? Background1 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the primary text color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for primary text,
  ///   or <c>null</c> to use the default theme text color.
  /// </value>
  /// <remarks>
  ///   The primary text color is used for main labels, titles, and other prominent text elements in the chart.
  ///   It should provide sufficient contrast against the primary background for readability.
  /// </remarks>
  public ColorSchemeIndexKind? Text1 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the secondary background color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the secondary background,
  ///   or <c>null</c> to use the default theme background color.
  /// </value>
  /// <remarks>
  ///   The secondary background color is used for alternate or complementary background areas in the chart,
  ///   such as the plot area background if different from the overall chart background.
  /// </remarks>
  public ColorSchemeIndexKind? Background2 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the secondary text color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for secondary text,
  ///   or <c>null</c> to use the default theme text color.
  /// </value>
  /// <remarks>
  ///   The secondary text color is used for less prominent text elements such as axis labels, legend text,
  ///   or supporting annotations that should be visible but less emphasized than primary text.
  /// </remarks>
  public ColorSchemeIndexKind? Text2 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the first accent color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the first accent,
  ///   or <c>null</c> to use the default theme accent color.
  /// </value>
  /// <remarks>
  ///   Accent 1 is typically used for the first data series or primary data visualization elements.
  ///   The six accent colors enable consistent color differentiation across multiple data series.
  /// </remarks>
  public ColorSchemeIndexKind? Accent1 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the second accent color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the second accent,
  ///   or <c>null</c> to use the default theme accent color.
  /// </value>
  /// <remarks>
  ///   Accent 2 is typically used for the second data series or secondary data visualization elements.
  /// </remarks>
  public ColorSchemeIndexKind? Accent2 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the third accent color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the third accent,
  ///   or <c>null</c> to use the default theme accent color.
  /// </value>
  /// <remarks>
  ///   Accent 3 is typically used for the third data series or tertiary data visualization elements.
  /// </remarks>
  public ColorSchemeIndexKind? Accent3 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the fourth accent color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the fourth accent,
  ///   or <c>null</c> to use the default theme accent color.
  /// </value>
  /// <remarks>
  ///   Accent 4 is typically used for the fourth data series in multi-series charts.
  /// </remarks>
  public ColorSchemeIndexKind? Accent4 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the fifth accent color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the fifth accent,
  ///   or <c>null</c> to use the default theme accent color.
  /// </value>
  /// <remarks>
  ///   Accent 5 is typically used for the fifth data series in multi-series charts.
  /// </remarks>
  public ColorSchemeIndexKind? Accent5 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for the sixth accent color.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for the sixth accent,
  ///   or <c>null</c> to use the default theme accent color.
  /// </value>
  /// <remarks>
  ///   Accent 6 is typically used for the sixth data series in multi-series charts. For charts with more
  ///   than six data series, colors may cycle through the accent colors with variations.
  /// </remarks>
  public ColorSchemeIndexKind? Accent6 { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for hyperlink text.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for hyperlinks,
  ///   or <c>null</c> to use the default theme hyperlink color.
  /// </value>
  /// <remarks>
  ///   The hyperlink color is used for interactive text elements that link to external resources or trigger
  ///   navigation actions within the chart or document.
  /// </remarks>
  public ColorSchemeIndexKind? Hyperlink { get; set; }

  /// <summary>
  ///   Gets or sets the theme color scheme index for followed (visited) hyperlink text.
  /// </summary>
  /// <value>
  ///   A <see cref="ColorSchemeIndexKind"/> value specifying which theme color to use for followed hyperlinks,
  ///   or <c>null</c> to use the default theme followed hyperlink color.
  /// </value>
  /// <remarks>
  ///   The followed hyperlink color is used to visually distinguish hyperlinks that have been previously
  ///   activated, providing users with visual feedback about their navigation history.
  /// </remarks>
  public ColorSchemeIndexKind? FollowedHyperlink { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="Drawings.ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements to the color mapping system without breaking
  ///   compatibility with existing implementations. This could include additional color roles or
  ///   mapping options introduced in future versions.
  /// </remarks>
  public Drawings.ExtensionList? ExtensionList { get; set; }
}