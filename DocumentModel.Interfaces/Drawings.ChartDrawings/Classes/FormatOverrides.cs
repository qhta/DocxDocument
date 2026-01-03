namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a collection of format overrides that customize specific formatting aspects of chart elements.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a container for format override elements that
///   allow selective modification of chart formatting without affecting the base formatting definitions. Format
///   overrides provide a mechanism to apply specific formatting customizations to individual chart elements (such as
///   data points, series, axes, or other components) that take precedence over default or inherited formatting rules.
///   This override system enables fine-grained control over chart appearance, allowing specific elements to be
///   visually distinguished or emphasized while maintaining consistent base formatting for the majority of chart
///   components. Common use cases include highlighting specific data points with different colors, applying custom
///   formatting to outlier values, distinguishing specific series with unique styling, or emphasizing particular
///   chart elements to draw user attention. Each <see cref="FormatOverride"/> in the collection defines a specific
///   formatting customization that supersedes default formatting when applied to its target element. The override
///   mechanism is particularly valuable in scenarios where charts need to dynamically adjust formatting based on data
///   values, conditions, or user interactions without requiring complete reformatting of the entire chart. Format
///   overrides are referenced by the <see cref="ChartSpace"/> and can be applied throughout the chart structure,
///   providing a centralized location for managing exceptional formatting cases while keeping standard formatting
///   definitions clean and maintainable. This separation of base formatting and overrides promotes efficient chart
///   styling where most elements follow consistent rules while specific elements receive targeted customization.
/// </remarks>
public interface FormatOverrides : IModelElement
{
  /// <summary>
  ///   Gets or sets the collection of individual format override definitions.
  /// </summary>
  /// <value>
  ///   A collection of <see cref="FormatOverride"/> objects defining specific formatting customizations,
  ///   or <c>null</c> if no format overrides are defined.
  /// </value>
  /// <remarks>
  ///   Each <see cref="FormatOverride"/> in the collection specifies a formatting customization that applies to
  ///   a particular chart element or set of elements. The overrides take precedence over default formatting,
  ///   enabling selective styling of specific components without affecting the overall chart formatting scheme.
  ///   Multiple overrides can be defined to target different elements or apply different formatting aspects
  ///   (such as fill, line style, effects, or text properties) to the same or different chart components. The
  ///   collection-based structure allows overrides to be easily added, modified, or removed as chart formatting
  ///   requirements change, providing flexibility in managing exceptional formatting cases while maintaining
  ///   the base formatting structure.
  /// </remarks>
  public Collection<FormatOverride>? Items { get; set; }
}