namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a single format override that applies custom formatting to a specific chart element.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines an individual format override that targets
///   a specific chart element identified by its index, applying custom visual styling that takes precedence over
///   default or inherited formatting rules. Format overrides enable selective customization of chart elements such
///   as individual data points, series elements, axis components, or other chart objects without affecting the base
///   formatting definitions that apply to most elements. Each override is associated with a specific element through
///   its zero-based index (<see cref="Idx"/>), and defines custom shape properties (<see cref="ShapeProperties"/>)
///   that supersede the element's default styling. This mechanism is particularly valuable for emphasizing specific
///   chart elements, highlighting outliers or important values, distinguishing exceptional cases, or applying
///   conditional formatting based on data values or business rules. Common scenarios include coloring the highest
///   or lowest data point differently, marking data points that exceed thresholds, applying distinct styling to
///   negative values, or visually separating different data categories within the same series. The format override
///   is part of the <see cref="FormatOverrides"/> collection referenced by <see cref="ChartSpace"/>, providing
///   centralized management of exceptional formatting cases. This architecture separates base formatting (which
///   maintains consistency across most chart elements) from targeted overrides (which handle special cases),
///   promoting maintainable and flexible chart styling where most elements follow standard rules while specific
///   elements receive custom treatment. Extension support enables future enhancements to format override capabilities.
///   This functionality is available in Office 2016 and later versions for the index property.
/// </remarks>
public interface FormatOverride : IModelElement
{
  /// <summary>
  ///   Gets or sets the zero-based index identifying which chart element this format override applies to.
  /// </summary>
  /// <value>
  ///   An unsigned 32-bit integer representing the element's position or identifier,
  ///   or <c>null</c> if no index is specified.
  /// </value>
  /// <remarks>
  ///   This property is only available in Office 2016 and later.
  ///   The index identifies the target chart element for this format override, using zero-based positioning where
  ///   0 represents the first element, 1 the second, and so on. The interpretation of the index depends on the
  ///   context in which the format override is used. For example, when overriding data point formatting, the index
  ///   corresponds to the data point's position within its series (similar to <see cref="DataPoint.Idx"/>); when
  ///   overriding series formatting, it identifies which series in the chart; or when targeting other chart elements,
  ///   it specifies the element's sequential position. This index-based approach enables precise targeting of
  ///   specific elements for custom formatting, allowing selective emphasis or distinction of particular chart
  ///   components without requiring complete redefinition of the entire chart's formatting structure.
  /// </remarks>
  public UInt32? Idx { get; set; }

  /// <summary>
  ///   Gets or sets the custom visual styling properties that override the element's default formatting.
  /// </summary>
  /// <value>
  ///   A <see cref="ShapeProperties"/> object defining fill, line, and effect properties,
  ///   or <c>null</c> if no custom formatting is applied.
  /// </value>
  /// <remarks>
  ///   Shape properties define the custom visual styling that supersedes the target element's default or inherited
  ///   formatting. This enables precise control over the element's appearance through custom colors, patterns, borders,
  ///   shadows, gradients, or other visual effects. The shape properties specified here take precedence over any
  ///   default formatting rules, allowing the targeted element to stand out visually from other elements that maintain
  ///   standard styling. Common customizations include applying a different fill color to highlight maximum or minimum
  ///   values, using contrasting borders to emphasize data points that meet specific criteria, adding special effects
  ///   (such as glow or shadows) to draw attention to important elements, or using distinct patterns to indicate
  ///   different data states or categories. When shape properties are specified, they completely override the element's
  ///   default styling for the properties defined; any properties not specified in the override continue to use the
  ///   default formatting. This selective override mechanism provides flexibility to customize only the specific
  ///   visual aspects that need to change while inheriting other formatting attributes from the default style.
  /// </remarks>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Gets or sets the collection of extension elements for future extensibility.
  /// </summary>
  /// <value>
  ///   An <see cref="ExtensionList"/> containing extension elements,
  ///   or <c>null</c> if no extensions are defined.
  /// </value>
  /// <remarks>
  ///   Extension elements allow for future enhancements to format override functionality without breaking
  ///   compatibility with existing implementations. This could include additional formatting options, conditional
  ///   formatting rules, animation effects, or interactive behaviors introduced in future Office versions. The
  ///   extension mechanism ensures that documents with enhanced format override features remain functional in
  ///   older applications while enabling full feature support when opened in capable applications.
  /// </remarks>
  public ExtensionList? ExtensionList { get; set; }
}